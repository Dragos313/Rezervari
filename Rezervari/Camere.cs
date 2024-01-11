using System;
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
        public Camere()
        {
            InitializeComponent();
        }

        private void Camere_Load(object sender, EventArgs e)
        {
            btnActualizeaza.Visible = false;
            btnSterge.Visible = false;
            btnRenunta.Visible = false;
            btnAdauga.Visible = true;
            BindCamera();
        }
        private void BindCamera()
        {
            SqlCommand cmd = new SqlCommand("select * from Camere", dbCon.GetCon());
            dbCon.OpenCon();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dbCon.CloseCon();
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
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            try
            {
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
                MessageBox.Show(ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
