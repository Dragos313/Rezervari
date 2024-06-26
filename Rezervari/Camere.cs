﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rezervari
{
    public partial class Camere : Form
    {
        DBConnect dbCon = new DBConnect();
        byte[] ImageData = null;
        public string IDCamera;
        public bool DeschisDinRezervare;
        public Camere()
        {
            InitializeComponent();
        }

        private void Camere_Load(object sender, EventArgs e)
        {
            btnModificare.Visible = false;
            btnSterge.Visible = false;
            btnRenunta.Visible = false;
            btnAdauga.Visible = true;
            BindCamera();
        }
        private void BindCamera()
        {
            if (DeschisDinRezervare)
            {
                SqlCommand cmd = new SqlCommand("select * from Camere where IdCamera = @IdCamera", dbCon.GetCon());
                cmd.Parameters.AddWithValue("@IdCamera", Convert.ToInt32(IDCamera));
                dbCon.OpenCon();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dbCon.CloseCon();
                btnAdauga.Visible = false;
                btnSterge.Visible = false;
                btnRenunta.Visible = false;
            }
            else
            {
                SqlCommand cmd = new SqlCommand("select * from Camere", dbCon.GetCon());
                dbCon.OpenCon();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dbCon.CloseCon();
            } 
        }
        private void txtClear()
        {
            txtNrCamera.Clear();
            txtNrLocuri.Clear();
            txtEtaj.Clear();
            txtPretZi.Clear();
            pictureBox1.Image = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "C:\\";
            openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.gif)|*.jpg;*.jpeg;*.png;*.gif|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Stream stream = openFileDialog.OpenFile();

                    Image selectedImage = Image.FromStream(stream);

                    pictureBox1.Image = selectedImage;

                    ImageData = File.ReadAllBytes(openFileDialog.FileName);

                    stream.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se pare ca a aparut o eroare", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            try
            {
                int parsareNrCamera;
                int parsareNrLocuri;
                int parsareEtaj;
                int parsarePretZi;
                if (txtNrCamera.Text == String.Empty)
                {
                    MessageBox.Show("Introdu un nr de camera", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNrCamera.Focus();
                    return;
                }
                else if (txtEtaj.Text == String.Empty)
                {
                    MessageBox.Show("Introdu un etaj", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEtaj.Focus();
                    return;
                }
                else if (txtNrLocuri.Text == String.Empty)
                {
                    MessageBox.Show("Introdu numarul de locuri", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNrLocuri.Focus();
                    return;
                }
                else if (txtPretZi.Text == String.Empty)
                {
                    MessageBox.Show("Introdu pretul zilnic", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPretZi.Focus();
                    return;
                }
                else if (((!Int32.TryParse(txtNrCamera.Text, out parsareNrCamera))))
                {
                    MessageBox.Show("Puteti introduce numai numere in campul numar camera", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNrCamera.Focus();
                    return;
                }
                else if (((!Int32.TryParse(txtEtaj.Text, out parsareEtaj))))
                {
                    MessageBox.Show("Puteti introduce numai numere in campul etaj", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEtaj.Focus();
                    return;
                }
                else if (((!Int32.TryParse(txtNrLocuri.Text, out parsareNrLocuri))))
                {
                    MessageBox.Show("Puteti introduce numai numere in campul numar locuri", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNrLocuri.Focus();
                    return;
                }
                else if (((!Int32.TryParse(txtPretZi.Text, out parsarePretZi))))
                {
                    MessageBox.Show("Puteti introduce numai numere in campul pret zi", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPretZi.Focus();
                    return;
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("select NrCamera from Camere where NrCamera=@NrCamera", dbCon.GetCon());
                    cmd.Parameters.AddWithValue("@NrCamera", txtNrCamera.Text);

                    dbCon.OpenCon();
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        MessageBox.Show("Camera exista deja in baza de date", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtClear();
                    }
                    else
                    {
                        cmd = new SqlCommand("adaugareCamera", dbCon.GetCon());
                        cmd.Parameters.AddWithValue("@NrCamera", Convert.ToInt32(txtNrCamera.Text));
                        cmd.Parameters.AddWithValue("@NrLocuri", Convert.ToInt32(txtNrLocuri.Text));
                        cmd.Parameters.AddWithValue("@Etaj", Convert.ToInt32(txtNrLocuri.Text));
                        cmd.Parameters.AddWithValue("@PretZi", Convert.ToDecimal(txtPretZi.Text));
                        if (ImageData != null)
                        {
                            cmd.Parameters.AddWithValue("@SpImagine", ImageData);
                        }

                        cmd.CommandType = CommandType.StoredProcedure;
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Camera a fost adaugata cu succes", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtClear();
                            BindCamera();
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

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (DeschisDinRezervare)
            {
                btnModificare.Visible = true;
                btnSterge.Visible = false;
                btnRenunta.Visible = false;
                btnAdauga.Visible = false;
            }
            else
            {
                btnModificare.Visible = true;
                btnSterge.Visible = true;
                btnRenunta.Visible = true;
                btnAdauga.Visible = false;
            }
            IDCamera = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtNrCamera.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtNrLocuri.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtEtaj.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtPretZi.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            ImageData = dataGridView1.SelectedRows[0].Cells[5].Value as byte[];
            if (ImageData != null)
            {
                using (MemoryStream ms = new MemoryStream(ImageData))
                {
                    pictureBox1.Image = Image.FromStream(ms);
                }
            }
            else
            {
                pictureBox1.Image = null;
            }
        }

        private void btnActualizeaza_Click(object sender, EventArgs e)
        {
            try
            {
                int parsareNrCamera;
                int parsareNrLocuri;
                int parsareEtaj;
                int parsarePretZi;
                if (txtNrCamera.Text == String.Empty)
                {
                    MessageBox.Show("Introdu un nr de camera", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNrCamera.Focus();
                    return;
                }
                else if (txtEtaj.Text == String.Empty)
                {
                    MessageBox.Show("Introdu un etaj", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEtaj.Focus();
                    return;
                }
                else if (txtNrLocuri.Text == String.Empty)
                {
                    MessageBox.Show("Introdu numarul de locuri", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNrLocuri.Focus();
                    return;
                }
                else if (txtPretZi.Text == String.Empty)
                {
                    MessageBox.Show("Introdu pretul zilnic", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPretZi.Focus();
                    return;
                }
                else if (((!Int32.TryParse(txtNrCamera.Text, out parsareNrCamera))))
                {
                    MessageBox.Show("Puteti introduce numai numere in campul numar camera", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNrCamera.Focus();
                    return;
                }
                else if (((!Int32.TryParse(txtEtaj.Text, out parsareEtaj))))
                {
                    MessageBox.Show("Puteti introduce numai numere in campul etaj", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEtaj.Focus();
                    return;
                }
                else if (((!Int32.TryParse(txtNrLocuri.Text, out parsareNrLocuri))))
                {
                    MessageBox.Show("Puteti introduce numai numere in campul numar locuri", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNrLocuri.Focus();
                    return;
                }
                else if (((!Int32.TryParse(txtPretZi.Text, out parsarePretZi))))
                {
                    MessageBox.Show("Puteti introduce numai numere in campul pret zi", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPretZi.Focus();
                    return;
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("select NrCamera from Camere where NrCamera=@NrCamera and IdCamera <> @IdCamera", dbCon.GetCon());
                    cmd.Parameters.AddWithValue("@NrCamera", txtNrCamera.Text);
                    cmd.Parameters.AddWithValue("@IdCamera", IDCamera);

                    dbCon.OpenCon();
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        MessageBox.Show("Cel putin o camera cu aceeasi denumire exista deja in baza de date", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtClear();
                    }
                    else
                    {
                        cmd = new SqlCommand("actalizareCamera", dbCon.GetCon());
                        cmd.Parameters.AddWithValue("@IdCamera", Convert.ToInt32(IDCamera));
                        cmd.Parameters.AddWithValue("@NrCamera", Convert.ToInt32(txtNrCamera.Text));
                        cmd.Parameters.AddWithValue("@NrLocuri", Convert.ToInt32(txtNrLocuri.Text));
                        cmd.Parameters.AddWithValue("@Etaj", Convert.ToInt32(txtEtaj.Text));
                        cmd.Parameters.AddWithValue("@PretZi", Convert.ToDecimal(txtPretZi.Text));
                        if (ImageData != null)
                        {
                            cmd.Parameters.AddWithValue("@SpImagine", ImageData);
                        }

                        cmd.CommandType = CommandType.StoredProcedure;
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Camera a fost adaugata cu succes", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtClear();
                            BindCamera();
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

        private void btnSterge_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selecateaza o camera", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    if (DialogResult.Yes == MessageBox.Show("Vrei sa stergi aceasta camera?", "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    {
                        SqlCommand cmd = new SqlCommand("select top 1 * from RezervariContinut where IdCamera=@IdCamera", dbCon.GetCon());
                        cmd.Parameters.AddWithValue("@IdCamera", Convert.ToInt32(IDCamera));
                        dbCon.OpenCon();
                        var result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            MessageBox.Show("Nu puteti sterge aceasta camera deoarece este continuta intr-o rezervare", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            cmd = new SqlCommand("stergeCamera", dbCon.GetCon());
                            cmd.Parameters.AddWithValue("@IdCamera", Convert.ToInt32(IDCamera));
                            cmd.CommandType = CommandType.StoredProcedure;
                            int i = cmd.ExecuteNonQuery();
                            if (i > 0)
                            {
                                MessageBox.Show("Camera stearsa", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtClear();
                                BindCamera();
                                btnModificare.Visible = false;
                                btnSterge.Visible = false;
                                btnAdauga.Visible = true;
                            }
                            else
                            {
                                MessageBox.Show("Stergerea nu s-a finalizat", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtClear();
                            }
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
            btnModificare.Visible = false;
            btnSterge.Visible = false;
            btnRenunta.Visible = false;
            btnAdauga.Visible = true;

            txtNrCamera.Text = "";
            txtEtaj.Text = "";
            txtNrLocuri.Text = "";
            txtPretZi.Text = "";
            pictureBox1.Image = null;

            dataGridView1.ClearSelection();
        }

        private void Camere_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            Imagine imagine = new Imagine();
            imagine.IdCamera = IDCamera;
            imagine.ShowDialog();
        }
    }
}
