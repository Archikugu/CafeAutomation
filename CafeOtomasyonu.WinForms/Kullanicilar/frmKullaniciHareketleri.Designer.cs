namespace CafeOtomasyonu.WinForms.Kullanicilar
{
	partial class frmKullaniciHareketleri
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKullaniciHareketleri));
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
			this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colKullaniciId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTarih = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colKullanicilar = new DevExpress.XtraGrid.Columns.GridColumn();
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
			this.labelControl1.Size = new System.Drawing.Size(883, 47);
			this.labelControl1.TabIndex = 5;
			this.labelControl1.Text = "Kullanıcı Hareketleri";
			// 
			// groupControl1
			// 
			this.groupControl1.Controls.Add(this.btnKapat);
			this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.groupControl1.Location = new System.Drawing.Point(0, 507);
			this.groupControl1.Name = "groupControl1";
			this.groupControl1.Size = new System.Drawing.Size(883, 100);
			this.groupControl1.TabIndex = 7;
			// 
			// btnKapat
			// 
			this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnKapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.ImageOptions.Image")));
			this.btnKapat.Location = new System.Drawing.Point(777, 43);
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
			this.gridControl1.Size = new System.Drawing.Size(883, 460);
			this.gridControl1.TabIndex = 8;
			this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colKullaniciId,
            this.colAciklama,
            this.colTarih,
            this.colKullanicilar});
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
			this.colId.Width = 104;
			// 
			// colKullaniciId
			// 
			this.colKullaniciId.FieldName = "KullaniciId";
			this.colKullaniciId.MinWidth = 25;
			this.colKullaniciId.Name = "colKullaniciId";
			this.colKullaniciId.OptionsColumn.AllowEdit = false;
			this.colKullaniciId.Width = 128;
			// 
			// colAciklama
			// 
			this.colAciklama.FieldName = "Aciklama";
			this.colAciklama.MinWidth = 25;
			this.colAciklama.Name = "colAciklama";
			this.colAciklama.OptionsColumn.AllowEdit = false;
			this.colAciklama.Visible = true;
			this.colAciklama.VisibleIndex = 1;
			this.colAciklama.Width = 244;
			// 
			// colTarih
			// 
			this.colTarih.FieldName = "Tarih";
			this.colTarih.MinWidth = 25;
			this.colTarih.Name = "colTarih";
			this.colTarih.OptionsColumn.AllowEdit = false;
			this.colTarih.Visible = true;
			this.colTarih.VisibleIndex = 2;
			this.colTarih.Width = 246;
			// 
			// colKullanicilar
			// 
			this.colKullanicilar.FieldName = "Kullanicilar.AdSoyad";
			this.colKullanicilar.MinWidth = 25;
			this.colKullanicilar.Name = "colKullanicilar";
			this.colKullanicilar.OptionsColumn.AllowEdit = false;
			this.colKullanicilar.Visible = true;
			this.colKullanicilar.VisibleIndex = 3;
			this.colKullanicilar.Width = 259;
			// 
			// frmKullaniciHareketleri
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(883, 607);
			this.Controls.Add(this.gridControl1);
			this.Controls.Add(this.groupControl1);
			this.Controls.Add(this.labelControl1);
			this.Name = "frmKullaniciHareketleri";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Kullanici Hareketleri";
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
		private DevExpress.XtraGrid.Columns.GridColumn colKullaniciId;
		private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
		private DevExpress.XtraGrid.Columns.GridColumn colTarih;
		private DevExpress.XtraGrid.Columns.GridColumn colKullanicilar;
	}
}