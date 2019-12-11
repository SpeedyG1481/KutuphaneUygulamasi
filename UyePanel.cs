using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Npgsql;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje
{
    public partial class UyePanel : Form
    {
        private NpgsqlConnection conn;
        private string kullanici;
        private AnaPanel panel;
        public UyePanel(object v, NpgsqlConnection conn, AnaPanel panel)
        {
            this.conn = conn;
            this.panel = panel;
            kullanici = (string) v;
            InitializeComponent();
        }

        private void UyePanel_Load(object sender, EventArgs e)
        {
            hosGeldin.Text = "Hoşgeldiniz sayın, " + kullanici;
            this.kitapListele();

        }

        private void cikis_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            panel.Show();
        }

        private void kitapListele()
        {
            //Kitap
            var kitap = new NpgsqlCommand("SELECT * FROM kitap ORDER BY \"kitapID\"", conn);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(kitap);
            DataTable dt = new DataTable();
            da.Fill(dt);
            kitaplar.DataSource = dt;
        }

        private void kiralaTikla_Click(object sender, EventArgs e)
        {
            



        }

        private void programiKapat_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
            conn.Close();
        }
    }
}
