namespace CafeOtomasyonu.WinForms.Kullanıcılar
{
	partial class frmKullanicilar
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKullanicilar));
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
			this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
			this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
			this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
			this.btnRoller = new DevExpress.XtraEditors.SimpleButton();
			this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.kullanicilarBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAdSoyad = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTelefon = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAdres = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colGorevi = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colKullaniciAdi = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colParola = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colHatirlatmaSorusu = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCevap = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colKayitTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAktifMi = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colIsAdmin = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colKullaniciHareketleri = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colMasalar = new DevExpress.XtraGrid.Columns.GridColumn();
			this.btnSil = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
			this.groupControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.kullanicilarBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
			this.labelControl1.TabIndex = 10;
			this.labelControl1.Text = "Kullanıcılar";
			// 
			// groupControl1
			// 
			this.groupControl1.Controls.Add(this.btnSil);
			this.groupControl1.Controls.Add(this.btnKapat);
			this.groupControl1.Controls.Add(this.btnEkle);
			this.groupControl1.Controls.Add(this.btnKaydet);
			this.groupControl1.Controls.Add(this.btnRoller);
			this.groupControl1.Controls.Add(this.btnGuncelle);
			this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.groupControl1.Location = new System.Drawing.Point(0, 577);
			this.groupControl1.Name = "groupControl1";
			this.groupControl1.Size = new System.Drawing.Size(1429, 100);
			this.groupControl1.TabIndex = 11;
			this.groupControl1.Text = "İşlemler";
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
			// btnEkle
			// 
			this.btnEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEkle.ImageOptions.Image")));
			this.btnEkle.Location = new System.Drawing.Point(12, 43);
			this.btnEkle.Name = "btnEkle";
			this.btnEkle.Size = new System.Drawing.Size(145, 45);
			this.btnEkle.TabIndex = 0;
			this.btnEkle.Text = "Yeni Kullanıcı Ekle";
			this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
			// 
			// btnKaydet
			// 
			this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
			this.btnKaydet.Location = new System.Drawing.Point(390, 43);
			this.btnKaydet.Name = "btnKaydet";
			this.btnKaydet.Size = new System.Drawing.Size(94, 45);
			this.btnKaydet.TabIndex = 0;
			this.btnKaydet.Text = "Kaydet";
			this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
			// 
			// btnRoller
			// 
			this.btnRoller.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRoller.ImageOptions.Image")));
			this.btnRoller.Location = new System.Drawing.Point(290, 43);
			this.btnRoller.Name = "btnRoller";
			this.btnRoller.Size = new System.Drawing.Size(94, 45);
			this.btnRoller.TabIndex = 0;
			this.btnRoller.Text = "Roller";
			this.btnRoller.Click += new System.EventHandler(this.btnRoller_Click);
			// 
			// btnGuncelle
			// 
			this.btnGuncelle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGuncelle.ImageOptions.SvgImage")));
			this.btnGuncelle.Location = new System.Drawing.Point(163, 43);
			this.btnGuncelle.Name = "btnGuncelle";
			this.btnGuncelle.Size = new System.Drawing.Size(121, 45);
			this.btnGuncelle.TabIndex = 0;
			this.btnGuncelle.Text = "Güncelle";
			this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
			// 
			// gridControl1
			// 
			this.gridControl1.DataSource = this.kullanicilarBindingSource;
			this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridControl1.Location = new System.Drawing.Point(0, 47);
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new System.Drawing.Size(1429, 530);
			this.gridControl1.TabIndex = 12;
			this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// kullanicilarBindingSource
			// 
			this.kullanicilarBindingSource.DataSource = typeof(CafeOtomasyonu.Entities.Models.Kullanicilar);
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colAdSoyad,
            this.colTelefon,
            this.colAdres,
            this.colEmail,
            this.colGorevi,
            this.colKullaniciAdi,
            this.colParola,
            this.colHatirlatmaSorusu,
            this.colCevap,
            this.colAciklama,
            this.colKayitTarihi,
            this.colAktifMi,
            this.colIsAdmin,
            this.colKullaniciHareketleri,
            this.colMasalar});
			this.gridView1.GridControl = this.gridControl1;
			this.gridView1.Name = "gridView1";
			// 
			// colId
			// 
			this.colId.FieldName = "Id";
			this.colId.MinWidth = 25;
			this.colId.Name = "colId";
			this.colId.OptionsColumn.AllowEdit = false;
			this.colId.Visible = true;
			this.colId.VisibleIndex = 0;
			this.colId.Width = 47;
			// 
			// colAdSoyad
			// 
			this.colAdSoyad.FieldName = "AdSoyad";
			this.colAdSoyad.MinWidth = 25;
			this.colAdSoyad.Name = "colAdSoyad";
			this.colAdSoyad.OptionsColumn.AllowEdit = false;
			this.colAdSoyad.Visible = true;
			this.colAdSoyad.VisibleIndex = 1;
			this.colAdSoyad.Width = 128;
			// 
			// colTelefon
			// 
			this.colTelefon.FieldName = "Telefon";
			this.colTelefon.MinWidth = 25;
			this.colTelefon.Name = "colTelefon";
			this.colTelefon.OptionsColumn.AllowEdit = false;
			this.colTelefon.Visible = true;
			this.colTelefon.VisibleIndex = 2;
			this.colTelefon.Width = 130;
			// 
			// colAdres
			// 
			this.colAdres.FieldName = "Adres";
			this.colAdres.MinWidth = 25;
			this.colAdres.Name = "colAdres";
			this.colAdres.OptionsColumn.AllowEdit = false;
			this.colAdres.Visible = true;
			this.colAdres.VisibleIndex = 3;
			this.colAdres.Width = 149;
			// 
			// colEmail
			// 
			this.colEmail.FieldName = "Email";
			this.colEmail.MinWidth = 25;
			this.colEmail.Name = "colEmail";
			this.colEmail.OptionsColumn.AllowEdit = false;
			this.colEmail.Visible = true;
			this.colEmail.VisibleIndex = 4;
			this.colEmail.Width = 160;
			// 
			// colGorevi
			// 
			this.colGorevi.FieldName = "Gorevi";
			this.colGorevi.MinWidth = 25;
			this.colGorevi.Name = "colGorevi";
			this.colGorevi.OptionsColumn.AllowEdit = false;
			this.colGorevi.Visible = true;
			this.colGorevi.VisibleIndex = 5;
			this.colGorevi.Width = 143;
			// 
			// colKullaniciAdi
			// 
			this.colKullaniciAdi.FieldName = "KullaniciAdi";
			this.colKullaniciAdi.MinWidth = 25;
			this.colKullaniciAdi.Name = "colKullaniciAdi";
			this.colKullaniciAdi.OptionsColumn.AllowEdit = false;
			this.colKullaniciAdi.Visible = true;
			this.colKullaniciAdi.VisibleIndex = 6;
			this.colKullaniciAdi.Width = 267;
			// 
			// colParola
			// 
			this.colParola.FieldName = "Parola";
			this.colParola.MinWidth = 25;
			this.colParola.Name = "colParola";
			this.colParola.OptionsColumn.AllowEdit = false;
			this.colParola.Width = 94;
			// 
			// colHatirlatmaSorusu
			// 
			this.colHatirlatmaSorusu.FieldName = "HatirlatmaSorusu";
			this.colHatirlatmaSorusu.MinWidth = 25;
			this.colHatirlatmaSorusu.Name = "colHatirlatmaSorusu";
			this.colHatirlatmaSorusu.OptionsColumn.AllowEdit = false;
			this.colHatirlatmaSorusu.Width = 103;
			// 
			// colCevap
			// 
			this.colCevap.FieldName = "Cevap";
			this.colCevap.MinWidth = 25;
			this.colCevap.Name = "colCevap";
			this.colCevap.OptionsColumn.AllowEdit = false;
			this.colCevap.Width = 103;
			// 
			// colAciklama
			// 
			this.colAciklama.FieldName = "Aciklama";
			this.colAciklama.MinWidth = 25;
			this.colAciklama.Name = "colAciklama";
			this.colAciklama.OptionsColumn.AllowEdit = false;
			this.colAciklama.Width = 94;
			// 
			// colKayitTarihi
			// 
			this.colKayitTarihi.FieldName = "KayitTarihi";
			this.colKayitTarihi.MinWidth = 25;
			this.colKayitTarihi.Name = "colKayitTarihi";
			this.colKayitTarihi.OptionsColumn.AllowEdit = false;
			this.colKayitTarihi.Visible = true;
			this.colKayitTarihi.VisibleIndex = 7;
			this.colKayitTarihi.Width = 200;
			// 
			// colAktifMi
			// 
			this.colAktifMi.Caption = "Aktif Mi ?";
			this.colAktifMi.FieldName = "AktifMi";
			this.colAktifMi.MinWidth = 25;
			this.colAktifMi.Name = "colAktifMi";
			this.colAktifMi.Visible = true;
			this.colAktifMi.VisibleIndex = 8;
			this.colAktifMi.Width = 97;
			// 
			// colIsAdmin
			// 
			this.colIsAdmin.Caption = "Admin Mi ?";
			this.colIsAdmin.FieldName = "IsAdmin";
			this.colIsAdmin.MinWidth = 25;
			this.colIsAdmin.Name = "colIsAdmin";
			this.colIsAdmin.Visible = true;
			this.colIsAdmin.VisibleIndex = 9;
			this.colIsAdmin.Width = 78;
			// 
			// colKullaniciHareketleri
			// 
			this.colKullaniciHareketleri.FieldName = "KullaniciHareketleri";
			this.colKullaniciHareketleri.MinWidth = 25;
			this.colKullaniciHareketleri.Name = "colKullaniciHareketleri";
			this.colKullaniciHareketleri.Width = 94;
			// 
			// colMasalar
			// 
			this.colMasalar.FieldName = "Masalar";
			this.colMasalar.MinWidth = 25;
			this.colMasalar.Name = "colMasalar";
			this.colMasalar.Width = 94;
			// 
			// btnSil
			// 
			this.btnSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSil.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
			this.btnSil.Location = new System.Drawing.Point(1223, 43);
			this.btnSil.Name = "btnSil";
			this.btnSil.Size = new System.Drawing.Size(94, 45);
			this.btnSil.TabIndex = 0;
			this.btnSil.Text = "Sil";
			this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
			// 
			// frmKullanicilar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1429, 677);
			this.Controls.Add(this.gridControl1);
			this.Controls.Add(this.groupControl1);
			this.Controls.Add(this.labelControl1);
			this.Name = "frmKullanicilar";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Kullanıcılar";
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
			this.groupControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.kullanicilarBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.GroupControl groupControl1;
		private DevExpress.XtraEditors.SimpleButton btnKapat;
		private DevExpress.XtraEditors.SimpleButton btnEkle;
		private DevExpress.XtraEditors.SimpleButton btnKaydet;
		private DevExpress.XtraEditors.SimpleButton btnRoller;
		private DevExpress.XtraEditors.SimpleButton btnGuncelle;
		private DevExpress.XtraGrid.GridControl gridControl1;
		private System.Windows.Forms.BindingSource kullanicilarBindingSource;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraGrid.Columns.GridColumn colId;
		private DevExpress.XtraGrid.Columns.GridColumn colAdSoyad;
		private DevExpress.XtraGrid.Columns.GridColumn colTelefon;
		private DevExpress.XtraGrid.Columns.GridColumn colAdres;
		private DevExpress.XtraGrid.Columns.GridColumn colEmail;
		private DevExpress.XtraGrid.Columns.GridColumn colGorevi;
		private DevExpress.XtraGrid.Columns.GridColumn colKullaniciAdi;
		private DevExpress.XtraGrid.Columns.GridColumn colParola;
		private DevExpress.XtraGrid.Columns.GridColumn colHatirlatmaSorusu;
		private DevExpress.XtraGrid.Columns.GridColumn colCevap;
		private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
		private DevExpress.XtraGrid.Columns.GridColumn colKayitTarihi;
		private DevExpress.XtraGrid.Columns.GridColumn colAktifMi;
		private DevExpress.XtraGrid.Columns.GridColumn colIsAdmin;
		private DevExpress.XtraGrid.Columns.GridColumn colKullaniciHareketleri;
		private DevExpress.XtraGrid.Columns.GridColumn colMasalar;
		private DevExpress.XtraEditors.SimpleButton btnSil;
	}
}