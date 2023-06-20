namespace CafeOtomasyonu.WinForms.Ayarlar
{
	partial class frmBackUp
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
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.txtSunucu = new DevExpress.XtraEditors.TextEdit();
			this.comboBoxVeritabani = new DevExpress.XtraEditors.ComboBoxEdit();
			this.txtYol = new DevExpress.XtraEditors.TextEdit();
			this.btnSec = new DevExpress.XtraEditors.SimpleButton();
			this.btnYedekAl = new DevExpress.XtraEditors.SimpleButton();
			this.lblYuzde = new DevExpress.XtraEditors.LabelControl();
			this.lblDurumu = new DevExpress.XtraEditors.LabelControl();
			this.lblDurum = new DevExpress.XtraEditors.LabelControl();
			this.xtraSaveFileDialog1 = new DevExpress.XtraEditors.XtraSaveFileDialog(this.components);
			this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
			((System.ComponentModel.ISupportInitialize)(this.txtSunucu.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.comboBoxVeritabani.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtYol.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// labelControl3
			// 
			this.labelControl3.Appearance.BorderColor = System.Drawing.Color.DarkGray;
			this.labelControl3.Appearance.Options.UseBorderColor = true;
			this.labelControl3.Appearance.Options.UseTextOptions = true;
			this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.labelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
			this.labelControl3.Location = new System.Drawing.Point(12, 42);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(102, 29);
			this.labelControl3.TabIndex = 12;
			this.labelControl3.Text = "Sunucu :";
			// 
			// labelControl1
			// 
			this.labelControl1.Appearance.BorderColor = System.Drawing.Color.DarkGray;
			this.labelControl1.Appearance.Options.UseBorderColor = true;
			this.labelControl1.Appearance.Options.UseTextOptions = true;
			this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
			this.labelControl1.Location = new System.Drawing.Point(12, 77);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(102, 29);
			this.labelControl1.TabIndex = 12;
			this.labelControl1.Text = "Veritabanı :";
			// 
			// labelControl2
			// 
			this.labelControl2.Appearance.BorderColor = System.Drawing.Color.DarkGray;
			this.labelControl2.Appearance.Options.UseBorderColor = true;
			this.labelControl2.Appearance.Options.UseTextOptions = true;
			this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
			this.labelControl2.Location = new System.Drawing.Point(12, 112);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(102, 29);
			this.labelControl2.TabIndex = 12;
			this.labelControl2.Text = "Yol :";
			// 
			// txtSunucu
			// 
			this.txtSunucu.Location = new System.Drawing.Point(120, 43);
			this.txtSunucu.Name = "txtSunucu";
			this.txtSunucu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
			this.txtSunucu.Properties.Appearance.Options.UseFont = true;
			this.txtSunucu.Size = new System.Drawing.Size(397, 28);
			this.txtSunucu.TabIndex = 13;
			// 
			// comboBoxVeritabani
			// 
			this.comboBoxVeritabani.Location = new System.Drawing.Point(120, 77);
			this.comboBoxVeritabani.Name = "comboBoxVeritabani";
			this.comboBoxVeritabani.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
			this.comboBoxVeritabani.Properties.Appearance.Options.UseFont = true;
			this.comboBoxVeritabani.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.comboBoxVeritabani.Size = new System.Drawing.Size(397, 28);
			this.comboBoxVeritabani.TabIndex = 14;
			// 
			// txtYol
			// 
			this.txtYol.Location = new System.Drawing.Point(120, 111);
			this.txtYol.Name = "txtYol";
			this.txtYol.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
			this.txtYol.Properties.Appearance.Options.UseFont = true;
			this.txtYol.Size = new System.Drawing.Size(316, 28);
			this.txtYol.TabIndex = 13;
			// 
			// btnSec
			// 
			this.btnSec.Location = new System.Drawing.Point(442, 110);
			this.btnSec.Name = "btnSec";
			this.btnSec.Size = new System.Drawing.Size(75, 29);
			this.btnSec.TabIndex = 15;
			this.btnSec.Text = "...";
			this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
			// 
			// btnYedekAl
			// 
			this.btnYedekAl.Location = new System.Drawing.Point(441, 155);
			this.btnYedekAl.Name = "btnYedekAl";
			this.btnYedekAl.Size = new System.Drawing.Size(76, 30);
			this.btnYedekAl.TabIndex = 15;
			this.btnYedekAl.Text = "Yedek Al";
			this.btnYedekAl.Click += new System.EventHandler(this.btnYedekAl_Click);
			// 
			// lblYuzde
			// 
			this.lblYuzde.Location = new System.Drawing.Point(412, 191);
			this.lblYuzde.Name = "lblYuzde";
			this.lblYuzde.Size = new System.Drawing.Size(23, 16);
			this.lblYuzde.TabIndex = 17;
			this.lblYuzde.Text = "0 %";
			// 
			// lblDurumu
			// 
			this.lblDurumu.Location = new System.Drawing.Point(120, 218);
			this.lblDurumu.Name = "lblDurumu";
			this.lblDurumu.Size = new System.Drawing.Size(54, 16);
			this.lblDurumu.TabIndex = 17;
			this.lblDurumu.Text = "Durumu :";
			// 
			// lblDurum
			// 
			this.lblDurum.Location = new System.Drawing.Point(180, 218);
			this.lblDurum.Name = "lblDurum";
			this.lblDurum.Size = new System.Drawing.Size(45, 16);
			this.lblDurum.TabIndex = 17;
			this.lblDurum.Text = "Durumu";
			// 
			// xtraSaveFileDialog1
			// 
			this.xtraSaveFileDialog1.FileName = "xtraSaveFileDialog1";
			// 
			// progressBarControl1
			// 
			this.progressBarControl1.Location = new System.Drawing.Point(120, 155);
			this.progressBarControl1.Name = "progressBarControl1";
			this.progressBarControl1.Size = new System.Drawing.Size(315, 30);
			this.progressBarControl1.TabIndex = 18;
			// 
			// frmBackUp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(529, 272);
			this.Controls.Add(this.progressBarControl1);
			this.Controls.Add(this.lblDurum);
			this.Controls.Add(this.lblDurumu);
			this.Controls.Add(this.lblYuzde);
			this.Controls.Add(this.btnYedekAl);
			this.Controls.Add(this.btnSec);
			this.Controls.Add(this.comboBoxVeritabani);
			this.Controls.Add(this.txtYol);
			this.Controls.Add(this.txtSunucu);
			this.Controls.Add(this.labelControl2);
			this.Controls.Add(this.labelControl1);
			this.Controls.Add(this.labelControl3);
			this.Name = "frmBackUp";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Back Up";
			((System.ComponentModel.ISupportInitialize)(this.txtSunucu.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.comboBoxVeritabani.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtYol.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraEditors.LabelControl labelControl3;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.TextEdit txtSunucu;
		private DevExpress.XtraEditors.ComboBoxEdit comboBoxVeritabani;
		private DevExpress.XtraEditors.TextEdit txtYol;
		private DevExpress.XtraEditors.SimpleButton btnSec;
		private DevExpress.XtraEditors.SimpleButton btnYedekAl;
		private DevExpress.XtraEditors.LabelControl lblYuzde;
		private DevExpress.XtraEditors.LabelControl lblDurumu;
		private DevExpress.XtraEditors.LabelControl lblDurum;
		private DevExpress.XtraEditors.XtraSaveFileDialog xtraSaveFileDialog1;
		private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
	}
}