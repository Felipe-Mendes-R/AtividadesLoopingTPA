namespace AtividadesTPA
{
    partial class frmatv2
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
            this.lblresul = new System.Windows.Forms.Label();
            this.txtresul = new System.Windows.Forms.TextBox();
            this.btncalc3 = new System.Windows.Forms.Button();
            this.btncalc2 = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btncalc1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblresul
            // 
            this.lblresul.AutoSize = true;
            this.lblresul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblresul.Location = new System.Drawing.Point(127, 22);
            this.lblresul.Name = "lblresul";
            this.lblresul.Size = new System.Drawing.Size(86, 20);
            this.lblresul.TabIndex = 17;
            this.lblresul.Text = "Resultado:";
            // 
            // txtresul
            // 
            this.txtresul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtresul.Location = new System.Drawing.Point(436, 22);
            this.txtresul.Multiline = true;
            this.txtresul.Name = "txtresul";
            this.txtresul.ReadOnly = true;
            this.txtresul.Size = new System.Drawing.Size(237, 251);
            this.txtresul.TabIndex = 16;
            // 
            // btncalc3
            // 
            this.btncalc3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalc3.Location = new System.Drawing.Point(131, 376);
            this.btncalc3.Name = "btncalc3";
            this.btncalc3.Size = new System.Drawing.Size(169, 36);
            this.btncalc3.TabIndex = 15;
            this.btncalc3.Text = "Calcular (for)";
            this.btncalc3.UseVisualStyleBackColor = true;
            this.btncalc3.Click += new System.EventHandler(this.btncalc3_Click);
            // 
            // btncalc2
            // 
            this.btncalc2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalc2.Location = new System.Drawing.Point(131, 334);
            this.btncalc2.Name = "btncalc2";
            this.btncalc2.Size = new System.Drawing.Size(169, 36);
            this.btncalc2.TabIndex = 14;
            this.btncalc2.Text = "Calcular (do while)";
            this.btncalc2.UseVisualStyleBackColor = true;
            this.btncalc2.Click += new System.EventHandler(this.btncalc2_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.Location = new System.Drawing.Point(564, 334);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(109, 36);
            this.btnvoltar.TabIndex = 13;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.Location = new System.Drawing.Point(382, 334);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(109, 36);
            this.btnlimpar.TabIndex = 12;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btncalc1
            // 
            this.btncalc1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalc1.Location = new System.Drawing.Point(131, 292);
            this.btncalc1.Name = "btncalc1";
            this.btncalc1.Size = new System.Drawing.Size(169, 36);
            this.btncalc1.TabIndex = 11;
            this.btncalc1.Text = "Calcular (while)";
            this.btncalc1.UseVisualStyleBackColor = true;
            this.btncalc1.Click += new System.EventHandler(this.btncalc1_Click);
            // 
            // frmatv2
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
            this.Name = "frmatv2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atividade 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblresul;
        private System.Windows.Forms.TextBox txtresul;
        private System.Windows.Forms.Button btncalc3;
        private System.Windows.Forms.Button btncalc2;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btncalc1;
    }
}