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
    public static Usuario ObterEmailEsqueceuSenha(string email) 

    {
        var conexao = new MySqlConnection(ConnectionBD.Connection.ConnectionString);
        Usuario emailusuario = null;

        try
        {
            conexao.Open();
            var comando = conexao.CreateCommand();
            comando.CommandText = @"SELECT * FROM Usuario WHERE email = @email;";
            comando.Parameters.AddWithValue("@email", email);
            var reader = comando.ExecuteReader();
            while (reader.Read())
            {
                emailusuario = new Usuario();
                emailusuario.Id_usuario = reader.GetInt32("id_usuario");
                emailusuario.Nome_usuario = reader.GetString("nome_usuario");
                emailusuario.Email = reader.GetString("email");
                emailusuario.Senha = reader.GetString("senha");
                break;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            emailusuario = null;
        }
        finally
        {
            if (conexao.State == ConnectionState.Open)
            {
                conexao.Close();
            }
        }
         return emailusuario;
    }

    public static bool RedefinirSenha(string email, string senha)
    {
        
        var conexao = new MySqlConnection(ConnectionBD.Connection.ConnectionString);
        bool foiAlterado = false;

        try
        {
            conexao.Open();
            var comando = conexao.CreateCommand();
            comando.CommandText = @"UPDATE Usuario SET senha = @senha WHERE email = @email";
            comando.Parameters.AddWithValue("@email", email);
            comando.Parameters.AddWithValue("@senha", senha);
            var reader = comando.ExecuteReader();
            foiAlterado = true;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally 
        {
            if (conexao.State == ConnectionState.Open) 
            {
                conexao.Close();
            }
        }
        return foiAlterado;
    }
}


