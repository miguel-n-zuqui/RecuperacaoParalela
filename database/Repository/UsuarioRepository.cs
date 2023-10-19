using database.Conexoes;
using Microsoft.Data.SqlClient;
using negocio.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace database.Repository
{
    public class UsuarioRepository
    {
        public bool Inserir(Usuarios usuario)
        {
            try
            {
                var sql = @"INSERT INTO [dbo].[Usuarios]
                ([Telefone]
                ,[Email]
                ,[Nome]
                ,[Endereco]
                ,[Nascimento]
                ,[Contato]
                ,[Observacoes]
                ,[Cargo]
                ,[Empresa])
            VALUES
                 ( @Telefone, 
                  @Email, 
                  @Nome, 
                  @Endereco, 
                  @Nascimento,
                  @Contato, 
                  @Observacoeax,
                  @Cargo, 
                  @Empresa)";

                using (var connection = new SqlConnection(SqlConexao.StrConexao()))
                {
                    connection.Open();
                    var cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@Telefone", usuario.Telefone);
                    cmd.Parameters.AddWithValue("@Email", usuario.Email) ;
                    cmd.Parameters.AddWithValue("@Nome", usuario.Nome);
                    cmd.Parameters.AddWithValue("@Nascimento", usuario.Endereco);
                    cmd.Parameters.AddWithValue("@Contato", usuario.Contato);
                    cmd.Parameters.AddWithValue("@Observacoeax", usuario.Observacoes);
                    cmd.Parameters.AddWithValue("@Cargo", usuario.Cargo);
                    cmd.Parameters.AddWithValue("@Empresa", usuario.Empresa);
                    var reposta = cmd.ExecuteNonQuery();
                    connection.Close();
                    return reposta == 1;

                }

            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Atualizar(Usuarios usuario, int id)
        {
            try
            {
                var sql = @"UPDATE [dbo].[Usuarios]
                          SET [Telefone] = @Telefone, 
                    [Email] = @Email, 
                    [Nome] = @Nome,
                    [Endereco] = @Endereco,
                    [Nascimento] = @Nascimento,
                    [Contato] = @Contato, 
                    [Observacoes] = @Observacoes,
                    [Cargo] = @Cargo,
                    [Empresa] = @Empresa, 
                         WHERE Id = @id";

                using (var connection = new SqlConnection(SqlConexao.StrConexao()))
                {
                    connection.Open();
                    var cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@Telefone", usuario.Telefone);
                    cmd.Parameters.AddWithValue("@Email", usuario.Email);
                    cmd.Parameters.AddWithValue("@Nome", usuario.Nome);
                    cmd.Parameters.AddWithValue("@Nascimento", usuario.Endereco);
                    cmd.Parameters.AddWithValue("@Contato", usuario.Contato);
                    cmd.Parameters.AddWithValue("@Observacoeax", usuario.Observacoes);
                    cmd.Parameters.AddWithValue("@Cargo", usuario.Cargo);
                    cmd.Parameters.AddWithValue("@Empresa", usuario.Empresa);
                    cmd.Parameters.AddWithValue("@id", id);

                    var reposta = cmd.ExecuteNonQuery();
                    connection.Close();
                    return reposta == 1;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Deletar(int usuarioId)
        {
            try
            {
                var sql = @"DELETE FROM [dbo].[Usuarios]
                          WHERE Id = @Id";

                using (var connection = new SqlConnection(SqlConexao.StrConexao()))
                {
                    connection.Open();
                    var cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@Id", usuarioId);

                    var resposta = cmd.ExecuteNonQuery();
                    connection.Close();
                    return resposta == 1;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable ObterTodos()
        {
            var sql = @"SELECT [Id]
                 ,[Telefone]
                 ,[Email]
                 ,[Nome]
                 ,[Endereco]
                 ,[Nascimento]
                 ,[Contato]
                 ,[Observacoes]
                 ,[Cargo]
                 ,[Empresa]
             FROM [dbo].[Usuarios]";

            SqlDataAdapter dataAdapter = null;
            var dataTable = new DataTable();

            try
            {


                using (var connection = new SqlConnection(SqlConexao.StrConexao()))
                {
                    connection.Open();
                    var cmd = connection.CreateCommand();

                    cmd.CommandText = sql;

                    dataAdapter = new SqlDataAdapter(sql, connection);
                    dataAdapter.Fill(dataTable);
                    connection.Close();
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<string> Complemento(string cargo)
        {
            var sql = @"SELECT [Nome] FROM [dbo].[Cargo]";

            try
            {
                using (var connection = new SqlConnection(SqlConexao.StrConexao()))
                {
                    connection.Open();
                    SqlCommand com = new SqlCommand(sql, connection);

                    SqlDataReader reader = com.ExecuteReader();

                    var lista = new List<string>();

                    while (reader.Read())
                    {
                        lista.Add(reader.GetString(0).Trim());
                    }

                    return lista;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}


       
        

