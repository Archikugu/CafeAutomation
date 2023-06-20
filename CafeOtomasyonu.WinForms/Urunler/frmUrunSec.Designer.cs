namespace CafeOtomasyonu.WinForms.Urunler
{
	partial class frmUrunSec
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUrunSec));
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
			this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
			this.btnSec = new DevExpress.XtraEditors.SimpleButton();
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
			this.labelControl1.Size = new System.Drawing.Size(1313, 47);
			this.labelControl1.TabIndex = 2;
			this.labelControl1.Text = "Ürün Seçim Sayfası";
			// 
			// groupControl1
			// 
			this.groupControl1.Controls.Add(this.btnKapat);
			this.groupControl1.Controls.Add(this.btnSec);
			this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.groupControl1.Location = new System.Drawing.Point(0, 540);
			this.groupControl1.Name = "groupControl1";
			this.groupControl1.Size = new System.Drawing.Size(1313, 100);
			this.groupControl1.TabIndex = 3;
			this.groupControl1.Text = "İşlemler";
			// 
			// btnKapat
			// 
			this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnKapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.ImageOptions.Image")));
			this.btnKapat.Location = new System.Drawing.Point(1207, 43);
			this.btnKapat.Name = "btnKapat";
			this.btnKapat.Size = new System.Drawing.Size(94, 45);
			this.btnKapat.TabIndex = 0;
			this.btnKapat.Text = "Kapat";
			// 
			// btnSec
			// 
			this.btnSec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSec.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSec.ImageOptions.Image")));
			this.btnSec.Location = new System.Drawing.Point(1107, 43);
			this.btnSec.Name = "btnSec";
			this.btnSec.Size = new System.Drawing.Size(94, 45);
			this.btnSec.TabIndex = 0;
			this.btnSec.Text = "Seç";
			this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
			// 
			// gridControl1
			// 
			this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridControl1.Location = new System.Drawing.Point(0, 47);
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new System.Drawing.Size(1313, 493);
			this.gridControl1.TabIndex = 4;
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
            this.colMenu});
			this.gridView1.GridControl = this.gridControl1;
			this.gridView1.Name = "gridView1";
			// 
			// colId
			// 
			this.colId.Caption = "Id";
			this.colId.FieldName = "Id";
			this.colId.MinWidth = 25;
			this.colId.Name = "colId";
			this.colId.Visible = true;
			this.colId.VisibleIndex = 0;
			this.colId.Width = 66;
			// 
			// colMenuId
			// 
			this.colMenuId.Caption = "MenuId";
			this.colMenuId.FieldName = "MenuId";
			this.colMenuId.MinWidth = 25;
			this.colMenuId.Name = "colMenuId";
			this.colMenuId.Width = 94;
			// 
			// colUrunKodu
			// 
			this.colUrunKodu.Caption = "UrunKodu";
			this.colUrunKodu.FieldName = "UrunKodu";
			this.colUrunKodu.MinWidth = 25;
			this.colUrunKodu.Name = "colUrunKodu";
			this.colUrunKodu.Visible = true;
			this.colUrunKodu.VisibleIndex = 2;
			this.colUrunKodu.Width = 101;
			// 
			// colUrunAdi
			// 
			this.colUrunAdi.Caption = "Ürün Adi";
			this.colUrunAdi.FieldName = "UrunAdi";
			this.colUrunAdi.MinWidth = 25;
			this.colUrunAdi.Name = "colUrunAdi";
			this.colUrunAdi.Visible = true;
			this.colUrunAdi.VisibleIndex = 3;
			this.colUrunAdi.Width = 95;
			// 
			// colAciklama
			// 
			this.colAciklama.Caption = "Açıklama";
			this.colAciklama.FieldName = "Aciklama";
			this.colAciklama.MinWidth = 25;
			this.colAciklama.Name = "colAciklama";
			this.colAciklama.Visible = true;
			this.colAciklama.VisibleIndex = 7;
			this.colAciklama.Width = 392;
			// 
			// colBirimFiyati1
			// 
			this.colBirimFiyati1.Caption = "Birim Fiyatı1";
			this.colBirimFiyati1.FieldName = "BirimFiyati1";
			this.colBirimFiyati1.MinWidth = 25;
			this.colBirimFiyati1.Name = "colBirimFiyati1";
			this.colBirimFiyati1.Visible = true;
			this.colBirimFiyati1.VisibleIndex = 4;
			this.colBirimFiyati1.Width = 93;
			// 
			// colBirimFiyati2
			// 
			this.colBirimFiyati2.Caption = "Birim Fiyatı2";
			this.colBirimFiyati2.FieldName = "BirimFiyati2";
			this.colBirimFiyati2.MinWidth = 25;
			this.colBirimFiyati2.Name = "colBirimFiyati2";
			this.colBirimFiyati2.Visible = true;
			this.colBirimFiyati2.VisibleIndex = 5;
			this.colBirimFiyati2.Width = 95;
			// 
			// colBirimFiyati3
			// 
			this.colBirimFiyati3.Caption = "Birim Fiyatı3";
			this.colBirimFiyati3.FieldName = "BirimFiyati3";
			this.colBirimFiyati3.MinWidth = 25;
			this.colBirimFiyati3.Name = "colBirimFiyati3";
			this.colBirimFiyati3.Visible = true;
			this.colBirimFiyati3.VisibleIndex = 6;
			this.colBirimFiyati3.Width = 110;
			// 
			// colTarih
			// 
			this.colTarih.Caption = "Tarih";
			this.colTarih.FieldName = "Tarih";
			this.colTarih.MinWidth = 25;
			this.colTarih.Name = "colTarih";
			this.colTarih.Visible = true;
			this.colTarih.VisibleIndex = 8;
			this.colTarih.Width = 200;
			// 
			// colResim
			// 
			this.colResim.Caption = "Resim";
			this.colResim.FieldName = "Resim";
			this.colResim.MinWidth = 25;
			this.colResim.Name = "colResim";
			this.colResim.Width = 94;
			// 
			// colMenu
			// 
			this.colMenu.Caption = "Menü";
			this.colMenu.FieldName = "Menu.MenuAdi";
			this.colMenu.MinWidth = 25;
			this.colMenu.Name = "colMenu";
			this.colMenu.Visible = true;
			this.colMenu.VisibleIndex = 1;
			this.colMenu.Width = 131;
			// 
			// frmUrunSec
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1313, 640);
			this.Controls.Add(this.gridControl1);
			this.Controls.Add(this.groupControl1);
			this.Controls.Add(this.labelControl1);
			this.Name = "frmUrunSec";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ürün Seçim Sayfası";
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
		private DevExpress.XtraEditors.SimpleButton btnSec;
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
	}
}