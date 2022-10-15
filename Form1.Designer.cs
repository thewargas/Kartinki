namespace Kartinki
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtim = new System.Windows.Forms.TextBox();
            this.btnfrm = new System.Windows.Forms.Button();
            this.txtchi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtim
            // 
            this.txtim.Location = new System.Drawing.Point(97, 55);
            this.txtim.Name = "txtim";
            this.txtim.Size = new System.Drawing.Size(113, 20);
            this.txtim.TabIndex = 0;
            // 
            // btnfrm
            // 
            this.btnfrm.Location = new System.Drawing.Point(97, 106);
            this.btnfrm.Name = "btnfrm";
            this.btnfrm.Size = new System.Drawing.Size(113, 23);
            this.btnfrm.TabIndex = 1;
            this.btnfrm.Text = "Создать форму";
            this.btnfrm.UseVisualStyleBackColor = true;
            this.btnfrm.Click += new System.EventHandler(this.btnfrm_Click);
            // 
            // txtchi
            // 
            this.txtchi.Location = new System.Drawing.Point(97, 163);
            this.txtchi.Name = "txtchi";
            this.txtchi.Size = new System.Drawing.Size(113, 20);
            this.txtchi.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите Ваше имя:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введите число:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 238);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtchi);
            this.Controls.Add(this.btnfrm);
            this.Controls.Add(this.txtim);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtim;
        private System.Windows.Forms.Button btnfrm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtchi;
    }
}

