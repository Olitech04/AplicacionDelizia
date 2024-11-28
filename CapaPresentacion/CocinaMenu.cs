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
    public partial class CocinaMenu : UserControl
    {
        Ventana padre;
        Funcionario user;
        public CocinaMenu(Ventana padre, Funcionario user)
        {
            InitializeComponent();
            this.padre = padre;
            this.user = user;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            padre.Controls.Remove(this);
            padre.Controls.Add(new Login(padre));
        }

        private void btn_verpedidos_Click(object sender, EventArgs e)
        {
            this.Dispose();
            padre.Controls.Remove(this);
            padre.Controls.Add(new CocinaPedidos(padre, user));
        }

        private void CocinaMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
