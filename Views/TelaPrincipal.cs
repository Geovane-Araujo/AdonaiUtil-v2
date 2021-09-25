using AdonaiUtil.Controllers;
using AdonaiUtil.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoUtilCode
{
    public partial class TelaPrincipal : Form
    {
        Hashtable atributes = new();
        Hashtable atributesOriginals = new();
        UtilConnections utilConnections = new();
        SqlConnection con = null;

        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_instance_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            JavaController jvController = new();
            CSharpController cSharpController = new();
            JavaScriptController jsController = new();
            PythonController pyController = new();
            DartController dtController = new();

            UtilConnections uta= new();
            uta.AddAtributes();

            UtilModels ut = new();

            ut.NomeClasse = txt_Connections.Text;
            ut.Linguagem = cb_linguagem.SelectedIndex;
            ut.RotaApi = txt_routeApi.Text;
            ut.Tabela = txt_tables.Text;
            ut.NameSpace = txt_namespace.Text;
            ut.NomeClasse = txt_class.Text;
            ut.GeraGetById = che_getdata.Checked;
            ut.GeraSave = che_saveData.Checked;
            ut.Model = che_model.Checked;
            ut.Controller = che_controller.Checked;
            ut.Resource = che_resource.Checked;
            ut.MetodoManual = che_normal.Checked;
            ut.UsaFramework = che_atom.Checked;
            ut.UsaToken = che_token.Checked;
            ut.GeraCabecalho = che_geracabecalho.Checked;
            ut.TipoBanco = cb_banco.SelectedIndex;
            ut.HostInstancia = txt_instance.Text;
            ut.Senha = txt_senha.Text;
            ut.NomeBanco = txt_dbName.Text;


            if (ut.Linguagem == 0)
                jvController.InitOperation();
            if (ut.Linguagem == 1)
                cSharpController.InitOperation();
            if (ut.Linguagem == 2)
                pyController.InitOperation();
            if (ut.Linguagem == 3)
                jsController.InitOperation();
            if (ut.Linguagem == 4)
                dtController.InitOperation();

        }
    }
}
