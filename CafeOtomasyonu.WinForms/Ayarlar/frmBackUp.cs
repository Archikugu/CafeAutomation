using CafeOtomasyonu.Entities.Models;
using DevExpress.XtraEditors;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeOtomasyonu.WinForms.Ayarlar
{
	public partial class frmBackUp : DevExpress.XtraEditors.XtraForm
	{
		CafeContext context = new CafeContext();
		public frmBackUp()
		{
			InitializeComponent();
			Server sunucu = new Server();
			var model = context.Database.SqlQuery<Database>("Select * From sys.databases").ToList();
			foreach (var item in model)
			{
				comboBoxVeritabani.Properties.Items.Add(item.Name);
			}
			comboBoxVeritabani.EditValue = "Cafe";
		}

		private void btnSec_Click(object sender, EventArgs e)
		{
			xtraSaveFileDialog1.Filter = "Backup(Yedekleme) Dosyaları (*.bak)|*.bak";
			xtraSaveFileDialog1.Title = "Yedeklenecek Dosyalar";
			if (xtraSaveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				txtYol.Text = xtraSaveFileDialog1.FileName;
			}
		}

		private void btnYedekAl_Click(object sender, EventArgs e)
		{
			progressBarControl1.EditValue = 0;
			try
			{
				if (System.IO.File.Exists(txtYol.Text))
				{
					File.Delete(txtYol.Text);
				}
				Server dbServer = new Server(new ServerConnection(txtSunucu.Text));
				Backup dbBackup = new Backup();
				dbBackup.Action = BackupActionType.Database;
				dbBackup.Database = comboBoxVeritabani.Text;
				dbBackup.Devices.AddDevice(txtYol.Text, DeviceType.File);
				dbBackup.Initialize = false;
				dbBackup.PercentComplete += DbBackup_PercentComplete;
				dbBackup.Complete += DbBackup_Complete;
				dbBackup.SqlBackup(dbServer);
			}
			catch (Exception exception)
			{
				MessageBox.Show("Hata\n" + exception.Message);
			}
		}

		private void DbBackup_Complete(object sender, ServerMessageEventArgs e)
		{
			MessageBox.Show("Yedekleme işlemi başarıyla gerçekleşti");
		}

		private void DbBackup_PercentComplete(object sender, PercentCompleteEventArgs e)
		{
			progressBarControl1.EditValue = e.Percent;
			progressBarControl1.Update();
			lblYuzde.Text = $"{e.Percent} %";
			lblDurum.Text = "İşlem başarıyla gerçekleşti";
		}
	}
}