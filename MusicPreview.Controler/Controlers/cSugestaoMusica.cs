using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class cSugestaoMusica
{
    public static List<SugestaoMusica> ObterTodasSugestoes()
    {
        return ConsultasSugestaoMusica.ObterTodasSugestoes();
    }

    public static bool NovaMusica(string nomeMusica, string nomeArtista)
    {
        return ConsultasSugestaoMusica.InserirMusica(nomeMusica, nomeArtista);
    }
}