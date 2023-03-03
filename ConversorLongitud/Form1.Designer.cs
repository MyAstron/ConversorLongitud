namespace ConversorLongitud
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.udKilometros = new System.Windows.Forms.DomainUpDown();
            this.txtPulgada = new System.Windows.Forms.TextBox();
            this.txtMillaMaritima = new System.Windows.Forms.TextBox();
            this.txtMetro = new System.Windows.Forms.TextBox();
            this.txtCentimetro = new System.Windows.Forms.TextBox();
            this.txtPie = new System.Windows.Forms.TextBox();
            this.txtYarda = new System.Windows.Forms.TextBox();
            this.txtMilimetro = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor en Kilometros (Km)";
            // 
            // udKilometros
            // 
            this.udKilometros.Location = new System.Drawing.Point(166, 34);
            this.udKilometros.Name = "udKilometros";
            this.udKilometros.Size = new System.Drawing.Size(120, 23);
            this.udKilometros.TabIndex = 1;
            this.udKilometros.Text = "000";
            // 
            // txtPulgada
            // 
            this.txtPulgada.Enabled = false;
            this.txtPulgada.Location = new System.Drawing.Point(23, 90);
            this.txtPulgada.Name = "txtPulgada";
            this.txtPulgada.Size = new System.Drawing.Size(137, 23);
            this.txtPulgada.TabIndex = 3;
            this.txtPulgada.Text = "Pulgada";
            // 
            // txtMillaMaritima
            // 
            this.txtMillaMaritima.Enabled = false;
            this.txtMillaMaritima.Location = new System.Drawing.Point(166, 148);
            this.txtMillaMaritima.Name = "txtMillaMaritima";
            this.txtMillaMaritima.Size = new System.Drawing.Size(137, 23);
            this.txtMillaMaritima.TabIndex = 4;
            this.txtMillaMaritima.Text = "Milla Maritima";
            // 
            // txtMetro
            // 
            this.txtMetro.Enabled = false;
            this.txtMetro.Location = new System.Drawing.Point(166, 90);
            this.txtMetro.Name = "txtMetro";
            this.txtMetro.Size = new System.Drawing.Size(137, 23);
            this.txtMetro.TabIndex = 5;
            this.txtMetro.Text = "Metro";
            // 
            // txtCentimetro
            // 
            this.txtCentimetro.Enabled = false;
            this.txtCentimetro.Location = new System.Drawing.Point(23, 148);
            this.txtCentimetro.Name = "txtCentimetro";
            this.txtCentimetro.Size = new System.Drawing.Size(137, 23);
            this.txtCentimetro.TabIndex = 6;
            this.txtCentimetro.Text = "Centimetro";
            // 
            // txtPie
            // 
            this.txtPie.Enabled = false;
            this.txtPie.Location = new System.Drawing.Point(23, 119);
            this.txtPie.Name = "txtPie";
            this.txtPie.Size = new System.Drawing.Size(137, 23);
            this.txtPie.TabIndex = 7;
            this.txtPie.Text = "Pie";
            // 
            // txtYarda
            // 
            this.txtYarda.Enabled = false;
            this.txtYarda.Location = new System.Drawing.Point(166, 119);
            this.txtYarda.Name = "txtYarda";
            this.txtYarda.Size = new System.Drawing.Size(137, 23);
            this.txtYarda.TabIndex = 8;
            this.txtYarda.Text = "Yarda";
            // 
            // txtMilimetro
            // 
            this.txtMilimetro.Enabled = false;
            this.txtMilimetro.Location = new System.Drawing.Point(90, 177);
            this.txtMilimetro.Name = "txtMilimetro";
            this.txtMilimetro.Size = new System.Drawing.Size(137, 23);
            this.txtMilimetro.TabIndex = 9;
            this.txtMilimetro.Text = "Milimetro";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(353, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(353, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Borrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(353, 119);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 225);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMilimetro);
            this.Controls.Add(this.txtYarda);
            this.Controls.Add(this.txtPie);
            this.Controls.Add(this.txtCentimetro);
            this.Controls.Add(this.txtMetro);
            this.Controls.Add(this.txtMillaMaritima);
            this.Controls.Add(this.txtPulgada);
            this.Controls.Add(this.udKilometros);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "..:: Conversor de Longitudes ::..";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DomainUpDown udKilometros;
        private TextBox txtPulgada;
        private TextBox txtMillaMaritima;
        private TextBox txtMetro;
        private TextBox txtCentimetro;
        private TextBox txtPie;
        private TextBox txtYarda;
        private TextBox txtMilimetro;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}