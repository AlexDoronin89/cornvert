
namespace Cornevter
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonTransRub = new System.Windows.Forms.Button();
            this.labelBalanceEur = new System.Windows.Forms.Label();
            this.labelBalanceDol = new System.Windows.Forms.Label();
            this.labelBalanceRub = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonTransEur = new System.Windows.Forms.Button();
            this.buttonTransDol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Баланс";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Перевод в валюты";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(439, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "евро";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(434, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "долары";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(434, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "рубли";
            // 
            // buttonTransRub
            // 
            this.buttonTransRub.Location = new System.Drawing.Point(318, 128);
            this.buttonTransRub.Name = "buttonTransRub";
            this.buttonTransRub.Size = new System.Drawing.Size(110, 29);
            this.buttonTransRub.TabIndex = 11;
            this.buttonTransRub.Text = "Перевод";
            this.buttonTransRub.UseVisualStyleBackColor = true;
            this.buttonTransRub.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelBalanceEur
            // 
            this.labelBalanceEur.AutoSize = true;
            this.labelBalanceEur.Location = new System.Drawing.Point(404, 53);
            this.labelBalanceEur.Name = "labelBalanceEur";
            this.labelBalanceEur.Size = new System.Drawing.Size(13, 13);
            this.labelBalanceEur.TabIndex = 12;
            this.labelBalanceEur.Text = "0";
            // 
            // labelBalanceDol
            // 
            this.labelBalanceDol.AutoSize = true;
            this.labelBalanceDol.Location = new System.Drawing.Point(337, 53);
            this.labelBalanceDol.Name = "labelBalanceDol";
            this.labelBalanceDol.Size = new System.Drawing.Size(13, 13);
            this.labelBalanceDol.TabIndex = 13;
            this.labelBalanceDol.Text = "0";
            // 
            // labelBalanceRub
            // 
            this.labelBalanceRub.AutoSize = true;
            this.labelBalanceRub.Location = new System.Drawing.Point(268, 53);
            this.labelBalanceRub.Name = "labelBalanceRub";
            this.labelBalanceRub.Size = new System.Drawing.Size(13, 13);
            this.labelBalanceRub.TabIndex = 14;
            this.labelBalanceRub.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(395, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Евро";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(328, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Долары";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(250, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Рубли";
            // 
            // buttonTransEur
            // 
            this.buttonTransEur.Location = new System.Drawing.Point(317, 198);
            this.buttonTransEur.Name = "buttonTransEur";
            this.buttonTransEur.Size = new System.Drawing.Size(110, 29);
            this.buttonTransEur.TabIndex = 18;
            this.buttonTransEur.Text = "Перевод";
            this.buttonTransEur.UseVisualStyleBackColor = true;
            this.buttonTransEur.Click += new System.EventHandler(this.buttonTransEur_Click);
            // 
            // buttonTransDol
            // 
            this.buttonTransDol.Location = new System.Drawing.Point(318, 163);
            this.buttonTransDol.Name = "buttonTransDol";
            this.buttonTransDol.Size = new System.Drawing.Size(110, 29);
            this.buttonTransDol.TabIndex = 19;
            this.buttonTransDol.Text = "Перевод";
            this.buttonTransDol.UseVisualStyleBackColor = true;
            this.buttonTransDol.Click += new System.EventHandler(this.buttonTransDol_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonTransDol);
            this.Controls.Add(this.buttonTransEur);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelBalanceRub);
            this.Controls.Add(this.labelBalanceDol);
            this.Controls.Add(this.labelBalanceEur);
            this.Controls.Add(this.buttonTransRub);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonTransRub;
        private System.Windows.Forms.Label labelBalanceEur;
        private System.Windows.Forms.Label labelBalanceDol;
        private System.Windows.Forms.Label labelBalanceRub;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonTransEur;
        private System.Windows.Forms.Button buttonTransDol;
    }
}

