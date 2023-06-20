namespace CafeOtomasyonu.WinForms.Urunler
{
	partial class frmUrunHareketleri
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUrunHareketleri));
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
			this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colUrunId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTarih = new DevExpress.XtraGrid.Columns.GridColumn();
			this.btnSil = new DevExpress.XtraEditors.SimpleButton();
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
			this.labelControl1.Size = new System.Drawing.Size(1170, 47);
			this.labelControl1.TabIndex = 6;
			this.labelControl1.Text = "Ürün Hareketleri";
			// 
			// groupControl1
			// 
			this.groupControl1.Controls.Add(this.btnSil);
			this.groupControl1.Controls.Add(this.btnKapat);
			this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.groupControl1.Location = new System.Drawing.Point(0, 594);
			this.groupControl1.Name = "groupControl1";
			this.groupControl1.Size = new System.Drawing.Size(1170, 100);
			this.groupControl1.TabIndex = 8;
			// 
			// btnKapat
			// 
			this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnKapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.ImageOptions.Image")));
			this.btnKapat.Location = new System.Drawing.Point(1064, 43);
			this.btnKapat.Name = "btnKapat";
			this.btnKapat.Size = new System.Drawing.Size(94, 45);
			this.btnKapat.TabIndex = 0;
			this.btnKapat.Text = "Kapat";
			this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
			// 
			// gridControl1
			// 
			this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridControl1.Location = new System.Drawing.Point(0, 47);
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new System.Drawing.Size(1170, 547);
			this.gridControl1.TabIndex = 9;
			this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colUrunId,
            this.colAciklama,
            this.colTarih});
			this.gridView1.GridControl = this.gridControl1;
			this.gridView1.Name = "gridView1";
			// 
			// colId
			// 
			this.colId.FieldName = "Id";
			this.colId.MinWidth = 25;
			this.colId.Name = "colId";
			this.colId.Visible = true;
			this.colId.VisibleIndex = 0;
			this.colId.Width = 94;
			// 
			// colUrunId
			// 
			this.colUrunId.FieldName = "Urun.UrunAdi";
			this.colUrunId.MinWidth = 25;
			this.colUrunId.Name = "colUrunId";
			this.colUrunId.Visible = true;
			this.colUrunId.VisibleIndex = 1;
			this.colUrunId.Width = 94;
			// 
			// colAciklama
			// 
			this.colAciklama.FieldName = "Aciklama";
			this.colAciklama.MinWidth = 25;
			this.colAciklama.Name = "colAciklama";
			this.colAciklama.Visible = true;
			this.colAciklama.VisibleIndex = 2;
			this.colAciklama.Width = 94;
			// 
			// colTarih
			// 
			this.colTarih.FieldName = "Tarih";
			this.colTarih.MinWidth = 25;
			this.colTarih.Name = "colTarih";
			this.colTarih.Visible = true;
			this.colTarih.VisibleIndex = 3;
			this.colTarih.Width = 94;
			// 
			// btnSil
			// 
			this.btnSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSil.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
			this.btnSil.Location = new System.Drawing.Point(943, 43);
			this.btnSil.Name = "btnSil";
			this.btnSil.Size = new System.Drawing.Size(94, 45);
			this.btnSil.TabIndex = 0;
			this.btnSil.Text = "Sil";
			this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
			// 
			// frmUrunHareketleri
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1170, 694);
			this.Controls.Add(this.gridControl1);
			this.Controls.Add(this.groupControl1);
			this.Controls.Add(this.labelControl1);
			this.Name = "frmUrunHareketleri";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Urun Hareketleri";
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
		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraGrid.Columns.GridColumn colId;
		private DevExpress.XtraGrid.Columns.GridColumn colUrunId;
		private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
		private DevExpress.XtraGrid.Columns.GridColumn colTarih;
		private DevExpress.XtraEditors.SimpleButton btnSil;
	}
}