﻿namespace CapaPresentacion
{
    partial class RecepcionProducto
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
            lbl_nombre = new Label();
            btn_restar = new Button();
            btn_sumar = new Button();
            lbl_cantidad = new Label();
            lbl_precio = new Label();
            SuspendLayout();
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Location = new Point(42, 9);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(122, 15);
            lbl_nombre.TabIndex = 0;
            lbl_nombre.Text = "Nombre del producto";
            lbl_nombre.Click += lbl_nombre_Click;
            // 
            // btn_restar
            // 
            btn_restar.Location = new Point(57, 67);
            btn_restar.Name = "btn_restar";
            btn_restar.Size = new Size(23, 23);
            btn_restar.TabIndex = 1;
            btn_restar.Text = "-";
            btn_restar.UseVisualStyleBackColor = true;
            btn_restar.Click += btn_restar_Click;
            // 
            // btn_sumar
            // 
            btn_sumar.Location = new Point(109, 67);
            btn_sumar.Name = "btn_sumar";
            btn_sumar.Size = new Size(23, 23);
            btn_sumar.TabIndex = 2;
            btn_sumar.Text = "+";
            btn_sumar.UseVisualStyleBackColor = true;
            btn_sumar.Click += btn_sumar_Click;
            // 
            // lbl_cantidad
            // 
            lbl_cantidad.AutoSize = true;
            lbl_cantidad.Location = new Point(86, 71);
            lbl_cantidad.Name = "lbl_cantidad";
            lbl_cantidad.Size = new Size(13, 15);
            lbl_cantidad.TabIndex = 3;
            lbl_cantidad.Text = "0";
            // 
            // lbl_precio
            // 
            lbl_precio.AutoSize = true;
            lbl_precio.Location = new Point(76, 44);
            lbl_precio.Name = "lbl_precio";
            lbl_precio.Size = new Size(46, 15);
            lbl_precio.TabIndex = 4;
            lbl_precio.Text = "$Precio";
            // 
            // RecepcionProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImageLayout = ImageLayout.None;
            Controls.Add(lbl_precio);
            Controls.Add(lbl_cantidad);
            Controls.Add(btn_sumar);
            Controls.Add(btn_restar);
            Controls.Add(lbl_nombre);
            DoubleBuffered = true;
            Name = "RecepcionProducto";
            Size = new Size(200, 103);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_nombre;
        private Button btn_restar;
        private Button btn_sumar;
        private Label lbl_cantidad;
        private Label lbl_precio;
    }
}
