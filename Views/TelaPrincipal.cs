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
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {            
           

            UtilModels ut = new();

            ut.NomeClasse = txt_class.Text;
            ut.Linguagem = cb_linguagem.SelectedIndex;
            ut.RotaApi = txt_routeApi.Text;
            ut.Tabela = txt_tables.Text;
            ut.NameSpace = txt_namespace.Text;
            ut.NomeClasse = txt_class.Text;
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
            ut.Usuario = txt_usuario.Text;
            ut.ClasseConexao = txt_Connections.Text;


            UtilConnections uta = new();
            ut = uta.AddAtributes(ut);


            if (ut.Linguagem == 0)
            {
                JavaController jvController = new(ut);
                jvController.InitOperation();
            }
                
            if (ut.Linguagem == 1)
            {
                CSharpController cSharpController = new(ut);
                cSharpController.InitOperation();
            }
                
            if (ut.Linguagem == 2)
            {
                PythonController pyController = new(ut);
                pyController.InitOperation();
            }
               
            if (ut.Linguagem == 3)
            {
                JavaScriptController jsController = new(ut);
                jsController.InitOperation();
            }
                
            if (ut.Linguagem == 4)
            {
                 DartController dtController = new();
                dtController.InitOperation();
            }
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PythonController.GeneratePyAtom();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            JavaController.GenerateFunctionToken();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            JavaController.GenerateClassConnection(cb_banco.SelectedIndex);
        }
    }
}
