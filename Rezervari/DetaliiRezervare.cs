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
    public partial class DetaliiRezervare : Form
    {
        DBConnect dbCon = new DBConnect();
        public string Nrc;
        public string IdCamera;
        public string IdRezervare_;
        public string NrZile;
        public DetaliiRezervare()
        {
            InitializeComponent();
        }

        private void DetaliiRezervare_Load(object sender, EventArgs e)
        {
            btnActualizeaza.Visible = false;
            btnSterge.Visible = false;
            btnRenunta.Visible = false;
            btnAdauga.Visible = true;
            BindRezervare();
            IncarcaDenumireCamera();
        }
        private void BindRezervare()
        {
            SqlCommand cmd = new SqlCommand("select r.IdRezervare,c.IdCamera as IdCamera_,r.Nrc,c.NrCamera,r.DataCazarii,c.PretZi,r.NrZile from RezervariContinut as r INNER JOIN Camere as c on r.IdCamera = c.IdCamera where r.IdRezervare = @IdRezervare", dbCon.GetCon());
            dbCon.OpenCon();
            cmd.Parameters.AddWithValue("@IdRezervare", Convert.ToInt32(IdRezervare_));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dbCon.CloseCon();
        }
        private void IncarcaDenumireCamera()
        {
            SqlCommand cmd = new SqlCommand("getCamere", dbCon.GetCon());
            cmd.CommandType = CommandType.StoredProcedure;
            dbCon.OpenCon();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbCamera.DataSource = dt;
            cmbCamera.DisplayMember = "NrCamera";
            cmbCamera.ValueMember = "IdCamera";
            if (cmbCamera.SelectedValue != null)
            {
                IdCamera = cmbCamera.SelectedValue.ToString();
            }
            dbCon.CloseCon();
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            try
            {
                int nrZile = (int)(dtpDataSfarsit.Value - dtpDataInceput.Value).TotalDays;
                if (nrZile == 0)
                {
                    MessageBox.Show("Data de sfarsit a rezervarii trebuie sa fie mai mare decat data de inceput", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dtpDataSfarsit.Focus();
                    return;
                }
                else if (dtpDataInceput.Value > dtpDataSfarsit.Value)
                {
                    MessageBox.Show("Data de inceput nu poate fi mai mare decat data de sfarsit", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dtpDataInceput.Focus();
                    return;
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("adaugareDetaliiRezervare", dbCon.GetCon());
                    dbCon.OpenCon();
                    cmd.Parameters.AddWithValue("@IdRezervare", Convert.ToInt32(IdRezervare_));
                    cmd.Parameters.AddWithValue("@IdCamera", Convert.ToInt32(IdCamera));
                    cmd.Parameters.AddWithValue("@DataCazarii", dtpDataInceput.Value.Date);
                    cmd.Parameters.AddWithValue("@NrZile", nrZile);
                    cmd.CommandType = CommandType.StoredProcedure;
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Detaliile a fost adaugate cu succes", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtClear();
                        BindRezervare();
                    }

                    dbCon.CloseCon();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtClear()
        {
            IncarcaDenumireCamera();
            dtpDataInceput.Value = DateTime.Now;
            dtpDataSfarsit.Value = DateTime.Now.AddDays(1);
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            btnActualizeaza.Visible = true;
            btnSterge.Visible = true;
            btnAdauga.Visible = false;
            btnRenunta.Visible = false;
            IdCamera = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            if (int.TryParse(IdCamera, out int cameraId))
            {
                cmbCamera.SelectedValue = cameraId;
            }
            Nrc = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            cmbCamera.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            NrZile = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            if (dataGridView1.SelectedRows[0].Cells[4].Value is DateTime dataInceput)
            {
                dtpDataInceput.Value = dataInceput;
                if (int.TryParse(NrZile, out int nrZileInt))
                {
                    dtpDataSfarsit.Value = dtpDataInceput.Value.AddDays(nrZileInt);
                }
            }
        }

        private void btnActualizeaza_Click(object sender, EventArgs e)
        {
            try
            {
                int nrZile = (int)(dtpDataSfarsit.Value - dtpDataInceput.Value).TotalDays;
                if (nrZile == 0)
                {
                    MessageBox.Show("Data de sfarsit a rezervarii trebuie sa fie mai mare decat data de inceput", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dtpDataSfarsit.Focus();
                    return;
                }
                else if (dtpDataInceput.Value > dtpDataSfarsit.Value)
                {
                    MessageBox.Show("Data de inceput nu poate fi mai mare decat data de sfarsit", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dtpDataInceput.Focus();
                    return;
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("actaulizareDetaliiRezervare", dbCon.GetCon());
                    dbCon.OpenCon();
                    cmd.Parameters.AddWithValue("@Nrc", Convert.ToInt32(Nrc));
                    cmd.Parameters.AddWithValue("@IdCamera", Convert.ToInt32(IdCamera));
                    cmd.Parameters.AddWithValue("@DataCazarii", dtpDataInceput.Value.Date);
                    cmd.Parameters.AddWithValue("@NrZile", nrZile);
                    cmd.CommandType = CommandType.StoredProcedure;
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Detaliile a fost adaugate cu succes", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtClear();
                        BindRezervare();
                    }

                    dbCon.CloseCon();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    if (DialogResult.Yes == MessageBox.Show("Vrei sa stergi aceasta rezervare?", "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    {
                        SqlCommand cmd = new SqlCommand("stergeRezervareContinut", dbCon.GetCon());
                        cmd.Parameters.AddWithValue("@Nrc", Convert.ToInt32(Nrc));
                        cmd.CommandType = CommandType.StoredProcedure;
                        dbCon.OpenCon();
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Rezervare stearsa", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            IncarcaDenumireCamera();
                            BindRezervare();
                            btnSterge.Visible = false;
                            btnActualizeaza.Visible = false;
                            btnRenunta.Visible = false;
                            btnAdauga.Visible = true;
                            dataGridView1.ClearSelection();
                        }
                        else
                        {
                            MessageBox.Show("Stergerea nu s-a finalizat", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            IncarcaDenumireCamera();
                        }
                        dbCon.CloseCon();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRenunta_Click(object sender, EventArgs e)
        {
            btnActualizeaza.Visible = false;
            btnSterge.Visible = false;
            btnRenunta.Visible = false;
            btnAdauga.Visible = true;

            IncarcaDenumireCamera();

            dataGridView1.ClearSelection();
        }

        private void DetaliiRezervare_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
