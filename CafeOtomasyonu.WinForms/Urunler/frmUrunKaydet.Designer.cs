namespace CafeOtomasyonu.WinForms.Urunler
{
    partial class frmUrunKaydet
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUrunKaydet));
			this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
			this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
			this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
			this.btnUrunKaydet = new DevExpress.XtraEditors.SimpleButton();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
			this.calcBirimFiyati1 = new DevExpress.XtraEditors.CalcEdit();
			this.calcBirimFiyati2 = new DevExpress.XtraEditors.CalcEdit();
			this.calcBirimFiyati3 = new DevExpress.XtraEditors.CalcEdit();
			this.txtAciklama = new DevExpress.XtraEditors.MemoEdit();
			this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
			this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
			this.txtUrunAdi = new DevExpress.XtraEditors.TextEdit();
			this.txtUrunKodu = new DevExpress.XtraEditors.TextEdit();
			this.lookUpMenu = new DevExpress.XtraEditors.LookUpEdit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
			this.groupControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.calcBirimFiyati1.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.calcBirimFiyati2.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.calcBirimFiyati3.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtUrunAdi.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtUrunKodu.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lookUpMenu.Properties)).BeginInit();
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
			this.lblBaslik.Size = new System.Drawing.Size(732, 47);
			this.lblBaslik.TabIndex = 2;
			this.lblBaslik.Text = "Ürün Kayıt";
			// 
			// groupControl1
			// 
			this.groupControl1.Controls.Add(this.btnKapat);
			this.groupControl1.Controls.Add(this.btnUrunKaydet);
			this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.groupControl1.Location = new System.Drawing.Point(0, 427);
			this.groupControl1.Name = "groupControl1";
			this.groupControl1.Size = new System.Drawing.Size(732, 100);
			this.groupControl1.TabIndex = 3;
			this.groupControl1.Text = "İşlemler";
			// 
			// btnKapat
			// 
			this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnKapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.ImageOptions.Image")));
			this.btnKapat.Location = new System.Drawing.Point(626, 43);
			this.btnKapat.Name = "btnKapat";
			this.btnKapat.Size = new System.Drawing.Size(94, 45);
			this.btnKapat.TabIndex = 0;
			this.btnKapat.Text = "Kapat";
			this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
			// 
			// btnUrunKaydet
			// 
			this.btnUrunKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUrunKaydet.ImageOptions.Image")));
			this.btnUrunKaydet.Location = new System.Drawing.Point(13, 43);
			this.btnUrunKaydet.Name = "btnUrunKaydet";
			this.btnUrunKaydet.Size = new System.Drawing.Size(94, 45);
			this.btnUrunKaydet.TabIndex = 0;
			this.btnUrunKaydet.Text = "Kaydet";
			this.btnUrunKaydet.Click += new System.EventHandler(this.btnUrunKaydet_Click);
			// 
			// labelControl2
			// 
			this.labelControl2.Appearance.BorderColor = System.Drawing.Color.DarkGray;
			this.labelControl2.Appearance.Options.UseBorderColor = true;
			this.labelControl2.Appearance.Options.UseTextOptions = true;
			this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
			this.labelControl2.Location = new System.Drawing.Point(27, 53);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(150, 29);
			this.labelControl2.TabIndex = 4;
			this.labelControl2.Text = "Menü :";
			// 
			// labelControl3
			// 
			this.labelControl3.Appearance.BorderColor = System.Drawing.Color.DarkGray;
			this.labelControl3.Appearance.Options.UseBorderColor = true;
			this.labelControl3.Appearance.Options.UseTextOptions = true;
			this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.labelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
			this.labelControl3.Location = new System.Drawing.Point(27, 88);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(150, 29);
			this.labelControl3.TabIndex = 4;
			this.labelControl3.Text = "Ürün Kodu :";
			// 
			// labelControl4
			// 
			this.labelControl4.Appearance.BorderColor = System.Drawing.Color.DarkGray;
			this.labelControl4.Appearance.Options.UseBorderColor = true;
			this.labelControl4.Appearance.Options.UseTextOptions = true;
			this.labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.labelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
			this.labelControl4.Location = new System.Drawing.Point(27, 123);
			this.labelControl4.Name = "labelControl4";
			this.labelControl4.Size = new System.Drawing.Size(150, 29);
			this.labelControl4.TabIndex = 4;
			this.labelControl4.Text = "Ürün Adı :";
			// 
			// labelControl5
			// 
			this.labelControl5.Appearance.BorderColor = System.Drawing.Color.DarkGray;
			this.labelControl5.Appearance.Options.UseBorderColor = true;
			this.labelControl5.Appearance.Options.UseTextOptions = true;
			this.labelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.labelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
			this.labelControl5.Location = new System.Drawing.Point(27, 158);
			this.labelControl5.Name = "labelControl5";
			this.labelControl5.Size = new System.Drawing.Size(150, 29);
			this.labelControl5.TabIndex = 4;
			this.labelControl5.Text = "Birim Fiyatı 1 :";
			// 
			// labelControl6
			// 
			this.labelControl6.Appearance.BorderColor = System.Drawing.Color.DarkGray;
			this.labelControl6.Appearance.Options.UseBorderColor = true;
			this.labelControl6.Appearance.Options.UseTextOptions = true;
			this.labelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.labelControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
			this.labelControl6.Location = new System.Drawing.Point(27, 193);
			this.labelControl6.Name = "labelControl6";
			this.labelControl6.Size = new System.Drawing.Size(150, 29);
			this.labelControl6.TabIndex = 4;
			this.labelControl6.Text = "Birim Fiyatı 2 :";
			// 
			// labelControl7
			// 
			this.labelControl7.Appearance.BorderColor = System.Drawing.Color.DarkGray;
			this.labelControl7.Appearance.Options.UseBorderColor = true;
			this.labelControl7.Appearance.Options.UseTextOptions = true;
			this.labelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.labelControl7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
			this.labelControl7.Location = new System.Drawing.Point(27, 228);
			this.labelControl7.Name = "labelControl7";
			this.labelControl7.Size = new System.Drawing.Size(150, 29);
			this.labelControl7.TabIndex = 4;
			this.labelControl7.Text = "Birim Fiyatı 3 :";
			// 
			// labelControl8
			// 
			this.labelControl8.Appearance.BorderColor = System.Drawing.Color.DarkGray;
			this.labelControl8.Appearance.Options.UseBorderColor = true;
			this.labelControl8.Appearance.Options.UseTextOptions = true;
			this.labelControl8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.labelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.labelControl8.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
			this.labelControl8.Location = new System.Drawing.Point(27, 358);
			this.labelControl8.Name = "labelControl8";
			this.labelControl8.Size = new System.Drawing.Size(150, 29);
			this.labelControl8.TabIndex = 4;
			this.labelControl8.Text = "Tarih :";
			// 
			// labelControl9
			// 
			this.labelControl9.Appearance.BorderColor = System.Drawing.Color.DarkGray;
			this.labelControl9.Appearance.Options.UseBorderColor = true;
			this.labelControl9.Appearance.Options.UseTextOptions = true;
			this.labelControl9.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.labelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.labelControl9.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
			this.labelControl9.Location = new System.Drawing.Point(27, 263);
			this.labelControl9.Name = "labelControl9";
			this.labelControl9.Size = new System.Drawing.Size(150, 89);
			this.labelControl9.TabIndex = 4;
			this.labelControl9.Text = "Açıklama :";
			// 
			// calcBirimFiyati1
			// 
			this.calcBirimFiyati1.Location = new System.Drawing.Point(183, 160);
			this.calcBirimFiyati1.Name = "calcBirimFiyati1";
			this.calcBirimFiyati1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.calcBirimFiyati1.Properties.Appearance.Options.UseFont = true;
			this.calcBirimFiyati1.Properties.Appearance.Options.UseTextOptions = true;
			this.calcBirimFiyati1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.calcBirimFiyati1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.calcBirimFiyati1.Properties.DisplayFormat.FormatString = "C2";
			this.calcBirimFiyati1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.calcBirimFiyati1.Properties.NullText = "0,00";
			this.calcBirimFiyati1.Size = new System.Drawing.Size(301, 24);
			this.calcBirimFiyati1.TabIndex = 7;
			// 
			// calcBirimFiyati2
			// 
			this.calcBirimFiyati2.Location = new System.Drawing.Point(183, 195);
			this.calcBirimFiyati2.Name = "calcBirimFiyati2";
			this.calcBirimFiyati2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.calcBirimFiyati2.Properties.Appearance.Options.UseFont = true;
			this.calcBirimFiyati2.Properties.Appearance.Options.UseTextOptions = true;
			this.calcBirimFiyati2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.calcBirimFiyati2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.calcBirimFiyati2.Properties.DisplayFormat.FormatString = "C2";
			this.calcBirimFiyati2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.calcBirimFiyati2.Properties.NullText = "0,00";
			this.calcBirimFiyati2.Size = new System.Drawing.Size(301, 24);
			this.calcBirimFiyati2.TabIndex = 7;
			// 
			// calcBirimFiyati3
			// 
			this.calcBirimFiyati3.Location = new System.Drawing.Point(183, 231);
			this.calcBirimFiyati3.Name = "calcBirimFiyati3";
			this.calcBirimFiyati3.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.calcBirimFiyati3.Properties.Appearance.Options.UseFont = true;
			this.calcBirimFiyati3.Properties.Appearance.Options.UseTextOptions = true;
			this.calcBirimFiyati3.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.calcBirimFiyati3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.calcBirimFiyati3.Properties.DisplayFormat.FormatString = "C2";
			this.calcBirimFiyati3.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.calcBirimFiyati3.Properties.NullText = "0,00";
			this.calcBirimFiyati3.Size = new System.Drawing.Size(301, 24);
			this.calcBirimFiyati3.TabIndex = 7;
			// 
			// txtAciklama
			// 
			this.txtAciklama.Location = new System.Drawing.Point(183, 263);
			this.txtAciklama.Name = "txtAciklama";
			this.txtAciklama.Size = new System.Drawing.Size(508, 89);
			this.txtAciklama.TabIndex = 8;
			// 
			// dateEdit1
			// 
			this.dateEdit1.EditValue = null;
			this.dateEdit1.Location = new System.Drawing.Point(183, 361);
			this.dateEdit1.Name = "dateEdit1";
			this.dateEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateEdit1.Properties.Appearance.Options.UseFont = true;
			this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dateEdit1.Size = new System.Drawing.Size(301, 24);
			this.dateEdit1.TabIndex = 9;
			// 
			// pictureEdit1
			// 
			this.pictureEdit1.Location = new System.Drawing.Point(501, 53);
			this.pictureEdit1.Name = "pictureEdit1";
			this.pictureEdit1.Properties.NullText = "Resim Seçilmedi";
			this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
			this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
			this.pictureEdit1.Size = new System.Drawing.Size(190, 202);
			this.pictureEdit1.TabIndex = 10;
			// 
			// txtUrunAdi
			// 
			this.txtUrunAdi.Location = new System.Drawing.Point(183, 127);
			this.txtUrunAdi.Name = "txtUrunAdi";
			this.txtUrunAdi.Size = new System.Drawing.Size(302, 22);
			this.txtUrunAdi.TabIndex = 6;
			// 
			// txtUrunKodu
			// 
			this.txtUrunKodu.Location = new System.Drawing.Point(183, 92);
			this.txtUrunKodu.Name = "txtUrunKodu";
			this.txtUrunKodu.Size = new System.Drawing.Size(302, 22);
			this.txtUrunKodu.TabIndex = 6;
			// 
			// lookUpMenu
			// 
			this.lookUpMenu.Location = new System.Drawing.Point(183, 54);
			this.lookUpMenu.Name = "lookUpMenu";
			this.lookUpMenu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.lookUpMenu.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MenuAdi", "Menü")});
			this.lookUpMenu.Properties.DisplayMember = "MenuAdi";
			this.lookUpMenu.Properties.NullText = "Menü Seçiniz";
			this.lookUpMenu.Properties.NullValuePrompt = "Menü Seçiniz";
			this.lookUpMenu.Properties.ValueMember = "Id";
			this.lookUpMenu.Size = new System.Drawing.Size(301, 22);
			this.lookUpMenu.TabIndex = 11;
			// 
			// frmUrunKaydet
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(732, 527);
			this.Controls.Add(this.pictureEdit1);
			this.Controls.Add(this.dateEdit1);
			this.Controls.Add(this.txtAciklama);
			this.Controls.Add(this.calcBirimFiyati3);
			this.Controls.Add(this.calcBirimFiyati2);
			this.Controls.Add(this.calcBirimFiyati1);
			this.Controls.Add(this.txtUrunAdi);
			this.Controls.Add(this.txtUrunKodu);
			this.Controls.Add(this.labelControl9);
			this.Controls.Add(this.labelControl8);
			this.Controls.Add(this.labelControl7);
			this.Controls.Add(this.labelControl6);
			this.Controls.Add(this.labelControl5);
			this.Controls.Add(this.labelControl4);
			this.Controls.Add(this.labelControl3);
			this.Controls.Add(this.labelControl2);
			this.Controls.Add(this.groupControl1);
			this.Controls.Add(this.lblBaslik);
			this.Controls.Add(this.lookUpMenu);
			this.Name = "frmUrunKaydet";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ürün Kaydetme";
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
			this.groupControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.calcBirimFiyati1.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.calcBirimFiyati2.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.calcBirimFiyati3.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtUrunAdi.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtUrunKodu.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lookUpMenu.Properties)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnUrunKaydet;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.CalcEdit calcBirimFiyati1;
        private DevExpress.XtraEditors.CalcEdit calcBirimFiyati2;
        private DevExpress.XtraEditors.CalcEdit calcBirimFiyati3;
        private DevExpress.XtraEditors.MemoEdit txtAciklama;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.TextEdit txtUrunAdi;
        private DevExpress.XtraEditors.TextEdit txtUrunKodu;
        private DevExpress.XtraEditors.LookUpEdit lookUpMenu;
    }
}