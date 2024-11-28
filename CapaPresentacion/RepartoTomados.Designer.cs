namespace CapaPresentacion
{
    partial class RepartoTomados
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
            pan_pedidos = new Panel();
            btn_volver = new Button();
            SuspendLayout();
            // 
            // pan_pedidos
            // 
            pan_pedidos.AutoScroll = true;
            pan_pedidos.AutoScrollMargin = new Size(10, 10);
            pan_pedidos.BackgroundImage = Properties.Resources.ventana;
            pan_pedidos.BackgroundImageLayout = ImageLayout.Stretch;
            pan_pedidos.Location = new Point(0, 0);
            pan_pedidos.Name = "pan_pedidos";
            pan_pedidos.Size = new Size(776, 394);
            pan_pedidos.TabIndex = 5;
            // 
            // btn_volver
            // 
            btn_volver.Location = new Point(3, 400);
            btn_volver.Name = "btn_volver";
            btn_volver.Size = new Size(75, 23);
            btn_volver.TabIndex = 3;
            btn_volver.Text = "Atrás";
            btn_volver.UseVisualStyleBackColor = true;
            btn_volver.Click += btn_volver_Click;
            // 
            // RepartoTomados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pan_pedidos);
            Controls.Add(btn_volver);
            Name = "RepartoTomados";
            Size = new Size(776, 426);
            ResumeLayout(false);
        }

        #endregion

        private Panel pan_pedidos;
        private Button btn_volver;
    }
}
