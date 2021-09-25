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
    class JavaScriptController : UtilModels
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
                propriedades += en.Key+": ''\n";
            }

            if (GeraCabecalho)
            {
                code = "form: {" +
                   "  " + propriedades +
                   "}";
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

        }
        public void GenerateResource()
        {

        }
    }
}
