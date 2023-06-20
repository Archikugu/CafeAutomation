namespace CafeOtomasyonu.WinForms.Kullanicilar
{
	partial class frmKullaniciKaydet
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKullaniciKaydet));
			this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
			this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
			this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
			this.btnKullaniciKaydet = new DevExpress.XtraEditors.SimpleButton();
			this.txtAdres = new DevExpress.XtraEditors.MemoEdit();
			this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
			this.txtAciklama = new DevExpress.XtraEditors.MemoEdit();
			this.toggleSwitchAktifMi = new DevExpress.XtraEditors.ToggleSwitch();
			this.txtHatirlatmaSorusu = new DevExpress.XtraEditors.TextEdit();
			this.txtCevap = new DevExpress.XtraEditors.TextEdit();
			this.txtParolaTekrar = new DevExpress.XtraEditors.TextEdit();
			this.txtParola = new DevExpress.XtraEditors.TextEdit();
			this.txtKullaniciAdi = new DevExpress.XtraEditors.TextEdit();
			this.txtGorevi = new DevExpress.XtraEditors.TextEdit();
			this.txtEmail = new DevExpress.XtraEditors.TextEdit();
			this.txtTelefon = new DevExpress.XtraEditors.TextEdit();
			this.txtAdSoyad = new DevExpress.XtraEditors.TextEdit();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
			this.groupControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtAdres.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.toggleSwitchAktifMi.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtHatirlatmaSorusu.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCevap.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtParolaTekrar.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtParola.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtGorevi.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTelefon.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtAdSoyad.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// lblBaslik
			// 
			this.lblBaslik.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBaslik.Appearance.Options.UseFont = true;
			this.lblBaslik.Appearance.Options.UseTextOptions = true;
			this.lblBaslik.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.lblBaslik.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.lblBaslik.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblBaslik.Location = new System.Drawing.Point(0, 0);
			this.lblBaslik.Name = "lblBaslik";
			this.lblBaslik.Size = new System.Drawing.Size(602, 47);
			this.lblBaslik.TabIndex = 10;
			this.lblBaslik.Text = "Kullanıcı Kaydetme Sayfası";
			// 
			// groupControl1
			// 
			this.groupControl1.Controls.Add(this.btnKapat);
			this.groupControl1.Controls.Add(this.btnKullaniciKaydet);
			this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.groupControl1.Location = new System.Drawing.Point(0, 593);
			this.groupControl1.Name = "groupControl1";
			this.groupControl1.Size = new System.Drawing.Size(602, 100);
			this.groupControl1.TabIndex = 11;
			this.groupControl1.Text = "İşlemler";
			// 
			// btnKapat
			// 
			this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnKapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.ImageOptions.Image")));
			this.btnKapat.Location = new System.Drawing.Point(496, 43);
			this.btnKapat.Name = "btnKapat";
			this.btnKapat.Size = new System.Drawing.Size(94, 45);
			this.btnKapat.TabIndex = 0;
			this.btnKapat.Text = "Kapat";
			this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
			// 
			// btnKullaniciKaydet
			// 
			this.btnKullaniciKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKullaniciKaydet.ImageOptions.Image")));
			this.btnKullaniciKaydet.Location = new System.Drawing.Point(13, 43);
			this.btnKullaniciKaydet.Name = "btnKullaniciKaydet";
			this.btnKullaniciKaydet.Size = new System.Drawing.Size(94, 45);
			this.btnKullaniciKaydet.TabIndex = 0;
			this.btnKullaniciKaydet.Text = "Kaydet";
			this.btnKullaniciKaydet.Click += new System.EventHandler(this.btnKullaniciKaydet_Click);
			// 
			// txtAdres
			// 
			this.txtAdres.Location = new System.Drawing.Point(177, 181);
			this.txtAdres.Name = "txtAdres";
			this.txtAdres.Size = new System.Drawing.Size(393, 53);
			this.txtAdres.TabIndex = 38;
			// 
			// labelControl6
			// 
			this.labelControl6.Appearance.BorderColor = System.Drawing.Color.DarkGray;
			this.labelControl6.Appearance.Options.UseBorderColor = true;
			this.labelControl6.Appearance.Options.UseTextOptions = true;
			this.labelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.labelControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
			this.labelControl6.Location = new System.Drawing.Point(21, 182);
			this.labelControl6.Name = "labelControl6";
			this.labelControl6.Size = new System.Drawing.Size(150, 52);
			this.labelControl6.TabIndex = 37;
			this.labelControl6.Text = "Adres :";
			// 
			// txtAciklama
			// 
			this.txtAciklama.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
			this.txtAciklama.Location = new System.Drawing.Point(177, 498);
			this.txtAciklama.Name = "txtAciklama";
			this.txtAciklama.Size = new System.Drawing.Size(391, 61);
			this.txtAciklama.TabIndex = 36;
			// 
			// toggleSwitchAktifMi
			// 
			this.toggleSwitchAktifMi.Location = new System.Drawing.Point(177, 75);
			this.toggleSwitchAktifMi.Name = "toggleSwitchAktifMi";
			this.toggleSwitchAktifMi.Properties.OffText = "Aktif Değil";
			this.toggleSwitchAktifMi.Properties.OnText = "Aktif";
			this.toggleSwitchAktifMi.Size = new System.Drawing.Size(302, 24);
			this.toggleSwitchAktifMi.TabIndex = 35;
			// 
			// txtHatirlatmaSorusu
			// 
			this.txtHatirlatmaSorusu.Location = new System.Drawing.Point(177, 424);
			this.txtHatirlatmaSorusu.Name = "txtHatirlatmaSorusu";
			this.txtHatirlatmaSorusu.Size = new System.Drawing.Size(392, 22);
			this.txtHatirlatmaSorusu.TabIndex = 33;
			// 
			// txtCevap
			// 
			this.txtCevap.Location = new System.Drawing.Point(177, 459);
			this.txtCevap.Name = "txtCevap";
			this.txtCevap.Size = new System.Drawing.Size(392, 22);
			this.txtCevap.TabIndex = 32;
			// 
			// txtParolaTekrar
			// 
			this.txtParolaTekrar.Location = new System.Drawing.Point(177, 389);
			this.txtParolaTekrar.Name = "txtParolaTekrar";
			this.txtParolaTekrar.Properties.UseSystemPasswordChar = true;
			this.txtParolaTekrar.Size = new System.Drawing.Size(392, 22);
			this.txtParolaTekrar.TabIndex = 31;
			// 
			// txtParola
			// 
			this.txtParola.Location = new System.Drawing.Point(177, 354);
			this.txtParola.Name = "txtParola";
			this.txtParola.Properties.UseSystemPasswordChar = true;
			this.txtParola.Size = new System.Drawing.Size(392, 22);
			this.txtParola.TabIndex = 30;
			// 
			// txtKullaniciAdi
			// 
			this.txtKullaniciAdi.Location = new System.Drawing.Point(177, 319);
			this.txtKullaniciAdi.Name = "txtKullaniciAdi";
			this.txtKullaniciAdi.Size = new System.Drawing.Size(392, 22);
			this.txtKullaniciAdi.TabIndex = 29;
			// 
			// txtGorevi
			// 
			this.txtGorevi.Location = new System.Drawing.Point(177, 284);
			this.txtGorevi.Name = "txtGorevi";
			this.txtGorevi.Size = new System.Drawing.Size(392, 22);
			this.txtGorevi.TabIndex = 28;
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(177, 249);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(393, 22);
			this.txtEmail.TabIndex = 34;
			// 
			// txtTelefon
			// 
			this.txtTelefon.Location = new System.Drawing.Point(178, 147);
			this.txtTelefon.Name = "txtTelefon";
			this.txtTelefon.Size = new System.Drawing.Size(393, 22);
			this.txtTelefon.TabIndex = 27;
			// 
			// txtAdSoyad
			// 
			this.txtAdSoyad.Location = new System.Drawing.Point(177, 112);
			this.txtAdSoyad.Name = "txtAdSoyad";
			this.txtAdSoyad.Size = new System.Drawing.Size(393, 22);
			this.txtAdSoyad.TabIndex = 26;
			// 
			// labelControl2
			// 
			this.labelControl2.Appearance.BorderColor = System.Drawing.Color.DarkGray;
			this.labelControl2.Appearance.Options.UseBorderColor = true;
			this.labelControl2.Appearance.Options.UseTextOptions = true;
			this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
			this.labelControl2.Location = new System.Drawing.Point(21, 70);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(150, 29);
			this.labelControl2.TabIndex = 24;
			this.labelControl2.Text = "Durumu :";
			// 
			// labelControl13
			// 
			this.labelControl13.Appearance.BorderColor = System.Drawing.Color.DarkGray;
			this.labelControl13.Appearance.Options.UseBorderColor = true;
			this.labelControl13.Appearance.Options.UseTextOptions = true;
			this.labelControl13.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.labelControl13.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.labelControl13.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
			this.labelControl13.Location = new System.Drawing.Point(22, 499);
			this.labelControl13.Name = "labelControl13";
			this.labelControl13.Size = new System.Drawing.Size(150, 60);
			this.labelControl13.TabIndex = 23;
			this.labelControl13.Text = "Açıklama :";
			// 
			// labelControl11
			// 
			this.labelControl11.Appearance.BorderColor = System.Drawing.Color.DarkGray;
			this.labelControl11.Appearance.Options.UseBorderColor = true;
			this.labelControl11.Appearance.Options.UseTextOptions = true;
			this.labelControl11.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.labelControl11.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.labelControl11.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
			this.labelControl11.Location = new System.Drawing.Point(21, 420);
			this.labelControl11.Name = "labelControl11";
			this.labelControl11.Size = new System.Drawing.Size(150, 29);
			this.labelControl11.TabIndex = 22;
			this.labelControl11.Text = "Hatırlatma Sorusu :";
			// 
			// labelControl12
			// 
			this.labelControl12.Appearance.BorderColor = System.Drawing.Color.DarkGray;
			this.labelControl12.Appearance.Options.UseBorderColor = true;
			this.labelControl12.Appearance.Options.UseTextOptions = true;
			this.labelControl12.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.labelControl12.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.labelControl12.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
			this.labelControl12.Location = new System.Drawing.Point(21, 455);
			this.labelControl12.Name = "labelControl12";
			this.labelControl12.Size = new System.Drawing.Size(150, 29);
			this.labelControl12.TabIndex = 21;
			this.labelControl12.Text = "Cevap :";
			// 
			// labelControl10
			// 
			this.labelControl10.Appearance.BorderColor = System.Drawing.Color.DarkGray;
			this.labelControl10.Appearance.Options.UseBorderColor = true;
			this.labelControl10.Appearance.Options.UseTextOptions = true;
			this.labelControl10.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.labelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.labelControl10.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
			this.labelControl10.Location = new System.Drawing.Point(21, 385);
			this.labelControl10.Name = "labelControl10";
			this.labelControl10.Size = new System.Drawing.Size(150, 29);
			this.labelControl10.TabIndex = 20;
			this.labelControl10.Text = "Parola Tekrar :";
			// 
			// labelControl9
			// 
			this.labelControl9.Appearance.BorderColor = System.Drawing.Color.DarkGray;
			this.labelControl9.Appearance.Options.UseBorderColor = true;
			this.labelControl9.Appearance.Options.UseTextOptions = true;
			this.labelControl9.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.labelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.labelControl9.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
			this.labelControl9.Location = new System.Drawing.Point(21, 350);
			this.labelControl9.Name = "labelControl9";
			this.labelControl9.Size = new System.Drawing.Size(150, 29);
			this.labelControl9.TabIndex = 19;
			this.labelControl9.Text = "Parola :";
			// 
			// labelControl8
			// 
			this.labelControl8.Appearance.BorderColor = System.Drawing.Color.DarkGray;
			this.labelControl8.Appearance.Options.UseBorderColor = true;
			this.labelControl8.Appearance.Options.UseTextOptions = true;
			this.labelControl8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.labelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.labelControl8.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
			this.labelControl8.Location = new System.Drawing.Point(21, 315);
			this.labelControl8.Name = "labelControl8";
			this.labelControl8.Size = new System.Drawing.Size(150, 29);
			this.labelControl8.TabIndex = 18;
			this.labelControl8.Text = "Kullanıcı Adı :";
			// 
			// labelControl7
			// 
			this.labelControl7.Appearance.BorderColor = System.Drawing.Color.DarkGray;
			this.labelControl7.Appearance.Options.UseBorderColor = true;
			this.labelControl7.Appearance.Options.UseTextOptions = true;
			this.labelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.labelControl7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
			this.labelControl7.Location = new System.Drawing.Point(21, 280);
			this.labelControl7.Name = "labelControl7";
			this.labelControl7.Size = new System.Drawing.Size(150, 29);
			this.labelControl7.TabIndex = 17;
			this.labelControl7.Text = "Görevi :";
			// 
			// labelControl5
			// 
			this.labelControl5.Appearance.BorderColor = System.Drawing.Color.DarkGray;
			this.labelControl5.Appearance.Options.UseBorderColor = true;
			this.labelControl5.Appearance.Options.UseTextOptions = true;
			this.labelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.labelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
			this.labelControl5.Location = new System.Drawing.Point(21, 245);
			this.labelControl5.Name = "labelControl5";
			this.labelControl5.Size = new System.Drawing.Size(150, 29);
			this.labelControl5.TabIndex = 16;
			this.labelControl5.Text = "E-Mail :";
			// 
			// labelControl4
			// 
			this.labelControl4.Appearance.BorderColor = System.Drawing.Color.DarkGray;
			this.labelControl4.Appearance.Options.UseBorderColor = true;
			this.labelControl4.Appearance.Options.UseTextOptions = true;
			this.labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.labelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
			this.labelControl4.Location = new System.Drawing.Point(21, 143);
			this.labelControl4.Name = "labelControl4";
			this.labelControl4.Size = new System.Drawing.Size(150, 29);
			this.labelControl4.TabIndex = 25;
			this.labelControl4.Text = "Telefon :";
			// 
			// labelControl3
			// 
			this.labelControl3.Appearance.BorderColor = System.Drawing.Color.DarkGray;
			this.labelControl3.Appearance.Options.UseBorderColor = true;
			this.labelControl3.Appearance.Options.UseTextOptions = true;
			this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.labelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
			this.labelControl3.Location = new System.Drawing.Point(21, 108);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(150, 29);
			this.labelControl3.TabIndex = 15;
			this.labelControl3.Text = "Ad Soyad :";
			// 
			// frmKullaniciKaydet
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(602, 693);
			this.Controls.Add(this.txtAdres);
			this.Controls.Add(this.labelControl6);
			this.Controls.Add(this.txtAciklama);
			this.Controls.Add(this.toggleSwitchAktifMi);
			this.Controls.Add(this.txtHatirlatmaSorusu);
			this.Controls.Add(this.txtCevap);
			this.Controls.Add(this.txtParolaTekrar);
			this.Controls.Add(this.txtParola);
			this.Controls.Add(this.txtKullaniciAdi);
			this.Controls.Add(this.txtGorevi);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.txtTelefon);
			this.Controls.Add(this.txtAdSoyad);
			this.Controls.Add(this.labelControl2);
			this.Controls.Add(this.labelControl13);
			this.Controls.Add(this.labelControl11);
			this.Controls.Add(this.labelControl12);
			this.Controls.Add(this.labelControl10);
			this.Controls.Add(this.labelControl9);
			this.Controls.Add(this.labelControl8);
			this.Controls.Add(this.labelControl7);
			this.Controls.Add(this.labelControl5);
			this.Controls.Add(this.labelControl4);
			this.Controls.Add(this.labelControl3);
			this.Controls.Add(this.groupControl1);
			this.Controls.Add(this.lblBaslik);
			this.Name = "frmKullaniciKaydet";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Kullanici Kaydet Sayfasi";
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
			this.groupControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.txtAdres.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.toggleSwitchAktifMi.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtHatirlatmaSorusu.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCevap.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtParolaTekrar.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtParola.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtGorevi.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTelefon.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtAdSoyad.Properties)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.LabelControl lblBaslik;
		private DevExpress.XtraEditors.GroupControl groupControl1;
		private DevExpress.XtraEditors.SimpleButton btnKapat;
		private DevExpress.XtraEditors.SimpleButton btnKullaniciKaydet;
		private DevExpress.XtraEditors.MemoEdit txtAdres;
		private DevExpress.XtraEditors.LabelControl labelControl6;
		private DevExpress.XtraEditors.MemoEdit txtAciklama;
		private DevExpress.XtraEditors.ToggleSwitch toggleSwitchAktifMi;
		private DevExpress.XtraEditors.TextEdit txtHatirlatmaSorusu;
		private DevExpress.XtraEditors.TextEdit txtCevap;
		private DevExpress.XtraEditors.TextEdit txtParolaTekrar;
		private DevExpress.XtraEditors.TextEdit txtParola;
		private DevExpress.XtraEditors.TextEdit txtKullaniciAdi;
		private DevExpress.XtraEditors.TextEdit txtGorevi;
		private DevExpress.XtraEditors.TextEdit txtEmail;
		private DevExpress.XtraEditors.TextEdit txtTelefon;
		private DevExpress.XtraEditors.TextEdit txtAdSoyad;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.LabelControl labelControl13;
		private DevExpress.XtraEditors.LabelControl labelControl11;
		private DevExpress.XtraEditors.LabelControl labelControl12;
		private DevExpress.XtraEditors.LabelControl labelControl10;
		private DevExpress.XtraEditors.LabelControl labelControl9;
		private DevExpress.XtraEditors.LabelControl labelControl8;
		private DevExpress.XtraEditors.LabelControl labelControl7;
		private DevExpress.XtraEditors.LabelControl labelControl5;
		private DevExpress.XtraEditors.LabelControl labelControl4;
		private DevExpress.XtraEditors.LabelControl labelControl3;
	}
}