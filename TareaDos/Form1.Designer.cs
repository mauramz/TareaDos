namespace TareaDos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cajaTexto = new System.Windows.Forms.TextBox();
            this.botonAgregar = new System.Windows.Forms.Button();
            this.dGVPrincipal = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGVNumeros = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGVLetras = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dGVPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVNumeros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVLetras)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite el valor a ingresar";
            // 
            // cajaTexto
            // 
            this.cajaTexto.Location = new System.Drawing.Point(158, 23);
            this.cajaTexto.Name = "cajaTexto";
            this.cajaTexto.Size = new System.Drawing.Size(100, 20);
            this.cajaTexto.TabIndex = 1;
            // 
            // botonAgregar
            // 
            this.botonAgregar.Location = new System.Drawing.Point(313, 21);
            this.botonAgregar.Name = "botonAgregar";
            this.botonAgregar.Size = new System.Drawing.Size(75, 23);
            this.botonAgregar.TabIndex = 2;
            this.botonAgregar.Text = "&Agregar";
            this.botonAgregar.UseVisualStyleBackColor = true;
            this.botonAgregar.Click += new System.EventHandler(this.botonAgregar_Click);
            // 
            // dGVPrincipal
            // 
            this.dGVPrincipal.AllowUserToAddRows = false;
            this.dGVPrincipal.AllowUserToDeleteRows = false;
            this.dGVPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVPrincipal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dGVPrincipal.Location = new System.Drawing.Point(25, 70);
            this.dGVPrincipal.Name = "dGVPrincipal";
            this.dGVPrincipal.ReadOnly = true;
            this.dGVPrincipal.RowHeadersVisible = false;
            this.dGVPrincipal.Size = new System.Drawing.Size(105, 440);
            this.dGVPrincipal.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Principal";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // dGVNumeros
            // 
            this.dGVNumeros.AllowUserToAddRows = false;
            this.dGVNumeros.AllowUserToDeleteRows = false;
            this.dGVNumeros.AllowUserToOrderColumns = true;
            this.dGVNumeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVNumeros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2});
            this.dGVNumeros.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dGVNumeros.Location = new System.Drawing.Point(153, 70);
            this.dGVNumeros.Name = "dGVNumeros";
            this.dGVNumeros.ReadOnly = true;
            this.dGVNumeros.RowHeadersVisible = false;
            this.dGVNumeros.Size = new System.Drawing.Size(105, 300);
            this.dGVNumeros.TabIndex = 4;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Números";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // dGVLetras
            // 
            this.dGVLetras.AllowUserToAddRows = false;
            this.dGVLetras.AllowUserToDeleteRows = false;
            this.dGVLetras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVLetras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3});
            this.dGVLetras.Location = new System.Drawing.Point(283, 70);
            this.dGVLetras.Name = "dGVLetras";
            this.dGVLetras.ReadOnly = true;
            this.dGVLetras.RowHeadersVisible = false;
            this.dGVLetras.Size = new System.Drawing.Size(105, 300);
            this.dGVLetras.TabIndex = 5;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Letras";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(283, 439);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Actualiza";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 519);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dGVLetras);
            this.Controls.Add(this.dGVNumeros);
            this.Controls.Add(this.dGVPrincipal);
            this.Controls.Add(this.botonAgregar);
            this.Controls.Add(this.cajaTexto);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tarea Dos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVNumeros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVLetras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cajaTexto;
        private System.Windows.Forms.Button botonAgregar;
        private System.Windows.Forms.DataGridView dGVPrincipal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView dGVNumeros;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridView dGVLetras;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}

