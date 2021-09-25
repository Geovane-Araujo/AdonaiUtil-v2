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
    class JavaController : UtilModels
    {

        public JavaController(UtilModels obj)
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

            propriedades =  "    @Ignore\n" +
                            "    private static final long serialVersionUID = 1L;\n" +
                            "\n" +
                            "    @Ignore\n" +
                            "    private boolean add = true;\n" +
                            "    @Ignore\n" +
                            "    private boolean edit = false;\n" +
                            "    @Ignore\n" +
                            "    private boolean del = false;\n\n";

            foreach (DictionaryEntry en in atributes)
            {
                propriedades += "    private " + en.Value + " " + en.Key + ";\n\n";
            }

            propriedades += "    public boolean isAdd() {\n" +
                            "        return add;\n" +
                            "    }\n" +
                            "\n" +
                            "    public void setAdd(boolean add) {\n" +
                            "        this.add = add;\n" +
                            "    }\n" +
                            "\n" +
                            "    public boolean isEdit() {\n" +
                            "        return edit;\n" +
                            "    }\n" +
                            "\n" +
                            "    public void setEdit(boolean edit) {\n" +
                            "        this.edit = edit;\n" +
                            "    }\n" +
                            "\n" +
                            "    public boolean isDel() {\n" +
                            "        return del;\n" +
                            "    }\n" +
                            "\n" +
                            "    public void setDel(boolean del) {\n" +
                            "        this.del = del;\n" +
                            "    }\n";

            foreach (DictionaryEntry en in atributes)
            {
                var prop = en.Key.ToString();

                String nomeMaiusculo = char.ToUpper(prop[0]) + prop.Substring(1);

                propriedades += "    public " + en.Value + " get"+ nomeMaiusculo + "() {\n" +
                                "        return "+en.Key+";\n" +
                                "    }\n" +
                                "\n" +
                                "\n" +
                                "    public void set" + nomeMaiusculo +"(" + en.Value + " " + en.Key + ") {\n" +
                                "        this." + en.Key + " = " + en.Key + ";\n" +
                                "    }\n";

            }

            if (GeraCabecalho)
            {
                code =  "import com.atom.Ignore;\n" +
                        "import com.atom.TableName;\n" +
                        "import java.io.Serializable;\n" +
                        "\n" +
                        "\n" +
                        "@TableName(value = \"pessoa\")\n" +
                        "public class Pessoa implements Serializable {\n" +
                        "    \n" +
                        "    \n" + propriedades +
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
            String code = "";
            String propriedades = "";


            propriedades =  "\n" +
                            "    String sql =\"\" ;\n" +
                            "    String descricao = \"Cadastro.Pessoa\";\n" +
                            "    String log =\"\" ;\n" +
                            "\n" +
                            "\n" +
                            "    public "+NomeClasse+" save(" + NomeClasse + " obj, Connection con) throws SQLException, IllegalAccessException {\n" +
                            "\n" +
                            "        int scalar = 0;\n" +
                            "\n" +
                            "        con.setAutoCommit(false);\n" +
                            "\n" +
                            "        if(obj.isAdd()){\n" +
                            "            scalar = Atom.insertedOne(obj,con);\n" +
                            "\n" +
                            "        }\n" +
                            "        else if(obj.isEdit()){\n" +
                            "            Atom.editingOne(obj,con);\n" +
                            "        }\n" +
                            "        else if(obj.isDel()){\n" +
                            "            Atom.deleted(con, \""+Tabela+"\", \"\",obj.getId());\n" +
                            "        }\n" +
                            "        con.commit();\n" +
                            "        con.close();\n" +
                            "        return obj;\n" +
                            "    }\n" +
                            "    public Object getById(int id,Connection con) throws SQLException {\n" +
                            "\n" +
                            "        Object object = new Object();\n" +
                            "\n" +
                            "        String sql = \"select * from "+Tabela+" where id = \" + id;\n" +
                            "\n" +
                            "        object =  Atom.getOne("+NomeClasse+".class,con,sql);\n" +
                            "\n" +
                            "        return object;\n" +
                            "    }";

            if (UsaFramework)
            {
                if (GeraCabecalho)
                {
                    code =  "import com.atom.Atom;\n" +
                            "import org.springframework.web.bind.annotation.RestController;\n" +
                            "\n" +
                            "import java.sql.Connection;\n" +
                            "import java.sql.SQLException;\n" +
                            "\n" +
                            "/**\n" +
                            " *\n" +
                            " * @author Geovane\n" +
                            " * Gerado automaticaente por AdonaiSoft - Utilitário\n" +
                            " */\n" +
                            "\n" +
                            "@RestController\n" +
                            "public class PessoaController {\n" +
                            "    \n" +
                            "    \n" + propriedades + "\n"+
                            "}";
                }
                else
                {
                    code = propriedades;
                }
            }
            else
            {
                code = "EM DESENVOLVIMENTO !!!";
            }

            Result rs = new(code);
            rs.Show();

        }
        public void GenerateResource()
        {
            String code = "";
            String propriedades = "";

            var nmm = NomeClasse;
            String nomeMinusculo = char.ToLower(nmm[0]) + nmm.Substring(1);


            if (UsaToken)
            {
                propriedades =  "    @Autowired\n" +
                                "    " + NomeClasse + "Controller objController;\n" +
                                "\n" +
                                "    @Autowired\n" +
                                "    " + ClasseConexao + " connection;\n" +
                                "\n" +
                                "    @PostMapping(\"/" + nomeMinusculo + "\")\n" +
                                "    public ResponseEntity<?> save(@RequestHeader(value = \"Authorization\")String token, @RequestBody "+NomeClasse+" "+nomeMinusculo+") throws SQLException {\n" +
                                "\n" +
                                "        Hashtable retorno = new Hashtable();\n" +
                                "        Connection con = null;\n" +
                                "\n" +
                                "        try {\n" +
                                "\n" +
                                "            String decode = UtilToken.decode(token);\n" +
                                "            con = connection.getNewConnections(decode);\n" +
                                "\n" +
                                "            objController.save("+nomeMinusculo+",con);\n" +
                                "            retorno.put(\"ret\", \"success\");\n" +
                                "            retorno.put(\"motivo\", \"OK\");\n" +
                                "            retorno.put(\"obj\", "+nomeMinusculo+");\n" +
                                "        }\n" +
                                "        catch (SQLException e ) {\n" +
                                "            retorno.put(\"ret\", \"unsuccess\");\n" +
                                "            retorno.put(\"motivo\",e.getMessage());\n" +
                                "        } catch (IllegalAccessException ex) {\n" +
                                "            retorno.put(\"ret\", \"unsuccess\");\n" +
                                "            retorno.put(\"motivo\",ex.getMessage());\n" +
                                "        }\n" +
                                "        finally {\n" +
                                "            con.close();\n" +
                                "        }\n" +
                                "\n" +
                                "        return ResponseEntity.ok().body(retorno);\n" +
                                "    }\n" +
                                "\n" +
                                "    @GetMapping(\"/"+nomeMinusculo+"/{id}\")\n" +
                                "    public ResponseEntity<?> get(@RequestHeader(value = \"Authorization\")String token, @PathVariable(value=\"id\") int id) throws SQLException {\n" +
                                "\n" +
                                "        Hashtable retorno = new Hashtable();\n" +
                                "        Connection con = null;\n" +
                                "\n" +
                                "        try {\n" +
                                "\n" +
                                "            String decode = UtilToken.decode(token);\n" +
                                "            con = connection.getNewConnections(decode);\n" +
                                "\n" +
                                "            if(id == -100){\n" +
                                "                retorno.put(\"obj\", new "+NomeClasse+"());\n" +
                                "            }\n" +
                                "            else{\n" +
                                "                retorno.put(\"obj\", objController.getById(id,con));\n" +
                                "            }\n" +
                                "\n" +
                                "            retorno.put(\"ret\", \"success\");\n" +
                                "            retorno.put(\"motivo\", \"OK\");\n" +
                                "        }\n" +
                                "        catch (SQLException e ) {\n" +
                                "            retorno.put(\"ret\", \"unsuccess\");\n" +
                                "            retorno.put(\"motivo\",e.getMessage());\n" +
                                "        }\n" +
                                "        finally {\n" +
                                "            con.close();\n" +
                                "        }\n" +
                                "\n" +
                                "        return ResponseEntity.ok().body(retorno);\n" +
                                "    }\n";
            }
            else
            {
                propriedades = "    @Autowired\n" +
                                "    " + NomeClasse + "Controller objController;\n" +
                                "\n" +
                                "    @Autowired\n" +
                                "    " + ClasseConexao + " connection;\n" +
                                "\n" +
                                "    @PostMapping(\"/" + nomeMinusculo + "\")\n" +
                                "    public ResponseEntity<?> save(@RequestBody " + NomeClasse + " " + nomeMinusculo + ") throws SQLException {\n" +
                                "\n" +
                                "        Hashtable retorno = new Hashtable();\n" +
                                "        Connection con = null;\n" +
                                "\n" +
                                "        try {\n" +
                                "\n" +
                                "            con = connection.getNewConnections("+NomeBanco+");\n" +
                                "\n" +
                                "            objController.save(" + nomeMinusculo + ",con);\n" +
                                "            retorno.put(\"ret\", \"success\");\n" +
                                "            retorno.put(\"motivo\", \"OK\");\n" +
                                "            retorno.put(\"obj\", " + nomeMinusculo + ");\n" +
                                "        }\n" +
                                "        catch (SQLException e ) {\n" +
                                "            retorno.put(\"ret\", \"unsuccess\");\n" +
                                "            retorno.put(\"motivo\",e.getMessage());\n" +
                                "        } catch (IllegalAccessException ex) {\n" +
                                "            retorno.put(\"ret\", \"unsuccess\");\n" +
                                "            retorno.put(\"motivo\",ex.getMessage());\n" +
                                "        }\n" +
                                "        finally {\n" +
                                "            con.close();\n" +
                                "        }\n" +
                                "\n" +
                                "        return ResponseEntity.ok().body(retorno);\n" +
                                "    }\n" +
                                "\n" +
                                "    @GetMapping(\"/" + nomeMinusculo + "/{id}\")\n" +
                                "    public ResponseEntity<?> get(@PathVariable(value=\"id\") int id) throws SQLException {\n" +
                                "\n" +
                                "        Hashtable retorno = new Hashtable();\n" +
                                "        Connection con = null;\n" +
                                "\n" +
                                "        try {\n" +
                                "\n" +
                                "            con = connection.getNewConnections(\""+NomeBanco+"\");\n" +
                                "\n" +
                                "            if(id == -100){\n" +
                                "                retorno.put(\"obj\", new " + NomeClasse + "());\n" +
                                "            }\n" +
                                "            else{\n" +
                                "                retorno.put(\"obj\", objController.getById(id,con));\n" +
                                "            }\n" +
                                "\n" +
                                "            retorno.put(\"ret\", \"success\");\n" +
                                "            retorno.put(\"motivo\", \"OK\");\n" +
                                "        }\n" +
                                "        catch (SQLException e ) {\n" +
                                "            retorno.put(\"ret\", \"unsuccess\");\n" +
                                "            retorno.put(\"motivo\",e.getMessage());\n" +
                                "        }\n" +
                                "        finally {\n" +
                                "            con.close();\n" +
                                "        }\n" +
                                "\n" +
                                "        return ResponseEntity.ok().body(retorno);\n" +
                                "    }\n";
            }

            

            if (GeraCabecalho)
            {
                code =  "import org.springframework.beans.factory.annotation.Autowired;\n" +
                        "import org.springframework.http.ResponseEntity;\n" +
                        "import org.springframework.web.bind.annotation.*;\n" +
                        "\n" +
                        "import java.sql.Connection;\n" +
                        "import java.sql.SQLException;\n" +
                        "import java.util.Hashtable;\n" +
                        "\n" +
                        "@RestController\n" +
                        "@RequestMapping(value = \"/"+RotaApi+"\")\n" +
                        "@CrossOrigin(origins =\"*\")\n" +
                        "public class "+NomeClasse+"Resource {\n" +
                        "    \n" +
                        "    \n" + propriedades +
                        "}";
            }
            else
            {
                code = propriedades;
            }

            Result rs = new(code);
            rs.Show();
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

        public static void GenerateFunctionToken()
        {
            String code = "";

            code =  "public class UtilToken {\n" +
                    "\n" +
                    "    private String criterios;\n" +
                    "\n" +
                    "    private int pagina;\n" +
                    "\n" +
                    "    private String route;\n" +
                    "\n" +
                    "    public String getRoute() {\n" +
                    "        return route;\n" +
                    "    }\n" +
                    "\n" +
                    "    public void setRoute(String route) {\n" +
                    "        this.route = route;\n" +
                    "    }\n" +
                    "\n" +
                    "    public int getPagina() {\n" +
                    "        return pagina;\n" +
                    "    }\n" +
                    "\n" +
                    "    public void setPagina(int pagina) {\n" +
                    "        this.pagina = pagina;\n" +
                    "    }\n" +
                    "\n" +
                    "    public String getCriterios() {\n" +
                    "        return criterios;\n" +
                    "    }\n" +
                    "\n" +
                    "    public void setCriterios(String criterios) {\n" +
                    "        this.criterios = criterios;\n" +
                    "    }\n" +
                    "\n" +
                    "    public static String decode(String token){\n" +
                    "\n" +
                    "        String[] tk = token.split(\" \");\n" +
                    "        String decode = Base64.base64Decode(tk[1]);\n" +
                    "        decode = decode.substring(0,4);\n" +
                    "        String[] a = decode.split(\"&\");\n" +
                    "        return a[0];\n" +
                    "    }\n" +
                    "\n" +
                    "    public static int decodeId(String token){\n" +
                    "\n" +
                    "        String[] tk = token.split(\" \");\n" +
                    "        String decode = Base64.base64Decode(tk[1]);\n" +
                    "        String[] id = decode.split(\"&\");\n" +
                    "\n" +
                    "        return Integer.parseInt(id[1]);\n" +
                    "    }\n" +
                    "\n" +
                    "    public static String[] decodeUsersApp(String token){\n" +
                    "\n" +
                    "        String decode = Base64.base64Decode(token);\n" +
                    "        String[] tk = decode.split(\"&\");\n" +
                    "        return tk;\n" +
                    "    }\n" +
                    "}";

            Result rs = new(code);
            rs.Show();
        }

        public static void GenerateClassConnection(int db)
        {
            String code = "";
            if(db == 0)
            {
                code =  "\tprivate String url = \"jdbc:postgresql://localhost:5432/\";\n" +
                        "\n" +
                        "\tpublic String getUrl() {\n" +
                        "\t\treturn url;\n" +
                        "\t}\n" +
                        "\n" +
                        "\tpublic boolean openSessionConnections(String db) throws ClassNotFoundException {\n" +
                        "\n" +
                        "\t\tboolean ret;\n" +
                        "\n" +
                        "\t\ttry {\n" +
                        "\t\t\tString url = getUrl()+db;\n" +
                        "\t\t\tClass.forName(\"org.postgresql.Driver\");\n" +
                        "\t\t\tString senha = \"1816\";\n" +
                        "\t\t\tDriverManager.getConnection(url, \"postgres\", senha);\n" +
                        "\t\t\tret = true;\n" +
                        "\t\t} catch (SQLException e) {\n" +
                        "\t\t\tret = false;\n" +
                        "\t\t\tSystem.out.println(e);\n" +
                        "\n" +
                        "\t\t}\n" +
                        "\n" +
                        "\t\treturn ret;\n" +
                        "\t}\n" +
                        "\n" +
                        "\tpublic Connection getNewConnections(String db) throws SQLException {\n" +
                        "\n" +
                        "\t\tConnection con = null;\n" +
                        "\t\tString url = getUrl()+db;\n" +
                        "\t\ttry {\n" +
                        "\t\t\tString senha = \"1816\";\n" +
                        "\t\t\tcon = DriverManager.getConnection(url,\"postgres\",senha);\n" +
                        "\t\t}\n" +
                        "\t\tcatch(SQLException e) {\n" +
                        "\t\t\tSystem.out.println(e);\n" +
                        "\n" +
                        "\t\t}\n" +
                        "\t\treturn con;\n" +
                        "\t}";
            }

            Result rs = new(code);
            rs.Show();
        }
    }
}
