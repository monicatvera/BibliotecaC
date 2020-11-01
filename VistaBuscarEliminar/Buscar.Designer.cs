namespace Biblioteca.VistaBuscarEliminar
{
    partial class Buscar
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textDni = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.textRegistro = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textApellido1 = new System.Windows.Forms.TextBox();
            this.textApellido2 = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduce el DNI del alumno que desea buscar:";
            // 
            // textDni
            // 
            this.textDni.Location = new System.Drawing.Point(360, 51);
            this.textDni.Name = "textDni";
            this.textDni.Size = new System.Drawing.Size(162, 26);
            this.textDni.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(545, 45);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(129, 38);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // textRegistro
            // 
            this.textRegistro.Enabled = false;
            this.textRegistro.Location = new System.Drawing.Point(182, 113);
            this.textRegistro.Name = "textRegistro";
            this.textRegistro.Size = new System.Drawing.Size(123, 26);
            this.textRegistro.TabIndex = 3;
            // 
            // textNombre
            // 
            this.textNombre.Enabled = false;
            this.textNombre.Location = new System.Drawing.Point(472, 113);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(123, 26);
            this.textNombre.TabIndex = 4;
            // 
            // textApellido1
            // 
            this.textApellido1.Enabled = false;
            this.textApellido1.Location = new System.Drawing.Point(182, 184);
            this.textApellido1.Name = "textApellido1";
            this.textApellido1.Size = new System.Drawing.Size(123, 26);
            this.textApellido1.TabIndex = 5;
            // 
            // textApellido2
            // 
            this.textApellido2.Enabled = false;
            this.textApellido2.Location = new System.Drawing.Point(472, 184);
            this.textApellido2.Name = "textApellido2";
            this.textApellido2.Size = new System.Drawing.Size(123, 26);
            this.textApellido2.TabIndex = 6;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(224, 238);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(141, 57);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Registro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(401, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Primer Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(332, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Segundo Apellido";
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(405, 238);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(153, 57);
            this.btnMenu.TabIndex = 12;
            this.btnMenu.Text = "Menu Principal";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // Buscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 307);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.textApellido2);
            this.Controls.Add(this.textApellido1);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.textRegistro);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.textDni);
            this.Controls.Add(this.label1);
            this.Name = "Buscar";
            this.Text = "Buscar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textDni;
        public string GetTextDni() {
            return textDni.Text;
        
        }
        public void setTextDni(string Dni)
        {
            textDni.Text = Dni;
        }
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox textRegistro;
        public string GetTextRegistro()
        {
            return textRegistro.Text;

        }
        public void setTextRegistro(string Registro) {
            textRegistro.Text = Registro;
        }
        public System.Windows.Forms.TextBox gettextRegistro
        {
            get
            {
                return textRegistro;
            }
        }
        private System.Windows.Forms.TextBox textNombre;
        public void setTextNombre(string Nombre)
        {
            textNombre.Text = Nombre;
        }
        private System.Windows.Forms.TextBox textApellido1;
        public void setTextApellido1(string Apellido1)
        {
            textApellido1.Text = Apellido1;
        }
        private System.Windows.Forms.TextBox textApellido2;
        public void setTextApellido2(string Apellido2)
        {
            textApellido2.Text = Apellido2;
        }
        private System.Windows.Forms.Button btnEliminar;
        public System.Windows.Forms.Button BtnEliminar {
            get {
                return btnEliminar;
            }
        }
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnMenu;
        public System.Windows.Forms.Button BtnMenu { get => btnMenu; set => btnMenu = value; }
    }
}