using System;
using System.Collections.Generic;
using System.Linq;
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
        public Empresa(int codNum, string nombre, int stock, decimal precioUnit, Tipos codTipo)
        {
            Codigo = codNum;
            Nombre = nombre;
            Stock = stock;
            PrecioUnitario = precioUnit;
            tipo = codTipo;
        }
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public int Stock { get; set; }
        public decimal PrecioUnitario { get; set; }
        public Tipos tipo { get; set; }

        
        public int ContarStock(int codigo, int Stock)
        {
            
            return
        }
    }
}
