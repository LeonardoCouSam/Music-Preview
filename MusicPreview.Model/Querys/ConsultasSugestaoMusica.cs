using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using System.Data;

public class ConsultasSugestaoMusica
{
    public static List<SugestaoMusica> ObterTodasSugestoes()
    {
        var conexao = new MySqlConnection(ConnectionBD.Connection.ConnectionString);
        List<SugestaoMusica> listaSugestao = new List<SugestaoMusica>();

        try
        {
            conexao.Open();
            var comando = conexao.CreateCommand();


            comando.CommandText = @"SELECT * FROM sugestao";
            var leitura = comando.ExecuteReader();
            while (leitura.Read())
            {
                SugestaoMusica sugestao = new SugestaoMusica();
                sugestao.id_musica = leitura.GetInt32("id_musica");
                sugestao.nome_musica = leitura.GetString("Nome_musica");
                sugestao.nome_artista = leitura.GetString("Nome_artista");

                listaSugestao.Add(sugestao);

            }
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
        return listaSugestao;
    }

    public static bool InserirMusica(string nomeMusica, string nomeArtista)
    {
        var conexao = new MySqlConnection(ConnectionBD.Connection.ConnectionString);
        bool foiInserido = false;

        try
        {
            conexao.Open();
            var comando = conexao.CreateCommand();
            comando.CommandText = @"INSERT INTO Sugestao (nome_musica, nome_artista) VALUES (@nomeMusica, @nomeArtista)";
            comando.Parameters.AddWithValue("@nomeMusica", nomeMusica);
            comando.Parameters.AddWithValue("@nomeArtista", nomeArtista);
            var leitura = comando.ExecuteReader();
            foiInserido = true;
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
        return foiInserido;
    }
}
