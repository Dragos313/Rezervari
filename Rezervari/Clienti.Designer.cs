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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.btnModificare = new System.Windows.Forms.Button();
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
            this.btnRenuntare = new System.Windows.Forms.Button();
            this.btnConfirmare = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugare.Location = new System.Drawing.Point(12, 13);
            this.btnAdaugare.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(132, 42);
            this.btnAdaugare.TabIndex = 0;
            this.btnAdaugare.Text = "Adaugare";
            this.btnAdaugare.UseVisualStyleBackColor = true;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // btnModificare
            // 
            this.btnModificare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificare.Location = new System.Drawing.Point(150, 13);
            this.btnModificare.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificare.Name = "btnModificare";
            this.btnModificare.Size = new System.Drawing.Size(131, 42);
            this.btnModificare.TabIndex = 1;
            this.btnModificare.Text = "Modificare";
            this.btnModificare.UseVisualStyleBackColor = true;
            this.btnModificare.Click += new System.EventHandler(this.btnActualizeaza_Click);
            // 
            // btnSterge
            // 
            this.btnSterge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSterge.Location = new System.Drawing.Point(287, 11);
            this.btnSterge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(131, 42);
            this.btnSterge.TabIndex = 2;
            this.btnSterge.Text = "Stergere";
            this.btnSterge.UseVisualStyleBackColor = true;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
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
            this.NumeClient});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 64);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(572, 281);
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
            this.txtNrTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNrTelefon.Location = new System.Drawing.Point(694, 179);
            this.txtNrTelefon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNrTelefon.Name = "txtNrTelefon";
            this.txtNrTelefon.Size = new System.Drawing.Size(185, 26);
            this.txtNrTelefon.TabIndex = 9;
            // 
            // lblParola
            // 
            this.lblParola.AutoSize = true;
            this.lblParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParola.Location = new System.Drawing.Point(602, 183);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(82, 20);
            this.lblParola.TabIndex = 8;
            this.lblParola.Text = "NrTelefon";
            // 
            // txtNume
            // 
            this.txtNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNume.Location = new System.Drawing.Point(694, 96);
            this.txtNume.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(185, 26);
            this.txtNume.TabIndex = 7;
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNume.Location = new System.Drawing.Point(602, 101);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(53, 20);
            this.lblNume.TabIndex = 6;
            this.lblNume.Text = "Nume";
            // 
            // txtPrenume
            // 
            this.txtPrenume.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrenume.Location = new System.Drawing.Point(694, 137);
            this.txtPrenume.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(185, 26);
            this.txtPrenume.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(602, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Prenume";
            // 
            // btnRenuntare
            // 
            this.btnRenuntare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenuntare.Location = new System.Drawing.Point(748, 13);
            this.btnRenuntare.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRenuntare.Name = "btnRenuntare";
            this.btnRenuntare.Size = new System.Drawing.Size(131, 42);
            this.btnRenuntare.TabIndex = 12;
            this.btnRenuntare.Text = "Renuntare";
            this.btnRenuntare.UseVisualStyleBackColor = true;
            this.btnRenuntare.Click += new System.EventHandler(this.btnRenunta_Click);
            // 
            // btnConfirmare
            // 
            this.btnConfirmare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmare.Location = new System.Drawing.Point(606, 13);
            this.btnConfirmare.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirmare.Name = "btnConfirmare";
            this.btnConfirmare.Size = new System.Drawing.Size(131, 42);
            this.btnConfirmare.TabIndex = 13;
            this.btnConfirmare.Text = "Confirmare";
            this.btnConfirmare.UseVisualStyleBackColor = true;
            // 
            // Clienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 360);
            this.Controls.Add(this.btnConfirmare);
            this.Controls.Add(this.btnRenuntare);
            this.Controls.Add(this.txtPrenume);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNrTelefon);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.btnModificare);
            this.Controls.Add(this.btnAdaugare);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Clienti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clienti";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Clienti_FormClosing);
            this.Load += new System.EventHandler(this.Clienti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.Button btnModificare;
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
        private System.Windows.Forms.Button btnRenuntare;
        private System.Windows.Forms.Button btnConfirmare;
    }
}