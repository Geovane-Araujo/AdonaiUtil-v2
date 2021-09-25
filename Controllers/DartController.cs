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
    class DartController : UtilModels
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
    }
}
