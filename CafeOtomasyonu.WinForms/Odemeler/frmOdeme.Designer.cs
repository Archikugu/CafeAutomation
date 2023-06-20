namespace CafeOtomasyonu.WinForms.Odemeler
{
	partial class frmOdeme
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOdeme));
			this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
			this.groupIslemler = new DevExpress.XtraEditors.GroupControl();
			this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
			this.btnOnay = new DevExpress.XtraEditors.SimpleButton();
			this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
			this.dateEditTarih = new DevExpress.XtraEditors.DateEdit();
			this.txtAciklama = new DevExpress.XtraEditors.MemoEdit();
			this.calcOdenecekTutar = new DevExpress.XtraEditors.CalcEdit();
			this.btnTumTutar = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)(this.groupIslemler)).BeginInit();
			this.groupIslemler.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dateEditTarih.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dateEditTarih.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.calcOdenecekTutar.Properties)).BeginInit();
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
			this.lblBaslik.Size = new System.Drawing.Size(599, 47);
			this.lblBaslik.TabIndex = 3;
			this.lblBaslik.Text = "Ödeme";
			// 
			// groupIslemler
			// 
			this.groupIslemler.Controls.Add(this.btnKapat);
			this.groupIslemler.Controls.Add(this.btnOnay);
			this.groupIslemler.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.groupIslemler.Location = new System.Drawing.Point(0, 395);
			this.groupIslemler.Name = "groupIslemler";
			this.groupIslemler.Size = new System.Drawing.Size(599, 100);
			this.groupIslemler.TabIndex = 6;
			this.groupIslemler.Text = "İşlemler";
			// 
			// btnKapat
			// 
			this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnKapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.ImageOptions.Image")));
			this.btnKapat.Location = new System.Drawing.Point(493, 43);
			this.btnKapat.Name = "btnKapat";
			this.btnKapat.Size = new System.Drawing.Size(94, 45);
			this.btnKapat.TabIndex = 0;
			this.btnKapat.Text = "Kapat";
			this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
			// 
			// btnOnay
			// 
			this.btnOnay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOnay.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOnay.ImageOptions.Image")));
			this.btnOnay.Location = new System.Drawing.Point(393, 43);
			this.btnOnay.Name = "btnOnay";
			this.btnOnay.Size = new System.Drawing.Size(94, 45);
			this.btnOnay.TabIndex = 0;
			this.btnOnay.Text = "Onay";
			this.btnOnay.Click += new System.EventHandler(this.btnOnay_Click);
			// 
			// labelControl4
			// 
			this.labelControl4.Appearance.BorderColor = System.Drawing.Color.Silver;
			this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl4.Appearance.Options.UseBorderColor = true;
			this.labelControl4.Appearance.Options.UseFont = true;
			this.labelControl4.Appearance.Options.UseTextOptions = true;
			this.labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.labelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
			this.labelControl4.Location = new System.Drawing.Point(12, 62);
			this.labelControl4.Name = "labelControl4";
			this.labelControl4.Size = new System.Drawing.Size(140, 30);
			this.labelControl4.TabIndex = 24;
			this.labelControl4.Text = "Ödenecek Tutar :";
			// 
			// labelControl10
			// 
			this.labelControl10.Appearance.BorderColor = System.Drawing.Color.DarkGray;
			this.labelControl10.Appearance.Options.UseBorderColor = true;
			this.labelControl10.Appearance.Options.UseTextOptions = true;
			this.labelControl10.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.labelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.labelControl10.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
			this.labelControl10.Location = new System.Drawing.Point(12, 111);
			this.labelControl10.Name = "labelControl10";
			this.labelControl10.Size = new System.Drawing.Size(140, 111);
			this.labelControl10.TabIndex = 26;
			this.labelControl10.Text = "Açıklama :";
			// 
			// labelControl9
			// 
			this.labelControl9.Appearance.BorderColor = System.Drawing.Color.DarkGray;
			this.labelControl9.Appearance.Options.UseBorderColor = true;
			this.labelControl9.Appearance.Options.UseTextOptions = true;
			this.labelControl9.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.labelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.labelControl9.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
			this.labelControl9.Location = new System.Drawing.Point(12, 244);
			this.labelControl9.Name = "labelControl9";
			this.labelControl9.Size = new System.Drawing.Size(140, 29);
			this.labelControl9.TabIndex = 28;
			this.labelControl9.Text = "Tarih :";
			// 
			// dateEditTarih
			// 
			this.dateEditTarih.EditValue = null;
			this.dateEditTarih.Location = new System.Drawing.Point(158, 245);
			this.dateEditTarih.Name = "dateEditTarih";
			this.dateEditTarih.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateEditTarih.Properties.Appearance.Options.UseFont = true;
			this.dateEditTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dateEditTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dateEditTarih.Size = new System.Drawing.Size(406, 28);
			this.dateEditTarih.TabIndex = 29;
			// 
			// txtAciklama
			// 
			this.txtAciklama.Location = new System.Drawing.Point(158, 112);
			this.txtAciklama.Name = "txtAciklama";
			this.txtAciklama.Size = new System.Drawing.Size(406, 110);
			this.txtAciklama.TabIndex = 27;
			// 
			// calcOdenecekTutar
			// 
			this.calcOdenecekTutar.Location = new System.Drawing.Point(158, 62);
			this.calcOdenecekTutar.Name = "calcOdenecekTutar";
			this.calcOdenecekTutar.Properties.Appearance.BackColor = System.Drawing.Color.Lime;
			this.calcOdenecekTutar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.calcOdenecekTutar.Properties.Appearance.ForeColor = System.Drawing.Color.White;
			this.calcOdenecekTutar.Properties.Appearance.Options.UseBackColor = true;
			this.calcOdenecekTutar.Properties.Appearance.Options.UseFont = true;
			this.calcOdenecekTutar.Properties.Appearance.Options.UseForeColor = true;
			this.calcOdenecekTutar.Properties.Appearance.Options.UseTextOptions = true;
			this.calcOdenecekTutar.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.calcOdenecekTutar.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.calcOdenecekTutar.Properties.EditFormat.FormatString = "C2";
			this.calcOdenecekTutar.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.calcOdenecekTutar.Properties.MaskSettings.Set("mask", "n");
			this.calcOdenecekTutar.Properties.MaskSettings.Set("culture", "tr-TR");
			this.calcOdenecekTutar.Properties.NullText = "₺0,00";
			this.calcOdenecekTutar.Properties.UseMaskAsDisplayFormat = true;
			this.calcOdenecekTutar.Size = new System.Drawing.Size(294, 30);
			this.calcOdenecekTutar.TabIndex = 25;
			// 
			// btnTumTutar
			// 
			this.btnTumTutar.Location = new System.Drawing.Point(458, 62);
			this.btnTumTutar.Name = "btnTumTutar";
			this.btnTumTutar.Size = new System.Drawing.Size(106, 29);
			this.btnTumTutar.TabIndex = 30;
			this.btnTumTutar.Text = "Tüm Kalan Tutar";
			this.btnTumTutar.Click += new System.EventHandler(this.btnTumTutar_Click);
			// 
			// frmOdeme
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(599, 495);
			this.Controls.Add(this.btnTumTutar);
			this.Controls.Add(this.dateEditTarih);
			this.Controls.Add(this.labelControl9);
			this.Controls.Add(this.txtAciklama);
			this.Controls.Add(this.labelControl10);
			this.Controls.Add(this.calcOdenecekTutar);
			this.Controls.Add(this.labelControl4);
			this.Controls.Add(this.groupIslemler);
			this.Controls.Add(this.lblBaslik);
			this.Name = "frmOdeme";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ödeme";
			((System.ComponentModel.ISupportInitialize)(this.groupIslemler)).EndInit();
			this.groupIslemler.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dateEditTarih.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dateEditTarih.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.calcOdenecekTutar.Properties)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.LabelControl lblBaslik;
		private DevExpress.XtraEditors.GroupControl groupIslemler;
		private DevExpress.XtraEditors.SimpleButton btnKapat;
		private DevExpress.XtraEditors.SimpleButton btnOnay;
		private DevExpress.XtraEditors.CalcEdit calcOdenecekTutar;
		private DevExpress.XtraEditors.LabelControl labelControl4;
		private DevExpress.XtraEditors.MemoEdit txtAciklama;
		private DevExpress.XtraEditors.LabelControl labelControl10;
		private DevExpress.XtraEditors.DateEdit dateEditTarih;
		private DevExpress.XtraEditors.LabelControl labelControl9;
		private DevExpress.XtraEditors.SimpleButton btnTumTutar;
	}
}