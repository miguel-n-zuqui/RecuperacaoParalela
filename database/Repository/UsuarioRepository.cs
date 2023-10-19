using database.Conexoes;
using negocio.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
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
           @Telefone, varchar(30),
           @Email, varchar(30),
           @Nome, varchar(30),
           @Endereco, varchar(30),
           @Nascimento, datetime,
           @Contato, datetime,
           @Observacoes, varchar(max),
           @Cargo, varchar(30),
           @Empresa, varchar(30),)";

            

            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Atualizar(Cargo cargo, int id)
        {
            try
            {
                var sql = @"UPDATE [dbo].[Usuarios]
                          SET [Telefone] = @Telefone, 
                    ,[Email] = @Email, 
                    ,[Nome] = @Nome
                    ,[Endereco] = @Endereco,
                    ,[Nascimento] = @Nascimento,
                    ,[Contato] = @Contato, 
                    ,[Observacoes] = @Observacoes,
                    ,[Cargo] = @Cargo,
                    ,[Empresa] = @Empresa, 
                         WHERE Id = @id";

                using (var connection = new SqlConnection(SqlServer.StrConexao()))
                {
                    connection.Open();
                    var cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@nome", cargo.Nome);
                    cmd.Parameters.AddWithValue("@status", cargo.Status);
                    cmd.Parameters.AddWithValue("@alteradoEm", cargo.AlteradoEm);
                    cmd.Parameters.AddWithValue("@alteradoPor", cargo.AlteradoPor);
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
    }
}


       
        

