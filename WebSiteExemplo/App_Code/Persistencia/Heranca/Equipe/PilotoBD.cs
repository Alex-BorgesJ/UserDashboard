using FATEC;
using System;
//para acesso a classe Mapped
using WebSiteExemplo.Classes.Equipe; //para acesso a classe de modelagem
using System.Data; // para acesso ao DataSet
using WebSiteExemplo.Util; //para acesso ao enum
namespace WebSiteExemplo.Persistencia.Equipe
{
    /// <summary>
    /// Summary description for EngenheiroBD
    /// </summary>
    public class PilotoBD
    {
        //métodos
        //insert
        public int Insert(Piloto piloto)
        {
            int retorno = 0;
            try
            {
                IDbConnection objConexao;
                IDbCommand objCommand;
                string sql = "INSERT INTO tbl_membro(mem_nome, mem_contrato, mem_altura, mem_tipo, mem_peso) VALUES(?nome, ?contrato, ?altura, ?tipo, ?peso)";
                objConexao = Mapped.Connection();
                objCommand = Mapped.Command(sql, objConexao);
                objCommand.Parameters.Add(Mapped.Parameter("?nome", piloto.Nome));
                objCommand.Parameters.Add(Mapped.Parameter("?contrato", piloto.Contrato));
                objCommand.Parameters.Add(Mapped.Parameter("?altura", piloto.Altura));
                //classe enum precisa ser convertida para int
                objCommand.Parameters.Add(Mapped.Parameter("?tipo", (int)MEMBRO.PILOTO));
                objCommand.Parameters.Add(Mapped.Parameter("?peso",piloto.Peso));
                objCommand.ExecuteNonQuery();
                objConexao.Close();
                objCommand.Dispose();
                objConexao.Dispose();
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                retorno = 1;
            }
            catch (Exception)
            {
                retorno = 2;
            }

            return retorno;
        }
        //selectAll
        public DataSet SelectAll()
        {
            DataSet ds = new DataSet();
            IDbConnection objConexao;
            IDbCommand objCommand;
            System.Data.IDataAdapter objDataAdapter;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM tbl_membro WHERE mem_tipo=?tipo", objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?tipo", MEMBRO.PILOTO));
            objDataAdapter = Mapped.Adapter(objCommand);
            objDataAdapter.Fill(ds);
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return ds;
        }
        //select
        public Piloto Select(int id)
        {
            Piloto obj = null;
            IDbConnection objConexao;
            IDbCommand objCommand;
            IDataReader objDataReader;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM tbl_membro WHERE mem_codigo = ?codigo", objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?codigo", id));
            objDataReader = objCommand.ExecuteReader();
            while (objDataReader.Read())
            {
                obj = new Piloto();
                obj.Codigo = Convert.ToInt32(objDataReader["mem_codigo"]);
                obj.Nome = Convert.ToString(objDataReader["mem_nome"]);
                obj.Contrato = Convert.ToString(objDataReader["mem_contrato"]);
                obj.Altura = Convert.ToDouble(objDataReader["mem_altura"]);
                obj.Peso = Convert.ToDouble(objDataReader["mem_peso"]);
            }
            objDataReader.Close();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            objDataReader.Dispose();
            return obj;
        }
        //update
        public bool Update(Piloto piloto)
        {
            IDbConnection objConexao;
            IDbCommand objCommand;
            string sql = "UPDATE tbl_membro SET mem_nome=?nome, mem_contrato=?contrato, mem_altura=?altura, mem_peso=?peso WHERE mem_codigo=?codigo";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?nome", piloto.Nome));
            objCommand.Parameters.Add(Mapped.Parameter("?contrato", piloto.Contrato));
            objCommand.Parameters.Add(Mapped.Parameter("?altura", piloto.Altura));
            objCommand.Parameters.Add(Mapped.Parameter("?peso", piloto.Peso));
            objCommand.Parameters.Add(Mapped.Parameter("?codigo", piloto.Codigo));
            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return true;
        }
        //delete
        public bool Delete(int id)
        {
            IDbConnection objConexao;
            IDbCommand objCommand;
            string sql = "DELETE FROM tbl_membro WHERE mem_codigo=?codigo";
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
        public PilotoBD()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}
