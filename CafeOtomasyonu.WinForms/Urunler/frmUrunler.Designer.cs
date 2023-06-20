namespace CafeOtomasyonu.WinForms.Urunler
{
    partial class frmUrunler
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUrunler));
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
			this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
			this.btnUrunHareketleri = new DevExpress.XtraEditors.SimpleButton();
			this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
			this.btnSil = new DevExpress.XtraEditors.SimpleButton();
			this.btnYenile = new DevExpress.XtraEditors.SimpleButton();
			this.btnDuzenle = new DevExpress.XtraEditors.SimpleButton();
			this.btnYeni = new DevExpress.XtraEditors.SimpleButton();
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colMenuId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colUrunKodu = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colUrunAdi = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colBirimFiyati1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colBirimFiyati2 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colBirimFiyati3 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTarih = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colResim = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colMenu = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colMenuAdi = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colHizliSatis = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
			this.groupControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
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
			this.labelControl1.Size = new System.Drawing.Size(1132, 47);
			this.labelControl1.TabIndex = 1;
			this.labelControl1.Text = "Ürünler";
			// 
			// groupControl1
			// 
			this.groupControl1.Controls.Add(this.btnKaydet);
			this.groupControl1.Controls.Add(this.btnUrunHareketleri);
			this.groupControl1.Controls.Add(this.btnKapat);
			this.groupControl1.Controls.Add(this.btnSil);
			this.groupControl1.Controls.Add(this.btnYenile);
			this.groupControl1.Controls.Add(this.btnDuzenle);
			this.groupControl1.Controls.Add(this.btnYeni);
			this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.groupControl1.Location = new System.Drawing.Point(0, 472);
			this.groupControl1.Name = "groupControl1";
			this.groupControl1.Size = new System.Drawing.Size(1132, 100);
			this.groupControl1.TabIndex = 2;
			this.groupControl1.Text = "İşlemler";
			// 
			// btnKaydet
			// 
			this.btnKaydet.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKaydet.ImageOptions.SvgImage")));
			this.btnKaydet.Location = new System.Drawing.Point(531, 43);
			this.btnKaydet.Name = "btnKaydet";
			this.btnKaydet.Size = new System.Drawing.Size(99, 45);
			this.btnKaydet.TabIndex = 2;
			this.btnKaydet.Text = "Kaydet";
			this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
			// 
			// btnUrunHareketleri
			// 
			this.btnUrunHareketleri.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMasaHareketleri.ImageOptions.Image")));
			this.btnUrunHareketleri.Location = new System.Drawing.Point(372, 43);
			this.btnUrunHareketleri.Name = "btnUrunHareketleri";
			this.btnUrunHareketleri.Size = new System.Drawing.Size(153, 45);
			this.btnUrunHareketleri.TabIndex = 2;
			this.btnUrunHareketleri.Text = "Ürün Hareketleri";
			this.btnUrunHareketleri.Click += new System.EventHandler(this.btnMasaHareketleri_Click);
			// 
			// btnKapat
			// 
			this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnKapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.ImageOptions.Image")));
			this.btnKapat.Location = new System.Drawing.Point(1026, 43);
			this.btnKapat.Name = "btnKapat";
			this.btnKapat.Size = new System.Drawing.Size(94, 45);
			this.btnKapat.TabIndex = 0;
			this.btnKapat.Text = "Kapat";
			this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
			// 
			// btnSil
			// 
			this.btnSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
			this.btnSil.Location = new System.Drawing.Point(926, 43);
			this.btnSil.Name = "btnSil";
			this.btnSil.Size = new System.Drawing.Size(94, 45);
			this.btnSil.TabIndex = 0;
			this.btnSil.Text = "Sil";
			this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
			// 
			// btnYenile
			// 
			this.btnYenile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnYenile.ImageOptions.Image")));
			this.btnYenile.Location = new System.Drawing.Point(213, 43);
			this.btnYenile.Name = "btnYenile";
			this.btnYenile.Size = new System.Drawing.Size(153, 45);
			this.btnYenile.TabIndex = 0;
			this.btnYenile.Text = "Yenile-Listele";
			this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
			// 
			// btnDuzenle
			// 
			this.btnDuzenle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDuzenle.ImageOptions.Image")));
			this.btnDuzenle.Location = new System.Drawing.Point(113, 43);
			this.btnDuzenle.Name = "btnDuzenle";
			this.btnDuzenle.Size = new System.Drawing.Size(94, 45);
			this.btnDuzenle.TabIndex = 0;
			this.btnDuzenle.Text = "Düzenle";
			this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
			// 
			// btnYeni
			// 
			this.btnYeni.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnYeni.ImageOptions.Image")));
			this.btnYeni.Location = new System.Drawing.Point(13, 43);
			this.btnYeni.Name = "btnYeni";
			this.btnYeni.Size = new System.Drawing.Size(94, 45);
			this.btnYeni.TabIndex = 0;
			this.btnYeni.Text = "Yeni";
			this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
			// 
			// gridControl1
			// 
			this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridControl1.Location = new System.Drawing.Point(0, 47);
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new System.Drawing.Size(1132, 425);
			this.gridControl1.TabIndex = 3;
			this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colMenuId,
            this.colUrunKodu,
            this.colUrunAdi,
            this.colAciklama,
            this.colBirimFiyati1,
            this.colBirimFiyati2,
            this.colBirimFiyati3,
            this.colTarih,
            this.colResim,
            this.colMenu,
            this.colMenuAdi,
            this.colHizliSatis});
			this.gridView1.GridControl = this.gridControl1;
			this.gridView1.Name = "gridView1";
			// 
			// colId
			// 
			this.colId.Caption = "Id";
			this.colId.FieldName = "Id";
			this.colId.MinWidth = 25;
			this.colId.Name = "colId";
			this.colId.OptionsColumn.AllowEdit = false;
			this.colId.Visible = true;
			this.colId.VisibleIndex = 0;
			this.colId.Width = 58;
			// 
			// colMenuId
			// 
			this.colMenuId.Caption = "MenuId";
			this.colMenuId.FieldName = "MenuId";
			this.colMenuId.MinWidth = 25;
			this.colMenuId.Name = "colMenuId";
			this.colMenuId.OptionsColumn.AllowEdit = false;
			this.colMenuId.Width = 94;
			// 
			// colUrunKodu
			// 
			this.colUrunKodu.Caption = "UrunKodu";
			this.colUrunKodu.FieldName = "UrunKodu";
			this.colUrunKodu.MinWidth = 25;
			this.colUrunKodu.Name = "colUrunKodu";
			this.colUrunKodu.OptionsColumn.AllowEdit = false;
			this.colUrunKodu.Visible = true;
			this.colUrunKodu.VisibleIndex = 2;
			this.colUrunKodu.Width = 91;
			// 
			// colUrunAdi
			// 
			this.colUrunAdi.Caption = "Ürün Adi";
			this.colUrunAdi.FieldName = "UrunAdi";
			this.colUrunAdi.MinWidth = 25;
			this.colUrunAdi.Name = "colUrunAdi";
			this.colUrunAdi.OptionsColumn.AllowEdit = false;
			this.colUrunAdi.Visible = true;
			this.colUrunAdi.VisibleIndex = 3;
			this.colUrunAdi.Width = 86;
			// 
			// colAciklama
			// 
			this.colAciklama.Caption = "Açıklama";
			this.colAciklama.FieldName = "Aciklama";
			this.colAciklama.MinWidth = 25;
			this.colAciklama.Name = "colAciklama";
			this.colAciklama.OptionsColumn.AllowEdit = false;
			this.colAciklama.Visible = true;
			this.colAciklama.VisibleIndex = 7;
			this.colAciklama.Width = 350;
			// 
			// colBirimFiyati1
			// 
			this.colBirimFiyati1.Caption = "Birim Fiyatı1";
			this.colBirimFiyati1.FieldName = "BirimFiyati1";
			this.colBirimFiyati1.MinWidth = 25;
			this.colBirimFiyati1.Name = "colBirimFiyati1";
			this.colBirimFiyati1.OptionsColumn.AllowEdit = false;
			this.colBirimFiyati1.Visible = true;
			this.colBirimFiyati1.VisibleIndex = 4;
			this.colBirimFiyati1.Width = 84;
			// 
			// colBirimFiyati2
			// 
			this.colBirimFiyati2.Caption = "Birim Fiyatı2";
			this.colBirimFiyati2.FieldName = "BirimFiyati2";
			this.colBirimFiyati2.MinWidth = 25;
			this.colBirimFiyati2.Name = "colBirimFiyati2";
			this.colBirimFiyati2.OptionsColumn.AllowEdit = false;
			this.colBirimFiyati2.Visible = true;
			this.colBirimFiyati2.VisibleIndex = 5;
			this.colBirimFiyati2.Width = 86;
			// 
			// colBirimFiyati3
			// 
			this.colBirimFiyati3.Caption = "Birim Fiyatı3";
			this.colBirimFiyati3.FieldName = "BirimFiyati3";
			this.colBirimFiyati3.MinWidth = 25;
			this.colBirimFiyati3.Name = "colBirimFiyati3";
			this.colBirimFiyati3.OptionsColumn.AllowEdit = false;
			this.colBirimFiyati3.Visible = true;
			this.colBirimFiyati3.VisibleIndex = 6;
			this.colBirimFiyati3.Width = 99;
			// 
			// colTarih
			// 
			this.colTarih.Caption = "Tarih";
			this.colTarih.FieldName = "Tarih";
			this.colTarih.MinWidth = 25;
			this.colTarih.Name = "colTarih";
			this.colTarih.OptionsColumn.AllowEdit = false;
			this.colTarih.Visible = true;
			this.colTarih.VisibleIndex = 8;
			this.colTarih.Width = 171;
			// 
			// colResim
			// 
			this.colResim.Caption = "Resim";
			this.colResim.FieldName = "Resim";
			this.colResim.MinWidth = 25;
			this.colResim.Name = "colResim";
			this.colResim.OptionsColumn.AllowEdit = false;
			this.colResim.Width = 94;
			// 
			// colMenu
			// 
			this.colMenu.FieldName = "Menu";
			this.colMenu.MinWidth = 25;
			this.colMenu.Name = "colMenu";
			this.colMenu.OptionsColumn.AllowEdit = false;
			this.colMenu.Width = 94;
			// 
			// colMenuAdi
			// 
			this.colMenuAdi.Caption = "Menü";
			this.colMenuAdi.FieldName = "Menu.MenuAdi";
			this.colMenuAdi.MinWidth = 25;
			this.colMenuAdi.Name = "colMenuAdi";
			this.colMenuAdi.OptionsColumn.AllowEdit = false;
			this.colMenuAdi.Visible = true;
			this.colMenuAdi.VisibleIndex = 1;
			this.colMenuAdi.Width = 94;
			// 
			// colHizliSatis
			// 
			this.colHizliSatis.Caption = "Hızlı Satış";
			this.colHizliSatis.FieldName = "HizliSatis";
			this.colHizliSatis.MinWidth = 25;
			this.colHizliSatis.Name = "colHizliSatis";
			this.colHizliSatis.Visible = true;
			this.colHizliSatis.VisibleIndex = 9;
			this.colHizliSatis.Width = 94;
			// 
			// frmUrunler
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1132, 572);
			this.Controls.Add(this.gridControl1);
			this.Controls.Add(this.groupControl1);
			this.Controls.Add(this.labelControl1);
			this.Name = "frmUrunler";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ürunler";
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
			this.groupControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnYenile;
        private DevExpress.XtraEditors.SimpleButton btnDuzenle;
        private DevExpress.XtraEditors.SimpleButton btnYeni;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colMenuId;
        private DevExpress.XtraGrid.Columns.GridColumn colUrunKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colUrunAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colBirimFiyati1;
        private DevExpress.XtraGrid.Columns.GridColumn colBirimFiyati2;
        private DevExpress.XtraGrid.Columns.GridColumn colBirimFiyati3;
        private DevExpress.XtraGrid.Columns.GridColumn colTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colResim;
        private DevExpress.XtraGrid.Columns.GridColumn colMenu;
        private DevExpress.XtraGrid.Columns.GridColumn colMenuAdi;
		private DevExpress.XtraEditors.SimpleButton btnUrunHareketleri;
		private DevExpress.XtraGrid.Columns.GridColumn colHizliSatis;
		private DevExpress.XtraEditors.SimpleButton btnKaydet;
	}
}