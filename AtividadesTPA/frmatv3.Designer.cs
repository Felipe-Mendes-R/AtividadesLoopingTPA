namespace AtividadesTPA
{
    partial class frmatv3
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
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btncalc = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblresul
            // 
            this.lblresul.AutoSize = true;
            this.lblresul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblresul.Location = new System.Drawing.Point(127, 139);
            this.lblresul.Name = "lblresul";
            this.lblresul.Size = new System.Drawing.Size(86, 20);
            this.lblresul.TabIndex = 17;
            this.lblresul.Text = "Resultado:";
            // 
            // txtresul
            // 
            this.txtresul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtresul.Location = new System.Drawing.Point(389, 139);
            this.txtresul.Multiline = true;
            this.txtresul.Name = "txtresul";
            this.txtresul.ReadOnly = true;
            this.txtresul.Size = new System.Drawing.Size(284, 170);
            this.txtresul.TabIndex = 16;
            // 
            // btnvoltar
            // 
            this.btnvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.Location = new System.Drawing.Point(495, 346);
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
            this.btnlimpar.Location = new System.Drawing.Point(332, 346);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(109, 36);
            this.btnlimpar.TabIndex = 12;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btncalc
            // 
            this.btncalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalc.Location = new System.Drawing.Point(167, 346);
            this.btncalc.Name = "btncalc";
            this.btncalc.Size = new System.Drawing.Size(109, 36);
            this.btncalc.TabIndex = 11;
            this.btncalc.Text = "Calcular";
            this.btncalc.UseVisualStyleBackColor = true;
            this.btncalc.Click += new System.EventHandler(this.btncalc_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl1.Location = new System.Drawing.Point(127, 24);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(203, 20);
            this.lbl1.TabIndex = 10;
            this.lbl1.Text = "Digite a largura do cômodo:";
            // 
            // txtnum1
            // 
            this.txtnum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtnum1.Location = new System.Drawing.Point(436, 24);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(237, 26);
            this.txtnum1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(127, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Digite o comprimento do cômodo:";
            // 
            // txtnum2
            // 
            this.txtnum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtnum2.Location = new System.Drawing.Point(436, 82);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(237, 26);
            this.txtnum2.TabIndex = 19;
            // 
            // frmatv3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.lblresul);
            this.Controls.Add(this.txtresul);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncalc);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtnum1);
            this.Name = "frmatv3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atividade 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblresul;
        private System.Windows.Forms.TextBox txtresul;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btncalc;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnum2;
    }
}