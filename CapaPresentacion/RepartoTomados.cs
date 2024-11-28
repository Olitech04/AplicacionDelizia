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
    public partial class RepartoTomados : UserControl
    {
        Funcionario user;
        Ventana padre;
        List<Pedido> pedidos;
        List<RepartoPedidoTomado> pedidos_graficos = new List<RepartoPedidoTomado>();
        public RepartoTomados(Ventana padre, Funcionario user)
        {
            InitializeComponent();
            this.padre = padre;
            this.user = user;

            pedidos = new List<Pedido>();

            LReparto lreparto = new LReparto();
            pedidos = lreparto.obtener_pedidos_tomados(user.cedula);

            mostrar_pedidos(pedidos);
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Dispose();
            padre.Controls.Remove(this);
            padre.Controls.Add(new RepartoMenu(padre, user));
        }

        // copia

        private void mostrar_pedidos(List<Pedido> pedidos)
        {
            int x = 5;
            int y = 20;
            int contador = 0;
            foreach (Pedido pedido in pedidos)
            {
                RepartoPedidoTomado cp = new RepartoPedidoTomado(this, pedido);
                if (contador % 5 == 0)
                {
                    if (contador == 0)
                    {
                        x = 5;
                        y = 20;
                    }
                    else
                    {
                        x = 5;
                        y += 5 + cp.Height;
                    }
                }
                else
                {
                    x += 5 + cp.Width;
                }
                cp.Location = new Point(x, y);
                contador++;
                pedidos_graficos.Add(cp);
            }

            foreach (RepartoPedidoTomado pedido in pedidos_graficos)
            {
                this.pan_pedidos.Controls.Add(pedido);
            }
        }

        public void actualizar_pantalla()
        {
            pan_pedidos.Controls.Clear();

            pedidos.Clear();
            pedidos_graficos.Clear();

            LReparto lreparto = new LReparto();
            pedidos = lreparto.obtener_pedidos_tomados(user.cedula);

            mostrar_pedidos(pedidos);
        }
    }
}
