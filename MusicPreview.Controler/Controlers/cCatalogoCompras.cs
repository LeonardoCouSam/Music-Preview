using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class cCatalogoCompras
{
    public static List<CatalogoCompra> CatalogoCompras()
    {
        return ConsultasCatalogoCompra.CatalogoCompras();
    }
}

