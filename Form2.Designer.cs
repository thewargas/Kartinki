namespace Kartinki
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelim = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listok = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.labelim);
            this.panel1.Location = new System.Drawing.Point(-7, -32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 79);
            this.panel1.TabIndex = 0;
            // 
            // labelim
            // 
            this.labelim.AutoSize = true;
            this.labelim.Location = new System.Drawing.Point(16, 48);
            this.labelim.Name = "labelim";
            this.labelim.Size = new System.Drawing.Size(35, 13);
            this.labelim.TabIndex = 0;
            this.labelim.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(12, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 600);
            this.panel2.TabIndex = 2;
            // 
            // listok
            // 
            this.listok.FormattingEnabled = true;
            this.listok.Items.AddRange(new object[] {
            "car",
            "che",
            "lod"});
            this.listok.Location = new System.Drawing.Point(671, 51);
            this.listok.Name = "listok";
            this.listok.Size = new System.Drawing.Size(120, 95);
            this.listok.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 684);
            this.Controls.Add(this.listok);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Activated += new System.EventHandler(this.Form2_Activated);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label labelim;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listok;
    }
}