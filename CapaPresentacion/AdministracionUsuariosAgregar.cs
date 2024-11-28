using CapaLogica;
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
    public partial class AdministracionUsuariosAgregar : UserControl
    {
        Funcionario user;
        Ventana padre;
        public AdministracionUsuariosAgregar(Ventana padre, Funcionario user)
        {
            InitializeComponent();
            this.padre = padre;
            this.user = user;
        }

        public Funcionario obtener_datos_funcionario()
        {
            Funcionario nuevo_usuario = new Funcionario();

            nuevo_usuario.cedula = txt_cedula.Text;
            nuevo_usuario.nombre = txt_nombre.Text;
            nuevo_usuario.apellido = txt_apellido.Text;
            nuevo_usuario.direccion = txt_direccion.Text;
            nuevo_usuario.telefono = txt_telefono.Text;
            nuevo_usuario.correo = txt_correo.Text;
            nuevo_usuario.contrasena = txt_contrasena.Text;
            nuevo_usuario.activo = "Si";
            // nuevo_usuario.rol = int.Parse(txt_rol.Text);
            nuevo_usuario.rol = int.Parse(menu_rol.Text);

            return nuevo_usuario;
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            LAdministracion ladministracion = new LAdministracion();

            Funcionario nuevo_usuario = obtener_datos_funcionario();
            ladministracion.insertar_usuario(nuevo_usuario);

            txt_cedula.Text = string.Empty;
            txt_nombre.Text = string.Empty;
            txt_apellido.Text = string.Empty;
            txt_direccion.Text = string.Empty;
            txt_telefono.Text = string.Empty;
            txt_correo.Text = string.Empty;
            txt_contrasena.Text = string.Empty;
            // txt_rol.Text = string.Empty;
            menu_rol.Text = "0";
        }
    }
}
