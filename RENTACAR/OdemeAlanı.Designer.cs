namespace RENTACAR
{
    partial class OdemeAlanı
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_kartsahibi = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txt_kartno = new System.Windows.Forms.TextBox();
            this.txt_ay = new System.Windows.Forms.TextBox();
            this.txt_cvv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_yil = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kart Sahibinin Adı Soyadı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kart Numarası";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Son Kullanma Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "CVV";
            // 
            // txt_kartsahibi
            // 
            this.txt_kartsahibi.Location = new System.Drawing.Point(280, 55);
            this.txt_kartsahibi.Name = "txt_kartsahibi";
            this.txt_kartsahibi.Size = new System.Drawing.Size(259, 22);
            this.txt_kartsahibi.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(280, 103);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(259, 22);
            this.textBox2.TabIndex = 5;
            // 
            // txt_kartno
            // 
            this.txt_kartno.Location = new System.Drawing.Point(280, 103);
            this.txt_kartno.Name = "txt_kartno";
            this.txt_kartno.Size = new System.Drawing.Size(259, 22);
            this.txt_kartno.TabIndex = 6;
            // 
            // txt_ay
            // 
            this.txt_ay.Location = new System.Drawing.Point(280, 156);
            this.txt_ay.Name = "txt_ay";
            this.txt_ay.Size = new System.Drawing.Size(26, 22);
            this.txt_ay.TabIndex = 7;
            // 
            // txt_cvv
            // 
            this.txt_cvv.Location = new System.Drawing.Point(280, 209);
            this.txt_cvv.Name = "txt_cvv";
            this.txt_cvv.Size = new System.Drawing.Size(68, 22);
            this.txt_cvv.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(312, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "/";
            // 
            // txt_yil
            // 
            this.txt_yil.Location = new System.Drawing.Point(330, 156);
            this.txt_yil.Name = "txt_yil";
            this.txt_yil.Size = new System.Drawing.Size(26, 22);
            this.txt_yil.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(280, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 35);
            this.button1.TabIndex = 11;
            this.button1.Text = "ÖDEME YAP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // OdemeAlanı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 412);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_yil);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_cvv);
            this.Controls.Add(this.txt_ay);
            this.Controls.Add(this.txt_kartno);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txt_kartsahibi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OdemeAlanı";
            this.Text = "OdemeAlanı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_kartsahibi;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txt_kartno;
        private System.Windows.Forms.TextBox txt_ay;
        private System.Windows.Forms.TextBox txt_cvv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_yil;
        private System.Windows.Forms.Button button1;
    }
}