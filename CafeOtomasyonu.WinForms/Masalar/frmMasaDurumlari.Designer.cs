namespace CafeOtomasyonu.WinForms.Menuler
{
    partial class frmMasaDurumlari
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMasaDurumlari));
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.groupIslemler = new DevExpress.XtraEditors.GroupControl();
			this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
			this.btnRezervYap = new DevExpress.XtraEditors.SimpleButton();
			this.btnMasaAc = new DevExpress.XtraEditors.SimpleButton();
			this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
			this.btnYenile = new DevExpress.XtraEditors.SimpleButton();
			this.btnSiparisEkle = new DevExpress.XtraEditors.SimpleButton();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			((System.ComponentModel.ISupportInitialize)(this.groupIslemler)).BeginInit();
			this.groupIslemler.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelControl1
			// 
			this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl1.Appearance.Options.UseFont = true;
			this.labelControl1.Appearance.Options.UseTextOptions = true;
			this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.labelControl1.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelControl1.Location = new System.Drawing.Point(0, 0);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(1429, 47);
			this.labelControl1.TabIndex = 2;
			this.labelControl1.Text = "Masa Durumları";
			// 
			// groupIslemler
			// 
			this.groupIslemler.Controls.Add(this.simpleButton2);
			this.groupIslemler.Controls.Add(this.btnRezervYap);
			this.groupIslemler.Controls.Add(this.btnMasaAc);
			this.groupIslemler.Controls.Add(this.btnKapat);
			this.groupIslemler.Controls.Add(this.btnYenile);
			this.groupIslemler.Controls.Add(this.btnSiparisEkle);
			this.groupIslemler.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.groupIslemler.Location = new System.Drawing.Point(0, 668);
			this.groupIslemler.Name = "groupIslemler";
			this.groupIslemler.Size = new System.Drawing.Size(1429, 100);
			this.groupIslemler.TabIndex = 6;
			this.groupIslemler.Text = "İşlemler";
			// 
			// simpleButton2
			// 
			this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
			this.simpleButton2.Location = new System.Drawing.Point(1494, 43);
			this.simpleButton2.Name = "simpleButton2";
			this.simpleButton2.Size = new System.Drawing.Size(94, 45);
			this.simpleButton2.TabIndex = 0;
			this.simpleButton2.Text = "Masa Aç";
			// 
			// btnRezervYap
			// 
			this.btnRezervYap.Enabled = false;
			this.btnRezervYap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRezervYap.ImageOptions.Image")));
			this.btnRezervYap.Location = new System.Drawing.Point(317, 43);
			this.btnRezervYap.Name = "btnRezervYap";
			this.btnRezervYap.Size = new System.Drawing.Size(153, 45);
			this.btnRezervYap.TabIndex = 0;
			this.btnRezervYap.Text = "Rezerve Yap";
			this.btnRezervYap.Click += new System.EventHandler(this.btnRezervYap_Click);
			// 
			// btnMasaAc
			// 
			this.btnMasaAc.Enabled = false;
			this.btnMasaAc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMasaAc.ImageOptions.Image")));
			this.btnMasaAc.Location = new System.Drawing.Point(158, 43);
			this.btnMasaAc.Name = "btnMasaAc";
			this.btnMasaAc.Size = new System.Drawing.Size(153, 45);
			this.btnMasaAc.TabIndex = 0;
			this.btnMasaAc.Text = "Masa Aç";
			this.btnMasaAc.Click += new System.EventHandler(this.btnMasaAc_Click);
			// 
			// btnKapat
			// 
			this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnKapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.ImageOptions.Image")));
			this.btnKapat.Location = new System.Drawing.Point(1323, 43);
			this.btnKapat.Name = "btnKapat";
			this.btnKapat.Size = new System.Drawing.Size(94, 45);
			this.btnKapat.TabIndex = 0;
			this.btnKapat.Text = "Kapat";
			this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
			// 
			// btnYenile
			// 
			this.btnYenile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnYenile.ImageOptions.Image")));
			this.btnYenile.Location = new System.Drawing.Point(476, 43);
			this.btnYenile.Name = "btnYenile";
			this.btnYenile.Size = new System.Drawing.Size(153, 45);
			this.btnYenile.TabIndex = 0;
			this.btnYenile.Text = "Yenile-Listele";
			// 
			// btnSiparisEkle
			// 
			this.btnSiparisEkle.Enabled = false;
			this.btnSiparisEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSiparisEkle.ImageOptions.Image")));
			this.btnSiparisEkle.Location = new System.Drawing.Point(12, 43);
			this.btnSiparisEkle.Name = "btnSiparisEkle";
			this.btnSiparisEkle.Size = new System.Drawing.Size(140, 45);
			this.btnSiparisEkle.TabIndex = 0;
			this.btnSiparisEkle.Text = "Siparişler";
			this.btnSiparisEkle.Click += new System.EventHandler(this.btnSiparisEkle_Click);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 47);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(1429, 621);
			this.flowLayoutPanel1.TabIndex = 7;
			// 
			// frmMasaDurumlari
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1429, 768);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Controls.Add(this.groupIslemler);
			this.Controls.Add(this.labelControl1);
			this.Name = "frmMasaDurumlari";
			this.Text = "Masa Durumları";
			((System.ComponentModel.ISupportInitialize)(this.groupIslemler)).EndInit();
			this.groupIslemler.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.GroupControl groupIslemler;
		private DevExpress.XtraEditors.SimpleButton simpleButton2;
		private DevExpress.XtraEditors.SimpleButton btnRezervYap;
		private DevExpress.XtraEditors.SimpleButton btnMasaAc;
		private DevExpress.XtraEditors.SimpleButton btnKapat;
		private DevExpress.XtraEditors.SimpleButton btnYenile;
		private DevExpress.XtraEditors.SimpleButton btnSiparisEkle;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
	}
}