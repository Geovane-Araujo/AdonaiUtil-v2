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


        public JavaScriptController(UtilModels obj)
        {
            this.atributes = obj.atributes;
            TipoBanco = obj.TipoBanco;
            HostInstancia = obj.HostInstancia;
            NomeBanco = obj.NomeBanco;
            Senha = obj.Senha;
            Usuario = obj.Usuario;
            ClasseConexao = obj.ClasseConexao;
            RotaApi = obj.RotaApi;
            NameSpace = obj.NameSpace;
            Linguagem = obj.Linguagem;
            Tabela = obj.Tabela;
            NomeClasse = obj.NomeClasse;
            GeraGetById = obj.GeraGetById;
            GeraSave = obj.GeraSave;
            Model = obj.Model;
            Controller = obj.Controller;
            Resource = obj.Resource;
            MetodoManual = obj.MetodoManual;
            UsaFramework = obj.UsaFramework;
            UsaToken = obj.UsaToken;
            GeraCabecalho = obj.GeraCabecalho;
        }

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
                propriedades += "  "+en.Key+": '',\n";
            }

            if (GeraCabecalho)
            {
                code = "form: {\n" +
                   "" + propriedades +
                   "}\n";
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
