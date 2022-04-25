using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class cUsuario
{
    public static Usuario ObterUsuarioPeloNomeSenha(string nome, string senha) 
    {
        return ConsultasUsuario.ObterUsuarioPeloNomeSenha(nome,senha);
    }

    public static Usuario ObterEmailEsqueceuSenha(string email) 
    {
        return ConsultasUsuario.ObterEmailEsqueceuSenha(email);
    }

    public static bool RededefinirSenha(string email, string senha) 
    {
        return ConsultasUsuario.RedefinirSenha(email, senha);
    }
}

