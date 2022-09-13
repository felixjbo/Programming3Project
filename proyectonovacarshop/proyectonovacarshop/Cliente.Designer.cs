namespace Factura
{
    partial class Cliente
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
            this.label2_cedula = new System.Windows.Forms.Label();
            this.label3_Nombre = new System.Windows.Forms.Label();
            this.txt_NombreCliente = new System.Windows.Forms.TextBox();
            this.BTNIngresar = new System.Windows.Forms.Button();
            this.txt_Apellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Telefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Empresa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Cedula = new System.Windows.Forms.MaskedTextBox();
            this.txt_EstadoCivil = new System.Windows.Forms.ComboBox();
            this.txt_genero = new System.Windows.Forms.ComboBox();
            this.txt_tipo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2_cedula
            // 
            this.label2_cedula.AutoSize = true;
            this.label2_cedula.ForeColor = System.Drawing.Color.Yellow;
            this.label2_cedula.Location = new System.Drawing.Point(31, 60);
            this.label2_cedula.Name = "label2_cedula";
            this.label2_cedula.Size = new System.Drawing.Size(40, 13);
            this.label2_cedula.TabIndex = 1;
            this.label2_cedula.Text = "Cedula";
            // 
            // label3_Nombre
            // 
            this.label3_Nombre.AutoSize = true;
            this.label3_Nombre.ForeColor = System.Drawing.Color.Yellow;
            this.label3_Nombre.Location = new System.Drawing.Point(18, 129);
            this.label3_Nombre.Name = "label3_Nombre";
            this.label3_Nombre.Size = new System.Drawing.Size(44, 13);
            this.label3_Nombre.TabIndex = 2;
            this.label3_Nombre.Text = "Nombre";
            this.label3_Nombre.Click += new System.EventHandler(this.label3_Nombre_Click);
            // 
            // txt_NombreCliente
            // 
            this.txt_NombreCliente.Location = new System.Drawing.Point(85, 126);
            this.txt_NombreCliente.Name = "txt_NombreCliente";
            this.txt_NombreCliente.Size = new System.Drawing.Size(185, 20);
            this.txt_NombreCliente.TabIndex = 4;
            this.txt_NombreCliente.TextChanged += new System.EventHandler(this.txt_NombreCliente_TextChanged);
            // 
            // BTNIngresar
            // 
            this.BTNIngresar.BackColor = System.Drawing.SystemColors.MenuText;
            this.BTNIngresar.Location = new System.Drawing.Point(114, 364);
            this.BTNIngresar.Name = "BTNIngresar";
            this.BTNIngresar.Size = new System.Drawing.Size(75, 23);
            this.BTNIngresar.TabIndex = 6;
            this.BTNIngresar.Text = "Ingresar";
            this.BTNIngresar.UseVisualStyleBackColor = false;
            this.BTNIngresar.Click += new System.EventHandler(this.BTNIngresar_Click);
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Location = new System.Drawing.Point(85, 174);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(185, 20);
            this.txt_Apellido.TabIndex = 8;
            this.txt_Apellido.TextChanged += new System.EventHandler(this.txt_Apellido_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(18, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Apellidos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(18, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Genero";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(18, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Estado Civil";
            // 
            // txt_Telefono
            // 
            this.txt_Telefono.Location = new System.Drawing.Point(85, 290);
            this.txt_Telefono.Name = "txt_Telefono";
            this.txt_Telefono.Size = new System.Drawing.Size(185, 20);
            this.txt_Telefono.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(18, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Telefono";
            // 
            // txt_Empresa
            // 
            this.txt_Empresa.Enabled = false;
            this.txt_Empresa.Location = new System.Drawing.Point(85, 327);
            this.txt_Empresa.Name = "txt_Empresa";
            this.txt_Empresa.Size = new System.Drawing.Size(185, 20);
            this.txt_Empresa.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(18, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Empresa";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Cedula);
            this.groupBox1.Controls.Add(this.txt_EstadoCivil);
            this.groupBox1.Controls.Add(this.txt_genero);
            this.groupBox1.Controls.Add(this.txt_tipo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_Empresa);
            this.groupBox1.Controls.Add(this.BTNIngresar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_NombreCliente);
            this.groupBox1.Controls.Add(this.txt_Telefono);
            this.groupBox1.Controls.Add(this.label3_Nombre);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_Apellido);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 402);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txt_Cedula
            // 
            this.txt_Cedula.Location = new System.Drawing.Point(85, 47);
            this.txt_Cedula.Mask = "0-0000-0000";
            this.txt_Cedula.Name = "txt_Cedula";
            this.txt_Cedula.Size = new System.Drawing.Size(185, 20);
            this.txt_Cedula.TabIndex = 21;
            // 
            // txt_EstadoCivil
            // 
            this.txt_EstadoCivil.FormattingEnabled = true;
            this.txt_EstadoCivil.Items.AddRange(new object[] {
            "Solter@",
            "Casad@",
            "Viud@"});
            this.txt_EstadoCivil.Location = new System.Drawing.Point(85, 250);
            this.txt_EstadoCivil.Name = "txt_EstadoCivil";
            this.txt_EstadoCivil.Size = new System.Drawing.Size(185, 21);
            this.txt_EstadoCivil.TabIndex = 20;
            // 
            // txt_genero
            // 
            this.txt_genero.FormattingEnabled = true;
            this.txt_genero.Items.AddRange(new object[] {
            "M",
            "F"});
            this.txt_genero.Location = new System.Drawing.Point(86, 211);
            this.txt_genero.Name = "txt_genero";
            this.txt_genero.Size = new System.Drawing.Size(184, 21);
            this.txt_genero.TabIndex = 19;
            // 
            // txt_tipo
            // 
            this.txt_tipo.FormattingEnabled = true;
            this.txt_tipo.Items.AddRange(new object[] {
            "Costarrincense",
            "Extranjero"});
            this.txt_tipo.Location = new System.Drawing.Point(86, 89);
            this.txt_tipo.Name = "txt_tipo";
            this.txt_tipo.Size = new System.Drawing.Size(184, 21);
            this.txt_tipo.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(16, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Tipo Cedula";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(370, 435);
            this.Controls.Add(this.label2_cedula);
            this.Controls.Add(this.groupBox1);
            this.Name = "Cliente";
            this.Text = "Cliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2_cedula;
        private System.Windows.Forms.Label label3_Nombre;
        private System.Windows.Forms.TextBox txt_NombreCliente;
        private System.Windows.Forms.Button BTNIngresar;
        private System.Windows.Forms.TextBox txt_Apellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Telefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Empresa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox txt_tipo;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.ComboBox txt_EstadoCivil;
        private System.Windows.Forms.ComboBox txt_genero;
        private System.Windows.Forms.MaskedTextBox txt_Cedula;
    }
}