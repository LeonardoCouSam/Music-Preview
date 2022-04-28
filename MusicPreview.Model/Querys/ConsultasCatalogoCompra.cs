using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using System.Data;
 public class ConsultasCatalogoCompra
 {
    public static List<CatalogoCompra> CatalogoCompras()
    {
        var conexao = new MySqlConnection(ConnectionBD.Connection.ConnectionString);
        List<CatalogoCompra> musicavendas = new List<CatalogoCompra>();

        try
        {
            conexao.Open();
            var comando = conexao.CreateCommand();


            comando.CommandText = @"SELECT * FROM Catalogo";
            var leitura = comando.ExecuteReader();
            while (leitura.Read())
            {
                CatalogoCompra shop = new CatalogoCompra();
                shop.id_catalogo = leitura.GetInt32("id_catalogo");
                shop.preco = leitura.GetString("preco");
                shop.musica_compra = leitura.GetString("musica_compra");
                shop.artista_compra = leitura.GetString("artista_compra");


                musicavendas.Add(shop);

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
        return musicavendas;
    }
}

