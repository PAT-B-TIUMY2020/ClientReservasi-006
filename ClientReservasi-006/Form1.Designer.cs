namespace ClientReservasi_006
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.textBoxNoTlf = new System.Windows.Forms.TextBox();
            this.textBoxJumlah = new System.Windows.Forms.TextBox();
            this.textBoxIDLokasi = new System.Windows.Forms.TextBox();
            this.btSimpan = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btHapus = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.dtPemesanan = new System.Windows.Forms.DataGridView();
            this.pemesananBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDPemesananDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaCustomerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noTeleponDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlahPemesananDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lokasiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtPemesanan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemesananBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Pemesanan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "No Telepon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Jumlah Pesanan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "ID Lokasi";
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(267, 74);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(273, 22);
            this.textID.TabIndex = 5;
            this.textID.TextChanged += new System.EventHandler(this.textID_TextChanged);
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(267, 128);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(273, 22);
            this.textBoxNama.TabIndex = 6;
            this.textBoxNama.TextChanged += new System.EventHandler(this.textBoxNama_TextChanged);
            // 
            // textBoxNoTlf
            // 
            this.textBoxNoTlf.Location = new System.Drawing.Point(267, 184);
            this.textBoxNoTlf.Name = "textBoxNoTlf";
            this.textBoxNoTlf.Size = new System.Drawing.Size(273, 22);
            this.textBoxNoTlf.TabIndex = 7;
            this.textBoxNoTlf.TextChanged += new System.EventHandler(this.textBoxNoTlf_TextChanged);
            // 
            // textBoxJumlah
            // 
            this.textBoxJumlah.Location = new System.Drawing.Point(267, 237);
            this.textBoxJumlah.Name = "textBoxJumlah";
            this.textBoxJumlah.Size = new System.Drawing.Size(273, 22);
            this.textBoxJumlah.TabIndex = 8;
            this.textBoxJumlah.TextChanged += new System.EventHandler(this.textBoxJumlah_TextChanged);
            // 
            // textBoxIDLokasi
            // 
            this.textBoxIDLokasi.Location = new System.Drawing.Point(267, 299);
            this.textBoxIDLokasi.Name = "textBoxIDLokasi";
            this.textBoxIDLokasi.Size = new System.Drawing.Size(273, 22);
            this.textBoxIDLokasi.TabIndex = 9;
            this.textBoxIDLokasi.TextChanged += new System.EventHandler(this.textBoxIDLokasi_TextChanged);
            // 
            // btSimpan
            // 
            this.btSimpan.Location = new System.Drawing.Point(666, 107);
            this.btSimpan.Name = "btSimpan";
            this.btSimpan.Size = new System.Drawing.Size(122, 26);
            this.btSimpan.TabIndex = 10;
            this.btSimpan.Text = "Simpan";
            this.btSimpan.UseVisualStyleBackColor = true;
            this.btSimpan.Click += new System.EventHandler(this.btSimpan_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(666, 154);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(122, 26);
            this.btUpdate.TabIndex = 11;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btHapus
            // 
            this.btHapus.Location = new System.Drawing.Point(666, 199);
            this.btHapus.Name = "btHapus";
            this.btHapus.Size = new System.Drawing.Size(122, 26);
            this.btHapus.TabIndex = 12;
            this.btHapus.Text = "Delete";
            this.btHapus.UseVisualStyleBackColor = true;
            this.btHapus.Click += new System.EventHandler(this.btHapus_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(666, 240);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(122, 26);
            this.btClear.TabIndex = 13;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // dtPemesanan
            // 
            this.dtPemesanan.AutoGenerateColumns = false;
            this.dtPemesanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtPemesanan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPemesananDataGridViewTextBoxColumn,
            this.namaCustomerDataGridViewTextBoxColumn,
            this.noTeleponDataGridViewTextBoxColumn,
            this.jumlahPemesananDataGridViewTextBoxColumn,
            this.lokasiDataGridViewTextBoxColumn});
            this.dtPemesanan.DataSource = this.pemesananBindingSource;
            this.dtPemesanan.Location = new System.Drawing.Point(86, 374);
            this.dtPemesanan.Name = "dtPemesanan";
            this.dtPemesanan.RowTemplate.Height = 24;
            this.dtPemesanan.Size = new System.Drawing.Size(551, 241);
            this.dtPemesanan.TabIndex = 14;
            this.dtPemesanan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtPemesanan_CellContentClick);
            // 
            // pemesananBindingSource
            // 
            this.pemesananBindingSource.DataSource = typeof(ServiceReservasi.Pemesanan);
            // 
            // iDPemesananDataGridViewTextBoxColumn
            // 
            this.iDPemesananDataGridViewTextBoxColumn.DataPropertyName = "IDPemesanan";
            this.iDPemesananDataGridViewTextBoxColumn.HeaderText = "IDPemesanan";
            this.iDPemesananDataGridViewTextBoxColumn.Name = "iDPemesananDataGridViewTextBoxColumn";
            // 
            // namaCustomerDataGridViewTextBoxColumn
            // 
            this.namaCustomerDataGridViewTextBoxColumn.DataPropertyName = "NamaCustomer";
            this.namaCustomerDataGridViewTextBoxColumn.HeaderText = "NamaCustomer";
            this.namaCustomerDataGridViewTextBoxColumn.Name = "namaCustomerDataGridViewTextBoxColumn";
            // 
            // noTeleponDataGridViewTextBoxColumn
            // 
            this.noTeleponDataGridViewTextBoxColumn.DataPropertyName = "NoTelepon";
            this.noTeleponDataGridViewTextBoxColumn.HeaderText = "NoTelepon";
            this.noTeleponDataGridViewTextBoxColumn.Name = "noTeleponDataGridViewTextBoxColumn";
            // 
            // jumlahPemesananDataGridViewTextBoxColumn
            // 
            this.jumlahPemesananDataGridViewTextBoxColumn.DataPropertyName = "JumlahPemesanan";
            this.jumlahPemesananDataGridViewTextBoxColumn.HeaderText = "JumlahPemesanan";
            this.jumlahPemesananDataGridViewTextBoxColumn.Name = "jumlahPemesananDataGridViewTextBoxColumn";
            // 
            // lokasiDataGridViewTextBoxColumn
            // 
            this.lokasiDataGridViewTextBoxColumn.DataPropertyName = "Lokasi";
            this.lokasiDataGridViewTextBoxColumn.HeaderText = "Lokasi";
            this.lokasiDataGridViewTextBoxColumn.Name = "lokasiDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 731);
            this.Controls.Add(this.dtPemesanan);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btHapus);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btSimpan);
            this.Controls.Add(this.textBoxIDLokasi);
            this.Controls.Add(this.textBoxJumlah);
            this.Controls.Add(this.textBoxNoTlf);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtPemesanan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemesananBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.TextBox textBoxNoTlf;
        private System.Windows.Forms.TextBox textBoxJumlah;
        private System.Windows.Forms.TextBox textBoxIDLokasi;
        private System.Windows.Forms.Button btSimpan;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btHapus;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.DataGridView dtPemesanan;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPemesananDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaCustomerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noTeleponDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlahPemesananDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lokasiDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pemesananBindingSource;
    }
}

