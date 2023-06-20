using CafeOtomasyonu.Entities.DAL;
using CafeOtomasyonu.Entities.Models;
using CafeOtomasyonu.WinForms.Masalar;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeOtomasyonu.WinForms.Menuler
{
	public partial class frmMasaDurumlari : DevExpress.XtraEditors.XtraForm
	{
		private CafeContext context = new CafeContext();
		private CheckButton btnSender;
		private SatisKodu modelSatisKodu;
		string _satisKodu;
		int _masaId;
		Entities.Models.Masalar masalar;
		MasalarDal masalarDal = new MasalarDal();
		public frmMasaDurumlari()
		{
			InitializeComponent();
			modelSatisKodu = context.SatisKodu.First();
			MasalariGetir();
		}
		public void MasalariGetir()
		{
			flowLayoutPanel1.Controls.Clear();
			context = new CafeContext();
			var model = context.Masalar.ToList();
			for (int i = 0; i < model.Count; i++)
			{
				var btn = new CheckButton();
				btn.Text = model[i].MasaAdi;
				btn.Name = model[i].Id.ToString();
				btn.Tag = model[i].SatisKodu;
				btn.Height = 100;
				btn.Width = 80;
				flowLayoutPanel1.Controls.Add(btn);

				if (model[i].RezerveMi && !model[i].Durumu)
				{
					btn.Appearance.BackColor = Color.Cyan;
				}
				else if (model[i].Durumu)
				{
					btn.Appearance.BackColor = Color.Red;
				}

				else if (!model[i].Durumu)
				{
					btn.Appearance.BackColor = Color.Lime;
				}
				btn.Click += Btn_Click;
			}

		}
		public void DurumlariYenile()
		{
			btnSiparisEkle.Enabled = false;
			btnMasaAc.Enabled = false;
			btnRezervYap.Enabled = false;
		}
		private void Btn_Click(object sender, EventArgs e)
		{
			btnSender = sender as CheckButton;
			_masaId = Convert.ToInt32(btnSender.Name);

			DurumlariYenile();
			if (btnSender.Appearance.BackColor == Color.Cyan)
			{
				btnMasaAc.Enabled = true;
			}
			else if (btnSender.Appearance.BackColor == Color.Lime)
			{
				btnMasaAc.Enabled = true;
				btnRezervYap.Enabled = true;
			}
			else if (btnSender.Appearance.BackColor == Color.Red)
			{
				btnSiparisEkle.Enabled = true;
			}

		}

		private void btnSiparisEkle_Click(object sender, EventArgs e)
		{
			_satisKodu = btnSender.Tag.ToString();
			frmMasaSiparisleri frm = new frmMasaSiparisleri(masaId: _masaId, masaAdi: btnSender.Text, satisKodu: _satisKodu);
			frm.ShowDialog();
			btnSender = null;
			DurumlariYenile();
			MasalariGetir();
		}

		private void btnMasaAc_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show(btnSender.Text + " açılsın mı?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
			{
				masalar = masalarDal.GetByFilter(context, m => m.Id == _masaId);
				masalar.SatisKodu = modelSatisKodu.SatisTanimi + modelSatisKodu.Sayi;
				masalar.Durumu = true;
				masalar.RezerveMi = false;
				var sayiArtir = context.SatisKodu.First();
				sayiArtir.Sayi++;
				masalarDal.Save(context);
				btnSender = null;
				DurumlariYenile();
				MasalariGetir();
				modelSatisKodu = context.SatisKodu.First();
			}
		}

		private void btnRezervYap_Click(object sender, EventArgs e)
		{
			frmMasaRezerv frm = new frmMasaRezerv(_masaId);
			frm.ShowDialog();
			DurumlariYenile();
			if (frm.islemYapildi)
			{
				MasalariGetir();
			}
			btnSender = null;
		}

		private void btnKapat_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
