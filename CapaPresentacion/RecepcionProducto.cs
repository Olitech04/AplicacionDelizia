﻿using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class RecepcionProducto : UserControl
    {
        public Producto producto;
        public RecepcionProducto(Producto producto)
        {
            InitializeComponent();
            this.producto = producto;
            actualizar_informacion();
        }

        public void actualizar_informacion()
        {
            lbl_nombre.Text = producto.nombre;
            lbl_cantidad.Text = producto.cantidad.ToString();
            lbl_precio.Text = "$" + producto.precio;
        }

        private void btn_sumar_Click(object sender, EventArgs e)
        {
            producto.cantidad += 1;
            lbl_cantidad.Text = producto.cantidad.ToString();
        }

        private void btn_restar_Click(object sender, EventArgs e)
        {
            if (producto.cantidad >= 1)
            {
                producto.cantidad -= 1;
                lbl_cantidad.Text = producto.cantidad.ToString();
            }
        }

        private void lbl_nombre_Click(object sender, EventArgs e)
        {

        }
    }
}
