using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using System.Data;

public class ConsultasProducaoProdutora
    {
    public static List<ProducaoProdutora> ObterTodasProducoes()
    {
        var conexao = new MySqlConnection(ConnectionBD.Connection.ConnectionString);
        List<ProducaoProdutora> listaProducao = new List<ProducaoProdutora>();

        try
        {
            conexao.Open();
            var comando = conexao.CreateCommand();


            comando.CommandText = @"SELECT * FROM Producao";
            var leitura = comando.ExecuteReader();
            while (leitura.Read())
            {
                ProducaoProdutora emProducao = new ProducaoProdutora();
                emProducao.id_produtora = leitura.GetInt32("id_produtora");
                emProducao.produtora = leitura.GetString("produtora");
                emProducao.musicaproducao = leitura.GetString("musicaproducao");
                emProducao.artistaproducao = leitura.GetString("artistaproducao");

                listaProducao.Add(emProducao);

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
        return listaProducao;
    }
}

