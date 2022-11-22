namespace proyectoTecnicas
{
    partial class ventanaPaciente
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.selectEstado = new System.Windows.Forms.ComboBox();
            this.btnCrearPersona = new System.Windows.Forms.Button();
            this.checkPatologia = new System.Windows.Forms.CheckBox();
            this.checkContrato = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(70, 69);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(70, 208);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 1;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(70, 114);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 2;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(70, 161);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(100, 20);
            this.txtCorreo.TabIndex = 3;
            // 
            // selectEstado
            // 
            this.selectEstado.FormattingEnabled = true;
            this.selectEstado.Items.AddRange(new object[] {
            "Casado",
            "Soltero",
            "Viudo"});
            this.selectEstado.Location = new System.Drawing.Point(70, 253);
            this.selectEstado.Name = "selectEstado";
            this.selectEstado.Size = new System.Drawing.Size(121, 21);
            this.selectEstado.TabIndex = 4;
            // 
            // btnCrearPersona
            // 
            this.btnCrearPersona.Location = new System.Drawing.Point(70, 377);
            this.btnCrearPersona.Name = "btnCrearPersona";
            this.btnCrearPersona.Size = new System.Drawing.Size(116, 35);
            this.btnCrearPersona.TabIndex = 5;
            this.btnCrearPersona.Text = "Agregar";
            this.btnCrearPersona.UseVisualStyleBackColor = true;
            this.btnCrearPersona.Click += new System.EventHandler(this.btnCrearPersona_Click);
            // 
            // checkPatologia
            // 
            this.checkPatologia.AutoSize = true;
            this.checkPatologia.Location = new System.Drawing.Point(70, 303);
            this.checkPatologia.Name = "checkPatologia";
            this.checkPatologia.Size = new System.Drawing.Size(104, 17);
            this.checkPatologia.TabIndex = 6;
            this.checkPatologia.Text = "Firmó el contrato";
            this.checkPatologia.UseVisualStyleBackColor = true;
            // 
            // checkContrato
            // 
            this.checkContrato.AutoSize = true;
            this.checkContrato.Location = new System.Drawing.Point(70, 338);
            this.checkContrato.Name = "checkContrato";
            this.checkContrato.Size = new System.Drawing.Size(125, 17);
            this.checkContrato.TabIndex = 7;
            this.checkContrato.Text = "Posee una patología";
            this.checkContrato.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre del paciente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Apellido del paciente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Correo del paciente";
            // 
            // ventanaPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkContrato);
            this.Controls.Add(this.checkPatologia);
            this.Controls.Add(this.btnCrearPersona);
            this.Controls.Add(this.selectEstado);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtNombre);
            this.Name = "ventanaPaciente";
            this.Text = "ventanaPaciente";
            this.Load += new System.EventHandler(this.ventanaPaciente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.ComboBox selectEstado;
        private System.Windows.Forms.Button btnCrearPersona;
        private System.Windows.Forms.CheckBox checkPatologia;
        private System.Windows.Forms.CheckBox checkContrato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}