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
            this.txtValorFiscal.Location = new System.Drawing.Point(12, 127);
            this.txtValorFiscal.Name = "txtValorFiscal";
            this.txtValorFiscal.Size = new System.Drawing.Size(100, 20);
            this.txtValorFiscal.TabIndex = 0;
            // 
            // txtAreaTerreno
            // 
            this.txtAreaTerreno.Location = new System.Drawing.Point(12, 166);
            this.txtAreaTerreno.Name = "txtAreaTerreno";
            this.txtAreaTerreno.Size = new System.Drawing.Size(100, 20);
            this.txtAreaTerreno.TabIndex = 1;
            // 
            // txtDirecExacta
            // 
            this.txtDirecExacta.Location = new System.Drawing.Point(12, 214);
            this.txtDirecExacta.Name = "txtDirecExacta";
            this.txtDirecExacta.Size = new System.Drawing.Size(100, 20);
            this.txtDirecExacta.TabIndex = 2;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(12, 412);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(100, 20);
            this.txtColor.TabIndex = 3;
            // 
            // txtImagen
            // 
            this.txtImagen.Location = new System.Drawing.Point(516, 111);
            this.txtImagen.Name = "txtImagen";
            this.txtImagen.Size = new System.Drawing.Size(100, 20);
            this.txtImagen.TabIndex = 4;
            // 
            // txtTiposdCirugia
            // 
            this.txtTiposdCirugia.Location = new System.Drawing.Point(12, 505);
            this.txtTiposdCirugia.Name = "txtTiposdCirugia";
            this.txtTiposdCirugia.Size = new System.Drawing.Size(100, 20);
            this.txtTiposdCirugia.TabIndex = 5;
            // 
            // txtCantConsultorios
            // 
            this.txtCantConsultorios.Location = new System.Drawing.Point(12, 462);
            this.txtCantConsultorios.Name = "txtCantConsultorios";
            this.txtCantConsultorios.Size = new System.Drawing.Size(100, 20);
            this.txtCantConsultorios.TabIndex = 6;
            // 
            // txtCantNiveles
            // 
            this.txtCantNiveles.Location = new System.Drawing.Point(12, 373);
            this.txtCantNiveles.Name = "txtCantNiveles";
            this.txtCantNiveles.Size = new System.Drawing.Size(100, 20);
            this.txtCantNiveles.TabIndex = 7;
            this.txtCantNiveles.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(12, 544);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 20);
            this.txtFecha.TabIndex = 8;
            this.txtFecha.Value = new System.DateTime(2001, 1, 1, 0, 1, 0, 0);
            // 
            // comboPronvincia
            // 
            this.comboPronvincia.FormattingEnabled = true;
            this.comboPronvincia.Items.AddRange(new object[] {
            "Alajuela",
            "Cartago",
            "Guanacaste",
            "Heredia",
            "Limón",
            "Puntarenas",
            "San Jose"});
            this.comboPronvincia.Location = new System.Drawing.Point(12, 253);
            this.comboPronvincia.Name = "comboPronvincia";
            this.comboPronvincia.Size = new System.Drawing.Size(100, 21);
            this.comboPronvincia.TabIndex = 9;
            // 
            // comboCanton
            // 
            this.comboCanton.FormattingEnabled = true;
            this.comboCanton.Items.AddRange(new object[] {
            "Central",
            "",
            "Liberia",
            "Escazú",
            "San Ramón",
            "Paraíso",
            "Barva",
            "Nicoya",
            "Esparza",
            "Pococí",
            "Desamparados",
            "Grecia",
            "La Unión",
            "Santo Domingo",
            "Santa Cruz",
            "Buenos Aires",
            "Siquirres",
            "Puriscal",
            "San Mateo",
            "Jiménez",
            "Santa Bárbara",
            "Bagaces",
            "Montes de Oro",
            "Talamanca",
            "Tarrazú",
            "Atenas",
            "Turrialba",
            "San Rafael",
            "Carrillo",
            "Osa",
            "Matina",
            "Aserrí",
            "Naranjo",
            "Alvarado",
            "San Isidro",
            "Cañas",
            "Quepos",
            "Guácimo",
            "Mora",
            "Palmares",
            "Oreamuno",
            "Belén",
            "Abangares",
            "Golfito",
            "Goicoechea",
            "Poás",
            "El Guarco",
            "Flores",
            "Tilarán",
            "Coto Brus",
            "Santa Ana",
            "Orotina",
            "San Pablo",
            "Nandayure",
            "Parrita",
            "Alajuelita",
            "San Carlos",
            "Sarapiquí",
            "La Cruz",
            "Corredores",
            "Vásquez de Coronado",
            "Zarcero",
            "Hojancha",
            "Garabito",
            "Acosta",
            "Sarchí",
            "Tibás",
            "Upala",
            "Moravia",
            "Los Chiles",
            "Montes de Oca",
            "Guatuso",
            "Turrubares",
            "Río Cuarto",
            "Dota",
            "Currridabat",
            "Pérez Zeledón",
            "León Cortés",
            ""});
            this.comboCanton.Location = new System.Drawing.Point(12, 293);
            this.comboCanton.Name = "comboCanton";
            this.comboCanton.Size = new System.Drawing.Size(100, 21);
            this.comboCanton.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Valor Fiscal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Area Terreno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Direccion exacta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Distrito\r\n";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Provincia";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Canton\r\n";
            // 
            // comboDistrito
            // 
            this.comboDistrito.FormattingEnabled = true;
            this.comboDistrito.Items.AddRange(new object[] {
            "Uruca",
            "Naranjo\t",
            "San Miguel\t",
            "San José\t",
            "Cirrí Sur\t",
            "San Jerónimo\t",
            "San Juan\t",
            "El Rosario\t",
            "Palmitos\t",
            "Palmares\t",
            "Zaragoza\t",
            "Buenos Aires\t",
            "Santiago\t",
            "Candelaria\t",
            "Esquipulas\t",
            "La Granja\t",
            "San Pedro\t",
            "San Juan\t",
            "San Rafael",
            "Carrillos",
            "Sabana Redonda\t",
            "Orotina",
            "El Mastate\t",
            "Hacienda Vieja\t",
            "Coyolar\t",
            "La Ceiba",
            "Quesada\t\t",
            "Florencia\t",
            "Buenavista\t",
            "Aguas Zarcas\t",
            "Venecia",
            "Pital\t",
            "La Fortuna\t",
            "La Tigra\t",
            "La Palmera\t",
            "Venado\t",
            "Cutris\t",
            "Monterrey\t",
            "Pocosol\t",
            "Zarcero\t",
            "Laguna\t",
            "Tapesco",
            "Guadalupe\t",
            "Palmira\t",
            "Zapote\t",
            "Brisas\t",
            "Sarchí Norte\t",
            "Sarchí Sur\t",
            "Toro Amarillo\t",
            "San Pedro\t",
            "Rodríguez\t",
            "Upala",
            "Aguas Claras\t\t",
            "Bijagua\t",
            "Delicias\t",
            "Dos Ríos\t",
            "Yolillal\t",
            "Canalete\t\t\t",
            "Los Chiles\t",
            "Caño Negro\t",
            "El Amparo\t",
            "San Jorge\t",
            "San Rafael\t",
            "Buenavista\t",
            "Cote",
            "Katira",
            "Río Cuarto\t\t\t\t\t\t",
            "Santa Rita\t\t\t\t\t\t\t",
            "Santa Isabel\t\t\t\t\t\t",
            "Oriental\t",
            "Occidental",
            "Carmen",
            "San Nicolás\t",
            "Aguacaliente\t",
            "Guadalupe\t",
            "Corralillo\t",
            "Tierra Blanca\t",
            "Dulce Nombre\t",
            "Llano Grande\t",
            "Quebradilla\t",
            "Paraíso\t",
            "Santiago\t",
            "Orosi\t",
            "Cachí\t",
            "Llanos de Santa Lucía\t",
            "Birrisito\t\t\t\t\t",
            "Tres Ríos\t",
            "San Diego\t",
            "San Juan\t",
            "San Rafael\t",
            "Concepción\t",
            "Dulce Nombre\t",
            "San Ramón\t",
            "Río Azul\t",
            "Juan Viñas\t",
            "Tucurrique\t",
            "Pejibaye\t",
            "La Victoria\t\t\t\t\t",
            "Turrialba\t",
            "La Suiza\t",
            "Peralta",
            "Santa Cruz\t",
            "Santa Teresita\t",
            "Pavones\t",
            "Tuis\t",
            "Tayutic",
            "Santa Rosa\t",
            "Tres Equis\t",
            "La Isabel\t",
            "Chirripó\t",
            "Pacayas",
            "Cervantes\t",
            "Capellades\t",
            "San Rafael",
            "Cot\t",
            "Potrero Cerrado\t",
            "Cipreses\t",
            "Santa Rosa\t",
            "El Tejar\t",
            "San Isidro",
            "Tobosi\t30803\t",
            "Patio de Agua\t",
            "Mercedes\t",
            "San Francisco\t",
            "Ulloa\t",
            "Varablanca\t",
            "Barva",
            "San Pedro\t",
            "San Pablo\t",
            "San Roque\t",
            "Santa Lucía\t",
            "San José de la Montña\t",
            "Santo Domingo",
            "San Vicente\t",
            "San Miguel",
            "Paracito\t",
            "Santo Tomás\t",
            "Santa Rosa\t",
            "Tures\t",
            "Pará\t",
            "Santa Bárbara\t",
            "San Pedro\t",
            "San Juan\t",
            "Jesús\t",
            "Santo Domingo\t",
            "Purabá\t",
            "San Rafael\t",
            "San Josecito\t",
            "Santiago\t",
            "Ángeles\t",
            "Concepción\t",
            "San Isidro\t",
            "San José\t",
            "Concepción\t",
            "San Francisco\t",
            "San Antonio\t",
            "La Ribera\t",
            "La Asunción\t",
            "San Joaquín\t",
            "Barrantes\t",
            "Llorente",
            "San Pablo",
            "Rincón de Sabanilla\t",
            "Puerto Viejo\t",
            "La Virgen\t",
            "Las Horquetas\t",
            "Llanuras del Gaspar\t",
            "Cureña\t",
            "Liberia\t\t",
            "Cañas Dulces\t",
            "Mayorga\t",
            "Nacascolo\t",
            "Curubandé\t",
            "Nicoya\t",
            "Mansión",
            "San Antonio\t",
            "Quebrada Honda\t",
            "Sámara\t",
            "Nosara\t",
            "Belén de Nosarita\t",
            "",
            "Santa Cruz\t",
            "Bolsón\t",
            "Veintisiete de Abril\t",
            "Tempate\t\t",
            "Cartagena\t",
            "Cuajiniquil\t",
            "Diriá\t",
            "Cabo Velas\t",
            "Tamarindo\t",
            "",
            "Bagaces",
            "La Fortuna\t",
            "Mogote\t\t",
            "Río Naranjo\t",
            "Filadelfia",
            "Palmira",
            "Sardinal\t",
            "Belén\t",
            "Cañas",
            "Palmira",
            "San Miguel\t",
            "Bebedero\t",
            "Porozal\t",
            "",
            "Las Juntas\t",
            "Sierra\t",
            "San Juan\t",
            "Colorado\t",
            "Tilarán\t",
            "Quebrada Grande",
            "Tronadora\t",
            "Santa Rosa\t",
            "Líbano",
            "Tierras Morenas\t",
            "Arenal\t",
            "Cabeceras\t\t\t\t",
            "Carmona",
            "Santa Rita\t",
            "Zapotal",
            "San Pablo\t",
            "Porvenir\t",
            "Bejuco\t",
            "La Cruz",
            "Santa Cecilia\t",
            "La Garita\t",
            "Santa Elena\t",
            "Hojancha\t",
            "Monte Romo\t",
            "Puerto Carrillo\t",
            "Huacas\t",
            "Matambú\t\t\t\t\t",
            "Pitahaya\t",
            "Chomes\t",
            "Lepanto\t",
            "Paquera\t",
            "Manzanillo\t",
            "Guacimal\t",
            "Barranca\t",
            "Monte Verde\t",
            "Isla del Coco\t\t\t\t",
            "Cóbano\t",
            "Chacarita\t",
            "Chira",
            "Acapulco\t",
            "El Roble\t",
            "Arancibia\t",
            "Espíritu Santo\t",
            "San Juan Grande\t",
            "Macacona\t",
            "San Rafael\t",
            "San Jerónimo\t",
            "Caldera\t\t\t\t\t",
            "Buenos Aires",
            "Volcán",
            "Potrero Grande",
            "Boruca\t",
            "Pilas\t",
            "Colinas\t",
            "Chánguena\t",
            "Biolley\t",
            "Brunka",
            "Miramar",
            "La Unión\t",
            "San Isidro\t",
            "Puerto Cortés",
            "Palmar\t",
            "Sierpe\t",
            "Bahía Ballena\t",
            "Piedras Blancas\t",
            "Bahía Drake\t\t\t\t\t",
            "",
            "Quepos\t",
            "Savegre\t",
            "Naranjito",
            "Golfito\t",
            "Puerto Jiménez\t",
            "Guaycará\t",
            "Pavón\t",
            "San Vito\t",
            "Sabalito\t",
            "Aguabuena\t",
            "Limoncito\t",
            "Pittier\t",
            "Gutiérrez Braun\t\t\t\t",
            "Parrita\t",
            "Corredor\t",
            "La Cuesta\t",
            "Canoas\t",
            "Laurel",
            "Jacó\t",
            "Tárcoles\t",
            "Lagunillas\t\t\t\t\t\t\t",
            "Valle La Estrella",
            "Río Blanco\t",
            "Matama\t",
            "Guápiles\t",
            "Jiménez\t",
            "Rita\t",
            "Roxana",
            "Cariari\t",
            "Colorado\t",
            "La Colonia\t",
            "Siquirres\t",
            "Pacuarito\t",
            "Florida\t",
            "Germania\t",
            "El Cairo\t",
            "Alegría",
            "Reventazón\t\t\t\t\t\t",
            "Bratsi\t",
            "Sixaola\t",
            "Cahuita\t",
            "Telire\t",
            "Matina\t",
            "Batán",
            "Carrandi",
            "Guácimo\t",
            "Mercedes\t",
            "Pocora\t",
            "Río Jiménez",
            "Duacarí\t"});
            this.comboDistrito.Location = new System.Drawing.Point(12, 333);
            this.comboDistrito.Name = "comboDistrito";
            this.comboDistrito.Size = new System.Drawing.Size(100, 21);
            this.comboDistrito.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 357);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Cantidad Niveles";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 396);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Color\r\n";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 435);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Cantidad de Consultorios\r\n";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 486);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Tipos de Cirugia\r\n";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(550, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Imagen\r\n";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 528);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Año de construcción";
            // 
            // crearHospital
            // 
            this.crearHospital.Location = new System.Drawing.Point(130, 561);
            this.crearHospital.Name = "crearHospital";
            this.crearHospital.Size = new System.Drawing.Size(76, 36);
            this.crearHospital.TabIndex = 23;
            this.crearHospital.Text = "Agregar";
            this.crearHospital.UseVisualStyleBackColor = true;
            this.crearHospital.Click += new System.EventHandler(this.crearHospital_Click);
            this.crearHospital.MouseLeave += new System.EventHandler(this.crearHospital_MouseLeave);
            this.crearHospital.MouseHover += new System.EventHandler(this.crearHospital_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::proyectoTecnicas.Properties.Resources.Registra_Tu_hospital__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(641, 609);
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
            this.DoubleBuffered = true;
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

