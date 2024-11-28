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
    public partial class RecepcionMenu : UserControl
    {
        Ventana padre;
        Funcionario user;
        public RecepcionMenu(Ventana padre, Funcionario user)
        {
            InitializeComponent();
            this.padre = padre;
            this.user = user;
        }

        private void btn_nuevopedido_Click(object sender, EventArgs e)
        {
            this.Dispose();
            padre.Controls.Remove(this);
            padre.Controls.Add(new RecepcionSeleccion(padre, user, null));
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            padre.Controls.Remove(this);
            padre.Controls.Add(new Login(padre));
        }
    }
}
