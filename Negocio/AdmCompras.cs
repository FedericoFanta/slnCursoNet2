using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class AdmCompras
    {
        public string AgregarProducto (Producto item,int Cantidad, Producto producto)
        {
            item=producto;
            return $"Producto nuevo: {producto.Nombre}";
        }

        public string Modificar (int Cantidad)
        {

            return $"Modificado";
        }

        public string Eliminar (string Nombre)
        {
            string result = null;   
            return result;
        }

        public string Confirmar (Vendedor vendedor)
        {
            return $"Confirmado";
        }

        public string Cancelar()
        {
            return null;
        }
    }
}
