using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using System.Data;

public class ConsultasSuaBiblioteca
{
    public static List<SuaBiblioteca> ObterTodasSuasMusicas()
    {
        var conexao = new MySqlConnection(ConnectionBD.Connection.ConnectionString);
        List<SuaBiblioteca> suaBiblioteca = new List<SuaBiblioteca>();

        try
        {
            conexao.Open();
            var comando = conexao.CreateCommand();


            comando.CommandText = @"SELECT * FROM Biblioteca";
            var leitura = comando.ExecuteReader();
            while (leitura.Read())
            {
                SuaBiblioteca suamusica = new SuaBiblioteca();
                suamusica.id = leitura.GetInt32("id");
                suamusica.suamusica = leitura.GetString("suamusica");
                suamusica.artista = leitura.GetString("artista");
                

                suaBiblioteca.Add(suamusica);

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
        return suaBiblioteca;
    }
}

