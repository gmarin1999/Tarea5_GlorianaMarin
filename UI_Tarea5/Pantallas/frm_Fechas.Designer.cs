namespace UI_Tarea5.Pantallas
{
    partial class frm_Fechas
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
            this.txtFecha = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Extraer = new System.Windows.Forms.Button();
            this.txtDiaSemana = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtZodiac = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_VerFechas = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDifMin = new System.Windows.Forms.TextBox();
            this.txtDifHoras = new System.Windows.Forms.TextBox();
            this.txtdifDias = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFechaFinal = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFechaInicio = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(63, 19);
            this.txtFecha.Mask = "00/00/0000";
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(90, 23);
            this.txtFecha.TabIndex = 0;
            this.txtFecha.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btn_Extraer);
            this.groupBox1.Controls.Add(this.txtDiaSemana);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtZodiac);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtAnio);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMes);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDia);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtFecha);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 168);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Partes de una fecha";
            // 
            // btn_Extraer
            // 
            this.btn_Extraer.BackColor = System.Drawing.Color.Green;
            this.btn_Extraer.Location = new System.Drawing.Point(175, 16);
            this.btn_Extraer.Name = "btn_Extraer";
            this.btn_Extraer.Size = new System.Drawing.Size(75, 23);
            this.btn_Extraer.TabIndex = 12;
            this.btn_Extraer.Text = "Extraer";
            this.btn_Extraer.UseVisualStyleBackColor = false;
            this.btn_Extraer.Click += new System.EventHandler(this.btn_Extraer_Click);
            // 
            // txtDiaSemana
            // 
            this.txtDiaSemana.Enabled = false;
            this.txtDiaSemana.Location = new System.Drawing.Point(147, 131);
            this.txtDiaSemana.Name = "txtDiaSemana";
            this.txtDiaSemana.Size = new System.Drawing.Size(100, 23);
            this.txtDiaSemana.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Día de la semana:";
            // 
            // txtZodiac
            // 
            this.txtZodiac.Enabled = false;
            this.txtZodiac.Location = new System.Drawing.Point(147, 94);
            this.txtZodiac.Name = "txtZodiac";
            this.txtZodiac.Size = new System.Drawing.Size(100, 23);
            this.txtZodiac.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Signo Zodiacal:";
            // 
            // txtAnio
            // 
            this.txtAnio.Enabled = false;
            this.txtAnio.Location = new System.Drawing.Point(244, 50);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(53, 23);
            this.txtAnio.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Año:";
            // 
            // txtMes
            // 
            this.txtMes.Enabled = false;
            this.txtMes.Location = new System.Drawing.Point(147, 50);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(56, 23);
            this.txtMes.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mes:";
            // 
            // txtDia
            // 
            this.txtDia.Enabled = false;
            this.txtDia.Location = new System.Drawing.Point(54, 50);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(51, 23);
            this.txtDia.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Día:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btn_VerFechas);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.txtDifMin);
            this.groupBox2.Controls.Add(this.txtDifHoras);
            this.groupBox2.Controls.Add(this.txtdifDias);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtFechaFinal);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtFechaInicio);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(528, 150);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Diferencia entre fechas";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btn_VerFechas
            // 
            this.btn_VerFechas.BackColor = System.Drawing.Color.Green;
            this.btn_VerFechas.Location = new System.Drawing.Point(466, 18);
            this.btn_VerFechas.Name = "btn_VerFechas";
            this.btn_VerFechas.Size = new System.Drawing.Size(54, 22);
            this.btn_VerFechas.TabIndex = 11;
            this.btn_VerFechas.Text = "Ver";
            this.btn_VerFechas.UseVisualStyleBackColor = false;
            this.btn_VerFechas.Click += new System.EventHandler(this.btn_VerFechas_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.Location = new System.Drawing.Point(445, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDifMin
            // 
            this.txtDifMin.Enabled = false;
            this.txtDifMin.Location = new System.Drawing.Point(175, 104);
            this.txtDifMin.Name = "txtDifMin";
            this.txtDifMin.Size = new System.Drawing.Size(55, 23);
            this.txtDifMin.TabIndex = 9;
            // 
            // txtDifHoras
            // 
            this.txtDifHoras.Enabled = false;
            this.txtDifHoras.Location = new System.Drawing.Point(175, 75);
            this.txtDifHoras.Name = "txtDifHoras";
            this.txtDifHoras.Size = new System.Drawing.Size(55, 23);
            this.txtDifHoras.TabIndex = 8;
            // 
            // txtdifDias
            // 
            this.txtdifDias.Enabled = false;
            this.txtdifDias.Location = new System.Drawing.Point(175, 48);
            this.txtdifDias.Name = "txtdifDias";
            this.txtdifDias.Size = new System.Drawing.Size(55, 23);
            this.txtdifDias.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(152, 17);
            this.label11.TabIndex = 6;
            this.label11.Text = "Diferencia en minutos:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 17);
            this.label10.TabIndex = 5;
            this.label10.Text = "Diferencia en horas:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "Diferencia en días:";
            // 
            // txtFechaFinal
            // 
            this.txtFechaFinal.Location = new System.Drawing.Point(335, 17);
            this.txtFechaFinal.Mask = "00/00/0000 90:00";
            this.txtFechaFinal.Name = "txtFechaFinal";
            this.txtFechaFinal.Size = new System.Drawing.Size(125, 23);
            this.txtFechaFinal.TabIndex = 3;
            this.txtFechaFinal.ValidatingType = typeof(System.DateTime);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(247, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Fecha final:";
            // 
            // txtFechaInicio
            // 
            this.txtFechaInicio.Location = new System.Drawing.Point(112, 17);
            this.txtFechaInicio.Mask = "00/00/0000 90:00";
            this.txtFechaInicio.Name = "txtFechaInicio";
            this.txtFechaInicio.Size = new System.Drawing.Size(129, 23);
            this.txtFechaInicio.TabIndex = 1;
            this.txtFechaInicio.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Fecha inicio:";
            // 
            // frm_Fechas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UI_Tarea5.Properties.Resources.calendarfondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(544, 348);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Fechas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fechas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDiaSemana;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtZodiac;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox txtFechaFinal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txtFechaInicio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDifMin;
        private System.Windows.Forms.TextBox txtDifHoras;
        private System.Windows.Forms.TextBox txtdifDias;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_Extraer;
        private System.Windows.Forms.Button btn_VerFechas;
    }
}