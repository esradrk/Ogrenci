﻿namespace haftadokuz
{
    partial class frmOgnKayit
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
            this.grpogrenci = new System.Windows.Forms.GroupBox();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.txtno = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.lblno = new System.Windows.Forms.Label();
            this.lblsoyad = new System.Windows.Forms.Label();
            this.lblad = new System.Windows.Forms.Label();
            this.grpogrenci.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpogrenci
            // 
            this.grpogrenci.Controls.Add(this.txtno);
            this.grpogrenci.Controls.Add(this.txtsoyad);
            this.grpogrenci.Controls.Add(this.txtad);
            this.grpogrenci.Controls.Add(this.lblno);
            this.grpogrenci.Controls.Add(this.lblsoyad);
            this.grpogrenci.Controls.Add(this.lblad);
            this.grpogrenci.Location = new System.Drawing.Point(47, 27);
            this.grpogrenci.Name = "grpogrenci";
            this.grpogrenci.Size = new System.Drawing.Size(220, 150);
            this.grpogrenci.TabIndex = 0;
            this.grpogrenci.TabStop = false;
            this.grpogrenci.Text = "Öğrenci Bilgileri";
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(110, 183);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(93, 23);
            this.btnkaydet.TabIndex = 6;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
           this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // txtno
            // 
            this.txtno.Location = new System.Drawing.Point(82, 113);
            this.txtno.MaxLength = 15;
            this.txtno.Name = "txtno";
            this.txtno.Size = new System.Drawing.Size(100, 20);
            this.txtno.TabIndex = 5;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(82, 62);
            this.txtsoyad.MaxLength = 30;
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(100, 20);
            this.txtsoyad.TabIndex = 4;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(82, 23);
            this.txtad.MaxLength = 20;
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(100, 20);
            this.txtad.TabIndex = 3;
            // 
            // lblno
            // 
            this.lblno.AutoSize = true;
            this.lblno.Location = new System.Drawing.Point(11, 116);
            this.lblno.Name = "lblno";
            this.lblno.Size = new System.Drawing.Size(44, 13);
            this.lblno.TabIndex = 2;
            this.lblno.Text = "Numara";
            // 
            // lblsoyad
            // 
            this.lblsoyad.AutoSize = true;
            this.lblsoyad.Location = new System.Drawing.Point(11, 65);
            this.lblsoyad.Name = "lblsoyad";
            this.lblsoyad.Size = new System.Drawing.Size(37, 13);
            this.lblsoyad.TabIndex = 1;
            this.lblsoyad.Text = "Soyad";
            // 
            // lblad
            // 
            this.lblad.AutoSize = true;
            this.lblad.Location = new System.Drawing.Point(11, 23);
            this.lblad.Name = "lblad";
            this.lblad.Size = new System.Drawing.Size(20, 13);
            this.lblad.TabIndex = 0;
            this.lblad.Text = "Ad";
            // 
            // frmOgnKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 235);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.grpogrenci);
            this.Name = "frmOgnKayit";
            this.Text = "Öğrenci Kayıt İşlemleri";
            this.grpogrenci.ResumeLayout(false);
            this.grpogrenci.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpogrenci;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.TextBox txtno;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label lblno;
        private System.Windows.Forms.Label lblsoyad;
        private System.Windows.Forms.Label lblad;
    }
}

