namespace CafeOtomasyonu.WinForms.Satislar
{
	partial class frmSatislar
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSatislar));
			this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
			this.groupIslemler = new DevExpress.XtraEditors.GroupControl();
			this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
			this.btnOdemeHareketleri = new DevExpress.XtraEditors.SimpleButton();
			this.btnYenile = new DevExpress.XtraEditors.SimpleButton();
			this.btnSiparisDetay = new DevExpress.XtraEditors.SimpleButton();
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSatisKodu = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colMusteriAdSoyad = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colMusteriId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTutar = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colOdenen = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colIndirimToplami = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colKalan = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSonIslemTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPaketmiSiparismi = new DevExpress.XtraGrid.Columns.GridColumn();
			this.btnExport = new DevExpress.XtraEditors.DropDownButton();
			this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
			this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			this.btnExcelExport = new DevExpress.XtraBars.BarButtonItem();
			this.btnWordExport = new DevExpress.XtraBars.BarButtonItem();
			this.btnPdfExport = new DevExpress.XtraBars.BarButtonItem();
			((System.ComponentModel.ISupportInitialize)(this.groupIslemler)).BeginInit();
			this.groupIslemler.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
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
			this.lblBaslik.Size = new System.Drawing.Size(1294, 47);
			this.lblBaslik.TabIndex = 4;
			this.lblBaslik.Text = "Satışlar";
			// 
			// groupIslemler
			// 
			this.groupIslemler.Controls.Add(this.btnExport);
			this.groupIslemler.Controls.Add(this.btnKapat);
			this.groupIslemler.Controls.Add(this.btnOdemeHareketleri);
			this.groupIslemler.Controls.Add(this.btnYenile);
			this.groupIslemler.Controls.Add(this.btnSiparisDetay);
			this.groupIslemler.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.groupIslemler.Location = new System.Drawing.Point(0, 532);
			this.groupIslemler.Name = "groupIslemler";
			this.groupIslemler.Size = new System.Drawing.Size(1294, 100);
			this.groupIslemler.TabIndex = 6;
			this.groupIslemler.Text = "İşlemler";
			// 
			// btnKapat
			// 
			this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnKapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.ImageOptions.Image")));
			this.btnKapat.Location = new System.Drawing.Point(1188, 43);
			this.btnKapat.Name = "btnKapat";
			this.btnKapat.Size = new System.Drawing.Size(94, 45);
			this.btnKapat.TabIndex = 0;
			this.btnKapat.Text = "Kapat";
			// 
			// btnOdemeHareketleri
			// 
			this.btnOdemeHareketleri.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnOdemeHareketleri.ImageOptions.SvgImage")));
			this.btnOdemeHareketleri.Location = new System.Drawing.Point(176, 43);
			this.btnOdemeHareketleri.Name = "btnOdemeHareketleri";
			this.btnOdemeHareketleri.Size = new System.Drawing.Size(166, 45);
			this.btnOdemeHareketleri.TabIndex = 0;
			this.btnOdemeHareketleri.Text = "Ödeme Hareketleri";
			this.btnOdemeHareketleri.Click += new System.EventHandler(this.btnOdemeHareketleri_Click);
			// 
			// btnYenile
			// 
			this.btnYenile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnYenile.ImageOptions.Image")));
			this.btnYenile.Location = new System.Drawing.Point(367, 43);
			this.btnYenile.Name = "btnYenile";
			this.btnYenile.Size = new System.Drawing.Size(153, 45);
			this.btnYenile.TabIndex = 0;
			this.btnYenile.Text = "Yenile-Listele";
			// 
			// btnSiparisDetay
			// 
			this.btnSiparisDetay.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSiparisDetay.ImageOptions.SvgImage")));
			this.btnSiparisDetay.Location = new System.Drawing.Point(13, 43);
			this.btnSiparisDetay.Name = "btnSiparisDetay";
			this.btnSiparisDetay.Size = new System.Drawing.Size(140, 45);
			this.btnSiparisDetay.TabIndex = 0;
			this.btnSiparisDetay.Text = "Sipariş Detayları";
			this.btnSiparisDetay.Click += new System.EventHandler(this.btnSiparisDetay_Click);
			// 
			// gridControl1
			// 
			this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridControl1.Location = new System.Drawing.Point(0, 47);
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new System.Drawing.Size(1294, 485);
			this.gridControl1.TabIndex = 7;
			this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colSatisKodu,
            this.colMusteriAdSoyad,
            this.colMusteriId,
            this.colTutar,
            this.colOdenen,
            this.colIndirimToplami,
            this.colKalan,
            this.colAciklama,
            this.colSonIslemTarihi,
            this.colPaketmiSiparismi});
			this.gridView1.GridControl = this.gridControl1;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsView.ShowFooter = true;
			// 
			// colId
			// 
			this.colId.FieldName = "Id";
			this.colId.MinWidth = 25;
			this.colId.Name = "colId";
			this.colId.OptionsColumn.AllowEdit = false;
			this.colId.Visible = true;
			this.colId.VisibleIndex = 0;
			this.colId.Width = 68;
			// 
			// colSatisKodu
			// 
			this.colSatisKodu.FieldName = "SatisKodu";
			this.colSatisKodu.MinWidth = 25;
			this.colSatisKodu.Name = "colSatisKodu";
			this.colSatisKodu.OptionsColumn.AllowEdit = false;
			this.colSatisKodu.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "SatisKodu", "Kayıt : {0}")});
			this.colSatisKodu.Visible = true;
			this.colSatisKodu.VisibleIndex = 1;
			this.colSatisKodu.Width = 94;
			// 
			// colMusteriAdSoyad
			// 
			this.colMusteriAdSoyad.Caption = "Müşteri Adı Soyadı";
			this.colMusteriAdSoyad.FieldName = "Musteriler.AdiSoyadi";
			this.colMusteriAdSoyad.MinWidth = 25;
			this.colMusteriAdSoyad.Name = "colMusteriAdSoyad";
			this.colMusteriAdSoyad.OptionsColumn.AllowEdit = false;
			this.colMusteriAdSoyad.Visible = true;
			this.colMusteriAdSoyad.VisibleIndex = 2;
			this.colMusteriAdSoyad.Width = 130;
			// 
			// colMusteriId
			// 
			this.colMusteriId.FieldName = "MusteriId";
			this.colMusteriId.MinWidth = 25;
			this.colMusteriId.Name = "colMusteriId";
			this.colMusteriId.OptionsColumn.AllowEdit = false;
			this.colMusteriId.Width = 94;
			// 
			// colTutar
			// 
			this.colTutar.DisplayFormat.FormatString = "C2";
			this.colTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colTutar.FieldName = "Tutar";
			this.colTutar.MinWidth = 25;
			this.colTutar.Name = "colTutar";
			this.colTutar.OptionsColumn.AllowEdit = false;
			this.colTutar.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Tutar", "Tutar={0:C2}")});
			this.colTutar.Visible = true;
			this.colTutar.VisibleIndex = 3;
			this.colTutar.Width = 128;
			// 
			// colOdenen
			// 
			this.colOdenen.DisplayFormat.FormatString = "C2";
			this.colOdenen.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colOdenen.FieldName = "Odenen";
			this.colOdenen.MinWidth = 25;
			this.colOdenen.Name = "colOdenen";
			this.colOdenen.OptionsColumn.AllowEdit = false;
			this.colOdenen.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Odenen", "{0:C2}")});
			this.colOdenen.Visible = true;
			this.colOdenen.VisibleIndex = 5;
			this.colOdenen.Width = 110;
			// 
			// colIndirimToplami
			// 
			this.colIndirimToplami.DisplayFormat.FormatString = "C2";
			this.colIndirimToplami.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colIndirimToplami.FieldName = "IndirimToplami";
			this.colIndirimToplami.MinWidth = 25;
			this.colIndirimToplami.Name = "colIndirimToplami";
			this.colIndirimToplami.OptionsColumn.AllowEdit = false;
			this.colIndirimToplami.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "IndirimToplami", "{0:C2}")});
			this.colIndirimToplami.Visible = true;
			this.colIndirimToplami.VisibleIndex = 4;
			this.colIndirimToplami.Width = 98;
			// 
			// colKalan
			// 
			this.colKalan.DisplayFormat.FormatString = "C2";
			this.colKalan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colKalan.FieldName = "Kalan";
			this.colKalan.MinWidth = 25;
			this.colKalan.Name = "colKalan";
			this.colKalan.OptionsColumn.AllowEdit = false;
			this.colKalan.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Kalan", "{0:C2}")});
			this.colKalan.Visible = true;
			this.colKalan.VisibleIndex = 6;
			this.colKalan.Width = 113;
			// 
			// colAciklama
			// 
			this.colAciklama.FieldName = "Aciklama";
			this.colAciklama.MinWidth = 25;
			this.colAciklama.Name = "colAciklama";
			this.colAciklama.OptionsColumn.AllowEdit = false;
			this.colAciklama.Visible = true;
			this.colAciklama.VisibleIndex = 7;
			this.colAciklama.Width = 295;
			// 
			// colSonIslemTarihi
			// 
			this.colSonIslemTarihi.FieldName = "SonIslemTarihi";
			this.colSonIslemTarihi.MinWidth = 25;
			this.colSonIslemTarihi.Name = "colSonIslemTarihi";
			this.colSonIslemTarihi.OptionsColumn.AllowEdit = false;
			this.colSonIslemTarihi.Visible = true;
			this.colSonIslemTarihi.VisibleIndex = 8;
			this.colSonIslemTarihi.Width = 143;
			// 
			// colPaketmiSiparismi
			// 
			this.colPaketmiSiparismi.Caption = "Paket mi Sipariş mi";
			this.colPaketmiSiparismi.FieldName = "PaketSiparisMi";
			this.colPaketmiSiparismi.MinWidth = 25;
			this.colPaketmiSiparismi.Name = "colPaketmiSiparismi";
			this.colPaketmiSiparismi.OptionsColumn.AllowEdit = false;
			this.colPaketmiSiparismi.Visible = true;
			this.colPaketmiSiparismi.VisibleIndex = 9;
			this.colPaketmiSiparismi.Width = 85;
			// 
			// btnExport
			// 
			this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExport.DropDownControl = this.popupMenu1;
			this.btnExport.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnExport.ImageOptions.SvgImage")));
			this.btnExport.Location = new System.Drawing.Point(1062, 44);
			this.btnExport.Name = "btnExport";
			this.btnExport.Size = new System.Drawing.Size(120, 44);
			this.btnExport.TabIndex = 1;
			this.btnExport.Text = "Export";
			// 
			// popupMenu1
			// 
			this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExcelExport),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnWordExport),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPdfExport)});
			this.popupMenu1.Manager = this.barManager1;
			this.popupMenu1.Name = "popupMenu1";
			// 
			// barManager1
			// 
			this.barManager1.DockControls.Add(this.barDockControlTop);
			this.barManager1.DockControls.Add(this.barDockControlBottom);
			this.barManager1.DockControls.Add(this.barDockControlLeft);
			this.barManager1.DockControls.Add(this.barDockControlRight);
			this.barManager1.Form = this;
			this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnExcelExport,
            this.btnWordExport,
            this.btnPdfExport});
			this.barManager1.MaxItemId = 3;
			// 
			// barDockControlTop
			// 
			this.barDockControlTop.CausesValidation = false;
			this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
			this.barDockControlTop.Manager = this.barManager1;
			this.barDockControlTop.Size = new System.Drawing.Size(1294, 0);
			// 
			// barDockControlBottom
			// 
			this.barDockControlBottom.CausesValidation = false;
			this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControlBottom.Location = new System.Drawing.Point(0, 632);
			this.barDockControlBottom.Manager = this.barManager1;
			this.barDockControlBottom.Size = new System.Drawing.Size(1294, 0);
			// 
			// barDockControlLeft
			// 
			this.barDockControlLeft.CausesValidation = false;
			this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
			this.barDockControlLeft.Manager = this.barManager1;
			this.barDockControlLeft.Size = new System.Drawing.Size(0, 632);
			// 
			// barDockControlRight
			// 
			this.barDockControlRight.CausesValidation = false;
			this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControlRight.Location = new System.Drawing.Point(1294, 0);
			this.barDockControlRight.Manager = this.barManager1;
			this.barDockControlRight.Size = new System.Drawing.Size(0, 632);
			// 
			// btnExcelExport
			// 
			this.btnExcelExport.Caption = "Excel Dosyaları(*.xlsx)";
			this.btnExcelExport.Id = 0;
			this.btnExcelExport.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnExcelExport.ImageOptions.SvgImage")));
			this.btnExcelExport.Name = "btnExcelExport";
			this.btnExcelExport.Tag = "Excel Dosyaları(*.xlsx)|*.xlsx";
			this.btnExcelExport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Export_ItemClick);
			// 
			// btnWordExport
			// 
			this.btnWordExport.Caption = "Word Dosyaları(*.docx)";
			this.btnWordExport.Id = 1;
			this.btnWordExport.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnWordExport.ImageOptions.SvgImage")));
			this.btnWordExport.Name = "btnWordExport";
			this.btnWordExport.Tag = "Word Dosyaları(*.docx)|*.docs";
			this.btnWordExport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Export_ItemClick);
			// 
			// btnPdfExport
			// 
			this.btnPdfExport.Caption = "Pdf Dosyaları(*.pdf)";
			this.btnPdfExport.Id = 2;
			this.btnPdfExport.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPdfExport.ImageOptions.SvgImage")));
			this.btnPdfExport.Name = "btnPdfExport";
			this.btnPdfExport.Tag = "Pdf Dosyaları(*.pdf)|*.pdf";
			this.btnPdfExport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Export_ItemClick);
			// 
			// frmSatislar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1294, 632);
			this.Controls.Add(this.gridControl1);
			this.Controls.Add(this.groupIslemler);
			this.Controls.Add(this.lblBaslik);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.Name = "frmSatislar";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Satışlar";
			((System.ComponentModel.ISupportInitialize)(this.groupIslemler)).EndInit();
			this.groupIslemler.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraEditors.LabelControl lblBaslik;
		private DevExpress.XtraEditors.GroupControl groupIslemler;
		private DevExpress.XtraEditors.SimpleButton btnKapat;
		private DevExpress.XtraEditors.SimpleButton btnOdemeHareketleri;
		private DevExpress.XtraEditors.SimpleButton btnYenile;
		private DevExpress.XtraEditors.SimpleButton btnSiparisDetay;
		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraGrid.Columns.GridColumn colId;
		private DevExpress.XtraGrid.Columns.GridColumn colSatisKodu;
		private DevExpress.XtraGrid.Columns.GridColumn colMusteriId;
		private DevExpress.XtraGrid.Columns.GridColumn colTutar;
		private DevExpress.XtraGrid.Columns.GridColumn colOdenen;
		private DevExpress.XtraGrid.Columns.GridColumn colIndirimToplami;
		private DevExpress.XtraGrid.Columns.GridColumn colKalan;
		private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
		private DevExpress.XtraGrid.Columns.GridColumn colSonIslemTarihi;
		private DevExpress.XtraGrid.Columns.GridColumn colMusteriAdSoyad;
		private DevExpress.XtraGrid.Columns.GridColumn colPaketmiSiparismi;
		private DevExpress.XtraEditors.DropDownButton btnExport;
		private DevExpress.XtraBars.PopupMenu popupMenu1;
		private DevExpress.XtraBars.BarButtonItem btnExcelExport;
		private DevExpress.XtraBars.BarButtonItem btnWordExport;
		private DevExpress.XtraBars.BarButtonItem btnPdfExport;
		private DevExpress.XtraBars.BarManager barManager1;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
	}
}