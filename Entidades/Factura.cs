﻿using Entidades.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Factura:DocumentoComercial
    {
        public Factura() { }
        public Factura(string tipo, string numero, DateTime fecha, string cliente, string direccion, string condicionIVA, string condicionVenta, string detalle, decimal total)
        {
            Tipo=tipo;
            Numero=numero;
            Fecha=fecha;
            Cliente=cliente;
            Direccion=direccion;
            CondicionIVA=condicionIVA;
            CondicionVenta=condicionVenta;
            Detalle=detalle;
            Total=total;
        }
    
        public string Tipo { get; set; }
        //public string Numero { get; set; }
        //public DateTime Fecha { get; set; }
        //public string Cliente { get; set; }
        //public string Direccion { get; set; }
        //public string CondicionIVA { get; set; }
        //public string CondicionVenta { get; set; }
        //public string Detalle { get; set; }
        //public decimal Total { get; set; }

    }
}
