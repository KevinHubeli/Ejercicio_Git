using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_GIT
{
    public enum Tipos
    {
        Electrodomesticos = 1,
        Muebles,
        Insumos,
    }
    public class Empresa
    {
        public List<Producto> productos { get; set; }
        public List<Compras> compras { get; set; }
        
        
    }
}
