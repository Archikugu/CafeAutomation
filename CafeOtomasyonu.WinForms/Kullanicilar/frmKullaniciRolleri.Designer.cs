namespace CafeOtomasyonu.WinForms.Kullanicilar
{
	partial class frmKullaniciRolleri
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKullaniciRolleri));
			this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
			this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
			this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
			this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colKullaniciId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colFormName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colControlName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colControlCaption = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colVisible = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
			this.groupControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
			this.lblBaslik.Size = new System.Drawing.Size(1094, 47);
			this.lblBaslik.TabIndex = 11;
			this.lblBaslik.Text = "Kullanıcı Rolleri";
			// 
			// groupControl1
			// 
			this.groupControl1.Controls.Add(this.btnKapat);
			this.groupControl1.Controls.Add(this.btnKaydet);
			this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.groupControl1.Location = new System.Drawing.Point(0, 558);
			this.groupControl1.Name = "groupControl1";
			this.groupControl1.Size = new System.Drawing.Size(1094, 100);
			this.groupControl1.TabIndex = 12;
			this.groupControl1.Text = "İşlemler";
			// 
			// btnKapat
			// 
			this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnKapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.ImageOptions.Image")));
			this.btnKapat.Location = new System.Drawing.Point(988, 43);
			this.btnKapat.Name = "btnKapat";
			this.btnKapat.Size = new System.Drawing.Size(94, 45);
			this.btnKapat.TabIndex = 0;
			this.btnKapat.Text = "Kapat";
			// 
			// btnKaydet
			// 
			this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
			this.btnKaydet.Location = new System.Drawing.Point(5, 43);
			this.btnKaydet.Name = "btnKaydet";
			this.btnKaydet.Size = new System.Drawing.Size(94, 45);
			this.btnKaydet.TabIndex = 0;
			this.btnKaydet.Text = "Kaydet";
			this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
			// 
			// gridControl1
			// 
			this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridControl1.Location = new System.Drawing.Point(0, 47);
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new System.Drawing.Size(1094, 511);
			this.gridControl1.TabIndex = 13;
			this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colKullaniciId,
            this.colFormName,
            this.colControlName,
            this.colControlCaption,
            this.colVisible});
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
			this.colId.Width = 177;
			// 
			// colKullaniciId
			// 
			this.colKullaniciId.FieldName = "KullaniciId";
			this.colKullaniciId.MinWidth = 25;
			this.colKullaniciId.Name = "colKullaniciId";
			this.colKullaniciId.OptionsColumn.AllowEdit = false;
			this.colKullaniciId.Width = 177;
			// 
			// colFormName
			// 
			this.colFormName.FieldName = "FormName";
			this.colFormName.MinWidth = 25;
			this.colFormName.Name = "colFormName";
			this.colFormName.OptionsColumn.AllowEdit = false;
			this.colFormName.Visible = true;
			this.colFormName.VisibleIndex = 1;
			this.colFormName.Width = 177;
			// 
			// colControlName
			// 
			this.colControlName.FieldName = "ControlName";
			this.colControlName.MinWidth = 25;
			this.colControlName.Name = "colControlName";
			this.colControlName.OptionsColumn.AllowEdit = false;
			this.colControlName.Visible = true;
			this.colControlName.VisibleIndex = 2;
			this.colControlName.Width = 217;
			// 
			// colControlCaption
			// 
			this.colControlCaption.FieldName = "ControlCaption";
			this.colControlCaption.MinWidth = 25;
			this.colControlCaption.Name = "colControlCaption";
			this.colControlCaption.OptionsColumn.AllowEdit = false;
			this.colControlCaption.Visible = true;
			this.colControlCaption.VisibleIndex = 3;
			this.colControlCaption.Width = 193;
			// 
			// colVisible
			// 
			this.colVisible.Caption = "Yetkili Mi ?";
			this.colVisible.FieldName = "Visible";
			this.colVisible.MinWidth = 25;
			this.colVisible.Name = "colVisible";
			this.colVisible.Visible = true;
			this.colVisible.VisibleIndex = 4;
			this.colVisible.Width = 123;
			// 
			// frmKullaniciRolleri
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1094, 658);
			this.Controls.Add(this.gridControl1);
			this.Controls.Add(this.groupControl1);
			this.Controls.Add(this.lblBaslik);
			this.Name = "frmKullaniciRolleri";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Kullanici Rolleri";
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
			this.groupControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.LabelControl lblBaslik;
		private DevExpress.XtraEditors.GroupControl groupControl1;
		private DevExpress.XtraEditors.SimpleButton btnKapat;
		private DevExpress.XtraEditors.SimpleButton btnKaydet;
		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraGrid.Columns.GridColumn colId;
		private DevExpress.XtraGrid.Columns.GridColumn colKullaniciId;
		private DevExpress.XtraGrid.Columns.GridColumn colFormName;
		private DevExpress.XtraGrid.Columns.GridColumn colControlName;
		private DevExpress.XtraGrid.Columns.GridColumn colControlCaption;
		private DevExpress.XtraGrid.Columns.GridColumn colVisible;
	}
}