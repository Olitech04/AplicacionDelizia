namespace CapaPresentacion
{
    partial class RecepcionMenu
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
            btn_nuevopedido = new Button();
            btn_salir = new Button();
            SuspendLayout();
            // 
            // btn_nuevopedido
            // 
            btn_nuevopedido.Location = new Point(321, 167);
            btn_nuevopedido.Name = "btn_nuevopedido";
            btn_nuevopedido.Size = new Size(135, 43);
            btn_nuevopedido.TabIndex = 0;
            btn_nuevopedido.Text = "Nuevo pedido";
            btn_nuevopedido.UseVisualStyleBackColor = true;
            btn_nuevopedido.Click += btn_nuevopedido_Click;
            // 
            // btn_salir
            // 
            btn_salir.Location = new Point(321, 244);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(135, 40);
            btn_salir.TabIndex = 1;
            btn_salir.Text = "volver";
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += btn_salir_Click;
            // 
            // RecepcionMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ventana;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(btn_salir);
            Controls.Add(btn_nuevopedido);
            DoubleBuffered = true;
            Name = "RecepcionMenu";
            Size = new Size(776, 426);
            ResumeLayout(false);
        }

        #endregion

        private Button btn_nuevopedido;
        private Button btn_salir;
    }
}
