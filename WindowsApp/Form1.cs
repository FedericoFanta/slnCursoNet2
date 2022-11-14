using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInstanciar_Click(object sender, EventArgs e)
        {
            ClienteEmpresa clienteEmpresa = new ClienteEmpresa("Ramon", "125622", "ramon@hotmail.com", "(0223)5892", "Peyerman", "Direccion123") {  };
            MessageBox.Show($"Cliente Empresa:\n {clienteEmpresa.Nombre} \n {clienteEmpresa.CUIT} \n {clienteEmpresa.Contacto} \n {clienteEmpresa.Direccion} \n {clienteEmpresa.Telefono} \n {clienteEmpresa.Email}");

            ClienteIndividuo clienteIndividuo = new ClienteIndividuo("PEPE", "324234", "PEPE@HOTMAIL.COM", "(0023)555", "Acevedo", "Dirreccion 123") { };
            MessageBox.Show($"Cliente Individuo:\n {clienteIndividuo.Nombre} \n {clienteIndividuo.CUIT} \n {clienteIndividuo.Direccion} \n {clienteIndividuo.Contacto} \n {clienteIndividuo.Telefono} \n {clienteIndividuo.Email}");


            
            Factura factura = new Factura();
            //propiedades 
            factura.Tipo = "A123";
            factura.Numero = "4666";
            factura.Cliente = "Edwardo";
            factura.Direccion = "lalala 123";
            factura.Fecha = new DateTime(1990, 2, 4);

            MessageBox.Show($"Factura: \n {factura.Tipo} \n {factura.Numero} \n {factura.Direccion} \n {factura.Fecha}" );

            Producto producto = new Producto("Morsilla", "Carniceria", 152, 022, 0.21, "German SA", "Alimentos", "Parilla") { };

            MessageBox.Show($"Producto: \n {producto.Nombre} \n {producto.Descripcion} \n {producto.PrecioCosto} \n {producto.Margen} \n {producto.IVA} \n {producto.Proveedor}");

            





            
        }

        
    }
}
