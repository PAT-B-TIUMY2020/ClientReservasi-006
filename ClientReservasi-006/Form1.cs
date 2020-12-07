using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientReservasi_006
{
    public partial class Form1 : Form
    {
        ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();
        public Form1()
        {
            InitializeComponent();
        }

        private void dtPemesanan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textID.Text = Convert.ToString(dtPemesanan.Rows[e.RowIndex].Cells[0].Value);
            textBoxNama.Text = Convert.ToString(dtPemesanan.Rows[e.RowIndex].Cells[3].Value);
            textBoxNoTlf.Text = Convert.ToString(dtPemesanan.Rows[e.RowIndex].Cells[4].Value);
            textBoxJumlah.Text = Convert.ToString(dtPemesanan.Rows[e.RowIndex].Cells[1].Value);
            textBoxIDLokasi.Text = Convert.ToString(dtPemesanan.Rows[e.RowIndex].Cells[2].Value);

            textBoxIDLokasi.Enabled = false;
            textBoxJumlah.Enabled = false;

            btUpdate.Enabled = true;
            btHapus.Enabled = true;

            btSimpan.Enabled = false;
            textID.Enabled = false;
        }

        private void btSimpan_Click(object sender, EventArgs e)
        {
            string IDPemesanan = textID.Text;
            string NamaCustomer = textBoxNama.Text;
            string NoTelpon = textBoxNoTlf.Text;
            int JumlahPemesanan = int.Parse(textBoxJumlah.Text);
            string idLokasi = textBoxIDLokasi.Text;

            var a = service.pemesanan(IDPemesanan, NamaCustomer, NoTelpon, JumlahPemesanan, idLokasi);
            MessageBox.Show(a);
            TampilData();
            Clear();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            string IDPemesanan = textID.Text;
            string NamaCustomer = textBoxNama.Text;
            string NoTelpon = textBoxNoTlf.Text;

            var a = service.editPemesanan(IDPemesanan, NamaCustomer, NoTelpon);
            MessageBox.Show(a);
            TampilData();
            Clear();
        }

        private void btHapus_Click(object sender, EventArgs e)
        {
            string IDPemesanan = textID.Text;

            var a = service.deletePemesann(IDPemesanan);
            MessageBox.Show(a);
            TampilData();
            Clear();
        }

        private void textID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNoTlf_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxJumlah_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxIDLokasi_TextChanged(object sender, EventArgs e)
        {

        }

        private void btClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        public void TampilData()
        {
            var List = service.Pemesanan1();
            dtPemesanan.DataSource = List;
        }
        public void Clear()
        {
            textID.Clear();
            textBoxNama.Clear();
            textBoxNoTlf.Clear();
            textBoxJumlah.Clear();
            textBoxIDLokasi.Clear();

            textBoxJumlah.Enabled = true;
            textBoxIDLokasi.Enabled = true;

            btSimpan.Enabled = true;
            btUpdate.Enabled = true;
            btHapus.Enabled = true;

            textID.Enabled = true;
        }
    }
}
