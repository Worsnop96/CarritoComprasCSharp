using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarritoCompras
{
    public partial class Form1 : Form
    {
        double precioFinal = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboProductos.Items.Add("Pantalon");
            cboProductos.Items.Add("Camisa");
            cboProductos.Items.Add("Zapatos");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string productoSeleccionado = cboProductos.SelectedItem.ToString();
            listCarritoCompras.Items.Add(productoSeleccionado);
        }

        private void btnListProductos_Click(object sender, EventArgs e)
        {
            
            int totalProductosCargados = listCarritoCompras.Items.Count;

            for(int i =0; i < totalProductosCargados; i++)
            {
                string productoElegido = listCarritoCompras.Items[i].ToString();
                if (productoElegido == "Pantalon")
                {
                    precioFinal += 20;

                }if (productoElegido == "Camisa")
                {
                    precioFinal += 35;
                }
                if(productoElegido== "Zapatos")
                {
                    precioFinal += 24;
                }
                
            }
            MessageBox.Show("el total de sus productos es " + precioFinal);
        }

        private void btnDescuento_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;
            if(codigo == "NAVIDAD")
            {
                precioFinal = precioFinal * 0.90;
                MessageBox.Show("el total de sus productos es " + precioFinal);
            }
            else
            {
                MessageBox.Show("codigo invalido");
                MessageBox.Show("el total de sus productos es " + precioFinal);
            }
        }
    }
}
