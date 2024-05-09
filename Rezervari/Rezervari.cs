using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rezervari
{
    public partial class Rezervari : Form
    {
        DBConnect dbCon = new DBConnect();
        public string IdRezervare;
        public string IdClient;
        public string NumeClient_;
        public Rezervari()
        {
            InitializeComponent();
        }

        private void Rezervari_Load(object sender, EventArgs e)
        {
            BindRezervare();
            IncarcaDenumireClient();
        }
        private void BindRezervare()
        {
            SqlCommand cmd = new SqlCommand("select r.IdRezervare,r.DataRezervarii,c.NumeClient,r.IdClient from Rezervari as r INNER JOIN Clienti as c on r.IdClient = c.IdClient order by r.DataRezervarii desc", dbCon.GetCon());
            dbCon.OpenCon();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dbCon.CloseCon();
        }
        private void BindRezervareContinut()
        {
            SqlCommand cmd = new SqlCommand("select r.IdRezervare as IdRezervare_,c.IdCamera as IdCamera_,r.Nrc,c.NrCamera,r.DataCazarii,c.PretZi,r.NrZile from RezervariContinut as r INNER JOIN Camere as c on r.IdCamera = c.IdCamera where r.IdRezervare = @IdRezervare order by r.Nrc asc", dbCon.GetCon());
            dbCon.OpenCon();
            cmd.Parameters.AddWithValue("@IdRezervare", Convert.ToInt32(IdRezervare));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            dbCon.CloseCon();
        }
        private void IncarcaDenumireClient()
        {
            SqlCommand cmd = new SqlCommand("getClient", dbCon.GetCon());
            cmd.CommandType = CommandType.StoredProcedure;
            dbCon.OpenCon();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            DataRow newRow = dt.NewRow();
            newRow["IdClient"] = 0;
            newRow["NumeClient"] = "---";
            dt.Rows.InsertAt(newRow, 0);

            cmbCauta.DataSource = dt;
            cmbCauta.DisplayMember = "NumeClient";
            cmbCauta.ValueMember = "IdClient";

            dbCon.CloseCon();
        }

        private void btnAdaugaRezervare_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(cmbCauta.SelectedValue) == 0)
                {
                    MessageBox.Show("Selectati un turist", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("adaugareRezervare", dbCon.GetCon());
                    dbCon.OpenCon();
                    cmd.Parameters.AddWithValue("@IdClient", Convert.ToInt32(IdClient));
                    cmd.Parameters.AddWithValue("@DataRezervarii", DateTime.Now);
                    cmd.CommandType = CommandType.StoredProcedure;
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Rezervarea a fost adaugata cu succes", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BindRezervare();
                    }
                }
                dbCon.CloseCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se pare ca a aparut o eroare", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbCauta_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdClient = cmbCauta.SelectedValue.ToString();
            NumeClient_ = cmbCauta.Text;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            IdRezervare = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            IdClient = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            if (int.TryParse(IdClient, out int clientId))
            {
                cmbCauta.SelectedValue = clientId;
            }
            cmbCauta.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            BindRezervareContinut();
        }

        private void btnStergeRezervare_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(IdRezervare) == 0)
                {
                    MessageBox.Show("Selectati o rezervare", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {
                    SqlCommand cmd = new SqlCommand("select top 1 * from RezervariContinut where IdRezervare=@IdRezervare", dbCon.GetCon());
                    cmd.Parameters.AddWithValue("@IdRezervare", Convert.ToInt32(IdRezervare));
                    dbCon.OpenCon();
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        MessageBox.Show("Nu puteti sterge aceasta rezervare deoarece are continutul completat.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        cmd = new SqlCommand("stergeRezervare", dbCon.GetCon());
                        cmd.Parameters.AddWithValue("@IdRezervare", Convert.ToInt32(IdRezervare));
                        cmd.CommandType = CommandType.StoredProcedure;
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Rezervare stearsa", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            IncarcaDenumireClient();
                            BindRezervare();
                            dataGridView1.ClearSelection();
                        }
                        else
                        {
                            MessageBox.Show("Stergerea nu s-a finalizat", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            IncarcaDenumireClient();
                        }
                    }
                    dbCon.CloseCon();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Se pare ca a aparut o eroare", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(cmbCauta.SelectedValue) == 0)
                {
                    MessageBox.Show("Selectati un turist", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else 
                { 
                    SqlCommand cmd = new SqlCommand("getRezervari_DupaNume", dbCon.GetCon());
                    cmd.Parameters.AddWithValue("@IdClient", cmbCauta.SelectedValue);
                    cmd.CommandType = CommandType.StoredProcedure;
                    dbCon.OpenCon();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    dbCon.CloseCon();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Se pare ca a aparut o eroare", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BindRezervare();
        }


        private void btnDetaliiRezervare_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(IdRezervare) == 0)
            {
                MessageBox.Show("Selectati o rezervare", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                DetaliiRezervare detaliiRezervare = new DetaliiRezervare();
                detaliiRezervare.IdRezervare_ = IdRezervare;
                detaliiRezervare.ShowDialog();
                if (detaliiRezervare.DialogResult == DialogResult.OK)
                {
                    BindRezervareContinut();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cmbCauta.SelectedValue) == 0)
            {
                MessageBox.Show("Selectati un turist", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else 
            {
                Clienti clienti = new Clienti();
                clienti.DeschisDinRezervare = true;
                clienti.IDClient = IdClient;
                clienti.ShowDialog();
                if (clienti.DialogResult == DialogResult.OK)
                {
                    BindRezervare();
                    IncarcaDenumireClient();
                    cmbCauta.SelectedValue = clienti.IDClient;
                }
            }
               
        }
    }
}
