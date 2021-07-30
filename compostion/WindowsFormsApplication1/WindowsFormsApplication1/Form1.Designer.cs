namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.beygirTxt = new System.Windows.Forms.TextBox();
            this.torkTxt = new System.Windows.Forms.TextBox();
            this.mGucuTxt = new System.Windows.Forms.TextBox();
            this.renkTxt = new System.Windows.Forms.TextBox();
            this.kapiSayiTxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(393, 226);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(221, 196);
            this.listBox1.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(117, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Beygir";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Tork";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Motor Gücü";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Renk";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Kapı Sayısı";
            // 
            // beygirTxt
            // 
            this.beygirTxt.Location = new System.Drawing.Point(192, 271);
            this.beygirTxt.Name = "beygirTxt";
            this.beygirTxt.Size = new System.Drawing.Size(100, 22);
            this.beygirTxt.TabIndex = 17;
            // 
            // torkTxt
            // 
            this.torkTxt.Location = new System.Drawing.Point(192, 221);
            this.torkTxt.Name = "torkTxt";
            this.torkTxt.Size = new System.Drawing.Size(100, 22);
            this.torkTxt.TabIndex = 16;
            // 
            // mGucuTxt
            // 
            this.mGucuTxt.Location = new System.Drawing.Point(192, 179);
            this.mGucuTxt.Name = "mGucuTxt";
            this.mGucuTxt.Size = new System.Drawing.Size(100, 22);
            this.mGucuTxt.TabIndex = 15;
            // 
            // renkTxt
            // 
            this.renkTxt.Location = new System.Drawing.Point(192, 139);
            this.renkTxt.Name = "renkTxt";
            this.renkTxt.Size = new System.Drawing.Size(100, 22);
            this.renkTxt.TabIndex = 14;
            // 
            // kapiSayiTxt
            // 
            this.kapiSayiTxt.Location = new System.Drawing.Point(192, 96);
            this.kapiSayiTxt.Name = "kapiSayiTxt";
            this.kapiSayiTxt.Size = new System.Drawing.Size(100, 22);
            this.kapiSayiTxt.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(382, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 92);
            this.button1.TabIndex = 12;
            this.button1.Text = "KAYDET";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 550);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.beygirTxt);
            this.Controls.Add(this.torkTxt);
            this.Controls.Add(this.mGucuTxt);
            this.Controls.Add(this.renkTxt);
            this.Controls.Add(this.kapiSayiTxt);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox beygirTxt;
        private System.Windows.Forms.TextBox torkTxt;
        private System.Windows.Forms.TextBox mGucuTxt;
        private System.Windows.Forms.TextBox renkTxt;
        private System.Windows.Forms.TextBox kapiSayiTxt;
        private System.Windows.Forms.Button button1;
    }
}

