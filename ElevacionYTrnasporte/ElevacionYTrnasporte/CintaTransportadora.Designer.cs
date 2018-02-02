namespace ElevacionYTrnasporte
{
    partial class CintaTransportadora
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
            this.capacidadTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.IMtxt = new System.Windows.Forms.TextBox();
            this.condicionTxt = new System.Windows.Forms.ComboBox();
            this.alimentacionBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Tamañomin = new System.Windows.Forms.ComboBox();
            this.Tamañomax = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.abrasividad = new System.Windows.Forms.ComboBox();
            this.respuesta = new System.Windows.Forms.Label();
            this.inclinacionBox = new System.Windows.Forms.ComboBox();
            this.resultTxt = new System.Windows.Forms.TextBox();
            this.angureposo = new System.Windows.Forms.ComboBox();
            this.pesobox = new System.Windows.Forms.ComboBox();
            this.utilizacionTxt = new System.Windows.Forms.ComboBox();
            this.utiltxt = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.distanciaEjesBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // capacidadTxt
            // 
            this.capacidadTxt.Location = new System.Drawing.Point(210, 55);
            this.capacidadTxt.Name = "capacidadTxt";
            this.capacidadTxt.Size = new System.Drawing.Size(153, 20);
            this.capacidadTxt.TabIndex = 0;
            this.capacidadTxt.Text = "1000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Capasidad";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(41, 190);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(137, 20);
            this.textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(210, 190);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(153, 20);
            this.textBox4.TabIndex = 5;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Exotc350 Bd BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(184, 22);
            this.label9.TabIndex = 16;
            this.label9.Text = "Cinta Transportadora";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // IMtxt
            // 
            this.IMtxt.Location = new System.Drawing.Point(210, 91);
            this.IMtxt.Name = "IMtxt";
            this.IMtxt.Size = new System.Drawing.Size(153, 20);
            this.IMtxt.TabIndex = 27;
            this.IMtxt.Text = "833";
            // 
            // condicionTxt
            // 
            this.condicionTxt.FormattingEnabled = true;
            this.condicionTxt.Items.AddRange(new object[] {
            "Limpio y con mantenimiento regular.",
            "Con presencia de material abrasivo o muy corrosivo.",
            "Con presencia de material muy abrasivo o corrosivo."});
            this.condicionTxt.Location = new System.Drawing.Point(554, 90);
            this.condicionTxt.Name = "condicionTxt";
            this.condicionTxt.Size = new System.Drawing.Size(195, 21);
            this.condicionTxt.TabIndex = 31;
            this.condicionTxt.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // alimentacionBox
            // 
            this.alimentacionBox.FormattingEnabled = true;
            this.alimentacionBox.Items.AddRange(new object[] {
            "Regular",
            "Poco Regular",
            "Muy Irregular"});
            this.alimentacionBox.Location = new System.Drawing.Point(554, 189);
            this.alimentacionBox.Name = "alimentacionBox";
            this.alimentacionBox.Size = new System.Drawing.Size(195, 21);
            this.alimentacionBox.TabIndex = 32;
            this.alimentacionBox.SelectedIndexChanged += new System.EventHandler(this.alimentacionBox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(338, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 20);
            this.button1.TabIndex = 33;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Tamañomin
            // 
            this.Tamañomin.FormattingEnabled = true;
            this.Tamañomin.Items.AddRange(new object[] {
            "50 - 75",
            "125",
            "170",
            "250 - 350",
            "400 - 450",
            "500 - 550",
            "600"});
            this.Tamañomin.Location = new System.Drawing.Point(55, 84);
            this.Tamañomin.Name = "Tamañomin";
            this.Tamañomin.Size = new System.Drawing.Size(186, 21);
            this.Tamañomin.TabIndex = 34;
            this.Tamañomin.SelectedIndexChanged += new System.EventHandler(this.Tamañomin_SelectedIndexChanged);
            // 
            // Tamañomax
            // 
            this.Tamañomax.FormattingEnabled = true;
            this.Tamañomax.Items.AddRange(new object[] {
            "100 - 150",
            "200",
            "300",
            "400 - 500",
            "600 - 650",
            "700 - 750",
            "800"});
            this.Tamañomax.Location = new System.Drawing.Point(55, 129);
            this.Tamañomax.Name = "Tamañomax";
            this.Tamañomax.Size = new System.Drawing.Size(186, 21);
            this.Tamañomax.TabIndex = 35;
            this.Tamañomax.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(661, 340);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 48);
            this.button2.TabIndex = 38;
            this.button2.Text = "calcular";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // abrasividad
            // 
            this.abrasividad.FormattingEnabled = true;
            this.abrasividad.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.abrasividad.Location = new System.Drawing.Point(290, 39);
            this.abrasividad.Name = "abrasividad";
            this.abrasividad.Size = new System.Drawing.Size(192, 21);
            this.abrasividad.TabIndex = 39;
            // 
            // respuesta
            // 
            this.respuesta.AutoSize = true;
            this.respuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.respuesta.Location = new System.Drawing.Point(604, 358);
            this.respuesta.Name = "respuesta";
            this.respuesta.Size = new System.Drawing.Size(53, 20);
            this.respuesta.TabIndex = 40;
            this.respuesta.Text = "Test 2";
            // 
            // inclinacionBox
            // 
            this.inclinacionBox.FormattingEnabled = true;
            this.inclinacionBox.Items.AddRange(new object[] {
            "0 º",
            "1 º",
            "2 º",
            "3 º",
            "4 º",
            "5 º",
            "6 º",
            "7 º",
            "8 º",
            "9 º",
            "10 º",
            "11 º",
            "12 º",
            "13 º ",
            "14 º",
            "15 º",
            "16 º",
            "17 º",
            "18 º",
            "19 º",
            "20 º"});
            this.inclinacionBox.Location = new System.Drawing.Point(554, 49);
            this.inclinacionBox.Name = "inclinacionBox";
            this.inclinacionBox.Size = new System.Drawing.Size(195, 21);
            this.inclinacionBox.TabIndex = 41;
            this.inclinacionBox.SelectedIndexChanged += new System.EventHandler(this.inclinacion_SelectedIndexChanged);
            // 
            // resultTxt
            // 
            this.resultTxt.Location = new System.Drawing.Point(554, 233);
            this.resultTxt.Multiline = true;
            this.resultTxt.Name = "resultTxt";
            this.resultTxt.Size = new System.Drawing.Size(195, 98);
            this.resultTxt.TabIndex = 42;
            // 
            // angureposo
            // 
            this.angureposo.FormattingEnabled = true;
            this.angureposo.Items.AddRange(new object[] {
            "0 - 19",
            "20 - 29",
            "30 - 34",
            "35 - 39",
            "> 40"});
            this.angureposo.Location = new System.Drawing.Point(290, 84);
            this.angureposo.Name = "angureposo";
            this.angureposo.Size = new System.Drawing.Size(192, 21);
            this.angureposo.TabIndex = 43;
            this.angureposo.SelectedIndexChanged += new System.EventHandler(this.angureposo_SelectedIndexChanged);
            // 
            // pesobox
            // 
            this.pesobox.FormattingEnabled = true;
            this.pesobox.Items.AddRange(new object[] {
            "< 1.2",
            "1.2 a 2",
            "> 2"});
            this.pesobox.Location = new System.Drawing.Point(55, 39);
            this.pesobox.Name = "pesobox";
            this.pesobox.Size = new System.Drawing.Size(186, 21);
            this.pesobox.TabIndex = 44;
            this.pesobox.SelectedIndexChanged += new System.EventHandler(this.pesobox_SelectedIndexChanged);
            // 
            // utilizacionTxt
            // 
            this.utilizacionTxt.FormattingEnabled = true;
            this.utilizacionTxt.Items.AddRange(new object[] {
            "Menos de 6 horas al día.",
            "De 6 a 9 horas al día.",
            "De 10 a 16 horas al día.",
            "Más de 16 horas al día."});
            this.utilizacionTxt.Location = new System.Drawing.Point(554, 127);
            this.utilizacionTxt.Name = "utilizacionTxt";
            this.utilizacionTxt.Size = new System.Drawing.Size(195, 21);
            this.utilizacionTxt.TabIndex = 45;
            this.utilizacionTxt.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // utiltxt
            // 
            this.utiltxt.AutoSize = true;
            this.utiltxt.Location = new System.Drawing.Point(714, 174);
            this.utiltxt.Name = "utiltxt";
            this.utiltxt.Size = new System.Drawing.Size(29, 13);
            this.utiltxt.TabIndex = 46;
            this.utiltxt.Text = "tests";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(331, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 47;
            this.label5.Text = "tn/h";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(24, 94);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(154, 13);
            this.label17.TabIndex = 48;
            this.label17.Text = "Capasidad Volumetrica";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(24, 131);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(147, 13);
            this.label15.TabIndex = 49;
            this.label15.Text = "Distancia entre Ejes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Altura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(194, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Material";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "Peso Especifico";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(17, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 13);
            this.label10.TabIndex = 53;
            this.label10.Text = "Tamaño Minimo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(17, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 13);
            this.label11.TabIndex = 54;
            this.label11.Text = "Tamaño Maximo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(263, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 13);
            this.label12.TabIndex = 55;
            this.label12.Text = "Abrasividad";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(263, 68);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 13);
            this.label13.TabIndex = 56;
            this.label13.Text = "Angulo de Reposo";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(395, 57);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 13);
            this.label14.TabIndex = 57;
            this.label14.Text = "Inclinación";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(395, 94);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(147, 13);
            this.label18.TabIndex = 58;
            this.label18.Text = "Condición de Trabajo";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(395, 131);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(84, 13);
            this.label19.TabIndex = 59;
            this.label19.Text = "Utilización";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(395, 174);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(147, 13);
            this.label20.TabIndex = 60;
            this.label20.Text = "Tipo de Alimentación";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Tamañomin);
            this.groupBox1.Controls.Add(this.Tamañomax);
            this.groupBox1.Controls.Add(this.pesobox);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.abrasividad);
            this.groupBox1.Controls.Add(this.angureposo);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 226);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 165);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Material";
            // 
            // distanciaEjesBox
            // 
            this.distanciaEjesBox.FormattingEnabled = true;
            this.distanciaEjesBox.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "80",
            "100",
            "150",
            "200",
            "250",
            "300",
            "400",
            "500",
            "1000"});
            this.distanciaEjesBox.Location = new System.Drawing.Point(210, 127);
            this.distanciaEjesBox.Name = "distanciaEjesBox";
            this.distanciaEjesBox.Size = new System.Drawing.Size(153, 21);
            this.distanciaEjesBox.TabIndex = 57;
            this.distanciaEjesBox.SelectedIndexChanged += new System.EventHandler(this.distanciaEjesBox_SelectedIndexChanged);
            // 
            // CintaTransportadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(764, 402);
            this.Controls.Add(this.distanciaEjesBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.utiltxt);
            this.Controls.Add(this.utilizacionTxt);
            this.Controls.Add(this.resultTxt);
            this.Controls.Add(this.inclinacionBox);
            this.Controls.Add(this.respuesta);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.alimentacionBox);
            this.Controls.Add(this.condicionTxt);
            this.Controls.Add(this.IMtxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.capacidadTxt);
            this.Name = "CintaTransportadora";
            this.Text = "CintaTransportadora";
            this.Load += new System.EventHandler(this.CintaTransportadora_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox capacidadTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox IMtxt;
        private System.Windows.Forms.ComboBox condicionTxt;
        private System.Windows.Forms.ComboBox alimentacionBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox Tamañomin;
        private System.Windows.Forms.ComboBox Tamañomax;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox abrasividad;
        private System.Windows.Forms.Label respuesta;
        private System.Windows.Forms.ComboBox inclinacionBox;
        private System.Windows.Forms.TextBox resultTxt;
        private System.Windows.Forms.ComboBox angureposo;
        private System.Windows.Forms.ComboBox pesobox;
        private System.Windows.Forms.ComboBox utilizacionTxt;
        private System.Windows.Forms.Label utiltxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox distanciaEjesBox;
    }
}