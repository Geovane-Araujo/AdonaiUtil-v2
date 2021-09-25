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
    class PythonController : UtilModels
    {

        public PythonController(UtilModels obj)
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
            String propriedadesElse = "";

            propriedades =  "            self.add = obj.get(\"add\")\n" +
                            "            self.edit = obj.get(\"edit\")\n" +
                            "            self.dele = obj.get(\"del\")\n";

            propriedadesElse = propriedades;

            foreach (DictionaryEntry en in atributes)
            {
                propriedades += "            self."+ en.Key + " = obj.get(\""+en.Key+"\")\n";
                propriedadesElse += "            self." + en.Key + " = ''\n";
            }

            if (GeraCabecalho)
            {
                code = "class User():\n" +
                        "    def __init__(self,obj):\n" +
                        "        if obj != '':\n" + propriedades +
                        "        else:\n" + propriedadesElse;
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


        public static void GeneratePyAtom()
        {
            String code = "";


            code =  "def insertone(obj,table_basse, con):\n" +
                    "    seq = vars(obj)\n" +
                    "    sec = executeStatement(seq,table_basse,1,con,0)\n" +
                    "    return sec\n" +
                    "\n" +
                    "def updateone(obj,table_basse, con,id):\n" +
                    "    seq = vars(obj)\n" +
                    "    sec = executeStatement(seq,table_basse,2,con,id)\n" +
                    "    return sec\n" +
                    "\n" +
                    "def updateSql(sql,values, con):\n" +
                    "    cursor = con.cursor()\n" +
                    "    cursor.execute(sql, values)\n" +
                    "    con.commit()\n" +
                    "\n" +
                    "def deletedone(table_basse, con,id):\n" +
                    "    sec = executeStatement('',table_basse,3,con,id)\n" +
                    "    return sec\n" +
                    "\n" +
                    "def getAll(sql,con):\n" +
                    "    cursor = con.cursor()\n" +
                    "    cursor.execute(sql)\n" +
                    "    columns = cursor.column_names\n" +
                    "    result = cursor.fetchall()\n" +
                    "    allobject = []\n" +
                    "    obj = dict((col, \"\") for col in columns)\n" +
                    "\n" +
                    "    for rs in result:\n" +
                    "        i = 0\n" +
                    "        ob = dict(obj)\n" +
                    "        for col in columns:\n" +
                    "            ob[col] = rs[i]\n" +
                    "            i += 1\n" +
                    "        allobject.append(ob)\n" +
                    "    return allobject\n" +
                    "\n" +
                    "def getOne(sql,con):\n" +
                    "    cursor = con.cursor()\n" +
                    "    cursor.execute(sql)\n" +
                    "    columns = cursor.column_names\n" +
                    "    result = cursor.fetchone()\n" +
                    "    allobject = []\n" +
                    "    obj = dict((col, \"\") for col in columns)\n" +
                    "\n" +
                    "\n" +
                    "    ob = dict(obj)\n" +
                    "    i = 0\n" +
                    "    if(result != None):\n" +
                    "        for col in columns:\n" +
                    "            ob[col] = result[i]\n" +
                    "            i += 1\n" +
                    "    else:\n" +
                    "        ob = None\n" +
                    "    return ob\n" +
                    "\n" +
                    "def executeStatement(obj,table_basse, tp,con, id):\n" +
                    "    sql = ''\n" +
                    "    atr = str()\n" +
                    "    satr = str()\n" +
                    "    values = list()\n" +
                    "    if(tp == 1):\n" +
                    "        sql = 'insert into ' + table_basse + '('\n" +
                    "        for kv in obj:\n" +
                    "            if(kv == 'id' or kv == 'add' or kv == 'edit' or kv == 'dele'):\n" +
                    "                ''\n" +
                    "            else:\n" +
                    "                atr = atr +  kv + ','\n" +
                    "                satr += '%s ,'\n" +
                    "                values.append(obj[kv])\n" +
                    "        sql = sql + atr[:-1] + ') VALUES (' + satr[:-1] + ')'\n" +
                    "\n" +
                    "        cursor = con.cursor()\n" +
                    "        cursor.execute(sql,values)\n" +
                    "        id = cursor.lastrowid\n" +
                    "        con.commit()\n" +
                    "    elif(tp == 2):\n" +
                    "\n" +
                    "        for kv in obj:\n" +
                    "            if (kv == 'id' or kv == 'add' or kv == 'edit' or kv == 'dele'):\n" +
                    "                ''\n" +
                    "            else:\n" +
                    "                atr = atr + kv + '=%s,'\n" +
                    "                values.append(obj[kv])\n" +
                    "        values.append(id)\n" +
                    "        sql = 'UPDATE ' + table_basse + ' set ' + atr[:-1] + ' where id = %s'\n" +
                    "\n" +
                    "        cursor = con.cursor()\n" +
                    "        cursor.execute(sql, values)\n" +
                    "        con.commit()\n" +
                    "    else:\n" +
                    "        sql = 'DELETE FROM ' + table_basse + ' where id = %s'\n" +
                    "        values.append(id)\n" +
                    "        cursor = con.cursor()\n" +
                    "        cursor.execute(sql, values)\n" +
                    "        con.commit()\n" +
                    "    return id";

            Result rs = new(code);
            rs.Show();

        }
    }
}
