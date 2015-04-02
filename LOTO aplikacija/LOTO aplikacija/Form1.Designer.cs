namespace LOTO_aplikacija
{
    partial class FrmLoto
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
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBoxUplaceni = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.btnUplati = new System.Windows.Forms.Button();
            this.groupBoxDobitni = new System.Windows.Forms.GroupBox();
            this.btnOdigraj = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.lbtNatpis = new System.Windows.Forms.Label();
            this.lblBrojPogodaka = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            this.groupBoxUplaceni.SuspendLayout();
            this.groupBoxDobitni.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(40, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBoxUplaceni
            // 
            this.groupBoxUplaceni.Controls.Add(this.btnUplati);
            this.groupBoxUplaceni.Controls.Add(this.textBox7);
            this.groupBoxUplaceni.Controls.Add(this.textBox6);
            this.groupBoxUplaceni.Controls.Add(this.textBox5);
            this.groupBoxUplaceni.Controls.Add(this.textBox4);
            this.groupBoxUplaceni.Controls.Add(this.textBox3);
            this.groupBoxUplaceni.Controls.Add(this.textBox2);
            this.groupBoxUplaceni.Controls.Add(this.textBox1);
            this.groupBoxUplaceni.Location = new System.Drawing.Point(12, 12);
            this.groupBoxUplaceni.Name = "groupBoxUplaceni";
            this.groupBoxUplaceni.Size = new System.Drawing.Size(338, 118);
            this.groupBoxUplaceni.TabIndex = 1;
            this.groupBoxUplaceni.TabStop = false;
            this.groupBoxUplaceni.Text = "uplacena kombinacija";
            this.groupBoxUplaceni.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(52, 33);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(40, 22);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(98, 33);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(40, 22);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(144, 33);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(40, 22);
            this.textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(190, 33);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(40, 22);
            this.textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(236, 33);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(40, 22);
            this.textBox6.TabIndex = 5;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(282, 33);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(40, 22);
            this.textBox7.TabIndex = 6;
            // 
            // btnUplati
            // 
            this.btnUplati.Location = new System.Drawing.Point(236, 72);
            this.btnUplati.Name = "btnUplati";
            this.btnUplati.Size = new System.Drawing.Size(75, 40);
            this.btnUplati.TabIndex = 7;
            this.btnUplati.Text = "Uplati";
            this.btnUplati.UseVisualStyleBackColor = true;
            // 
            // groupBoxDobitni
            // 
            this.groupBoxDobitni.Controls.Add(this.btnOdigraj);
            this.groupBoxDobitni.Controls.Add(this.textBox8);
            this.groupBoxDobitni.Controls.Add(this.textBox9);
            this.groupBoxDobitni.Controls.Add(this.textBox10);
            this.groupBoxDobitni.Controls.Add(this.textBox11);
            this.groupBoxDobitni.Controls.Add(this.textBox12);
            this.groupBoxDobitni.Controls.Add(this.textBox13);
            this.groupBoxDobitni.Controls.Add(this.textBox14);
            this.groupBoxDobitni.Location = new System.Drawing.Point(12, 136);
            this.groupBoxDobitni.Name = "groupBoxDobitni";
            this.groupBoxDobitni.Size = new System.Drawing.Size(338, 125);
            this.groupBoxDobitni.TabIndex = 8;
            this.groupBoxDobitni.TabStop = false;
            this.groupBoxDobitni.Text = "dobitna kombinacija";
            // 
            // btnOdigraj
            // 
            this.btnOdigraj.Location = new System.Drawing.Point(236, 72);
            this.btnOdigraj.Name = "btnOdigraj";
            this.btnOdigraj.Size = new System.Drawing.Size(75, 40);
            this.btnOdigraj.TabIndex = 7;
            this.btnOdigraj.Text = "Odigraj";
            this.btnOdigraj.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(282, 33);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(40, 22);
            this.textBox8.TabIndex = 6;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(236, 33);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(40, 22);
            this.textBox9.TabIndex = 5;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(190, 33);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(40, 22);
            this.textBox10.TabIndex = 4;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(144, 33);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(40, 22);
            this.textBox11.TabIndex = 3;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(98, 33);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(40, 22);
            this.textBox12.TabIndex = 2;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(52, 33);
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(40, 22);
            this.textBox13.TabIndex = 1;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(6, 33);
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            this.textBox14.Size = new System.Drawing.Size(40, 22);
            this.textBox14.TabIndex = 0;
            // 
            // lbtNatpis
            // 
            this.lbtNatpis.AutoSize = true;
            this.lbtNatpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbtNatpis.Location = new System.Drawing.Point(18, 279);
            this.lbtNatpis.Name = "lbtNatpis";
            this.lbtNatpis.Size = new System.Drawing.Size(113, 17);
            this.lbtNatpis.TabIndex = 9;
            this.lbtNatpis.Text = "Broj pogodaka";
            // 
            // lblBrojPogodaka
            // 
            this.lblBrojPogodaka.AutoSize = true;
            this.lblBrojPogodaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBrojPogodaka.Location = new System.Drawing.Point(188, 279);
            this.lblBrojPogodaka.Name = "lblBrojPogodaka";
            this.lblBrojPogodaka.Size = new System.Drawing.Size(17, 17);
            this.lblBrojPogodaka.TabIndex = 10;
            this.lblBrojPogodaka.Text = "0";
            // 
            // FrmLoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 328);
            this.Controls.Add(this.lblBrojPogodaka);
            this.Controls.Add(this.lbtNatpis);
            this.Controls.Add(this.groupBoxDobitni);
            this.Controls.Add(this.groupBoxUplaceni);
            this.Name = "FrmLoto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOTO 7/39";
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).EndInit();
            this.groupBoxUplaceni.ResumeLayout(false);
            this.groupBoxUplaceni.PerformLayout();
            this.groupBoxDobitni.ResumeLayout(false);
            this.groupBoxDobitni.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Diagnostics.PerformanceCounter performanceCounter1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBoxUplaceni;
        private System.Windows.Forms.Button btnUplati;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBoxDobitni;
        private System.Windows.Forms.Button btnOdigraj;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Label lbtNatpis;
        private System.Windows.Forms.Label lblBrojPogodaka;
    }
}

