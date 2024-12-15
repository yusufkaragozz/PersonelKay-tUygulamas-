namespace PersonelKayıtUygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Kaydetbutton_Click(object sender, EventArgs e)
        {
            var personel = new Personel
            {
                Ad = txtAd.Text,
                SoyAd = txtSoyAd.Text,
                Cinsiyet = rbtnErkekk.Checked,
                TcNo = txtTcNo.Text,
                TelNo = txtTelNo.Text,
                IseGirisTarihi = dtpIseGirisTarihi.Value,
                Meslegi = txtMeslegi.Text,
                MedeniDurum = rbtnEvli.Checked
            };

            try
            {
                var kaydet = new Kaydet();
                kaydet.PersonelEkle(personel);
                MessageBox.Show("Personel başarıyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Guncellebutton_Click(object sender, EventArgs e)
        {
            var personel = new Personel
            {
                ID = Convert.ToInt32(txtID.Text), 
                Ad = txtAd.Text,
                SoyAd = txtSoyAd.Text,
                Cinsiyet = rbtnErkekk.Checked,
                TcNo = txtTcNo.Text,
                TelNo = txtTelNo.Text,
                IseGirisTarihi = dtpIseGirisTarihi.Value,
                Meslegi = txtMeslegi.Text,
                MedeniDurum = rbtnEvli.Checked
            };

            try
            {
                var guncelle = new Guncelle();
                guncelle.PersonelGuncelle(personel);
                MessageBox.Show("Personel başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Çıkışbutton_Click(object sender, EventArgs e)
        {
            var personelID = Convert.ToInt32(txtID.Text); 

            try
            {
                var sil = new Sil();
                sil.PersonelSil(personelID);
                MessageBox.Show("Personel başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }



