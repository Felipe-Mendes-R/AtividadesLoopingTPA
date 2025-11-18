namespace AtividadesTPA
{
    partial class frmatv1
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
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btncalc1 = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btncalc2 = new System.Windows.Forms.Button();
            this.btncalc3 = new System.Windows.Forms.Button();
            this.lblresul = new System.Windows.Forms.Label();
            this.txtresul = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtnum1
            // 
            this.txtnum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtnum1.Location = new System.Drawing.Point(418, 21);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(237, 26);
            this.txtnum1.TabIndex = 0;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl1.Location = new System.Drawing.Point(109, 21);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(199, 20);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Digite um número de 1 a 9:";
            // 
            // btncalc1
            // 
            this.btncalc1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalc1.Location = new System.Drawing.Point(113, 303);
            this.btncalc1.Name = "btncalc1";
            this.btncalc1.Size = new System.Drawing.Size(169, 36);
            this.btncalc1.TabIndex = 2;
            this.btncalc1.Text = "Calcular (while)";
            this.btncalc1.UseVisualStyleBackColor = true;
            this.btncalc1.Click += new System.EventHandler(this.btncalc1_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.Location = new System.Drawing.Point(364, 345);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(109, 36);
            this.btnlimpar.TabIndex = 3;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.Location = new System.Drawing.Point(546, 345);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(109, 36);
            this.btnvoltar.TabIndex = 4;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btncalc2
            // 
            this.btncalc2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalc2.Location = new System.Drawing.Point(113, 345);
            this.btncalc2.Name = "btncalc2";
            this.btncalc2.Size = new System.Drawing.Size(169, 36);
            this.btncalc2.TabIndex = 5;
            this.btncalc2.Text = "Calcular (do while)";
            this.btncalc2.UseVisualStyleBackColor = true;
            this.btncalc2.Click += new System.EventHandler(this.btncalc2_Click);
            // 
            // btncalc3
            // 
            this.btncalc3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalc3.Location = new System.Drawing.Point(113, 387);
            this.btncalc3.Name = "btncalc3";
            this.btncalc3.Size = new System.Drawing.Size(169, 36);
            this.btncalc3.TabIndex = 6;
            this.btncalc3.Text = "Calcular (for)";
            this.btncalc3.UseVisualStyleBackColor = true;
            this.btncalc3.Click += new System.EventHandler(this.btncalc3_Click);
            // 
            // lblresul
            // 
            this.lblresul.AutoSize = true;
            this.lblresul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblresul.Location = new System.Drawing.Point(109, 73);
            this.lblresul.Name = "lblresul";
            this.lblresul.Size = new System.Drawing.Size(86, 20);
            this.lblresul.TabIndex = 8;
            this.lblresul.Text = "Resultado:";
            // 
            // txtresul
            // 
            this.txtresul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtresul.Location = new System.Drawing.Point(418, 73);
            this.txtresul.Multiline = true;
            this.txtresul.Name = "txtresul";
            this.txtresul.ReadOnly = true;
            this.txtresul.Size = new System.Drawing.Size(237, 217);
            this.txtresul.TabIndex = 7;
            // 
            // frmatv1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.lblresul);
            this.Controls.Add(this.txtresul);
            this.Controls.Add(this.btncalc3);
            this.Controls.Add(this.btncalc2);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncalc1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtnum1);
            this.Name = "frmatv1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atividade 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btncalc1;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btncalc2;
        private System.Windows.Forms.Button btncalc3;
        private System.Windows.Forms.Label lblresul;
        private System.Windows.Forms.TextBox txtresul;
    }
}