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
            this.lstAsker = new System.Windows.Forms.ListBox();
            this.lstSehir = new System.Windows.Forms.ListBox();
            this.lstDagitim = new System.Windows.Forms.ListBox();
            this.SehirEkle = new System.Windows.Forms.Button();
            this.DaigitimYap = new System.Windows.Forms.Button();
            this.AskerEkle = new System.Windows.Forms.Button();
            this.txtAsker = new System.Windows.Forms.TextBox();
            this.txtSehir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstAsker
            // 
            this.lstAsker.BackColor = System.Drawing.Color.Gold;
            this.lstAsker.FormattingEnabled = true;
            this.lstAsker.Location = new System.Drawing.Point(12, 25);
            this.lstAsker.Name = "lstAsker";
            this.lstAsker.Size = new System.Drawing.Size(246, 277);
            this.lstAsker.TabIndex = 0;
            // 
            // lstSehir
            // 
            this.lstSehir.FormattingEnabled = true;
            this.lstSehir.Location = new System.Drawing.Point(287, 25);
            this.lstSehir.Name = "lstSehir";
            this.lstSehir.Size = new System.Drawing.Size(261, 277);
            this.lstSehir.TabIndex = 1;
            // 
            // lstDagitim
            // 
            this.lstDagitim.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lstDagitim.FormattingEnabled = true;
            this.lstDagitim.Location = new System.Drawing.Point(582, 25);
            this.lstDagitim.Name = "lstDagitim";
            this.lstDagitim.Size = new System.Drawing.Size(321, 277);
            this.lstDagitim.TabIndex = 2;
            // 
            // SehirEkle
            // 
            this.SehirEkle.BackColor = System.Drawing.Color.Maroon;
            this.SehirEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SehirEkle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SehirEkle.Location = new System.Drawing.Point(365, 367);
            this.SehirEkle.Name = "SehirEkle";
            this.SehirEkle.Size = new System.Drawing.Size(157, 65);
            this.SehirEkle.TabIndex = 4;
            this.SehirEkle.Text = "Şehir Ekle";
            this.SehirEkle.UseVisualStyleBackColor = false;
            this.SehirEkle.Click += new System.EventHandler(this.SehirEkle_Click);
            // 
            // DaigitimYap
            // 
            this.DaigitimYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.DaigitimYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DaigitimYap.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DaigitimYap.Location = new System.Drawing.Point(722, 365);
            this.DaigitimYap.Name = "DaigitimYap";
            this.DaigitimYap.Size = new System.Drawing.Size(181, 65);
            this.DaigitimYap.TabIndex = 5;
            this.DaigitimYap.Text = "Dağıtım Yap";
            this.DaigitimYap.UseVisualStyleBackColor = false;
            this.DaigitimYap.Click += new System.EventHandler(this.DagitimYap_Click);
            // 
            // AskerEkle
            // 
            this.AskerEkle.BackColor = System.Drawing.Color.Red;
            this.AskerEkle.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Bordo_Bereli_Yüzü_Boyalı_Kamufulajlı_Resim;
            this.AskerEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AskerEkle.ForeColor = System.Drawing.Color.Yellow;
            this.AskerEkle.Location = new System.Drawing.Point(103, 365);
            this.AskerEkle.Margin = new System.Windows.Forms.Padding(3, 3, 3, 4);
            this.AskerEkle.Name = "AskerEkle";
            this.AskerEkle.Size = new System.Drawing.Size(134, 67);
            this.AskerEkle.TabIndex = 6;
            this.AskerEkle.Text = "Asker Ekle";
            this.AskerEkle.UseVisualStyleBackColor = false;
            this.AskerEkle.Click += new System.EventHandler(this.AskerEkle_Click);
            // 
            // txtAsker
            // 
            this.txtAsker.Location = new System.Drawing.Point(137, 326);
            this.txtAsker.Name = "txtAsker";
            this.txtAsker.Size = new System.Drawing.Size(100, 20);
            this.txtAsker.TabIndex = 7;
            // 
            // txtSehir
            // 
            this.txtSehir.Location = new System.Drawing.Point(422, 326);
            this.txtSehir.Name = "txtSehir";
            this.txtSehir.Size = new System.Drawing.Size(100, 20);
            this.txtSehir.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(8, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "ASKER EKLE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(283, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "ŞEHİR EKLE:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(962, 533);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSehir);
            this.Controls.Add(this.txtAsker);
            this.Controls.Add(this.AskerEkle);
            this.Controls.Add(this.DaigitimYap);
            this.Controls.Add(this.SehirEkle);
            this.Controls.Add(this.lstDagitim);
            this.Controls.Add(this.lstSehir);
            this.Controls.Add(this.lstAsker);
            this.Name = "Form1";
            this.Text = "ASKER DAĞITIM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstAsker;
        private System.Windows.Forms.ListBox lstSehir;
        private System.Windows.Forms.ListBox lstDagitim;
        private System.Windows.Forms.Button SehirEkle;
        private System.Windows.Forms.Button DaigitimYap;
        private System.Windows.Forms.Button AskerEkle;
        private System.Windows.Forms.TextBox txtAsker;
        private System.Windows.Forms.TextBox txtSehir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

