namespace CapaPresentacion
{
    partial class Login
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
            lbl_cedula = new Label();
            lbl_contrasena = new Label();
            txt_cedula = new TextBox();
            txt_contrasena = new TextBox();
            btn_cancelar = new Button();
            btn_entrar = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lbl_cedula
            // 
            lbl_cedula.AutoSize = true;
            lbl_cedula.BackColor = Color.Transparent;
            lbl_cedula.Location = new Point(289, 220);
            lbl_cedula.Name = "lbl_cedula";
            lbl_cedula.Size = new Size(44, 15);
            lbl_cedula.TabIndex = 0;
            lbl_cedula.Text = "Cédula";
            lbl_cedula.Click += lbl_cedula_Click;
            // 
            // lbl_contrasena
            // 
            lbl_contrasena.AutoSize = true;
            lbl_contrasena.BackColor = Color.Transparent;
            lbl_contrasena.Location = new Point(266, 259);
            lbl_contrasena.Name = "lbl_contrasena";
            lbl_contrasena.Size = new Size(67, 15);
            lbl_contrasena.TabIndex = 1;
            lbl_contrasena.Text = "Contraseña";
            // 
            // txt_cedula
            // 
            txt_cedula.Location = new Point(339, 217);
            txt_cedula.Name = "txt_cedula";
            txt_cedula.Size = new Size(100, 23);
            txt_cedula.TabIndex = 2;
            // 
            // txt_contrasena
            // 
            txt_contrasena.Location = new Point(339, 256);
            txt_contrasena.Name = "txt_contrasena";
            txt_contrasena.Size = new Size(100, 23);
            txt_contrasena.TabIndex = 3;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(737, 6);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(24, 23);
            btn_cancelar.TabIndex = 4;
            btn_cancelar.Text = "X";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_entrar
            // 
            btn_entrar.Location = new Point(351, 285);
            btn_entrar.Name = "btn_entrar";
            btn_entrar.Size = new Size(75, 23);
            btn_entrar.TabIndex = 5;
            btn_entrar.Text = "Iniciar Sesión";
            btn_entrar.UseVisualStyleBackColor = true;
            btn_entrar.Click += btn_entrar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(103, -58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(517, 255);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(339, 91);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 97);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // Login
            // 
            AccessibleRole = AccessibleRole.None;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = Properties.Resources.panatalla_principal12;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lbl_cedula);
            Controls.Add(btn_entrar);
            Controls.Add(btn_cancelar);
            Controls.Add(txt_contrasena);
            Controls.Add(lbl_contrasena);
            Controls.Add(txt_cedula);
            DoubleBuffered = true;
            Name = "Login";
            Size = new Size(776, 426);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_cedula;
        private Label lbl_contrasena;
        private TextBox txt_cedula;
        private TextBox txt_contrasena;
        private Button btn_cancelar;
        private Button btn_entrar;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
