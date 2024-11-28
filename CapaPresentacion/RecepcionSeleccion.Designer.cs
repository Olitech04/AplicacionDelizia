namespace CapaPresentacion
{
    partial class RecepcionSeleccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecepcionSeleccion));
            btn_cancelar = new Button();
            btn_siguiente = new Button();
            pan_productos = new Panel();
            pictureBox2 = new PictureBox();
            pan_productos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(679, 360);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(75, 23);
            btn_cancelar.TabIndex = 0;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_siguiente
            // 
            btn_siguiente.BackColor = Color.Transparent;
            btn_siguiente.Location = new Point(679, 331);
            btn_siguiente.Name = "btn_siguiente";
            btn_siguiente.Size = new Size(75, 23);
            btn_siguiente.TabIndex = 1;
            btn_siguiente.Text = "Siguiente";
            btn_siguiente.UseVisualStyleBackColor = false;
            btn_siguiente.Click += btn_siguiente_Click;
            // 
            // pan_productos
            // 
            pan_productos.AutoScroll = true;
            pan_productos.AutoScrollMargin = new Size(10, 10);
            pan_productos.BackColor = Color.Transparent;
            pan_productos.BackgroundImage = Properties.Resources.panatalla_principal12;
            pan_productos.BackgroundImageLayout = ImageLayout.Center;
            pan_productos.Controls.Add(btn_siguiente);
            pan_productos.Controls.Add(btn_cancelar);
            pan_productos.Controls.Add(pictureBox2);
            pan_productos.Location = new Point(0, 0);
            pan_productos.Name = "pan_productos";
            pan_productos.Size = new Size(776, 396);
            pan_productos.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(663, 46);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(158, 199);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // RecepcionSeleccion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            BackgroundImageLayout = ImageLayout.Zoom;
            Controls.Add(pan_productos);
            Name = "RecepcionSeleccion";
            Size = new Size(776, 396);
            pan_productos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_cancelar;
        private Button btn_siguiente;
        private Panel pan_productos;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
