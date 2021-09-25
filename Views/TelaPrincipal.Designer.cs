
namespace DoUtilCode
{
    partial class TelaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.principal = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.che_geracabecalho = new System.Windows.Forms.CheckBox();
            this.che_token = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.che_resource = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cb_linguagem = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Connections = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_namespace = new System.Windows.Forms.TextBox();
            this.che_atom = new System.Windows.Forms.CheckBox();
            this.che_normal = new System.Windows.Forms.CheckBox();
            this.che_controller = new System.Windows.Forms.CheckBox();
            this.che_model = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_class = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_tables = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_routeApi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_banco = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.txt_instance = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_dbName = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.principal.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // principal
            // 
            this.principal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.principal.Controls.Add(this.tabPage1);
            this.principal.Controls.Add(this.tabPage2);
            this.principal.Controls.Add(this.tabPage3);
            this.principal.Controls.Add(this.tabPage4);
            this.principal.Location = new System.Drawing.Point(3, 0);
            this.principal.Name = "principal";
            this.principal.SelectedIndex = 0;
            this.principal.Size = new System.Drawing.Size(747, 527);
            this.principal.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.che_geracabecalho);
            this.tabPage1.Controls.Add(this.che_token);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.che_resource);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.cb_linguagem);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txt_Connections);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txt_namespace);
            this.tabPage1.Controls.Add(this.che_atom);
            this.tabPage1.Controls.Add(this.che_normal);
            this.tabPage1.Controls.Add(this.che_controller);
            this.tabPage1.Controls.Add(this.che_model);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txt_class);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txt_tables);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txt_routeApi);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(739, 499);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Gerador de Código";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // che_geracabecalho
            // 
            this.che_geracabecalho.AutoSize = true;
            this.che_geracabecalho.Checked = true;
            this.che_geracabecalho.CheckState = System.Windows.Forms.CheckState.Checked;
            this.che_geracabecalho.Location = new System.Drawing.Point(544, 368);
            this.che_geracabecalho.Name = "che_geracabecalho";
            this.che_geracabecalho.Size = new System.Drawing.Size(161, 19);
            this.che_geracabecalho.TabIndex = 71;
            this.che_geracabecalho.Text = "Gera Cabeçalho da Classe";
            this.che_geracabecalho.UseVisualStyleBackColor = true;
            // 
            // che_token
            // 
            this.che_token.AutoSize = true;
            this.che_token.Checked = true;
            this.che_token.CheckState = System.Windows.Forms.CheckState.Checked;
            this.che_token.Location = new System.Drawing.Point(544, 326);
            this.che_token.Name = "che_token";
            this.che_token.Size = new System.Drawing.Size(79, 19);
            this.che_token.TabIndex = 70;
            this.che_token.Text = "Usa Token";
            this.che_token.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(544, 221);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 15);
            this.label13.TabIndex = 69;
            this.label13.Text = "Outros";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 221);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 15);
            this.label12.TabIndex = 68;
            this.label12.Text = "Recursos";
            // 
            // che_resource
            // 
            this.che_resource.AutoSize = true;
            this.che_resource.Checked = true;
            this.che_resource.CheckState = System.Windows.Forms.CheckState.Checked;
            this.che_resource.Location = new System.Drawing.Point(13, 323);
            this.che_resource.Name = "che_resource";
            this.che_resource.Size = new System.Drawing.Size(74, 19);
            this.che_resource.TabIndex = 66;
            this.che_resource.Text = "Resource";
            this.che_resource.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(397, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 15);
            this.label11.TabIndex = 65;
            this.label11.Text = "Linguagem";
            // 
            // cb_linguagem
            // 
            this.cb_linguagem.FormattingEnabled = true;
            this.cb_linguagem.Items.AddRange(new object[] {
            "Java",
            "C#",
            "Python",
            "JavaScript",
            "Dart"});
            this.cb_linguagem.Location = new System.Drawing.Point(397, 40);
            this.cb_linguagem.Name = "cb_linguagem";
            this.cb_linguagem.Size = new System.Drawing.Size(335, 23);
            this.cb_linguagem.TabIndex = 64;
            this.cb_linguagem.Text = "Java";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 15);
            this.label7.TabIndex = 63;
            this.label7.Text = "Classe Padrão de Conexão";
            // 
            // txt_Connections
            // 
            this.txt_Connections.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Connections.Location = new System.Drawing.Point(8, 40);
            this.txt_Connections.Name = "txt_Connections";
            this.txt_Connections.Size = new System.Drawing.Size(334, 23);
            this.txt_Connections.TabIndex = 62;
            this.txt_Connections.Text = "AdonaiConnections";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 15);
            this.label8.TabIndex = 53;
            this.label8.Text = "NameSpace/Pacote";
            // 
            // txt_namespace
            // 
            this.txt_namespace.Location = new System.Drawing.Point(8, 152);
            this.txt_namespace.Name = "txt_namespace";
            this.txt_namespace.Size = new System.Drawing.Size(334, 23);
            this.txt_namespace.TabIndex = 52;
            // 
            // che_atom
            // 
            this.che_atom.AutoSize = true;
            this.che_atom.Checked = true;
            this.che_atom.CheckState = System.Windows.Forms.CheckState.Checked;
            this.che_atom.Location = new System.Drawing.Point(544, 287);
            this.che_atom.Name = "che_atom";
            this.che_atom.Size = new System.Drawing.Size(118, 19);
            this.che_atom.TabIndex = 49;
            this.che_atom.Text = "Atom Framework";
            this.che_atom.UseVisualStyleBackColor = true;
            // 
            // che_normal
            // 
            this.che_normal.AutoSize = true;
            this.che_normal.Location = new System.Drawing.Point(544, 251);
            this.che_normal.Name = "che_normal";
            this.che_normal.Size = new System.Drawing.Size(66, 19);
            this.che_normal.TabIndex = 48;
            this.che_normal.Text = "Normal";
            this.che_normal.UseVisualStyleBackColor = true;
            // 
            // che_controller
            // 
            this.che_controller.AutoSize = true;
            this.che_controller.Checked = true;
            this.che_controller.CheckState = System.Windows.Forms.CheckState.Checked;
            this.che_controller.Location = new System.Drawing.Point(13, 286);
            this.che_controller.Name = "che_controller";
            this.che_controller.Size = new System.Drawing.Size(79, 19);
            this.che_controller.TabIndex = 47;
            this.che_controller.Text = "Controller";
            this.che_controller.UseVisualStyleBackColor = true;
            // 
            // che_model
            // 
            this.che_model.AutoSize = true;
            this.che_model.Checked = true;
            this.che_model.CheckState = System.Windows.Forms.CheckState.Checked;
            this.che_model.Location = new System.Drawing.Point(13, 250);
            this.che_model.Name = "che_model";
            this.che_model.Size = new System.Drawing.Size(60, 19);
            this.che_model.TabIndex = 46;
            this.che_model.Text = "Model";
            this.che_model.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(399, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(234, 15);
            this.label6.TabIndex = 45;
            this.label6.Text = "Class Name(if is empty default table name)";
            // 
            // txt_class
            // 
            this.txt_class.Location = new System.Drawing.Point(397, 152);
            this.txt_class.Name = "txt_class";
            this.txt_class.Size = new System.Drawing.Size(336, 23);
            this.txt_class.TabIndex = 44;
            this.txt_class.Text = "Pessoa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(399, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 43;
            this.label5.Text = "Table";
            // 
            // txt_tables
            // 
            this.txt_tables.Location = new System.Drawing.Point(397, 101);
            this.txt_tables.Name = "txt_tables";
            this.txt_tables.Size = new System.Drawing.Size(336, 23);
            this.txt_tables.TabIndex = 42;
            this.txt_tables.Text = "pessoa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 34;
            this.label3.Text = "Route Api";
            // 
            // txt_routeApi
            // 
            this.txt_routeApi.Location = new System.Drawing.Point(8, 101);
            this.txt_routeApi.Name = "txt_routeApi";
            this.txt_routeApi.Size = new System.Drawing.Size(334, 23);
            this.txt_routeApi.TabIndex = 33;
            this.txt_routeApi.Text = "adonai";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(657, 476);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Gerar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(739, 499);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SQL";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.txt_usuario);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.cb_banco);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.txt_senha);
            this.tabPage3.Controls.Add(this.txt_instance);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.txt_dbName);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(739, 499);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Conexão";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 74);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 15);
            this.label14.TabIndex = 69;
            this.label14.Text = "Usuário";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_usuario.Location = new System.Drawing.Point(3, 92);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(334, 23);
            this.txt_usuario.TabIndex = 68;
            this.txt_usuario.Text = "postgres";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 15);
            this.label10.TabIndex = 65;
            this.label10.Text = "Banco de Dados";
            // 
            // cb_banco
            // 
            this.cb_banco.FormattingEnabled = true;
            this.cb_banco.Items.AddRange(new object[] {
            "Postgres",
            "Sql Server",
            "MySql"});
            this.cb_banco.Location = new System.Drawing.Point(3, 37);
            this.cb_banco.Name = "cb_banco";
            this.cb_banco.Size = new System.Drawing.Size(334, 23);
            this.cb_banco.TabIndex = 64;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(390, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 15);
            this.label9.TabIndex = 63;
            this.label9.Text = "Password";
            // 
            // txt_senha
            // 
            this.txt_senha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_senha.Location = new System.Drawing.Point(390, 92);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(343, 23);
            this.txt_senha.TabIndex = 62;
            this.txt_senha.Text = "1816";
            // 
            // txt_instance
            // 
            this.txt_instance.Location = new System.Drawing.Point(390, 37);
            this.txt_instance.Name = "txt_instance";
            this.txt_instance.Size = new System.Drawing.Size(343, 23);
            this.txt_instance.TabIndex = 56;
            this.txt_instance.Text = "localhost";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 59;
            this.label2.Text = "Nome Banco";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(390, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 57;
            this.label1.Text = "Instancia/Host";
            // 
            // txt_dbName
            // 
            this.txt_dbName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_dbName.Location = new System.Drawing.Point(3, 153);
            this.txt_dbName.Name = "txt_dbName";
            this.txt_dbName.Size = new System.Drawing.Size(334, 23);
            this.txt_dbName.TabIndex = 58;
            this.txt_dbName.Text = "adonai";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button4);
            this.tabPage4.Controls.Add(this.button3);
            this.tabPage4.Controls.Add(this.button2);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(739, 499);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Uteis";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 23);
            this.button2.TabIndex = 29;
            this.button2.Text = "PyAtom";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 59);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 23);
            this.button3.TabIndex = 30;
            this.button3.Text = "Java Token Function";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 88);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(141, 23);
            this.button4.TabIndex = 31;
            this.button4.Text = "Classe de Conexão Java";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 530);
            this.Controls.Add(this.principal);
            this.MaximizeBox = false;
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adonai Util";
            this.principal.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl principal;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_namespace;
        private System.Windows.Forms.CheckBox che_atom;
        private System.Windows.Forms.CheckBox che_normal;
        private System.Windows.Forms.CheckBox che_controller;
        private System.Windows.Forms.CheckBox che_model;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_class;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_tables;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_routeApi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cb_banco;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.TextBox txt_instance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_dbName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cb_linguagem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Connections;
        private System.Windows.Forms.CheckBox che_token;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox che_resource;
        private System.Windows.Forms.CheckBox che_geracabecalho;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
    }
}

