namespace Rezervari
{
    partial class Clienti
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
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnActualizeaza = new System.Windows.Forms.Button();
            this.btnSterge = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NrTelefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNrTelefon = new System.Windows.Forms.TextBox();
            this.lblParola = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.lblNume = new System.Windows.Forms.Label();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRenunta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(16, 164);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(138, 43);
            this.btnAdauga.TabIndex = 0;
            this.btnAdauga.Text = "Adaugare";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // btnActualizeaza
            // 
            this.btnActualizeaza.Location = new System.Drawing.Point(15, 214);
            this.btnActualizeaza.Name = "btnActualizeaza";
            this.btnActualizeaza.Size = new System.Drawing.Size(138, 43);
            this.btnActualizeaza.TabIndex = 1;
            this.btnActualizeaza.Text = "Actualizeaza";
            this.btnActualizeaza.UseVisualStyleBackColor = true;
            this.btnActualizeaza.Click += new System.EventHandler(this.btnActualizeaza_Click);
            // 
            // btnSterge
            // 
            this.btnSterge.Location = new System.Drawing.Point(15, 265);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(138, 43);
            this.btnSterge.TabIndex = 2;
            this.btnSterge.Text = "Stergere";
            this.btnSterge.UseVisualStyleBackColor = true;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NrTelefon,
            this.NumeClient});
            this.dataGridView1.Location = new System.Drawing.Point(347, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(610, 417);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "IdClient";
            this.ID.HeaderText = "Column1";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 125;
            // 
            // NrTelefon
            // 
            this.NrTelefon.DataPropertyName = "NumeClient";
            this.NrTelefon.HeaderText = "Nume Client";
            this.NrTelefon.MinimumWidth = 6;
            this.NrTelefon.Name = "NrTelefon";
            this.NrTelefon.ReadOnly = true;
            this.NrTelefon.Width = 125;
            // 
            // NumeClient
            // 
            this.NumeClient.DataPropertyName = "NrTelefon";
            this.NumeClient.HeaderText = "Numar Telefon";
            this.NumeClient.MinimumWidth = 6;
            this.NumeClient.Name = "NumeClient";
            this.NumeClient.ReadOnly = true;
            this.NumeClient.Width = 125;
            // 
            // txtNrTelefon
            // 
            this.txtNrTelefon.Location = new System.Drawing.Point(97, 106);
            this.txtNrTelefon.Name = "txtNrTelefon";
            this.txtNrTelefon.Size = new System.Drawing.Size(208, 26);
            this.txtNrTelefon.TabIndex = 9;
            // 
            // lblParola
            // 
            this.lblParola.AutoSize = true;
            this.lblParola.Location = new System.Drawing.Point(12, 112);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(78, 20);
            this.lblParola.TabIndex = 8;
            this.lblParola.Text = "NrTelefon";
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(97, 18);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(208, 26);
            this.txtNume.TabIndex = 7;
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Location = new System.Drawing.Point(12, 24);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(51, 20);
            this.lblNume.TabIndex = 6;
            this.lblNume.Text = "Nume";
            // 
            // txtPrenume
            // 
            this.txtPrenume.Location = new System.Drawing.Point(97, 62);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(208, 26);
            this.txtPrenume.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Prenume";
            // 
            // btnRenunta
            // 
            this.btnRenunta.Location = new System.Drawing.Point(16, 316);
            this.btnRenunta.Name = "btnRenunta";
            this.btnRenunta.Size = new System.Drawing.Size(138, 43);
            this.btnRenunta.TabIndex = 12;
            this.btnRenunta.Text = "Renunta";
            this.btnRenunta.UseVisualStyleBackColor = true;
            this.btnRenunta.Click += new System.EventHandler(this.btnRenunta_Click);
            // 
            // Clienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 450);
            this.Controls.Add(this.btnRenunta);
            this.Controls.Add(this.txtPrenume);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNrTelefon);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.btnActualizeaza);
            this.Controls.Add(this.btnAdauga);
            this.Name = "Clienti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clienti";
            this.Load += new System.EventHandler(this.Clienti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnActualizeaza;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtNrTelefon;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NrTelefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeClient;
        private System.Windows.Forms.Button btnRenunta;
    }
}