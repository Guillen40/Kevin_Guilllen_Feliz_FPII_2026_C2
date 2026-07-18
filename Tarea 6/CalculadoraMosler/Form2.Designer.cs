namespace CalculadoraMosler
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboExtension = new System.Windows.Forms.ComboBox();
            this.cboSustitucion = new System.Windows.Forms.ComboBox();
            this.cboProfundidad = new System.Windows.Forms.ComboBox();
            this.cboFuncion = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            this.bntSiguiente = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboAgresion = new System.Windows.Forms.ComboBox();
            this.cboVulnerabilidad = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Criterios de Evaluacion";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.cboExtension);
            this.groupBox1.Controls.Add(this.cboVulnerabilidad);
            this.groupBox1.Controls.Add(this.cboSustitucion);
            this.groupBox1.Controls.Add(this.cboAgresion);
            this.groupBox1.Controls.Add(this.cboProfundidad);
            this.groupBox1.Controls.Add(this.cboFuncion);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(14, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 213);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // cboExtension
            // 
            this.cboExtension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboExtension.FormattingEnabled = true;
            this.cboExtension.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cboExtension.Location = new System.Drawing.Point(159, 111);
            this.cboExtension.Name = "cboExtension";
            this.cboExtension.Size = new System.Drawing.Size(71, 21);
            this.cboExtension.TabIndex = 11;
            // 
            // cboSustitucion
            // 
            this.cboSustitucion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSustitucion.FormattingEnabled = true;
            this.cboSustitucion.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cboSustitucion.Location = new System.Drawing.Point(159, 44);
            this.cboSustitucion.Name = "cboSustitucion";
            this.cboSustitucion.Size = new System.Drawing.Size(71, 21);
            this.cboSustitucion.TabIndex = 9;
            // 
            // cboProfundidad
            // 
            this.cboProfundidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProfundidad.FormattingEnabled = true;
            this.cboProfundidad.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cboProfundidad.Location = new System.Drawing.Point(23, 111);
            this.cboProfundidad.Name = "cboProfundidad";
            this.cboProfundidad.Size = new System.Drawing.Size(71, 21);
            this.cboProfundidad.TabIndex = 7;
            // 
            // cboFuncion
            // 
            this.cboFuncion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFuncion.FormattingEnabled = true;
            this.cboFuncion.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cboFuncion.Location = new System.Drawing.Point(22, 44);
            this.cboFuncion.Name = "cboFuncion";
            this.cboFuncion.Size = new System.Drawing.Size(71, 21);
            this.cboFuncion.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(156, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Sustitucion (S)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(156, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Extencion (E)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Profundidad (P)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Funcion (F)";
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.IndianRed;
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(18, 317);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(108, 45);
            this.btnAtras.TabIndex = 3;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // bntSiguiente
            // 
            this.bntSiguiente.BackColor = System.Drawing.SystemColors.Highlight;
            this.bntSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntSiguiente.Location = new System.Drawing.Point(197, 317);
            this.bntSiguiente.Name = "bntSiguiente";
            this.bntSiguiente.Size = new System.Drawing.Size(108, 45);
            this.bntSiguiente.TabIndex = 4;
            this.bntSiguiente.Text = "Siguiente";
            this.bntSiguiente.UseVisualStyleBackColor = false;
            this.bntSiguiente.Click += new System.EventHandler(this.bntSiguiente_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Agresion (A)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(156, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Vulnerabilidad (V)";
            // 
            // cboAgresion
            // 
            this.cboAgresion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAgresion.FormattingEnabled = true;
            this.cboAgresion.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cboAgresion.Location = new System.Drawing.Point(22, 167);
            this.cboAgresion.Name = "cboAgresion";
            this.cboAgresion.Size = new System.Drawing.Size(71, 21);
            this.cboAgresion.TabIndex = 8;
            // 
            // cboVulnerabilidad
            // 
            this.cboVulnerabilidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVulnerabilidad.FormattingEnabled = true;
            this.cboVulnerabilidad.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cboVulnerabilidad.Location = new System.Drawing.Point(159, 167);
            this.cboVulnerabilidad.Name = "cboVulnerabilidad";
            this.cboVulnerabilidad.Size = new System.Drawing.Size(71, 21);
            this.cboVulnerabilidad.TabIndex = 10;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(333, 384);
            this.Controls.Add(this.bntSiguiente);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboExtension;
        private System.Windows.Forms.ComboBox cboSustitucion;
        private System.Windows.Forms.ComboBox cboProfundidad;
        private System.Windows.Forms.ComboBox cboFuncion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button bntSiguiente;
        private System.Windows.Forms.ComboBox cboVulnerabilidad;
        private System.Windows.Forms.ComboBox cboAgresion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
    }
}