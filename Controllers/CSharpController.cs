using AdonaiUtil.Utils;
using DoUtilCode;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdonaiUtil.Controllers
{
    class CSharpController : UtilModels
    {

        public void InitOperation()
        {
            if (Model)
                GenerateModel();
            if (Controller)
                GenerateController();
            if (Resource)
                GenerateResource();
        }

        public void GenerateModel()
        {
            String code = "";
            String propriedades = "";

            foreach (DictionaryEntry en in atributes)
            {
            }

            if (GeraCabecalho)
            {
            }
            else
            {
                code = propriedades;
            }

            Result rs = new(code);
            rs.Show();
        }
        public void GenerateController()
        {
            String code = "";
            String propriedades = "";
            if (GeraCabecalho)
            {
            }
            else
            {
                code = propriedades;
            }
        }
        public void GenerateResource()
        {
            String code = "";
            String propriedades = "";
            if (GeraCabecalho)
            {
            }
            else
            {
                code = propriedades;
            }
        }


        private string MontSql(int type)
        {
            String sql = "";
            String variable = "";
            String reference = "";

            if (type == 0)
            {

                foreach (DictionaryEntry en in atributes)
                {
                    variable += en.Key + ",";
                    reference += "@" + en.Key + ",";
                }
                variable = variable.Substring(0, variable.Length - 1);
                reference = reference.Substring(0, reference.Length - 1);

                sql = "INSERT INTO " + Tabela + " (" + variable + ") values(" + reference + ");";
            }
            else if (type == 1)
            {

                foreach (DictionaryEntry en in atributes)
                {
                    if (en.Key.Equals("ID"))
                    {
                        reference = " WHERE ID=@ID";
                    }
                    else
                    {
                        variable += en.Key + "=@" + en.Key + ",";
                    }

                }
                variable = variable.Substring(0, variable.Length - 1);

                sql = "UPDATE " + Tabela + " SET " + variable + " " + reference + ";";
            }


            return sql;
        }
    }
}
