
namespace bilgi_yarismasi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.LblA = new System.Windows.Forms.Button();
            this.LblB = new System.Windows.Forms.Button();
            this.LblC = new System.Windows.Forms.Button();
            this.LblD = new System.Windows.Forms.Button();
            this.LblSonraki = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.LblSoruNo = new System.Windows.Forms.Label();
            this.LblDogru = new System.Windows.Forms.Label();
            this.LblYanlis = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(15, 17);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(543, 234);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // LblA
            // 
            this.LblA.Location = new System.Drawing.Point(17, 262);
            this.LblA.Margin = new System.Windows.Forms.Padding(4);
            this.LblA.Name = "LblA";
            this.LblA.Size = new System.Drawing.Size(267, 74);
            this.LblA.TabIndex = 1;
            this.LblA.Text = "A";
            this.LblA.UseVisualStyleBackColor = true;
            this.LblA.Click += new System.EventHandler(this.LblA_Click);
            // 
            // LblB
            // 
            this.LblB.Location = new System.Drawing.Point(292, 262);
            this.LblB.Margin = new System.Windows.Forms.Padding(4);
            this.LblB.Name = "LblB";
            this.LblB.Size = new System.Drawing.Size(267, 74);
            this.LblB.TabIndex = 2;
            this.LblB.Text = "B";
            this.LblB.UseVisualStyleBackColor = true;
            this.LblB.Click += new System.EventHandler(this.LblB_Click);
            // 
            // LblC
            // 
            this.LblC.Location = new System.Drawing.Point(17, 344);
            this.LblC.Margin = new System.Windows.Forms.Padding(4);
            this.LblC.Name = "LblC";
            this.LblC.Size = new System.Drawing.Size(267, 74);
            this.LblC.TabIndex = 3;
            this.LblC.Text = "C";
            this.LblC.UseVisualStyleBackColor = true;
            this.LblC.Click += new System.EventHandler(this.LblC_Click);
            // 
            // LblD
            // 
            this.LblD.Location = new System.Drawing.Point(292, 344);
            this.LblD.Margin = new System.Windows.Forms.Padding(4);
            this.LblD.Name = "LblD";
            this.LblD.Size = new System.Drawing.Size(267, 74);
            this.LblD.TabIndex = 4;
            this.LblD.Text = "D";
            this.LblD.UseVisualStyleBackColor = true;
            this.LblD.Click += new System.EventHandler(this.LblD_Click);
            // 
            // LblSonraki
            // 
            this.LblSonraki.Location = new System.Drawing.Point(630, 262);
            this.LblSonraki.Margin = new System.Windows.Forms.Padding(4);
            this.LblSonraki.Name = "LblSonraki";
            this.LblSonraki.Size = new System.Drawing.Size(267, 74);
            this.LblSonraki.TabIndex = 5;
            this.LblSonraki.Text = "Sonraki";
            this.LblSonraki.UseVisualStyleBackColor = true;
            this.LblSonraki.Click += new System.EventHandler(this.LblSonraki_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(630, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Soru No:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(644, 81);
            this.lbl2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(57, 21);
            this.lbl2.TabIndex = 7;
            this.lbl2.Text = "Doğru:";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(648, 126);
            this.lbl3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(53, 21);
            this.lbl3.TabIndex = 8;
            this.lbl3.Text = "Yanlış:";
            // 
            // LblSoruNo
            // 
            this.LblSoruNo.AutoSize = true;
            this.LblSoruNo.Location = new System.Drawing.Point(711, 38);
            this.LblSoruNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSoruNo.Name = "LblSoruNo";
            this.LblSoruNo.Size = new System.Drawing.Size(19, 21);
            this.LblSoruNo.TabIndex = 9;
            this.LblSoruNo.Text = "0";
            // 
            // LblDogru
            // 
            this.LblDogru.AutoSize = true;
            this.LblDogru.Location = new System.Drawing.Point(711, 81);
            this.LblDogru.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDogru.Name = "LblDogru";
            this.LblDogru.Size = new System.Drawing.Size(19, 21);
            this.LblDogru.TabIndex = 10;
            this.LblDogru.Text = "0";
            // 
            // LblYanlis
            // 
            this.LblYanlis.AutoSize = true;
            this.LblYanlis.Location = new System.Drawing.Point(711, 126);
            this.LblYanlis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblYanlis.Name = "LblYanlis";
            this.LblYanlis.Size = new System.Drawing.Size(19, 21);
            this.LblYanlis.TabIndex = 11;
            this.LblYanlis.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(591, 376);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(758, 376);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(139, 118);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 444);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 444);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 528);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LblYanlis);
            this.Controls.Add(this.LblDogru);
            this.Controls.Add(this.LblSoruNo);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblSonraki);
            this.Controls.Add(this.LblD);
            this.Controls.Add(this.LblC);
            this.Controls.Add(this.LblB);
            this.Controls.Add(this.LblA);
            this.Controls.Add(this.richTextBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button LblA;
        private System.Windows.Forms.Button LblB;
        private System.Windows.Forms.Button LblC;
        private System.Windows.Forms.Button LblD;
        private System.Windows.Forms.Button LblSonraki;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label LblSoruNo;
        private System.Windows.Forms.Label LblDogru;
        private System.Windows.Forms.Label LblYanlis;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

