namespace AtividadesTPA
{
    partial class frmmenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.atividadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiatv1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiatv2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiatv3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmisair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atividadesToolStripMenuItem,
            this.tsmisair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // atividadesToolStripMenuItem
            // 
            this.atividadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiatv1,
            this.tsmiatv2,
            this.tsmiatv3});
            this.atividadesToolStripMenuItem.Name = "atividadesToolStripMenuItem";
            this.atividadesToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.atividadesToolStripMenuItem.Text = "Atividades";
            // 
            // tsmiatv1
            // 
            this.tsmiatv1.Name = "tsmiatv1";
            this.tsmiatv1.Size = new System.Drawing.Size(133, 22);
            this.tsmiatv1.Text = "Atividade 1";
            this.tsmiatv1.Click += new System.EventHandler(this.tsmiatv1_Click);
            // 
            // tsmiatv2
            // 
            this.tsmiatv2.Name = "tsmiatv2";
            this.tsmiatv2.Size = new System.Drawing.Size(180, 22);
            this.tsmiatv2.Text = "Atividade 2";
            this.tsmiatv2.Click += new System.EventHandler(this.tsmiatv2_Click);
            // 
            // tsmiatv3
            // 
            this.tsmiatv3.Name = "tsmiatv3";
            this.tsmiatv3.Size = new System.Drawing.Size(133, 22);
            this.tsmiatv3.Text = "Atividade 3";
            this.tsmiatv3.Click += new System.EventHandler(this.tsmiatv3_Click);
            // 
            // tsmisair
            // 
            this.tsmisair.Name = "tsmisair";
            this.tsmisair.Size = new System.Drawing.Size(38, 20);
            this.tsmisair.Text = "Sair";
            this.tsmisair.Click += new System.EventHandler(this.tsmisair_Click);
            // 
            // frmmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmmenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem atividadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiatv1;
        private System.Windows.Forms.ToolStripMenuItem tsmiatv2;
        private System.Windows.Forms.ToolStripMenuItem tsmiatv3;
        private System.Windows.Forms.ToolStripMenuItem tsmisair;
    }
}

