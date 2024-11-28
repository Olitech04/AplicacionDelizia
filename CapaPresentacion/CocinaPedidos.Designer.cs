namespace CapaPresentacion
{
    partial class CocinaPedidos
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
            btn_volver = new Button();
            pan_pedidos = new Panel();
            SuspendLayout();
            // 
            // btn_volver
            // 
            btn_volver.Location = new Point(3, 400);
            btn_volver.Name = "btn_volver";
            btn_volver.Size = new Size(75, 23);
            btn_volver.TabIndex = 0;
            btn_volver.Text = "Volver";
            btn_volver.UseVisualStyleBackColor = true;
            btn_volver.Click += btn_volver_Click;
            // 
            // pan_pedidos
            // 
            pan_pedidos.BackgroundImage = Properties.Resources.ventana;
            pan_pedidos.BackgroundImageLayout = ImageLayout.Stretch;
            pan_pedidos.Location = new Point(3, 3);
            pan_pedidos.Name = "pan_pedidos";
            pan_pedidos.Size = new Size(770, 391);
            pan_pedidos.TabIndex = 1;
            // 
            // CocinaPedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pan_pedidos);
            Controls.Add(btn_volver);
            Name = "CocinaPedidos";
            Size = new Size(776, 426);
            ResumeLayout(false);
        }

        #endregion

        private Button btn_volver;
        private Panel pan_pedidos;
    }
}
