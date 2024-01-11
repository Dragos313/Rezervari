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
    public partial class Clienti : Form
    {
        DBConnect dbCon = new DBConnect();
        public string IDClient;
        public Clienti()
        {
            InitializeComponent();
        }

        private void Clienti_Load(object sender, EventArgs e)
        {
            btnActualizeaza.Visible = false;
            btnSterge.Visible = false;
            btnRenunta.Visible = false;
            btnAdauga.Visible = true;
            BindClient();
        }
        private void BindClient()
        {
            SqlCommand cmd = new SqlCommand("select * from Clienti", dbCon.GetCon());
            dbCon.OpenCon();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dbCon.CloseCon();
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNume.Text == String.Empty)
                {
                    MessageBox.Show("Introdu un nume", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNume.Focus();
                    return;
                }
                else if (txtPrenume.Text == String.Empty)
                {
                    MessageBox.Show("Introdu un prenume", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNrTelefon.Focus();
                    return;
                }
                else if (txtNrTelefon.Text == String.Empty)
                {
                    MessageBox.Show("Introdu un numar de telefon", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNrTelefon.Focus();
                    return;
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("select NumeClient from Clienti where NumeClient=@NumeClient", dbCon.GetCon());
                    cmd.Parameters.AddWithValue("@NumeClient", txtNume.Text + " " + txtPrenume.Text);

                    dbCon.OpenCon();
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        if (DialogResult.Yes == MessageBox.Show("Client cu acelasi nume exista deja in baza de date. Continuati?", "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                        {
                            cmd = new SqlCommand("adaugareClient", dbCon.GetCon());
                            cmd.Parameters.AddWithValue("@NumeClient", txtNume.Text + " " + txtPrenume.Text);
                            cmd.Parameters.AddWithValue("@NrTelefon", txtNrTelefon.Text);
                            cmd.CommandType = CommandType.StoredProcedure;
                            int i = cmd.ExecuteNonQuery();
                            if (i > 0)
                            {
                                MessageBox.Show("Clientul a fost adaugat cu succes", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtClear();
                                BindClient();
                            }
                        }
                        else
                        {
                            txtClear();
                        }
                    }
                    else
                    {
                        cmd = new SqlCommand("adaugareClient", dbCon.GetCon());
                        cmd.Parameters.AddWithValue("@NumeClient", txtNume.Text + " " + txtPrenume.Text);
                        cmd.Parameters.AddWithValue("@NrTelefon", txtNrTelefon.Text);
                        cmd.CommandType = CommandType.StoredProcedure;
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Clientul a fost adaugat cu succes", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtClear();
                            BindClient();
                        }
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
            txtNume.Clear();
            txtPrenume.Clear();
            txtNrTelefon.Clear();
        }

        private void btnActualizeaza_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNume.Text == String.Empty)
                {
                    MessageBox.Show("Introdu un nume", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNume.Focus();
                    return;
                }
                else if (txtPrenume.Text == String.Empty)
                {
                    MessageBox.Show("Introdu un prenume", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNrTelefon.Focus();
                    return;
                }
                else if (txtNrTelefon.Text == String.Empty)
                {
                    MessageBox.Show("Introdu un numar de telefon", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNrTelefon.Focus();
                    return;
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("SELECT NumeClient FROM Clienti WHERE NumeClient = @NumeClient AND IdClient <> @IdClient", dbCon.GetCon());
                    cmd.Parameters.AddWithValue("@NumeClient", txtNume.Text + " " + txtPrenume.Text);
                    cmd.Parameters.AddWithValue("@IdClient", IDClient);


                    dbCon.OpenCon();
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        if (DialogResult.Yes == MessageBox.Show("Client cu acelasi nume exista deja in baza de date. Continuati?", "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                        {
                            cmd = new SqlCommand("actalizareClient", dbCon.GetCon());
                            cmd.Parameters.AddWithValue("@IdClient", IDClient);
                            cmd.Parameters.AddWithValue("@NumeClient", txtNume.Text + " " + txtPrenume.Text);
                            cmd.Parameters.AddWithValue("@NrTelefon", txtNrTelefon.Text);
                            cmd.CommandType = CommandType.StoredProcedure;
                            int i = cmd.ExecuteNonQuery();
                            if (i > 0)
                            {
                                MessageBox.Show("Clientul a fost modificat cu succes", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtClear();
                                BindClient();
                            }
                        }
                        else
                        {
                            txtClear();
                        }
                    }
                    else
                    {
                        cmd = new SqlCommand("actalizareClient", dbCon.GetCon());
                        cmd.Parameters.AddWithValue("@IdClient", IDClient);
                        cmd.Parameters.AddWithValue("@NumeClient", txtNume.Text + " " + txtPrenume.Text);
                        cmd.Parameters.AddWithValue("@NrTelefon", txtNrTelefon.Text);
                        cmd.CommandType = CommandType.StoredProcedure;
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Clientul a fost modificat cu succes", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtClear();
                            BindClient();
                        }
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
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selecateaza un client", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    if (DialogResult.Yes == MessageBox.Show("Vrei sa stergi acest client?", "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    {
                        SqlCommand cmd = new SqlCommand("stergeClient", dbCon.GetCon());
                        cmd.Parameters.AddWithValue("@IdClient", Convert.ToInt32(IDClient));
                        cmd.CommandType = CommandType.StoredProcedure;
                        dbCon.OpenCon();
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Partener sters", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtClear();
                            BindClient();
                            btnActualizeaza.Visible = false;
                            btnSterge.Visible = false;
                            btnAdauga.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("Stergerea nu s-a finalizat", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtClear();
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

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            btnActualizeaza.Visible = true;
            btnSterge.Visible = true;
            btnRenunta.Visible = true;
            btnAdauga.Visible = false;
            IDClient = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string fullName = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            string[] nameParts = fullName.Split(' ');

            if (nameParts.Length >= 1)
            {
                txtNume.Text = nameParts[0];
            }
            if (nameParts.Length >= 2)
            {
                txtPrenume.Text = nameParts[1];
            }
            
            txtNrTelefon.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void btnRenunta_Click(object sender, EventArgs e)
        {
            btnActualizeaza.Visible = false;
            btnSterge.Visible = false;
            btnRenunta.Visible = false;
            btnAdauga.Visible = true;

            txtNume.Text = "";
            txtPrenume.Text = "";
            txtNrTelefon.Text = "";

            dataGridView1.ClearSelection();
        }
       
    }
}
