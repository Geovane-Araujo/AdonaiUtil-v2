using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdonaiUtil.Utils
{
    class UtilModels
    {

        public Hashtable atributes { get; set; } = new();
        public Hashtable atributesOriginals { get; set; } = new();

        //Dados de Conexão com o banco
        public int TipoBanco { get; set; }
        public string HostInstancia { get; set; }
        public string NomeBanco { get; set; }
        public string Senha { get; set; }
        public bool Usuario { get; set; }



        //Aqui pega os dados para a geração dos codigos
        public string ClasseConexao { get; set; }
        public string RotaApi { get; set; }
        public string NameSpace { get; set; }
        public int Linguagem { get; set; }
        public string Tabela { get; set; }
        public string NomeClasse { get; set; }



        //Aqui pega os dados dos parametros
        public bool GeraGetById { get; set; }
        public bool GeraSave { get; set; }
        public bool Model { get; set; }
        public bool Controller { get; set; }
        public bool Resource { get; set; }

        public bool MetodoManual { get; set; }
        public bool UsaFramework { get; set; }

        public bool UsaToken { get; set; }

        public bool GeraCabecalho { get; set; }

        public UtilModels()
        {
        }
    }
}
