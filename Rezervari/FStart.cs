using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rezervari
{
    public partial class FStart : Form
    {
        DBConnect dbCon = new DBConnect();
        private SqlCommand cmd = new SqlCommand();
        private SqlDataReader rdr;
        public FStart()
        {
            InitializeComponent();
        }

        private void FStart_Load(object sender, EventArgs e)
        {
            A1(true);
        }
        private void A1(Boolean v)
        {
            menuStrip1.Visible = !v;
            lblTitlu.Visible = !v;
            lblAutor.Visible = !v;
            lblParola.Visible = v;
            txtParola.Visible = v;
            lblUtilizator.Visible = v;
            txtUtilizator.Visible = v;
            if (v) btnStart.Text = "Log In";
            else btnStart.Text = "Log Out";
        }

        private bool Logare_OK()
        {
            if (txtUtilizator.Text == "")
            {
                MessageBox.Show("Completati utilizator !");
                txtUtilizator.Focus();
                return false;
            }
            if (txtParola.Text == "")
            {
                MessageBox.Show("Completati parola !");
                txtParola.Focus();
                return false;
            }

            try
            {
                SqlCommand cmd = new SqlCommand("select top 1 Nume,Parola from Utilizatori where Nume=@Nume and Parola=@Parola", dbCon.GetCon());
                cmd.Parameters.AddWithValue("@Nume", txtUtilizator.Text);
                cmd.Parameters.AddWithValue("@Parola", txtParola.Text);
                dbCon.OpenCon();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Autentificare reusita", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Autentificare esuata, verifica utilizatorul si parola", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUtilizator.Focus();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se pare ca a aparut o problema");
                return false;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "Log In")
            {
                if (Logare_OK()) A1(false);
            }
            else A1(true);
        }

        private void clientiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clienti clienti = new Clienti();
            clienti.Show();
        }

        private void camereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Camere camere = new Camere();
            camere.Show();
        }

        private void rezervariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rezervari rezervari = new Rezervari();
            rezervari.Show();
        }
    }
}
