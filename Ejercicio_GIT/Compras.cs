using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_GIT
{
    public class Compras
    {
        public Compras() { }
        DateTime fechaDeCompra { get; set; }
        int codProducto { get; set; }
        int cantidadCompra { get; set; }
        public Resultado RegistrarCompra(int codigo)
        {
            Resultado resultado = new Resultado();
            if ()
            {
                resultado.decision = true;
            }
            else
            {
                resultado.decision = false;
                resultado.mensaje = "El codigo no esta registrado";
            }
            return resultado;
        }
    }
}
