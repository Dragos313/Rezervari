namespace Rezervari
{
    partial class Camere
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NrTelefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Etaj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PretZi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpImagine = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnRenunta = new System.Windows.Forms.Button();
            this.txtNrLocuri = new System.Windows.Forms.TextBox();
            this.lblNrLocuri = new System.Windows.Forms.Label();
            this.txtEtaj = new System.Windows.Forms.TextBox();
            this.lblEtaj = new System.Windows.Forms.Label();
            this.txtNrCamera = new System.Windows.Forms.TextBox();
            this.lblNrCamera = new System.Windows.Forms.Label();
            this.btnSterge = new System.Windows.Forms.Button();
            this.btnActualizeaza = new System.Windows.Forms.Button();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.lblImagine = new System.Windows.Forms.Label();
            this.txtPretZi = new System.Windows.Forms.TextBox();
            this.lblPretZi = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NrTelefon,
            this.NumeClient,
            this.Etaj,
            this.PretZi,
            this.SpImagine});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(426, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1069, 528);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "IdCamera";
            this.ID.HeaderText = "Column1";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 125;
            // 
            // NrTelefon
            // 
            this.NrTelefon.DataPropertyName = "NrCamera";
            this.NrTelefon.HeaderText = "Nr Camera";
            this.NrTelefon.MinimumWidth = 6;
            this.NrTelefon.Name = "NrTelefon";
            this.NrTelefon.ReadOnly = true;
            this.NrTelefon.Width = 125;
            // 
            // NumeClient
            // 
            this.NumeClient.DataPropertyName = "NrLocuri";
            this.NumeClient.HeaderText = "Nr Locuri";
            this.NumeClient.MinimumWidth = 6;
            this.NumeClient.Name = "NumeClient";
            this.NumeClient.ReadOnly = true;
            this.NumeClient.Width = 125;
            // 
            // Etaj
            // 
            this.Etaj.DataPropertyName = "Etaj";
            this.Etaj.HeaderText = "Etaj";
            this.Etaj.MinimumWidth = 6;
            this.Etaj.Name = "Etaj";
            this.Etaj.ReadOnly = true;
            this.Etaj.Width = 125;
            // 
            // PretZi
            // 
            this.PretZi.DataPropertyName = "PretZi";
            this.PretZi.HeaderText = "Pret Zi";
            this.PretZi.MinimumWidth = 6;
            this.PretZi.Name = "PretZi";
            this.PretZi.ReadOnly = true;
            this.PretZi.Width = 125;
            // 
            // SpImagine
            // 
            this.SpImagine.DataPropertyName = "SpImagine";
            this.SpImagine.HeaderText = "Sp Imagine";
            this.SpImagine.MinimumWidth = 6;
            this.SpImagine.Name = "SpImagine";
            this.SpImagine.ReadOnly = true;
            this.SpImagine.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SpImagine.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.SpImagine.Width = 125;
            // 
            // btnRenunta
            // 
            this.btnRenunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenunta.Location = new System.Drawing.Point(12, 444);
            this.btnRenunta.Name = "btnRenunta";
            this.btnRenunta.Size = new System.Drawing.Size(153, 50);
            this.btnRenunta.TabIndex = 22;
            this.btnRenunta.Text = "Renunta";
            this.btnRenunta.UseVisualStyleBackColor = true;
            this.btnRenunta.Click += new System.EventHandler(this.btnRenunta_Click);
            // 
            // txtNrLocuri
            // 
            this.txtNrLocuri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNrLocuri.Location = new System.Drawing.Point(136, 66);
            this.txtNrLocuri.Name = "txtNrLocuri";
            this.txtNrLocuri.Size = new System.Drawing.Size(228, 30);
            this.txtNrLocuri.TabIndex = 21;
            // 
            // lblNrLocuri
            // 
            this.lblNrLocuri.AutoSize = true;
            this.lblNrLocuri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNrLocuri.Location = new System.Drawing.Point(14, 71);
            this.lblNrLocuri.Name = "lblNrLocuri";
            this.lblNrLocuri.Size = new System.Drawing.Size(90, 25);
            this.lblNrLocuri.TabIndex = 20;
            this.lblNrLocuri.Text = "Nr Locuri";
            // 
            // txtEtaj
            // 
            this.txtEtaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEtaj.Location = new System.Drawing.Point(136, 119);
            this.txtEtaj.Name = "txtEtaj";
            this.txtEtaj.Size = new System.Drawing.Size(228, 30);
            this.txtEtaj.TabIndex = 19;
            // 
            // lblEtaj
            // 
            this.lblEtaj.AutoSize = true;
            this.lblEtaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtaj.Location = new System.Drawing.Point(14, 119);
            this.lblEtaj.Name = "lblEtaj";
            this.lblEtaj.Size = new System.Drawing.Size(45, 25);
            this.lblEtaj.TabIndex = 18;
            this.lblEtaj.Text = "Etaj";
            // 
            // txtNrCamera
            // 
            this.txtNrCamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNrCamera.Location = new System.Drawing.Point(136, 14);
            this.txtNrCamera.Name = "txtNrCamera";
            this.txtNrCamera.Size = new System.Drawing.Size(228, 30);
            this.txtNrCamera.TabIndex = 17;
            // 
            // lblNrCamera
            // 
            this.lblNrCamera.AutoSize = true;
            this.lblNrCamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNrCamera.Location = new System.Drawing.Point(11, 17);
            this.lblNrCamera.Name = "lblNrCamera";
            this.lblNrCamera.Size = new System.Drawing.Size(107, 25);
            this.lblNrCamera.TabIndex = 16;
            this.lblNrCamera.Text = "Nr Camera";
            // 
            // btnSterge
            // 
            this.btnSterge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSterge.Location = new System.Drawing.Point(12, 388);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(153, 50);
            this.btnSterge.TabIndex = 15;
            this.btnSterge.Text = "Stergere";
            this.btnSterge.UseVisualStyleBackColor = true;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // btnActualizeaza
            // 
            this.btnActualizeaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizeaza.Location = new System.Drawing.Point(12, 332);
            this.btnActualizeaza.Name = "btnActualizeaza";
            this.btnActualizeaza.Size = new System.Drawing.Size(153, 50);
            this.btnActualizeaza.TabIndex = 14;
            this.btnActualizeaza.Text = "Actualizeaza";
            this.btnActualizeaza.UseVisualStyleBackColor = true;
            this.btnActualizeaza.Click += new System.EventHandler(this.btnActualizeaza_Click);
            // 
            // btnAdauga
            // 
            this.btnAdauga.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdauga.Location = new System.Drawing.Point(12, 276);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(153, 50);
            this.btnAdauga.TabIndex = 13;
            this.btnAdauga.Text = "Adaugare";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // lblImagine
            // 
            this.lblImagine.AutoSize = true;
            this.lblImagine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagine.Location = new System.Drawing.Point(14, 226);
            this.lblImagine.Name = "lblImagine";
            this.lblImagine.Size = new System.Drawing.Size(111, 25);
            this.lblImagine.TabIndex = 27;
            this.lblImagine.Text = "Sp Imagine";
            // 
            // txtPretZi
            // 
            this.txtPretZi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPretZi.Location = new System.Drawing.Point(136, 171);
            this.txtPretZi.Name = "txtPretZi";
            this.txtPretZi.Size = new System.Drawing.Size(228, 30);
            this.txtPretZi.TabIndex = 24;
            // 
            // lblPretZi
            // 
            this.lblPretZi.AutoSize = true;
            this.lblPretZi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPretZi.Location = new System.Drawing.Point(14, 171);
            this.lblPretZi.Name = "lblPretZi";
            this.lblPretZi.Size = new System.Drawing.Size(68, 25);
            this.lblPretZi.TabIndex = 23;
            this.lblPretZi.Text = "Pret Zi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Location = new System.Drawing.Point(188, 221);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 319);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(131, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 34);
            this.button1.TabIndex = 30;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Camere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1507, 566);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblImagine);
            this.Controls.Add(this.txtPretZi);
            this.Controls.Add(this.lblPretZi);
            this.Controls.Add(this.btnRenunta);
            this.Controls.Add(this.txtNrLocuri);
            this.Controls.Add(this.lblNrLocuri);
            this.Controls.Add(this.txtEtaj);
            this.Controls.Add(this.lblEtaj);
            this.Controls.Add(this.txtNrCamera);
            this.Controls.Add(this.lblNrCamera);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.btnActualizeaza);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Camere";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Camere";
            this.Load += new System.EventHandler(this.Camere_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRenunta;
        private System.Windows.Forms.TextBox txtNrLocuri;
        private System.Windows.Forms.Label lblNrLocuri;
        private System.Windows.Forms.TextBox txtEtaj;
        private System.Windows.Forms.Label lblEtaj;
        private System.Windows.Forms.TextBox txtNrCamera;
        private System.Windows.Forms.Label lblNrCamera;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.Button btnActualizeaza;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Label lblImagine;
        private System.Windows.Forms.TextBox txtPretZi;
        private System.Windows.Forms.Label lblPretZi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NrTelefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn Etaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn PretZi;
        private System.Windows.Forms.DataGridViewImageColumn SpImagine;
    }
}