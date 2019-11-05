namespace Donguler
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
            this.btnOrnekYedi = new System.Windows.Forms.Button();
            this.txtGirisAlani = new System.Windows.Forms.TextBox();
            this.btnOrnekAlti = new System.Windows.Forms.Button();
            this.btnOrnekBes = new System.Windows.Forms.Button();
            this.btnOrnekDort = new System.Windows.Forms.Button();
            this.btnOrnekUc = new System.Windows.Forms.Button();
            this.btnOrnekIki = new System.Windows.Forms.Button();
            this.btnOrnekBir = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnOrnekYedi
            // 
            this.btnOrnekYedi.Location = new System.Drawing.Point(187, 314);
            this.btnOrnekYedi.Name = "btnOrnekYedi";
            this.btnOrnekYedi.Size = new System.Drawing.Size(356, 40);
            this.btnOrnekYedi.TabIndex = 26;
            this.btnOrnekYedi.Text = "TOPLAMA YAP";
            this.btnOrnekYedi.UseVisualStyleBackColor = true;
            this.btnOrnekYedi.Click += new System.EventHandler(this.btnOrnekYedi_Click);
            // 
            // txtGirisAlani
            // 
            this.txtGirisAlani.Location = new System.Drawing.Point(187, 288);
            this.txtGirisAlani.Name = "txtGirisAlani";
            this.txtGirisAlani.Size = new System.Drawing.Size(356, 20);
            this.txtGirisAlani.TabIndex = 25;
            // 
            // btnOrnekAlti
            // 
            this.btnOrnekAlti.Location = new System.Drawing.Point(187, 242);
            this.btnOrnekAlti.Name = "btnOrnekAlti";
            this.btnOrnekAlti.Size = new System.Drawing.Size(356, 40);
            this.btnOrnekAlti.TabIndex = 24;
            this.btnOrnekAlti.Text = "BUTONLARIN STİLİNİ DEĞİŞTİR";
            this.btnOrnekAlti.UseVisualStyleBackColor = true;
            this.btnOrnekAlti.Click += new System.EventHandler(this.btnOrnekAlti_Click);
            // 
            // btnOrnekBes
            // 
            this.btnOrnekBes.Location = new System.Drawing.Point(187, 196);
            this.btnOrnekBes.Name = "btnOrnekBes";
            this.btnOrnekBes.Size = new System.Drawing.Size(356, 40);
            this.btnOrnekBes.TabIndex = 23;
            this.btnOrnekBes.Text = "KARMAŞIK SAYILARI LİSTBOXA AT";
            this.btnOrnekBes.UseVisualStyleBackColor = true;
            this.btnOrnekBes.Click += new System.EventHandler(this.btnOrnekBes_Click);
            // 
            // btnOrnekDort
            // 
            this.btnOrnekDort.Location = new System.Drawing.Point(187, 150);
            this.btnOrnekDort.Name = "btnOrnekDort";
            this.btnOrnekDort.Size = new System.Drawing.Size(356, 40);
            this.btnOrnekDort.TabIndex = 22;
            this.btnOrnekDort.Text = "İSMİNİ TERSTEN YAZDIR";
            this.btnOrnekDort.UseVisualStyleBackColor = true;
            this.btnOrnekDort.Click += new System.EventHandler(this.btnOrnekDort_Click);
            // 
            // btnOrnekUc
            // 
            this.btnOrnekUc.Location = new System.Drawing.Point(187, 104);
            this.btnOrnekUc.Name = "btnOrnekUc";
            this.btnOrnekUc.Size = new System.Drawing.Size(356, 40);
            this.btnOrnekUc.TabIndex = 21;
            this.btnOrnekUc.Text = "TEKLERİN VE ÇİFTLERİN SAYISINI GÖSTER";
            this.btnOrnekUc.UseVisualStyleBackColor = true;
            this.btnOrnekUc.Click += new System.EventHandler(this.btnOrnekUc_Click);
            // 
            // btnOrnekIki
            // 
            this.btnOrnekIki.Location = new System.Drawing.Point(187, 58);
            this.btnOrnekIki.Name = "btnOrnekIki";
            this.btnOrnekIki.Size = new System.Drawing.Size(356, 40);
            this.btnOrnekIki.TabIndex = 20;
            this.btnOrnekIki.Text = "EN BÜYÜĞÜ GÖSTER";
            this.btnOrnekIki.UseVisualStyleBackColor = true;
            this.btnOrnekIki.Click += new System.EventHandler(this.btnOrnekIki_Click);
            // 
            // btnOrnekBir
            // 
            this.btnOrnekBir.Location = new System.Drawing.Point(187, 12);
            this.btnOrnekBir.Name = "btnOrnekBir";
            this.btnOrnekBir.Size = new System.Drawing.Size(356, 40);
            this.btnOrnekBir.TabIndex = 19;
            this.btnOrnekBir.Text = "TAKIMLARI LİSTEYE EKLE";
            this.btnOrnekBir.UseVisualStyleBackColor = true;
            this.btnOrnekBir.Click += new System.EventHandler(this.btnOrnekBir_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(168, 342);
            this.listBox1.TabIndex = 18;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 366);
            this.Controls.Add(this.btnOrnekYedi);
            this.Controls.Add(this.txtGirisAlani);
            this.Controls.Add(this.btnOrnekAlti);
            this.Controls.Add(this.btnOrnekBes);
            this.Controls.Add(this.btnOrnekDort);
            this.Controls.Add(this.btnOrnekUc);
            this.Controls.Add(this.btnOrnekIki);
            this.Controls.Add(this.btnOrnekBir);
            this.Controls.Add(this.listBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrnekYedi;
        private System.Windows.Forms.TextBox txtGirisAlani;
        private System.Windows.Forms.Button btnOrnekAlti;
        private System.Windows.Forms.Button btnOrnekBes;
        private System.Windows.Forms.Button btnOrnekDort;
        private System.Windows.Forms.Button btnOrnekUc;
        private System.Windows.Forms.Button btnOrnekIki;
        private System.Windows.Forms.Button btnOrnekBir;
        private System.Windows.Forms.ListBox listBox1;
    }
}