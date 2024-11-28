namespace CapaPresentacion
{
    partial class RepartoMenu
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_mis_pedidos = new Button();
            btn_tomar_pedidos = new Button();
            btn_salir = new Button();
            SuspendLayout();
            // 
            // btn_mis_pedidos
            // 
            btn_mis_pedidos.BackColor = Color.DarkGray;
            btn_mis_pedidos.Location = new Point(333, 148);
            btn_mis_pedidos.Name = "btn_mis_pedidos";
            btn_mis_pedidos.Size = new Size(132, 54);
            btn_mis_pedidos.TabIndex = 0;
            btn_mis_pedidos.Text = "Mis pedidos";
            btn_mis_pedidos.UseVisualStyleBackColor = false;
            btn_mis_pedidos.Click += btn_mis_pedidos_Click;
            // 
            // btn_tomar_pedidos
            // 
            btn_tomar_pedidos.BackColor = Color.DarkGray;
            btn_tomar_pedidos.Location = new Point(333, 248);
            btn_tomar_pedidos.Name = "btn_tomar_pedidos";
            btn_tomar_pedidos.Size = new Size(132, 58);
            btn_tomar_pedidos.TabIndex = 1;
            btn_tomar_pedidos.Text = "Tomar pedidos";
            btn_tomar_pedidos.UseVisualStyleBackColor = false;
            btn_tomar_pedidos.Click += btn_tomar_pedidos_Click;
            // 
            // btn_salir
            // 
            btn_salir.Location = new Point(732, 10);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(31, 23);
            btn_salir.TabIndex = 2;
            btn_salir.Text = "X";
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += btn_salir_Click;
            // 
            // RepartoMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ventana;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(btn_salir);
            Controls.Add(btn_tomar_pedidos);
            Controls.Add(btn_mis_pedidos);
            DoubleBuffered = true;
            Name = "RepartoMenu";
            Size = new Size(776, 426);
            ResumeLayout(false);
        }

        #endregion

        private Button btn_mis_pedidos;
        private Button btn_tomar_pedidos;
        private Button btn_salir;
    }
}
