using AdonaiUtil.Utils;
using MySql.Data.MySqlClient;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoUtilCode
{
    class UtilConnections
    {
        
        public IDbConnection NewInstance(UtilModels obj)
        {
            if (obj.TipoBanco == 0)
            {
                NpgsqlConnection con = new NpgsqlConnection("Host=" + obj.HostInstancia + ";Username=" + obj.Usuario + ";Password=" + obj.Senha + ";Database=" + obj.NomeBanco);

                try
                {
                    con.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                return con;
            }
            if (obj.TipoBanco == 1)
            {
                SqlConnection cnn = new SqlConnection("Data Source=" + obj.HostInstancia + ";Initial Catalog=" + obj.NomeBanco + ";User=sa;Password=" + obj.Senha);

                try
                {
                    cnn.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                return cnn;
            }
            if (obj.TipoBanco == 2)
            {
                MySqlConnection con = new MySqlConnection("Server=" + obj.HostInstancia + ";Database=" + obj.NomeBanco + ";Uid=" + obj.Usuario + ";Pwd=" + obj.Senha);

                try
                {
                    con.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                return con;
            }
            else
            {
                return null;
            }
            
        }

        public UtilModels AddAtributes(UtilModels obj)
        {
            IDbConnection con = NewInstance(obj);
            IDbCommand command = null;
            IDataReader dr = null;

            String sql = "SELECT column_name as tabela, data_type as tipo FROM information_schema.columns WHERE table_name = '" + obj.Tabela + "' and COLUMN_NAME <> 'Guid'";

            command = con.CreateCommand();
            command.CommandText = sql;

            dr = command.ExecuteReader();

            while (dr.Read())
            {
                String type = dr.GetString(dr.GetOrdinal("tipo"));
                String name = dr.GetString(dr.GetOrdinal("tabela"));
                String tipo = "";

                if (type.Equals("int") || type.Equals("smallint") || type.Equals("integer"))
                {
                    if(obj.Linguagem == 0)
                    {
                        tipo = "int";
                    }
                    else
                    {
                        tipo = "Int32";
                    }
                    
                }
                else if (type.Equals("varchar"))
                {
                    tipo = "String";
                }
                else if (type.Equals("character varying") || type.Equals("longtext"))
                {
                    tipo = "String";
                }
                else if (type.Equals("datetime"))
                {
                    if (obj.Linguagem == 0)
                    {
                        tipo = "TImeStamp";
                    }
                    else
                    {
                        tipo = "DateTime";
                    }
                    
                }
                else if (type.Equals("date"))
                {
                    if (obj.Linguagem == 0)
                    {
                        tipo = "Date";
                    }
                    else
                    {
                        tipo = "DateTime";
                    }

                }
                else if (type.Equals("tinyint"))
                {
                    tipo = "Byte";
                }
                else if (type.Equals("decimal"))
                {
                    tipo = "Decimal";
                }
                else if (type.Equals("varbinary"))
                {
                    tipo = "String";
                }
                else if (type.Equals("nvarchar"))
                {
                    tipo = "String";
                }
                else
                {
                    type = "PADRÂO NÂO ENCONTRADO";
                }

                obj.atributes.Add(name, tipo);
            }
            command.Dispose();
            dr.Close();

            return obj;

        }
    }
}
