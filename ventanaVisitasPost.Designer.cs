namespace proyectoTecnicas
{
    partial class ventanaVisitasPost
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
            this.comboNumHospital = new System.Windows.Forms.ComboBox();
            this.comboIDPaciente = new System.Windows.Forms.ComboBox();
            this.comboTipodChequeo = new System.Windows.Forms.ComboBox();
            this.comboEstadoHerida = new System.Windows.Forms.ComboBox();
            this.comboIdDoctor = new System.Windows.Forms.ComboBox();
            this.txtFecha = new System.Windows.Forms.DateTimePicker();
            this.txtMedicamento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRegistrarVisita = new System.Windows.Forms.Button();
            this.txtValorContrato = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboNumHospital
            // 
            this.comboNumHospital.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboNumHospital.FormattingEnabled = true;
            this.comboNumHospital.Location = new System.Drawing.Point(14, 54);
            this.comboNumHospital.Name = "comboNumHospital";
            this.comboNumHospital.Size = new System.Drawing.Size(121, 21);
            this.comboNumHospital.TabIndex = 1;
            this.comboNumHospital.SelectedIndexChanged += new System.EventHandler(this.comboNumHospital_SelectedIndexChanged);
            // 
            // comboIDPaciente
            // 
            this.comboIDPaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboIDPaciente.FormattingEnabled = true;
            this.comboIDPaciente.Location = new System.Drawing.Point(12, 112);
            this.comboIDPaciente.Name = "comboIDPaciente";
            this.comboIDPaciente.Size = new System.Drawing.Size(121, 21);
            this.comboIDPaciente.TabIndex = 2;
            // 
            // comboTipodChequeo
            // 
            this.comboTipodChequeo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipodChequeo.FormattingEnabled = true;
            this.comboTipodChequeo.Items.AddRange(new object[] {
            "Chequeo",
            "Retiro de puntos"});
            this.comboTipodChequeo.Location = new System.Drawing.Point(12, 155);
            this.comboTipodChequeo.Name = "comboTipodChequeo";
            this.comboTipodChequeo.Size = new System.Drawing.Size(121, 21);
            this.comboTipodChequeo.TabIndex = 3;
            // 
            // comboEstadoHerida
            // 
            this.comboEstadoHerida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEstadoHerida.FormattingEnabled = true;
            this.comboEstadoHerida.Items.AddRange(new object[] {
            "Leve",
            "Moderado",
            "Grave"});
            this.comboEstadoHerida.Location = new System.Drawing.Point(12, 193);
            this.comboEstadoHerida.Name = "comboEstadoHerida";
            this.comboEstadoHerida.Size = new System.Drawing.Size(121, 21);
            this.comboEstadoHerida.TabIndex = 4;
            // 
            // comboIdDoctor
            // 
            this.comboIdDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboIdDoctor.FormattingEnabled = true;
            this.comboIdDoctor.Location = new System.Drawing.Point(12, 235);
            this.comboIdDoctor.Name = "comboIdDoctor";
            this.comboIdDoctor.Size = new System.Drawing.Size(121, 21);
            this.comboIdDoctor.TabIndex = 5;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(12, 440);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(200, 20);
            this.txtFecha.TabIndex = 6;
            // 
            // txtMedicamento
            // 
            this.txtMedicamento.Location = new System.Drawing.Point(12, 314);
            this.txtMedicamento.Multiline = true;
            this.txtMedicamento.Name = "txtMedicamento";
            this.txtMedicamento.Size = new System.Drawing.Size(169, 89);
            this.txtMedicamento.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Número del hospital";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Identificación del paciente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tipo de chequeo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Estado de la herida";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Identificación del doctor";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Medicamentos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 415);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Fecha de la visita";
            // 
            // btnRegistrarVisita
            // 
            this.btnRegistrarVisita.Location = new System.Drawing.Point(208, 482);
            this.btnRegistrarVisita.Name = "btnRegistrarVisita";
            this.btnRegistrarVisita.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrarVisita.TabIndex = 15;
            this.btnRegistrarVisita.Text = "Asignar";
            this.btnRegistrarVisita.UseVisualStyleBackColor = true;
            this.btnRegistrarVisita.Click += new System.EventHandler(this.btnRegistrarVisita_Click);
            // 
            // txtValorContrato
            // 
            this.txtValorContrato.Location = new System.Drawing.Point(12, 275);
            this.txtValorContrato.Name = "txtValorContrato";
            this.txtValorContrato.Size = new System.Drawing.Size(169, 20);
            this.txtValorContrato.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Valor del contrato";
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(12, 482);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 18;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.button1_Click);
            // 
            // ventanaVisitasPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 517);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtValorContrato);
            this.Controls.Add(this.btnRegistrarVisita);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMedicamento);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.comboIdDoctor);
            this.Controls.Add(this.comboEstadoHerida);
            this.Controls.Add(this.comboTipodChequeo);
            this.Controls.Add(this.comboIDPaciente);
            this.Controls.Add(this.comboNumHospital);
            this.Name = "ventanaVisitasPost";
            this.Text = "ventanaVisitasPost";
            this.Load += new System.EventHandler(this.ventanaVisitasPost_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboNumHospital;
        private System.Windows.Forms.ComboBox comboIDPaciente;
        private System.Windows.Forms.ComboBox comboTipodChequeo;
        private System.Windows.Forms.ComboBox comboEstadoHerida;
        private System.Windows.Forms.ComboBox comboIdDoctor;
        private System.Windows.Forms.DateTimePicker txtFecha;
        private System.Windows.Forms.TextBox txtMedicamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRegistrarVisita;
        private System.Windows.Forms.TextBox txtValorContrato;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAtras;
    }
}