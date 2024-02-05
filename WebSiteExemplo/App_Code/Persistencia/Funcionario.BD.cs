using FATEC; //para acesso a classe Mapped
using System;
using System.Web;
using WebSiteExemplo.Classes; //para acesso a classe Funcionario
using System.Data; //para uso de DataSet
namespace WebSiteExemplo.Persistencia
{
    /// <summary>
    /// Summary description for FuncionarioBD
    /// </summary>
    public class FuncionarioBD
    {
        //métodos
        //insert
        public bool Insert(Funcionario funcionario)
        {
            IDbConnection objConexao;
            IDbCommand objCommand;
            string sql = "INSERT INTO tbl_funcionario(fun_nome, fun_salario, fun_cracha) VALUES (?nome, ?salario, ?cracha)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?nome", funcionario.Nome));
            objCommand.Parameters.Add(Mapped.Parameter("?salario", funcionario.Salario));
            objCommand.Parameters.Add(Mapped.Parameter("?cracha", funcionario.Cracha));
            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();

            return true;
        }
        //selectall
        public DataSet SelectAll()
        {
            DataSet ds = new DataSet();
            IDbConnection objConexao;
            IDbCommand objCommand;
            IDataAdapter objDataAdapter;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM tbl_funcionario", objConexao);
            objDataAdapter = Mapped.Adapter(objCommand);
            objDataAdapter.Fill(ds);
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return ds;
        }
        //select
        public Funcionario Select(int id)
        {
            Funcionario obj = null;
            IDbConnection objConexao;
            IDbCommand objCommand;
            IDataReader objDataReader;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM tbl_funcionario WHERE fun_codigo = ?codigo", objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?codigo", id));
            objDataReader = objCommand.ExecuteReader();
            while (objDataReader.Read())
            {
                obj = new Funcionario();
                obj.Codigo = Convert.ToInt32(objDataReader["fun_codigo"]);
                obj.Nome = Convert.ToString(objDataReader["fun_nome"]);
                obj.Salario = Convert.ToDouble(objDataReader["fun_salario"]);
                obj.Cracha = Convert.ToString(objDataReader["fun_cracha"]);
            }
            objDataReader.Close();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            objDataReader.Dispose();
            return obj;
        }
        //update
        public bool Update(Funcionario funcionario)
        {
            IDbConnection objConexao;
            IDbCommand objCommand;
            string sql = "UPDATE tbl_funcionario SET fun_nome=?nome, fun_salario=?salario, fun_cracha=?cracha WHERE fun_codigo=?codigo";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?nome", funcionario.Nome));
            objCommand.Parameters.Add(Mapped.Parameter("?salario", funcionario.Salario));
            objCommand.Parameters.Add(Mapped.Parameter("?cracha", funcionario.Cracha));
            objCommand.Parameters.Add(Mapped.Parameter("?codigo", funcionario.Codigo));
            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return true;
        }

        //delete
        public bool Delete(int id)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "DELETE FROM tbl_funcionario WHERE fun_codigo=?codigo";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?codigo", id));

            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return true;
        }
        //construtor
    }
}
