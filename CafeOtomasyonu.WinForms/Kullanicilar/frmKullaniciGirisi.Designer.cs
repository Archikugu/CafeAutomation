namespace CafeOtomasyonu.WinForms.Kullanıcılar
{
	partial class frmKullaniciGirisi
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKullaniciGirisi));
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
			this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
			this.btnParolamiUnuttum = new DevExpress.XtraEditors.SimpleButton();
			this.btnGiris = new DevExpress.XtraEditors.SimpleButton();
			this.lblKaydol = new DevExpress.XtraEditors.HyperlinkLabelControl();
			this.checkBeniHatırla = new DevExpress.XtraEditors.CheckEdit();
			this.txtSifre = new DevExpress.XtraEditors.TextEdit();
			this.txtKullaniciAdi = new DevExpress.XtraEditors.TextEdit();
			this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
			this.groupControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.checkBeniHatırla.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
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
			this.labelControl1.Size = new System.Drawing.Size(596, 47);
			this.labelControl1.TabIndex = 4;
			this.labelControl1.Text = "Kullanıcı Girişi";
			// 
			// groupControl1
			// 
			this.groupControl1.Controls.Add(this.btnKapat);
			this.groupControl1.Controls.Add(this.btnParolamiUnuttum);
			this.groupControl1.Controls.Add(this.btnGiris);
			this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.groupControl1.Location = new System.Drawing.Point(242, 203);
			this.groupControl1.Name = "groupControl1";
			this.groupControl1.Size = new System.Drawing.Size(354, 100);
			this.groupControl1.TabIndex = 6;
			this.groupControl1.Text = "İşlemler";
			// 
			// btnKapat
			// 
			this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnKapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.ImageOptions.Image")));
			this.btnKapat.Location = new System.Drawing.Point(248, 43);
			this.btnKapat.Name = "btnKapat";
			this.btnKapat.Size = new System.Drawing.Size(94, 45);
			this.btnKapat.TabIndex = 0;
			this.btnKapat.Text = "Kapat";
			this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
			// 
			// btnParolamiUnuttum
			// 
			this.btnParolamiUnuttum.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnParolamiUnuttum.ImageOptions.Image")));
			this.btnParolamiUnuttum.Location = new System.Drawing.Point(122, 43);
			this.btnParolamiUnuttum.Name = "btnParolamiUnuttum";
			this.btnParolamiUnuttum.Size = new System.Drawing.Size(110, 45);
			this.btnParolamiUnuttum.TabIndex = 0;
			this.btnParolamiUnuttum.Text = "Parolamı \r\n Unuttum ";
			this.btnParolamiUnuttum.Click += new System.EventHandler(this.btnParolamiUnuttum_Click);
			// 
			// btnGiris
			// 
			this.btnGiris.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGiris.ImageOptions.Image")));
			this.btnGiris.Location = new System.Drawing.Point(13, 43);
			this.btnGiris.Name = "btnGiris";
			this.btnGiris.Size = new System.Drawing.Size(94, 45);
			this.btnGiris.TabIndex = 0;
			this.btnGiris.Text = "Giriş Yap";
			this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
			// 
			// lblKaydol
			// 
			this.lblKaydol.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblKaydol.Appearance.Options.UseFont = true;
			this.lblKaydol.Location = new System.Drawing.Point(535, 136);
			this.lblKaydol.Name = "lblKaydol";
			this.lblKaydol.Size = new System.Drawing.Size(49, 21);
			this.lblKaydol.TabIndex = 8;
			this.lblKaydol.Text = "Kaydol";
			this.lblKaydol.Click += new System.EventHandler(this.lblKaydol_Click);
			// 
			// checkBeniHatırla
			// 
			this.checkBeniHatırla.Location = new System.Drawing.Point(249, 149);
			this.checkBeniHatırla.Name = "checkBeniHatırla";
			this.checkBeniHatırla.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBeniHatırla.Properties.Appearance.Options.UseFont = true;
			this.checkBeniHatırla.Properties.Caption = "Beni Hatırla";
			this.checkBeniHatırla.Size = new System.Drawing.Size(126, 25);
			this.checkBeniHatırla.TabIndex = 9;
			// 
			// txtSifre
			// 
			this.txtSifre.Location = new System.Drawing.Point(248, 102);
			this.txtSifre.Name = "txtSifre";
			this.txtSifre.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSifre.Properties.Appearance.Options.UseFont = true;
			this.txtSifre.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("txtSifre.Properties.ContextImageOptions.Image")));
			this.txtSifre.Properties.NullText = "Şifrenizi Giriniz :";
			this.txtSifre.Properties.NullValuePrompt = "Şifrenizi Giriniz :";
			this.txtSifre.Properties.UseSystemPasswordChar = true;
			this.txtSifre.Size = new System.Drawing.Size(336, 28);
			this.txtSifre.TabIndex = 7;
			// 
			// txtKullaniciAdi
			// 
			this.txtKullaniciAdi.Location = new System.Drawing.Point(248, 53);
			this.txtKullaniciAdi.Name = "txtKullaniciAdi";
			this.txtKullaniciAdi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtKullaniciAdi.Properties.Appearance.Options.UseFont = true;
			this.txtKullaniciAdi.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("txtKullaniciAdi.Properties.ContextImageOptions.Image")));
			this.txtKullaniciAdi.Properties.NullText = "Kullanıcı Adınızı Giriniz :";
			this.txtKullaniciAdi.Properties.NullValuePrompt = "Kullanıcı Adınızı Giriniz :";
			this.txtKullaniciAdi.Size = new System.Drawing.Size(336, 28);
			this.txtKullaniciAdi.TabIndex = 7;
			// 
			// pictureEdit1
			// 
			this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Left;
			this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
			this.pictureEdit1.Location = new System.Drawing.Point(0, 47);
			this.pictureEdit1.Name = "pictureEdit1";
			this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
			this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
			this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
			this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
			this.pictureEdit1.Size = new System.Drawing.Size(242, 256);
			this.pictureEdit1.TabIndex = 5;
			// 
			// frmKullaniciGirisi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(596, 303);
			this.Controls.Add(this.checkBeniHatırla);
			this.Controls.Add(this.lblKaydol);
			this.Controls.Add(this.txtSifre);
			this.Controls.Add(this.txtKullaniciAdi);
			this.Controls.Add(this.groupControl1);
			this.Controls.Add(this.pictureEdit1);
			this.Controls.Add(this.labelControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmKullaniciGirisi";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Kullanıcı Girişi";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmKullaniciGirisi_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
			this.groupControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.checkBeniHatırla.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.PictureEdit pictureEdit1;
		private DevExpress.XtraEditors.GroupControl groupControl1;
		private DevExpress.XtraEditors.SimpleButton btnKapat;
		private DevExpress.XtraEditors.SimpleButton btnParolamiUnuttum;
		private DevExpress.XtraEditors.SimpleButton btnGiris;
		private DevExpress.XtraEditors.TextEdit txtKullaniciAdi;
		private DevExpress.XtraEditors.TextEdit txtSifre;
		private DevExpress.XtraEditors.HyperlinkLabelControl lblKaydol;
		private DevExpress.XtraEditors.CheckEdit checkBeniHatırla;
	}
}