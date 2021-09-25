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
    class UtilConnections : UtilModels
    {
        
        public IDbConnection NewInstance(String Instance,String db, String senha)
        {
            if (TipoBanco == 0)
            {
                NpgsqlConnection con = new NpgsqlConnection("Host=" + HostInstancia + ";Username=" + Usuario + ";Password=" + Senha+ ";Database=" + NomeBanco);

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
            if (TipoBanco == 1)
            {
                SqlConnection cnn = new SqlConnection("Data Source=" + Instance + ";Initial Catalog=" + db + ";User=sa;Password=" + senha);

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
            if (TipoBanco == 2)
            {
                MySqlConnection con = new MySqlConnection("Server=" + HostInstancia + ";Database=" + NomeBanco + ";Uid=" + Usuario + ";Pwd=" + Senha);

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

        public void AddAtributes()
        {
            IDbConnection con = NewInstance(HostInstancia, NomeBanco, Senha);
            IDbCommand command = null;
            IDataReader dr = null;

            String sql = "SELECT column_name as tabela, data_type as tipo FROM information_schema.columns WHERE table_name = '" + Tabela + "' and COLUMN_NAME <> 'Guid'";

            command = con.CreateCommand();
            command.CommandText = sql;

            dr = command.ExecuteReader();

            while (dr.Read())
            {
                String type = dr.GetString(dr.GetOrdinal("tipo"));
                String name = dr.GetString(dr.GetOrdinal("tabela"));
                String tipo = "";

                if (type.Equals("int") || type.Equals("smallint"))
                {
                    if(Linguagem == 0)
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
                else if (type.Equals("character varying"))
                {
                    tipo = "String";
                }
                else if (type.Equals("datetime"))
                {
                    if (Linguagem == 0)
                    {
                        tipo = "TImeStamp";
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

                atributes.Add(name, tipo);
            }
            command.Dispose();
            dr.Close();

        }
    }
}
