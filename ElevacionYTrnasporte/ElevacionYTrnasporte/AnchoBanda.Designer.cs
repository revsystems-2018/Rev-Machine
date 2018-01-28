namespace ElevacionYTrnasporte
{
    partial class AnchoBanda
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnchoBanda));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.enviarbtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.anchobandabox = new System.Windows.Forms.ComboBox();
            this.resultadoTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pasoTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ancho de banda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;
            // 
            // enviarbtn
            // 
            this.enviarbtn.Location = new System.Drawing.Point(296, 147);
            this.enviarbtn.Name = "enviarbtn";
            this.enviarbtn.Size = new System.Drawing.Size(75, 23);
            this.enviarbtn.TabIndex = 3;
            this.enviarbtn.Text = "enviar";
            this.enviarbtn.UseVisualStyleBackColor = true;
            this.enviarbtn.Click += new System.EventHandler(this.enviarbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(458, 91);
            this.label3.TabIndex = 4;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // anchobandabox
            // 
            this.anchobandabox.FormattingEnabled = true;
            this.anchobandabox.Items.AddRange(new object[] {
            "300",
            "400",
            "500",
            "650",
            "800",
            "1000",
            "1200",
            "1400",
            "1600",
            "1800",
            "2000",
            "2200"});
            this.anchobandabox.Location = new System.Drawing.Point(105, 149);
            this.anchobandabox.Name = "anchobandabox";
            this.anchobandabox.Size = new System.Drawing.Size(185, 21);
            this.anchobandabox.TabIndex = 44;
            this.anchobandabox.SelectedIndexChanged += new System.EventHandler(this.anchobandabox_SelectedIndexChanged);
            // 
            // resultadoTxt
            // 
            this.resultadoTxt.Location = new System.Drawing.Point(71, 118);
            this.resultadoTxt.Name = "resultadoTxt";
            this.resultadoTxt.Size = new System.Drawing.Size(110, 20);
            this.resultadoTxt.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "label4";
            // 
            // pasoTxt
            // 
            this.pasoTxt.AutoSize = true;
            this.pasoTxt.Location = new System.Drawing.Point(187, 121);
            this.pasoTxt.Name = "pasoTxt";
            this.pasoTxt.Size = new System.Drawing.Size(35, 13);
            this.pasoTxt.TabIndex = 47;
            this.pasoTxt.Text = "label5";
            // 
            // AnchoBanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 180);
            this.Controls.Add(this.pasoTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.resultadoTxt);
            this.Controls.Add(this.anchobandabox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.enviarbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AnchoBanda";
            this.Text = "AnchoBanda";
            this.Load += new System.EventHandler(this.AnchoBanda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button enviarbtn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox anchobandabox;
        private System.Windows.Forms.TextBox resultadoTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label pasoTxt;
    }
}