﻿using System;
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
            btnRenunta.Visible = false;
            btnConfirmare.Visible = false;
            pnlControale.Visible = false;
            lblOP.Visible = false;
            BindRezervare();
            IncarcaDenumireCamera();
        }
        private void BindRezervare()
        {
            SqlCommand cmd = new SqlCommand("select r.IdRezervare,c.IdCamera as IdCamera_,r.Nrc,c.NrCamera,r.DataCazarii,c.PretZi,r.NrZile from RezervariContinut as r INNER JOIN Camere as c on r.IdCamera = c.IdCamera where r.IdRezervare = @IdRezervare order by r.Nrc asc", dbCon.GetCon());
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
            lblOP.Text = "ADAUGARE";
            lblOP.Visible = true;
            btnRenunta.Visible = true;
            btnConfirmare.Visible = true;
            pnlControale.Visible = true;
            txtNrc.Text = "";
        }
        private void txtClear()
        {
            IncarcaDenumireCamera();
            dtpDataInceput.Value = DateTime.Now;
            dtpDataSfarsit.Value = DateTime.Now.AddDays(1);
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (lblOP.Text == "MODIFICARE")
            {
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
                txtNrc.Text = Nrc.ToString();
            }
        }

        private void btnActualizeaza_Click(object sender, EventArgs e)
        {
            lblOP.Text = "MODIFICARE";
            lblOP.Visible = true;
            btnRenunta.Visible = true;
            btnConfirmare.Visible = true;
            pnlControale.Visible = true;
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            if (Nrc == "")
            {
                MessageBox.Show("Selecteaza o rezervare", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    if (DialogResult.Yes == MessageBox.Show("Vrei sa stergi aceasta rezervare?", "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    {
                        SqlCommand cmd = new SqlCommand("stergeRezervareContinut", dbCon.GetCon());
                        cmd.Parameters.AddWithValue("@Nrc", Convert.ToInt32(Nrc));
                        cmd.Parameters.AddWithValue("@IdRezervare", Convert.ToInt32(IdRezervare_));
                        cmd.CommandType = CommandType.StoredProcedure;
                        dbCon.OpenCon();
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Rezervare stearsa", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            IncarcaDenumireCamera();
                            BindRezervare();
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
                MessageBox.Show("Se pare ca a aparut o eroare", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRenunta_Click(object sender, EventArgs e)
        {
            btnRenunta.Visible = false;
            btnConfirmare.Visible = false;
            pnlControale.Visible = false;
            lblOP.Visible = false;
            dtpDataInceput.Value = DateTime.Now;
            dtpDataSfarsit.Value = DateTime.Now;
            txtNrc.Text = "";
            IncarcaDenumireCamera();

            dataGridView1.ClearSelection();
        }

        private void DetaliiRezervare_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnModificaCamera_Click(object sender, EventArgs e)
        {
            Camere camere = new Camere();
            camere.DeschisDinRezervare = true;
            camere.IDCamera = IdCamera;
            camere.ShowDialog();
            if (camere.DialogResult == DialogResult.OK)
            {
                BindRezervare();
                IncarcaDenumireCamera();
            }
        }

        private void cmbCamera_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdCamera = cmbCamera.SelectedValue.ToString();
        }

        private void btnConfirmare_Click(object sender, EventArgs e)
        {
            if (lblOP.Text == "ADAUGARE")
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
                        SqlCommand cmd = new SqlCommand("select top 1 Nrc from RezervariContinut where IdRezervare=@IdRezervare order by Nrc desc", dbCon.GetCon());
                        cmd.Parameters.AddWithValue("@IdRezervare", Convert.ToInt32(IdRezervare_));
                        dbCon.OpenCon();
                        var result = cmd.ExecuteScalar();
                        int nrc = 1;
                        if (result != null)
                        {
                            nrc = Convert.ToInt32(result) + 1;
                        }
                        cmd = new SqlCommand("adaugareDetaliiRezervare", dbCon.GetCon());
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
                    MessageBox.Show("Se pare ca a aparut o eroare", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (lblOP.Text == "MODIFICARE")
            {
                if (Nrc == "")
                {
                    MessageBox.Show("Selecteaza o rezervare", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
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
                    MessageBox.Show("Se pare ca a aparut o eroare", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
