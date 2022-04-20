using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using System.Data;
public class ConsultasUsuario
{
    public static Usuario ObterUsuarioPeloNomeSenha(string nome,string senha)
    {
        var conexao = new MySqlConnection(ConnectionBD.Connection.ConnectionString);
        Usuario usuario = null;

        try
        {
            conexao.Open();
            var comando = conexao.CreateCommand();
            comando.CommandText = @"SELECT * FROM Usuario WHERE nome_usuario = @nome AND senha = @senha;";
            comando.Parameters.AddWithValue("@nome", nome);
            comando.Parameters.AddWithValue("@senha", senha);
            var reader = comando.ExecuteReader();
            while (reader.Read()) 
            {
                usuario = new Usuario();
                usuario.Id_usuario = reader.GetInt32("id_usuario");
                usuario.Nome_usuario = reader.GetString("nome_usuario");
                usuario.Email = reader.GetString("email");
                usuario.Senha = reader.GetString("senha");
                break;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            usuario = null;
        }
        finally 
        {
            if (conexao.State == ConnectionState.Open) 
            {
                conexao.Close();
            }        
        }

        return usuario;
    }
}

