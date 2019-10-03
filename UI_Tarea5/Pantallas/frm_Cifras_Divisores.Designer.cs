namespace UI_Tarea5.Pantallas
{
    partial class frm_Cifras_Divisores
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNumDivs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCifMenor = new System.Windows.Forms.TextBox();
            this.txtCifMayor = new System.Windows.Forms.TextBox();
            this.txtSumCifImpar = new System.Windows.Forms.TextBox();
            this.txtSumCifPar = new System.Windows.Forms.TextBox();
            this.txtCantCif = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_LimpiarCampos = new System.Windows.Forms.Button();
            this.btn_VerResultados = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbox_Divisores = new System.Windows.Forms.ListBox();
            this.btnCerrarDiv = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtNumDivs);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Plum;
            this.groupBox1.Location = new System.Drawing.Point(15, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 54);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Número";
            // 
            // txtNumDivs
            // 
            this.txtNumDivs.Location = new System.Drawing.Point(146, 18);
            this.txtNumDivs.MaxLength = 9;
            this.txtNumDivs.Name = "txtNumDivs";
            this.txtNumDivs.Size = new System.Drawing.Size(116, 21);
            this.txtNumDivs.TabIndex = 1;
            this.txtNumDivs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumDivs_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Plum;
            this.label1.Location = new System.Drawing.Point(8, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número a evaluar:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtCifMenor);
            this.groupBox2.Controls.Add(this.txtCifMayor);
            this.groupBox2.Controls.Add(this.txtSumCifImpar);
            this.groupBox2.Controls.Add(this.txtSumCifPar);
            this.groupBox2.Controls.Add(this.txtCantCif);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Plum;
            this.groupBox2.Location = new System.Drawing.Point(15, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 220);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultados";
            // 
            // txtCifMenor
            // 
            this.txtCifMenor.Enabled = false;
            this.txtCifMenor.Location = new System.Drawing.Point(164, 144);
            this.txtCifMenor.MaxLength = 9;
            this.txtCifMenor.Name = "txtCifMenor";
            this.txtCifMenor.Size = new System.Drawing.Size(128, 21);
            this.txtCifMenor.TabIndex = 9;
            // 
            // txtCifMayor
            // 
            this.txtCifMayor.Enabled = false;
            this.txtCifMayor.Location = new System.Drawing.Point(164, 114);
            this.txtCifMayor.MaxLength = 9;
            this.txtCifMayor.Name = "txtCifMayor";
            this.txtCifMayor.Size = new System.Drawing.Size(128, 21);
            this.txtCifMayor.TabIndex = 8;
            // 
            // txtSumCifImpar
            // 
            this.txtSumCifImpar.Enabled = false;
            this.txtSumCifImpar.Location = new System.Drawing.Point(164, 84);
            this.txtSumCifImpar.MaxLength = 9;
            this.txtSumCifImpar.Name = "txtSumCifImpar";
            this.txtSumCifImpar.Size = new System.Drawing.Size(128, 21);
            this.txtSumCifImpar.TabIndex = 7;
            // 
            // txtSumCifPar
            // 
            this.txtSumCifPar.Enabled = false;
            this.txtSumCifPar.Location = new System.Drawing.Point(164, 51);
            this.txtSumCifPar.MaxLength = 9;
            this.txtSumCifPar.Name = "txtSumCifPar";
            this.txtSumCifPar.Size = new System.Drawing.Size(128, 21);
            this.txtSumCifPar.TabIndex = 6;
            // 
            // txtCantCif
            // 
            this.txtCantCif.Enabled = false;
            this.txtCantCif.Location = new System.Drawing.Point(164, 20);
            this.txtCantCif.MaxLength = 9;
            this.txtCantCif.Name = "txtCantCif";
            this.txtCantCif.Size = new System.Drawing.Size(128, 21);
            this.txtCantCif.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Cifra menor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Cifra mayor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Suma de cifras impares:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Suma de cifras pares:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cantidad de cifras:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btn_LimpiarCampos);
            this.groupBox3.Controls.Add(this.btn_VerResultados);
            this.groupBox3.ForeColor = System.Drawing.Color.Plum;
            this.groupBox3.Location = new System.Drawing.Point(329, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(233, 54);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Opciones";
            // 
            // btn_LimpiarCampos
            // 
            this.btn_LimpiarCampos.BackColor = System.Drawing.Color.Khaki;
            this.btn_LimpiarCampos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_LimpiarCampos.Location = new System.Drawing.Point(121, 16);
            this.btn_LimpiarCampos.Name = "btn_LimpiarCampos";
            this.btn_LimpiarCampos.Size = new System.Drawing.Size(87, 27);
            this.btn_LimpiarCampos.TabIndex = 1;
            this.btn_LimpiarCampos.Text = "Limpiar";
            this.btn_LimpiarCampos.UseVisualStyleBackColor = false;
            this.btn_LimpiarCampos.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_VerResultados
            // 
            this.btn_VerResultados.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_VerResultados.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_VerResultados.Location = new System.Drawing.Point(27, 16);
            this.btn_VerResultados.Name = "btn_VerResultados";
            this.btn_VerResultados.Size = new System.Drawing.Size(87, 27);
            this.btn_VerResultados.TabIndex = 0;
            this.btn_VerResultados.Text = "Ver";
            this.btn_VerResultados.UseVisualStyleBackColor = false;
            this.btn_VerResultados.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.lbox_Divisores);
            this.groupBox4.ForeColor = System.Drawing.Color.Plum;
            this.groupBox4.Location = new System.Drawing.Point(329, 91);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(233, 220);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Divisores";
            // 
            // lbox_Divisores
            // 
            this.lbox_Divisores.FormattingEnabled = true;
            this.lbox_Divisores.ItemHeight = 15;
            this.lbox_Divisores.Location = new System.Drawing.Point(8, 23);
            this.lbox_Divisores.Name = "lbox_Divisores";
            this.lbox_Divisores.Size = new System.Drawing.Size(217, 184);
            this.lbox_Divisores.TabIndex = 0;
            // 
            // btnCerrarDiv
            // 
            this.btnCerrarDiv.BackColor = System.Drawing.Color.DarkRed;
            this.btnCerrarDiv.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCerrarDiv.Location = new System.Drawing.Point(450, 318);
            this.btnCerrarDiv.Name = "btnCerrarDiv";
            this.btnCerrarDiv.Size = new System.Drawing.Size(87, 27);
            this.btnCerrarDiv.TabIndex = 4;
            this.btnCerrarDiv.Text = "Cerrar";
            this.btnCerrarDiv.UseVisualStyleBackColor = false;
            this.btnCerrarDiv.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_Cifras_Divisores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.BackgroundImage = global::UI_Tarea5.Properties.Resources.fondoNUmeros;
            this.ClientSize = new System.Drawing.Size(576, 359);
            this.Controls.Add(this.btnCerrarDiv);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Cifras_Divisores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cifras Divisores";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNumDivs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCifMenor;
        private System.Windows.Forms.TextBox txtCifMayor;
        private System.Windows.Forms.TextBox txtSumCifImpar;
        private System.Windows.Forms.TextBox txtSumCifPar;
        private System.Windows.Forms.TextBox txtCantCif;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_LimpiarCampos;
        private System.Windows.Forms.Button btn_VerResultados;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lbox_Divisores;
        private System.Windows.Forms.Button btnCerrarDiv;
    }
}