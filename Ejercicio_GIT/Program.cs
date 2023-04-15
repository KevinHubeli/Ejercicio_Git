using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_GIT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Una empresa necesita manejar el listado de productos y la compra de cada uno de ellos..
            //De cada producto se conoce el código numérico, nombre, stock, precio unitario y
            //tipo(electrodomésticos, muebles, insumos).
            //Usar un enumerador para manejar el tipo de producto.

            //A su vez se deben registrar las compras que realice la empresa, con la fecha de compra,
            //código de producto y cantidad comprada.

            //Al momento de registrar una compra se debe recibir el código de producto y validar
            //que el código de producto pasado como parámetro exista(En caso de existir se debe
            //retornar un valor booleano = true, en caso que no exista un valor booleano = false y
            //un mensaje que indique el motivo)

            //Obtener luego:
            //A partir de un código de producto, cuanto es el stock actual.
            //Buscar los nombres de productos cuyo stock sea menor a un valor ingresado por parámetro.
            //Obtener todos los datos del producto que mayor cantidad de stock tiene.
            //Buscar la última compra(la más nueva) de un producto pasado como parámetro.

            //Mínimamente se debe dividir el trabajo en 4 commits correctamente detallados.

            Console.WriteLine("El listado de productos y la compra de cada producto");
            bool salir = true;
            Compras producto = new Compras();
            List<Empresa> listaProducto = new List<Empresa>();

            while (salir)
            {
                Console.WriteLine("Ingrese el codigo numerico:");
                int codNum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el Nombre del producto:");
                string nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el stock:");
                int stock = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el Precio por unidad:");
                decimal precioUnit = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Ingrese el tipo:");
                int cod = Convert.ToInt32(Console.ReadLine());
                Tipos codTipo = (Tipos)cod;

                Empresa listaPro = new Empresa(codNum, nombre, stock, precioUnit, codTipo);
                listaProducto.Add(listaPro);

                Console.WriteLine("Desea registrar una compra:");
                bool decision = Convert.ToBoolean(Console.ReadKey());
                if (decision == true)
                {
                    Console.WriteLine("El codigo del producto:");
                    producto.RegistrarCompra(codNum);
                    listaPro.ContarStock(codNum, stock);
                }
                








            }

        }
    }
}
