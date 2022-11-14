using Entidades.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Remito:DocumentoComercial
    { 
        public Remito(string numero, DateTime feha, string cliente, string direccion, string condicionIVA, string condicionVenta, string detalle, DateTime fechaEntrega, decimal total)
        {
            Numero=numero;
            Feha=feha;
            Cliente=cliente;
            Direccion=direccion;
            CondicionIVA=condicionIVA;
            CondicionVenta=condicionVenta;
            Detalle=detalle;
            FechaEntrega=fechaEntrega;
            Total=total;
        }

         //public string Numero { get; set; }
        public DateTime Feha { get; set; }
        //public string Cliente { get; set; }
        //public string Direccion { get; set; }
        //public string CondicionIVA { get; set; }
        //public string CondicionVenta { get; set; }
        //public string Detalle { get; set; }
        public DateTime FechaEntrega { get; set; }
        //public decimal Total { get; set; }
    }
}
