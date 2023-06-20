namespace CafeOtomasyonu.WinForms.Masalar
{
	partial class frmMasaRezerv
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMasaRezerv));
			this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
			this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
			this.txtIslem = new DevExpress.XtraEditors.MemoEdit();
			this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
			this.dateEditTarih = new DevExpress.XtraEditors.DateEdit();
			this.groupIslemler = new DevExpress.XtraEditors.GroupControl();
			this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
			this.btnOnayla = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)(this.txtIslem.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dateEditTarih.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dateEditTarih.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupIslemler)).BeginInit();
			this.groupIslemler.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelControl8
			// 
			this.labelControl8.Appearance.BorderColor = System.Drawing.Color.DarkGray;
			this.labelControl8.Appearance.Options.UseBorderColor = true;
			this.labelControl8.Appearance.Options.UseTextOptions = true;
			this.labelControl8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.labelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.labelControl8.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
			this.labelControl8.Location = new System.Drawing.Point(60, 90);
			this.labelControl8.Name = "labelControl8";
			this.labelControl8.Size = new System.Drawing.Size(150, 29);
			this.labelControl8.TabIndex = 12;
			this.labelControl8.Text = "Tarih :";
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
			this.lblBaslik.Size = new System.Drawing.Size(627, 47);
			this.lblBaslik.TabIndex = 13;
			this.lblBaslik.Text = "Masa Rezervi";
			// 
			// txtIslem
			// 
			this.txtIslem.Location = new System.Drawing.Point(216, 132);
			this.txtIslem.Name = "txtIslem";
			this.txtIslem.Size = new System.Drawing.Size(354, 110);
			this.txtIslem.TabIndex = 17;
			// 
			// labelControl10
			// 
			this.labelControl10.Appearance.BorderColor = System.Drawing.Color.DarkGray;
			this.labelControl10.Appearance.Options.UseBorderColor = true;
			this.labelControl10.Appearance.Options.UseTextOptions = true;
			this.labelControl10.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.labelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.labelControl10.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
			this.labelControl10.Location = new System.Drawing.Point(60, 133);
			this.labelControl10.Name = "labelControl10";
			this.labelControl10.Size = new System.Drawing.Size(150, 109);
			this.labelControl10.TabIndex = 16;
			this.labelControl10.Text = "İşlem :";
			// 
			// dateEditTarih
			// 
			this.dateEditTarih.EditValue = null;
			this.dateEditTarih.Location = new System.Drawing.Point(216, 91);
			this.dateEditTarih.Name = "dateEditTarih";
			this.dateEditTarih.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateEditTarih.Properties.Appearance.Options.UseFont = true;
			this.dateEditTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dateEditTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dateEditTarih.Size = new System.Drawing.Size(354, 28);
			this.dateEditTarih.TabIndex = 18;
			// 
			// groupIslemler
			// 
			this.groupIslemler.Controls.Add(this.btnKapat);
			this.groupIslemler.Controls.Add(this.btnOnayla);
			this.groupIslemler.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.groupIslemler.Location = new System.Drawing.Point(0, 299);
			this.groupIslemler.Name = "groupIslemler";
			this.groupIslemler.Size = new System.Drawing.Size(627, 100);
			this.groupIslemler.TabIndex = 19;
			this.groupIslemler.Text = "İşlemler";
			// 
			// btnKapat
			// 
			this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnKapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.ImageOptions.Image")));
			this.btnKapat.Location = new System.Drawing.Point(521, 43);
			this.btnKapat.Name = "btnKapat";
			this.btnKapat.Size = new System.Drawing.Size(94, 45);
			this.btnKapat.TabIndex = 0;
			this.btnKapat.Text = "Kapat";
			this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
			// 
			// btnOnayla
			// 
			this.btnOnayla.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSiparisEkle.ImageOptions.Image")));
			this.btnOnayla.Location = new System.Drawing.Point(13, 43);
			this.btnOnayla.Name = "btnOnayla";
			this.btnOnayla.Size = new System.Drawing.Size(144, 45);
			this.btnOnayla.TabIndex = 0;
			this.btnOnayla.Text = "Onayla";
			this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
			// 
			// frmMasaRezerv
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(627, 399);
			this.Controls.Add(this.groupIslemler);
			this.Controls.Add(this.dateEditTarih);
			this.Controls.Add(this.txtIslem);
			this.Controls.Add(this.labelControl10);
			this.Controls.Add(this.lblBaslik);
			this.Controls.Add(this.labelControl8);
			this.Name = "frmMasaRezerv";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Masa Rezervi";
			((System.ComponentModel.ISupportInitialize)(this.txtIslem.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dateEditTarih.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dateEditTarih.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupIslemler)).EndInit();
			this.groupIslemler.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.LabelControl labelControl8;
		private DevExpress.XtraEditors.LabelControl lblBaslik;
		private DevExpress.XtraEditors.MemoEdit txtIslem;
		private DevExpress.XtraEditors.LabelControl labelControl10;
		private DevExpress.XtraEditors.DateEdit dateEditTarih;
		private DevExpress.XtraEditors.GroupControl groupIslemler;
		private DevExpress.XtraEditors.SimpleButton btnKapat;
		private DevExpress.XtraEditors.SimpleButton btnOnayla;
	}
}