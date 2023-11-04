namespace ListBoxDeneme
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
            this.lbl_ekle = new System.Windows.Forms.Label();
            this.msg_ekle = new System.Windows.Forms.TextBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.ben_count = new System.Windows.Forms.Button();
            this.btn_tem = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbl_ekle
            // 
            this.lbl_ekle.AutoSize = true;
            this.lbl_ekle.Location = new System.Drawing.Point(67, 39);
            this.lbl_ekle.Name = "lbl_ekle";
            this.lbl_ekle.Size = new System.Drawing.Size(163, 13);
            this.lbl_ekle.TabIndex = 0;
            this.lbl_ekle.Text = "Eklemek istediğiniz değeri giriniz :";
            this.lbl_ekle.Click += new System.EventHandler(this.label1_Click);
            // 
            // msg_ekle
            // 
            this.msg_ekle.Location = new System.Drawing.Point(236, 39);
            this.msg_ekle.Name = "msg_ekle";
            this.msg_ekle.Size = new System.Drawing.Size(116, 20);
            this.msg_ekle.TabIndex = 1;
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(236, 74);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(77, 37);
            this.btn_ekle.TabIndex = 2;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(236, 115);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(77, 37);
            this.btn_sil.TabIndex = 3;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // ben_count
            // 
            this.ben_count.Location = new System.Drawing.Point(236, 160);
            this.ben_count.Name = "ben_count";
            this.ben_count.Size = new System.Drawing.Size(77, 37);
            this.ben_count.TabIndex = 4;
            this.ben_count.Text = "Count";
            this.ben_count.UseVisualStyleBackColor = true;
            this.ben_count.Click += new System.EventHandler(this.ben_count_Click);
            // 
            // btn_tem
            // 
            this.btn_tem.Location = new System.Drawing.Point(236, 201);
            this.btn_tem.Name = "btn_tem";
            this.btn_tem.Size = new System.Drawing.Size(77, 37);
            this.btn_tem.TabIndex = 5;
            this.btn_tem.Text = "Temizle";
            this.btn_tem.UseVisualStyleBackColor = true;
            this.btn_tem.Click += new System.EventHandler(this.btn_tem_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Pazartesi",
            "Salı",
            "Çarşamba"});
            this.listBox1.Location = new System.Drawing.Point(79, 87);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_tem);
            this.Controls.Add(this.ben_count);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.msg_ekle);
            this.Controls.Add(this.lbl_ekle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ekle;
        private System.Windows.Forms.TextBox msg_ekle;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button ben_count;
        private System.Windows.Forms.Button btn_tem;
        private System.Windows.Forms.ListBox listBox1;
    }
}

