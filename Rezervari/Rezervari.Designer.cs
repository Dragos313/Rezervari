﻿namespace Rezervari
{
    partial class Rezervari
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
            this.btnStergeRezervare = new System.Windows.Forms.Button();
            this.btnAdaugaRezervare = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NrTelefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeClientt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbCauta = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnModificareRezervare = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.IdCamera_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdRezervare_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStergeRezervare
            // 
            this.btnStergeRezervare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStergeRezervare.Location = new System.Drawing.Point(636, 89);
            this.btnStergeRezervare.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStergeRezervare.Name = "btnStergeRezervare";
            this.btnStergeRezervare.Size = new System.Drawing.Size(191, 36);
            this.btnStergeRezervare.TabIndex = 25;
            this.btnStergeRezervare.Text = "Sterge Rezervare";
            this.btnStergeRezervare.UseVisualStyleBackColor = true;
            this.btnStergeRezervare.Click += new System.EventHandler(this.btnStergeRezervare_Click);
            // 
            // btnAdaugaRezervare
            // 
            this.btnAdaugaRezervare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugaRezervare.Location = new System.Drawing.Point(636, 49);
            this.btnAdaugaRezervare.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdaugaRezervare.Name = "btnAdaugaRezervare";
            this.btnAdaugaRezervare.Size = new System.Drawing.Size(191, 36);
            this.btnAdaugaRezervare.TabIndex = 23;
            this.btnAdaugaRezervare.Text = "Adauga Rezervare";
            this.btnAdaugaRezervare.UseVisualStyleBackColor = true;
            this.btnAdaugaRezervare.Click += new System.EventHandler(this.btnAdaugaRezervare_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NrTelefon,
            this.NumeClient,
            this.NumeClientt});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(604, 302);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "IdRezervare";
            this.ID.HeaderText = "Id Rezervare";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 125;
            // 
            // NrTelefon
            // 
            this.NrTelefon.DataPropertyName = "DataRezervarii";
            this.NrTelefon.HeaderText = "Data Rezervarii";
            this.NrTelefon.MinimumWidth = 6;
            this.NrTelefon.Name = "NrTelefon";
            this.NrTelefon.ReadOnly = true;
            this.NrTelefon.Width = 125;
            // 
            // NumeClient
            // 
            this.NumeClient.DataPropertyName = "IdClient";
            this.NumeClient.HeaderText = "Id Client";
            this.NumeClient.MinimumWidth = 6;
            this.NumeClient.Name = "NumeClient";
            this.NumeClient.ReadOnly = true;
            this.NumeClient.Visible = false;
            this.NumeClient.Width = 125;
            // 
            // NumeClientt
            // 
            this.NumeClientt.DataPropertyName = "NumeClient";
            this.NumeClientt.HeaderText = "Nume Client";
            this.NumeClientt.MinimumWidth = 8;
            this.NumeClientt.Name = "NumeClientt";
            this.NumeClientt.ReadOnly = true;
            this.NumeClientt.Width = 150;
            // 
            // cmbCauta
            // 
            this.cmbCauta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCauta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCauta.FormattingEnabled = true;
            this.cmbCauta.Location = new System.Drawing.Point(636, 12);
            this.cmbCauta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCauta.Name = "cmbCauta";
            this.cmbCauta.Size = new System.Drawing.Size(191, 28);
            this.cmbCauta.TabIndex = 29;
            this.cmbCauta.SelectedIndexChanged += new System.EventHandler(this.cmbCauta_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(859, 11);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 26);
            this.button2.TabIndex = 31;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnModificareRezervare
            // 
            this.btnModificareRezervare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificareRezervare.Location = new System.Drawing.Point(636, 129);
            this.btnModificareRezervare.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificareRezervare.Name = "btnModificareRezervare";
            this.btnModificareRezervare.Size = new System.Drawing.Size(191, 36);
            this.btnModificareRezervare.TabIndex = 32;
            this.btnModificareRezervare.Text = "Modificare Rezervare";
            this.btnModificareRezervare.UseVisualStyleBackColor = true;
            this.btnModificareRezervare.Click += new System.EventHandler(this.btnDetaliiRezervare_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Rezervari.Properties.Resources.search_interface_symbol;
            this.button1.Location = new System.Drawing.Point(832, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 26);
            this.button1.TabIndex = 30;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCamera_,
            this.IdRezervare_,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView2.Location = new System.Drawing.Point(7, 328);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(899, 278);
            this.dataGridView2.TabIndex = 33;
            // 
            // IdCamera_
            // 
            this.IdCamera_.DataPropertyName = "IdCamera_";
            this.IdCamera_.HeaderText = "Column1";
            this.IdCamera_.MinimumWidth = 8;
            this.IdCamera_.Name = "IdCamera_";
            this.IdCamera_.ReadOnly = true;
            this.IdCamera_.Visible = false;
            this.IdCamera_.Width = 150;
            // 
            // IdRezervare_
            // 
            this.IdRezervare_.DataPropertyName = "IdRezervare_";
            this.IdRezervare_.HeaderText = "Column1";
            this.IdRezervare_.MinimumWidth = 8;
            this.IdRezervare_.Name = "IdRezervare_";
            this.IdRezervare_.ReadOnly = true;
            this.IdRezervare_.Visible = false;
            this.IdRezervare_.Width = 150;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Nrc";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nrc";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NrCamera";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nr Camera";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DataCazarii";
            this.dataGridViewTextBoxColumn3.HeaderText = "Data Cazarii";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PretZi";
            this.dataGridViewTextBoxColumn4.HeaderText = "Pret Zi";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NrZile";
            this.dataGridViewTextBoxColumn5.HeaderText = "Nr Zile";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(885, 11);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(26, 26);
            this.button3.TabIndex = 34;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Rezervari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 618);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnModificareRezervare);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbCauta);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnStergeRezervare);
            this.Controls.Add(this.btnAdaugaRezervare);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "Rezervari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rezervari";
            this.Load += new System.EventHandler(this.Rezervari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnStergeRezervare;
        private System.Windows.Forms.Button btnAdaugaRezervare;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbCauta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnModificareRezervare;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCamera_;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdRezervare_;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NrTelefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeClientt;
    }
}