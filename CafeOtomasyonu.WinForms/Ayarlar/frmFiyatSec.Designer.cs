namespace CafeOtomasyonu.WinForms.Ayarlar
{
	partial class frmFiyatSec
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFiyatSec));
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
			this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
			this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.lookUpBirimFiyati = new DevExpress.XtraEditors.LookUpEdit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
			this.groupControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.lookUpBirimFiyati.Properties)).BeginInit();
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
			this.labelControl1.Size = new System.Drawing.Size(357, 39);
			this.labelControl1.TabIndex = 3;
			this.labelControl1.Text = "Fiyat";
			// 
			// groupControl1
			// 
			this.groupControl1.Controls.Add(this.btnKapat);
			this.groupControl1.Controls.Add(this.btnKaydet);
			this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.groupControl1.Location = new System.Drawing.Point(0, 111);
			this.groupControl1.Name = "groupControl1";
			this.groupControl1.Size = new System.Drawing.Size(357, 99);
			this.groupControl1.TabIndex = 5;
			this.groupControl1.Text = "İşlemler";
			// 
			// btnKapat
			// 
			this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnKapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.ImageOptions.Image")));
			this.btnKapat.Location = new System.Drawing.Point(251, 43);
			this.btnKapat.Name = "btnKapat";
			this.btnKapat.Size = new System.Drawing.Size(94, 45);
			this.btnKapat.TabIndex = 0;
			this.btnKapat.Text = "Kapat";
			this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
			// 
			// btnKaydet
			// 
			this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
			this.btnKaydet.Location = new System.Drawing.Point(13, 43);
			this.btnKaydet.Name = "btnKaydet";
			this.btnKaydet.Size = new System.Drawing.Size(94, 45);
			this.btnKaydet.TabIndex = 0;
			this.btnKaydet.Text = "Kaydet";
			this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
			// 
			// labelControl3
			// 
			this.labelControl3.Appearance.BorderColor = System.Drawing.Color.DarkGray;
			this.labelControl3.Appearance.Options.UseBorderColor = true;
			this.labelControl3.Appearance.Options.UseTextOptions = true;
			this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.labelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
			this.labelControl3.Location = new System.Drawing.Point(12, 45);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(102, 29);
			this.labelControl3.TabIndex = 11;
			this.labelControl3.Text = "Birim Fiyatı :";
			// 
			// lookUpBirimFiyati
			// 
			this.lookUpBirimFiyati.Location = new System.Drawing.Point(121, 46);
			this.lookUpBirimFiyati.Name = "lookUpBirimFiyati";
			this.lookUpBirimFiyati.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
			this.lookUpBirimFiyati.Properties.Appearance.Options.UseFont = true;
			this.lookUpBirimFiyati.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.lookUpBirimFiyati.Properties.NullText = "Birim Fiyatı Seçiniz";
			this.lookUpBirimFiyati.Properties.NullValuePrompt = "Birim Fiyatı Seçiniz";
			this.lookUpBirimFiyati.Size = new System.Drawing.Size(221, 28);
			this.lookUpBirimFiyati.TabIndex = 12;
			// 
			// frmFiyatSec
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(357, 210);
			this.Controls.Add(this.lookUpBirimFiyati);
			this.Controls.Add(this.labelControl3);
			this.Controls.Add(this.groupControl1);
			this.Controls.Add(this.labelControl1);
			this.Name = "frmFiyatSec";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Fiyat Ayarları";
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
			this.groupControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.lookUpBirimFiyati.Properties)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.GroupControl groupControl1;
		private DevExpress.XtraEditors.SimpleButton btnKapat;
		private DevExpress.XtraEditors.SimpleButton btnKaydet;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private DevExpress.XtraEditors.LookUpEdit lookUpBirimFiyati;
	}
}