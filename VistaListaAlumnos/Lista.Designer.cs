namespace Biblioteca.VistaListaAlumnos
{
    partial class Lista
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
            this.dataGridViewAlumnos = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAlumnos
            // 
            this.dataGridViewAlumnos.AllowDrop = true;
            this.dataGridViewAlumnos.AllowUserToAddRows = false;
            this.dataGridViewAlumnos.AllowUserToDeleteRows = false;
            this.dataGridViewAlumnos.AllowUserToResizeRows = false;
            this.dataGridViewAlumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAlumnos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewAlumnos.ColumnHeadersHeight = 46;
            this.dataGridViewAlumnos.GridColor = System.Drawing.SystemColors.Highlight;
            this.dataGridViewAlumnos.Location = new System.Drawing.Point(12, 49);
            this.dataGridViewAlumnos.Name = "dataGridViewAlumnos";
            this.dataGridViewAlumnos.ReadOnly = true;
            this.dataGridViewAlumnos.RowHeadersWidth = 82;
            this.dataGridViewAlumnos.RowTemplate.Height = 33;
            this.dataGridViewAlumnos.Size = new System.Drawing.Size(801, 287);
            this.dataGridViewAlumnos.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(632, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Menu Principal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewAlumnos);
            this.Name = "Lista";
            this.Text = "Lista";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlumnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAlumnos;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button Button1 { get => button1; set => button1 = value; }
        public System.Windows.Forms.DataGridView viewAlumnos
        {
            get 
            {
                return dataGridViewAlumnos;
            }
        }
    }
}