namespace CapaPresentacion
{
    partial class AdministracionUsuariosAgregar
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
            panel1 = new Panel();
            panel4 = new Panel();
            label11 = new Label();
            label5 = new Label();
            menu_rol = new NumericUpDown();
            btn_activo_si = new RadioButton();
            btn_activo_no = new RadioButton();
            lbl_activo = new Label();
            panel3 = new Panel();
            label10 = new Label();
            label8 = new Label();
            label4 = new Label();
            txt_correo = new TextBox();
            label7 = new Label();
            txt_contrasena = new TextBox();
            txt_telefono = new TextBox();
            btn_ingresar = new Button();
            panel2 = new Panel();
            label9 = new Label();
            label1 = new Label();
            txt_cedula = new TextBox();
            label2 = new Label();
            txt_nombre = new TextBox();
            label3 = new Label();
            txt_apellido = new TextBox();
            label6 = new Label();
            txt_direccion = new TextBox();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menu_rol).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.ventana_de_pedido2;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(btn_ingresar);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(770, 420);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveBorder;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label11);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(menu_rol);
            panel4.Controls.Add(btn_activo_si);
            panel4.Controls.Add(btn_activo_no);
            panel4.Controls.Add(lbl_activo);
            panel4.Location = new Point(394, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(373, 153);
            panel4.TabIndex = 24;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(10, 19);
            label11.Name = "label11";
            label11.Size = new Size(108, 15);
            label11.TabIndex = 23;
            label11.Text = "Sobre sus permisos";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 34);
            label5.Name = "label5";
            label5.Size = new Size(24, 15);
            label5.TabIndex = 12;
            label5.Text = "Rol";
            // 
            // menu_rol
            // 
            menu_rol.BackColor = Color.Silver;
            menu_rol.Location = new Point(40, 37);
            menu_rol.Name = "menu_rol";
            menu_rol.Size = new Size(43, 23);
            menu_rol.TabIndex = 20;
            // 
            // btn_activo_si
            // 
            btn_activo_si.AutoSize = true;
            btn_activo_si.Location = new Point(10, 119);
            btn_activo_si.Name = "btn_activo_si";
            btn_activo_si.Size = new Size(34, 19);
            btn_activo_si.TabIndex = 17;
            btn_activo_si.TabStop = true;
            btn_activo_si.Text = "Sí";
            btn_activo_si.UseVisualStyleBackColor = true;
            // 
            // btn_activo_no
            // 
            btn_activo_no.AutoSize = true;
            btn_activo_no.Location = new Point(50, 119);
            btn_activo_no.Name = "btn_activo_no";
            btn_activo_no.Size = new Size(41, 19);
            btn_activo_no.TabIndex = 18;
            btn_activo_no.TabStop = true;
            btn_activo_no.Text = "No";
            btn_activo_no.UseVisualStyleBackColor = true;
            // 
            // lbl_activo
            // 
            lbl_activo.AutoSize = true;
            lbl_activo.Location = new Point(22, 101);
            lbl_activo.Name = "lbl_activo";
            lbl_activo.Size = new Size(41, 15);
            lbl_activo.TabIndex = 19;
            lbl_activo.Text = "Activo";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveBorder;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(txt_correo);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(txt_contrasena);
            panel3.Controls.Add(txt_telefono);
            panel3.Location = new Point(394, 178);
            panel3.Name = "panel3";
            panel3.Size = new Size(373, 195);
            panel3.TabIndex = 23;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(10, 10);
            label10.Name = "label10";
            label10.Size = new Size(85, 15);
            label10.TabIndex = 22;
            label10.Text = "Datos de inicio";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(10, 42);
            label8.Name = "label8";
            label8.Size = new Size(53, 15);
            label8.TabIndex = 14;
            label8.Text = "Teléfono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 86);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 6;
            label4.Text = "Correo";
            // 
            // txt_correo
            // 
            txt_correo.BackColor = Color.Silver;
            txt_correo.Location = new Point(10, 104);
            txt_correo.Name = "txt_correo";
            txt_correo.Size = new Size(225, 23);
            txt_correo.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 130);
            label7.Name = "label7";
            label7.Size = new Size(67, 15);
            label7.TabIndex = 8;
            label7.Text = "Contraseña";
            // 
            // txt_contrasena
            // 
            txt_contrasena.BackColor = Color.Silver;
            txt_contrasena.Location = new Point(10, 148);
            txt_contrasena.Name = "txt_contrasena";
            txt_contrasena.Size = new Size(225, 23);
            txt_contrasena.TabIndex = 9;
            // 
            // txt_telefono
            // 
            txt_telefono.BackColor = Color.Silver;
            txt_telefono.Location = new Point(10, 60);
            txt_telefono.Name = "txt_telefono";
            txt_telefono.Size = new Size(225, 23);
            txt_telefono.TabIndex = 15;
            // 
            // btn_ingresar
            // 
            btn_ingresar.Location = new Point(692, 394);
            btn_ingresar.Name = "btn_ingresar";
            btn_ingresar.Size = new Size(75, 23);
            btn_ingresar.TabIndex = 16;
            btn_ingresar.Text = "Crear usuario";
            btn_ingresar.UseVisualStyleBackColor = true;
            btn_ingresar.Click += btn_ingresar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveBorder;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txt_cedula);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txt_nombre);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txt_apellido);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txt_direccion);
            panel2.Location = new Point(3, 82);
            panel2.Name = "panel2";
            panel2.Size = new Size(373, 255);
            panel2.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(10, 10);
            label9.Name = "label9";
            label9.Size = new Size(96, 15);
            label9.TabIndex = 22;
            label9.Text = "Datos personales";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 42);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Cédula";
            // 
            // txt_cedula
            // 
            txt_cedula.BackColor = Color.Silver;
            txt_cedula.Location = new Point(10, 60);
            txt_cedula.Name = "txt_cedula";
            txt_cedula.Size = new Size(225, 23);
            txt_cedula.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 86);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // txt_nombre
            // 
            txt_nombre.BackColor = Color.Silver;
            txt_nombre.Location = new Point(10, 104);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(225, 23);
            txt_nombre.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 130);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 4;
            label3.Text = "Apellido";
            // 
            // txt_apellido
            // 
            txt_apellido.BackColor = Color.Silver;
            txt_apellido.Location = new Point(10, 148);
            txt_apellido.Name = "txt_apellido";
            txt_apellido.Size = new Size(225, 23);
            txt_apellido.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 174);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 10;
            label6.Text = "Dirección";
            // 
            // txt_direccion
            // 
            txt_direccion.BackColor = Color.Silver;
            txt_direccion.Location = new Point(10, 192);
            txt_direccion.Name = "txt_direccion";
            txt_direccion.Size = new Size(225, 23);
            txt_direccion.TabIndex = 11;
            // 
            // AdministracionUsuariosAgregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "AdministracionUsuariosAgregar";
            Size = new Size(776, 426);
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)menu_rol).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private TextBox txt_direccion;
        private Label label6;
        private TextBox txt_contrasena;
        private Label label7;
        private TextBox txt_correo;
        private Label label4;
        private TextBox txt_apellido;
        private Label label3;
        private TextBox txt_nombre;
        private Label label2;
        private TextBox txt_cedula;
        private Label label1;
        private TextBox txt_telefono;
        private Label label8;
        private Button btn_ingresar;
        private RadioButton btn_activo_no;
        private RadioButton btn_activo_si;
        private NumericUpDown menu_rol;
        private Label lbl_activo;
        private Panel panel4;
        private Panel panel3;
        private Label label10;
        private Panel panel2;
        private Label label9;
        private Label label11;
    }
}
