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
}

