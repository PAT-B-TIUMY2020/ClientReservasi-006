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
    public partial class Register : Form
    {
        ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();
        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btSimpan_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string pass = textBoxPassword.Text;
            string kategori = comboBoxKategori.Text;
            string a = service.Register(username, pass, kategori);

            if (textBoxUsername.Text == "" || textBoxPassword.Text == "" || comboBoxKategori.Text == "")
            {
                MessageBox.Show("Semua data wajib diisi");
            }
            else
            {
                MessageBox.Show(a);
                Refresh();
                TampilData();
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string pass = textBoxPassword.Text;
            string kategori = comboBoxKategori.Text;
            int id = Convert.ToInt32(textBoxUsername.Text);
            string a = service.UpdateRegister(username, pass, kategori, id);
            if (textBoxUsername.Text == "" || textBoxPassword.Text == "" || comboBoxKategori.Text == "")
            {
                MessageBox.Show("Semua data wajib diisi");
            }
            else
            {
                MessageBox.Show(a);
                Clear();
                TampilData();
            }
        }

        private void btClean_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void TampilData()
        {
            var list = service.DataRegist();
            dtRegister.DataSource = list;
        }

        public void Clear()
        {
            textBoxPassword.Clear();
            textBoxUsername.Clear();
            comboBoxKategori.SelectedItem = null;

            btSimpan.Enabled = true;
            btUpdate.Enabled = false;
            btHapus.Enabled = false;

        }

        public Register()
        {
            InitializeComponent();
            TampilData();
            textBoxID.Visible = false;
            btUpdate.Enabled = false;
            btHapus.Enabled = false;
        }

        private void dtRegister_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxID.Text = Convert.ToString(dtRegister.Rows[e.RowIndex].Cells[0].Value);
            textBoxUsername.Text = Convert.ToString(dtRegister.Rows[e.RowIndex].Cells[1].Value);
            textBoxPassword.Text = Convert.ToString(dtRegister.Rows[e.RowIndex].Cells[2].Value);
            comboBoxKategori.Text = Convert.ToString(dtRegister.Rows[e.RowIndex].Cells[3].Value);

            btUpdate.Enabled = true;
            btHapus.Enabled = true;

            btSimpan.Enabled = false;
        }
    }
}
