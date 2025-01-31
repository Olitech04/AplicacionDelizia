﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;

namespace CapaPresentacion
{
    public partial class RecepcionConfirmacion : UserControl
    {
        Ventana padre;
        Funcionario user;
        List<Producto> productos;
        List<RecepcionConfirmacionProducto> productos_graficos;
        public RecepcionConfirmacion(Ventana padre, Funcionario user, List<Producto> productos)
        {
            InitializeComponent();
            this.padre = padre;
            this.user = user;
            this.productos = productos;
            mostrar_productos(productos);
        }

        private void mostrar_productos(List<Producto> productos)
        {
            productos_graficos = new List<RecepcionConfirmacionProducto>();
            List<Producto> productos_seleccionados = new List<Producto>();
            int x = 3;
            int y = 3;
            foreach (Producto producto in productos)
            {
                if (producto.cantidad > 0)
                {
                    RecepcionConfirmacionProducto rp = new RecepcionConfirmacionProducto(producto);
                    y += 3 + rp.Height;
                    rp.Location = new Point(x, y);
                    productos_graficos.Add(rp);
                    productos_seleccionados.Add(producto);
                }
            }

            foreach (RecepcionConfirmacionProducto producto in productos_graficos)
            {
                this.pan_productos.Controls.Add(producto);
            }
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            // junta los datos del cliente
            string nombre = txt_nombre.Text;
            string apellido = txt_apellido.Text;
            string telefono = txt_telefono.Text;
            string direccion = txt_direccion.Text;

            // creamos un cliente nuevo
            Cliente nuevo_cliente = new Cliente();
            // le pasamos los datos
            nuevo_cliente.nombre = nombre;
            nuevo_cliente.apellido = apellido;
            nuevo_cliente.telefono = telefono;
            nuevo_cliente.direccion = direccion;

            LRecepcion lrecepcion = new LRecepcion();
            lrecepcion.insertar_cliente(nuevo_cliente);

            // seteamos el id del cliente
            nuevo_cliente.id = lrecepcion.obtener_id_cliente(nuevo_cliente);

            // Obtenemos los pedidos del producto
            List<Producto> productos_pedido = new List<Producto>();
            foreach (RecepcionConfirmacionProducto producto_grafico in productos_graficos)
            {
                productos_pedido.Add(producto_grafico.get_producto());
            }

            Pedido pedido = new Pedido();
            // recolectamos los datos para el pedido
            pedido.fecha = DateOnly.FromDateTime(DateTime.Now).ToString("yyyy-MM-dd");
            pedido.hora = TimeOnly.FromDateTime(DateTime.Now).ToString("HH:mm:ss");
            pedido.estado = 1;
            pedido.precio = 0;
            foreach (Producto p in productos_pedido)
            {
                pedido.precio += p.precio;
            }
            pedido.cliente = nuevo_cliente.id;
            // crea la consulta e inserta el pedido
            lrecepcion.insertar_pedido(pedido);
            pedido.id = lrecepcion.obtener_id_pedido(pedido);

            foreach (Producto p in productos_pedido)
            {
                lrecepcion.insertar_pedido_producto(pedido.id, p.id, p.cantidad);
            }

            // agregamos un dato al historial de actualizaciones
            lrecepcion.insertar_actualizacion_pedido(user.cedula, pedido.id, pedido.hora);

            // generamos el ticket
            lrecepcion.crear_ticket(pedido.fecha, pedido.hora, pedido.id);

            // antes de cambiar de ventada
            this.Dispose();
            padre.Controls.Remove(this);
            padre.Controls.Add(new RecepcionMenu(padre, user));
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            this.Dispose();
            padre.Controls.Remove(this);
            padre.Controls.Add(new RecepcionSeleccion(padre, user, productos));
        }

        private void pan_cliente_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_total_Click(object sender, EventArgs e)
        {

        }

        private void pan_detalles_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_telefono_Click(object sender, EventArgs e)
        {

        }

        private void txt_telefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_direccion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
