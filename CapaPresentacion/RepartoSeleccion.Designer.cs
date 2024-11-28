namespace CapaPresentacion
{
    partial class RepartoSeleccion
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
            pan_pedidos.BackColor = Color.FromArgb(65, 65, 65);
            pan_pedidos.BackgroundImage = Properties.Resources.ventana;
            pan_pedidos.BackgroundImageLayout = ImageLayout.Stretch;
            pan_pedidos.Location = new Point(0, 0);
            pan_pedidos.Name = "pan_pedidos";
            pan_pedidos.Size = new Size(776, 372);
            pan_pedidos.TabIndex = 7;
            // 
            // btn_volver
            // 
            btn_volver.BackColor = SystemColors.ActiveBorder;
            btn_volver.FlatStyle = FlatStyle.Popup;
            btn_volver.Font = new Font("Microsoft Sans Serif", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_volver.ForeColor = SystemColors.ControlLightLight;
            btn_volver.Location = new Point(3, 378);
            btn_volver.Name = "btn_volver";
            btn_volver.Size = new Size(77, 29);
            btn_volver.TabIndex = 6;
            btn_volver.Text = "<<";
            btn_volver.UseVisualStyleBackColor = false;
            btn_volver.Click += btn_volver_Click;
            // 
            // RepartoSeleccion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pan_pedidos);
            Controls.Add(btn_volver);
            Name = "RepartoSeleccion";
            Size = new Size(776, 426);
            ResumeLayout(false);
        }

        #endregion

        private Panel pan_pedidos;
        private Button btn_volver;
    }
}
