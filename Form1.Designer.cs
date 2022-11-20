namespace proyectoTecnicas
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
            this.txtValorFiscal = new System.Windows.Forms.TextBox();
            this.txtAreaTerreno = new System.Windows.Forms.TextBox();
            this.txtDirecExacta = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtImagen = new System.Windows.Forms.TextBox();
            this.txtTiposdCirugia = new System.Windows.Forms.TextBox();
            this.txtCantConsultorios = new System.Windows.Forms.TextBox();
            this.txtCantNiveles = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.DateTimePicker();
            this.comboPronvincia = new System.Windows.Forms.ComboBox();
            this.comboCanton = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboDistrito = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.crearHospital = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtValorFiscal
            // 
            this.txtValorFiscal.Location = new System.Drawing.Point(72, 72);
            this.txtValorFiscal.Name = "txtValorFiscal";
            this.txtValorFiscal.Size = new System.Drawing.Size(100, 20);
            this.txtValorFiscal.TabIndex = 0;
            // 
            // txtAreaTerreno
            // 
            this.txtAreaTerreno.Location = new System.Drawing.Point(72, 115);
            this.txtAreaTerreno.Name = "txtAreaTerreno";
            this.txtAreaTerreno.Size = new System.Drawing.Size(100, 20);
            this.txtAreaTerreno.TabIndex = 1;
            // 
            // txtDirecExacta
            // 
            this.txtDirecExacta.Location = new System.Drawing.Point(72, 158);
            this.txtDirecExacta.Name = "txtDirecExacta";
            this.txtDirecExacta.Size = new System.Drawing.Size(100, 20);
            this.txtDirecExacta.TabIndex = 2;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(72, 391);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(100, 20);
            this.txtColor.TabIndex = 3;
            // 
            // txtImagen
            // 
            this.txtImagen.Location = new System.Drawing.Point(279, 482);
            this.txtImagen.Name = "txtImagen";
            this.txtImagen.Size = new System.Drawing.Size(100, 20);
            this.txtImagen.TabIndex = 4;
            // 
            // txtTiposdCirugia
            // 
            this.txtTiposdCirugia.Location = new System.Drawing.Point(72, 482);
            this.txtTiposdCirugia.Name = "txtTiposdCirugia";
            this.txtTiposdCirugia.Size = new System.Drawing.Size(100, 20);
            this.txtTiposdCirugia.TabIndex = 5;
            // 
            // txtCantConsultorios
            // 
            this.txtCantConsultorios.Location = new System.Drawing.Point(72, 440);
            this.txtCantConsultorios.Name = "txtCantConsultorios";
            this.txtCantConsultorios.Size = new System.Drawing.Size(100, 20);
            this.txtCantConsultorios.TabIndex = 6;
            // 
            // txtCantNiveles
            // 
            this.txtCantNiveles.Location = new System.Drawing.Point(72, 347);
            this.txtCantNiveles.Name = "txtCantNiveles";
            this.txtCantNiveles.Size = new System.Drawing.Size(100, 20);
            this.txtCantNiveles.TabIndex = 7;
            this.txtCantNiveles.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(444, 482);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(200, 20);
            this.txtFecha.TabIndex = 8;
            this.txtFecha.Value = new System.DateTime(2001, 1, 1, 0, 1, 0, 0);
            // 
            // comboPronvincia
            // 
            this.comboPronvincia.FormattingEnabled = true;
            this.comboPronvincia.Items.AddRange(new object[] {
            "San Jose"});
            this.comboPronvincia.Location = new System.Drawing.Point(72, 205);
            this.comboPronvincia.Name = "comboPronvincia";
            this.comboPronvincia.Size = new System.Drawing.Size(100, 21);
            this.comboPronvincia.TabIndex = 9;
            // 
            // comboCanton
            // 
            this.comboCanton.FormattingEnabled = true;
            this.comboCanton.Items.AddRange(new object[] {
            "Central"});
            this.comboCanton.Location = new System.Drawing.Point(72, 256);
            this.comboCanton.Name = "comboCanton";
            this.comboCanton.Size = new System.Drawing.Size(100, 21);
            this.comboCanton.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Valor Fiscal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Area Terreno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Direccion exacta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Distrito\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Provincia";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(103, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Canton\r\n";
            // 
            // comboDistrito
            // 
            this.comboDistrito.FormattingEnabled = true;
            this.comboDistrito.Items.AddRange(new object[] {
            "Uruca"});
            this.comboDistrito.Location = new System.Drawing.Point(72, 296);
            this.comboDistrito.Name = "comboDistrito";
            this.comboDistrito.Size = new System.Drawing.Size(100, 21);
            this.comboDistrito.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Cantidad Niveles";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(74, 375);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Color\r\n";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(69, 414);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Cantidad de Consultorios\r\n";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(85, 466);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Tipos de Cirugia\r\n";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(299, 466);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Imagen\r\n";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(460, 466);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "anoConstruccion\r\n";
            // 
            // crearHospital
            // 
            this.crearHospital.Location = new System.Drawing.Point(471, 334);
            this.crearHospital.Name = "crearHospital";
            this.crearHospital.Size = new System.Drawing.Size(111, 54);
            this.crearHospital.TabIndex = 23;
            this.crearHospital.Text = "Agregar";
            this.crearHospital.UseVisualStyleBackColor = true;
            this.crearHospital.Click += new System.EventHandler(this.crearHospital_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 534);
            this.Controls.Add(this.crearHospital);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboDistrito);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboCanton);
            this.Controls.Add(this.comboPronvincia);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtCantNiveles);
            this.Controls.Add(this.txtCantConsultorios);
            this.Controls.Add(this.txtTiposdCirugia);
            this.Controls.Add(this.txtImagen);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtDirecExacta);
            this.Controls.Add(this.txtAreaTerreno);
            this.Controls.Add(this.txtValorFiscal);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Registro de Hospitales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValorFiscal;
        private System.Windows.Forms.TextBox txtAreaTerreno;
        private System.Windows.Forms.TextBox txtDirecExacta;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtImagen;
        private System.Windows.Forms.TextBox txtTiposdCirugia;
        private System.Windows.Forms.TextBox txtCantConsultorios;
        private System.Windows.Forms.TextBox txtCantNiveles;
        private System.Windows.Forms.DateTimePicker txtFecha;
        private System.Windows.Forms.ComboBox comboPronvincia;
        private System.Windows.Forms.ComboBox comboCanton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboDistrito;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button crearHospital;
    }
}

