namespace CalculadoraMosler
{
    partial class Form3
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAmenaza = new System.Windows.Forms.Label();
            this.lblBienProteger = new System.Windows.Forms.Label();
            this.lblEvaluador = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNivel = new System.Windows.Forms.Label();
            this.lblResultadoER = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            this.bntSiguiente = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.lblAmenaza);
            this.panel1.Controls.Add(this.lblBienProteger);
            this.panel1.Controls.Add(this.lblEvaluador);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 181);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblAmenaza
            // 
            this.lblAmenaza.AutoSize = true;
            this.lblAmenaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmenaza.Location = new System.Drawing.Point(95, 122);
            this.lblAmenaza.Name = "lblAmenaza";
            this.lblAmenaza.Size = new System.Drawing.Size(24, 20);
            this.lblAmenaza.TabIndex = 7;
            this.lblAmenaza.Text = "...";
            // 
            // lblBienProteger
            // 
            this.lblBienProteger.AutoSize = true;
            this.lblBienProteger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienProteger.Location = new System.Drawing.Point(134, 87);
            this.lblBienProteger.Name = "lblBienProteger";
            this.lblBienProteger.Size = new System.Drawing.Size(24, 20);
            this.lblBienProteger.TabIndex = 6;
            this.lblBienProteger.Text = "...";
            // 
            // lblEvaluador
            // 
            this.lblEvaluador.AutoSize = true;
            this.lblEvaluador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvaluador.Location = new System.Drawing.Point(95, 50);
            this.lblEvaluador.Name = "lblEvaluador";
            this.lblEvaluador.Size = new System.Drawing.Size(24, 20);
            this.lblEvaluador.TabIndex = 5;
            this.lblEvaluador.Text = "...";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(84, 19);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(24, 20);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "...";
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Amenaza:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bien a Proteger:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proyecto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Evaluador:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lblNivel);
            this.panel2.Controls.Add(this.lblResultadoER);
            this.panel2.Location = new System.Drawing.Point(278, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(187, 181);
            this.panel2.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Resultados:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel.Location = new System.Drawing.Point(13, 122);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(31, 29);
            this.lblNivel.TabIndex = 1;
            this.lblNivel.Text = "...";
            // 
            // lblResultadoER
            // 
            this.lblResultadoER.AutoSize = true;
            this.lblResultadoER.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoER.Location = new System.Drawing.Point(13, 59);
            this.lblResultadoER.Name = "lblResultadoER";
            this.lblResultadoER.Size = new System.Drawing.Size(30, 25);
            this.lblResultadoER.TabIndex = 0;
            this.lblResultadoER.Text = "...";
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.IndianRed;
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(12, 235);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(108, 45);
            this.btnAtras.TabIndex = 4;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // bntSiguiente
            // 
            this.bntSiguiente.BackColor = System.Drawing.SystemColors.Highlight;
            this.bntSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntSiguiente.Location = new System.Drawing.Point(357, 235);
            this.bntSiguiente.Name = "bntSiguiente";
            this.bntSiguiente.Size = new System.Drawing.Size(108, 45);
            this.bntSiguiente.TabIndex = 5;
            this.bntSiguiente.Text = "Siguiente";
            this.bntSiguiente.UseVisualStyleBackColor = false;
            this.bntSiguiente.Click += new System.EventHandler(this.bntSiguiente_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(484, 308);
            this.Controls.Add(this.bntSiguiente);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAmenaza;
        private System.Windows.Forms.Label lblBienProteger;
        private System.Windows.Forms.Label lblEvaluador;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.Label lblResultadoER;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button bntSiguiente;
    }
}