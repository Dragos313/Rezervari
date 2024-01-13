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
    public partial class Imagine : Form
    {
        DBConnect dbCon = new DBConnect();
        public string IdCamera;
        byte[] ImageData = null;
        public Imagine()
        {
            InitializeComponent();
        }
        
        private void Imagine_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select SpImagine from Camere where IdCamera = @IdCamera", dbCon.GetCon());
            cmd.Parameters.AddWithValue("@IdCamera", Convert.ToInt32(IdCamera));
            dbCon.OpenCon();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    if (!reader.IsDBNull(reader.GetOrdinal("SpImagine")))
                    {
                        ImageData = (byte[])reader["SpImagine"];

                        if (ImageData != null)
                        {
                            using (MemoryStream ms = new MemoryStream(ImageData))
                            {
                                ms.Position = 0;
                                pictureBox1.Image = Image.FromStream(ms);
                            }
                        }
                    }
                }
            }

            dbCon.CloseCon();
        }
    }
}
