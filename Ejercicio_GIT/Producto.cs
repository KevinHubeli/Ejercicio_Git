using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_GIT
{
    public class Producto
    {

        public Producto(int codNum, string nombre,int stock,decimal precioUnit,Tipos codTipo) {
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

        public Producto ContarStock(int codigo)
        {
            Producto stockEncontrado = Codigo.Find(p => p.Codigo == codigo);
            return stockEncontrado;
        }
        public int BuscarNombre(int valorPorParametro) 
        {
            Producto nombreProductos = Stock.FindAll(p => p.Stock < valorPorParametro)
                .Select(p => p.Nombre)
                .To.List();

            return nombreProductos;
        }
        public void MayorCantidad()
        {
            Producto ProductoMayor = Stock.OrderByDescending(p => p.Stock).FirstOrDefault();

        }

    }
}
