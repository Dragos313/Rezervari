namespace Rezervari
{
    partial class DetaliiRezervare
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
            this.cmbCamera = new System.Windows.Forms.ComboBox();
            this.dtpDataInceput = new System.Windows.Forms.DateTimePicker();
            this.btnRenunta = new System.Windows.Forms.Button();
            this.btnSterge = new System.Windows.Forms.Button();
            this.btnActualizeaza = new System.Windows.Forms.Button();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdRezervare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCamera_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNrCamera = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnModificaCamera = new System.Windows.Forms.Button();
            this.dtpDataSfarsit = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConfirmare = new System.Windows.Forms.Button();
            this.lblOP = new System.Windows.Forms.Label();
            this.pnlControale = new System.Windows.Forms.Panel();
            this.txtNrc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlControale.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbCamera
            // 
            this.cmbCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCamera.FormattingEnabled = true;
            this.cmbCamera.Location = new System.Drawing.Point(136, 12);
            this.cmbCamera.Name = "cmbCamera";
            this.cmbCamera.Size = new System.Drawing.Size(176, 28);
            this.cmbCamera.TabIndex = 0;
            this.cmbCamera.SelectedIndexChanged += new System.EventHandler(this.cmbCamera_SelectedIndexChanged);
            // 
            // dtpDataInceput
            // 
            this.dtpDataInceput.Location = new System.Drawing.Point(101, 64);
            this.dtpDataInceput.Name = "dtpDataInceput";
            this.dtpDataInceput.Size = new System.Drawing.Size(211, 26);
            this.dtpDataInceput.TabIndex = 2;
            // 
            // btnRenunta
            // 
            this.btnRenunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenunta.Location = new System.Drawing.Point(982, 12);
            this.btnRenunta.Name = "btnRenunta";
            this.btnRenunta.Size = new System.Drawing.Size(134, 38);
            this.btnRenunta.TabIndex = 26;
            this.btnRenunta.Text = "Renunta";
            this.btnRenunta.UseVisualStyleBackColor = true;
            this.btnRenunta.Click += new System.EventHandler(this.btnRenunta_Click);
            // 
            // btnSterge
            // 
            this.btnSterge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSterge.Location = new System.Drawing.Point(292, 12);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(134, 38);
            this.btnSterge.TabIndex = 25;
            this.btnSterge.Text = "Stergere";
            this.btnSterge.UseVisualStyleBackColor = true;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // btnActualizeaza
            // 
            this.btnActualizeaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizeaza.Location = new System.Drawing.Point(152, 12);
            this.btnActualizeaza.Name = "btnActualizeaza";
            this.btnActualizeaza.Size = new System.Drawing.Size(134, 38);
            this.btnActualizeaza.TabIndex = 24;
            this.btnActualizeaza.Text = "Modificare";
            this.btnActualizeaza.UseVisualStyleBackColor = true;
            this.btnActualizeaza.Click += new System.EventHandler(this.btnActualizeaza_Click);
            // 
            // btnAdauga
            // 
            this.btnAdauga.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdauga.Location = new System.Drawing.Point(12, 13);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(134, 38);
            this.btnAdauga.TabIndex = 23;
            this.btnAdauga.Text = "Adaugare";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdRezervare,
            this.IdCamera_,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView1.Location = new System.Drawing.Point(12, 65);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(760, 376);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // IdRezervare
            // 
            this.IdRezervare.DataPropertyName = "IdRezervare";
            this.IdRezervare.HeaderText = "Column1";
            this.IdRezervare.MinimumWidth = 8;
            this.IdRezervare.Name = "IdRezervare";
            this.IdRezervare.ReadOnly = true;
            this.IdRezervare.Visible = false;
            this.IdRezervare.Width = 150;
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
            // lblNrCamera
            // 
            this.lblNrCamera.AutoSize = true;
            this.lblNrCamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNrCamera.Location = new System.Drawing.Point(5, 15);
            this.lblNrCamera.Name = "lblNrCamera";
            this.lblNrCamera.Size = new System.Drawing.Size(91, 20);
            this.lblNrCamera.TabIndex = 30;
            this.lblNrCamera.Text = "Nr Camera";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "De la";
            // 
            // btnModificaCamera
            // 
            this.btnModificaCamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificaCamera.Location = new System.Drawing.Point(102, 10);
            this.btnModificaCamera.Name = "btnModificaCamera";
            this.btnModificaCamera.Size = new System.Drawing.Size(31, 27);
            this.btnModificaCamera.TabIndex = 33;
            this.btnModificaCamera.Text = "...";
            this.btnModificaCamera.UseVisualStyleBackColor = true;
            this.btnModificaCamera.Click += new System.EventHandler(this.btnModificaCamera_Click);
            // 
            // dtpDataSfarsit
            // 
            this.dtpDataSfarsit.Location = new System.Drawing.Point(101, 111);
            this.dtpDataSfarsit.Name = "dtpDataSfarsit";
            this.dtpDataSfarsit.Size = new System.Drawing.Size(211, 26);
            this.dtpDataSfarsit.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Pana la";
            // 
            // btnConfirmare
            // 
            this.btnConfirmare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmare.Location = new System.Drawing.Point(828, 12);
            this.btnConfirmare.Name = "btnConfirmare";
            this.btnConfirmare.Size = new System.Drawing.Size(134, 38);
            this.btnConfirmare.TabIndex = 34;
            this.btnConfirmare.Text = "Confirmare";
            this.btnConfirmare.UseVisualStyleBackColor = true;
            this.btnConfirmare.Click += new System.EventHandler(this.btnConfirmare_Click);
            // 
            // lblOP
            // 
            this.lblOP.AutoSize = true;
            this.lblOP.Location = new System.Drawing.Point(694, 22);
            this.lblOP.Name = "lblOP";
            this.lblOP.Size = new System.Drawing.Size(33, 20);
            this.lblOP.TabIndex = 35;
            this.lblOP.Text = "OP";
            // 
            // pnlControale
            // 
            this.pnlControale.Controls.Add(this.label3);
            this.pnlControale.Controls.Add(this.txtNrc);
            this.pnlControale.Controls.Add(this.cmbCamera);
            this.pnlControale.Controls.Add(this.dtpDataInceput);
            this.pnlControale.Controls.Add(this.dtpDataSfarsit);
            this.pnlControale.Controls.Add(this.btnModificaCamera);
            this.pnlControale.Controls.Add(this.lblNrCamera);
            this.pnlControale.Controls.Add(this.label2);
            this.pnlControale.Controls.Add(this.label1);
            this.pnlControale.Location = new System.Drawing.Point(786, 65);
            this.pnlControale.Name = "pnlControale";
            this.pnlControale.Size = new System.Drawing.Size(330, 204);
            this.pnlControale.TabIndex = 36;
            // 
            // txtNrc
            // 
            this.txtNrc.Location = new System.Drawing.Point(101, 157);
            this.txtNrc.Name = "txtNrc";
            this.txtNrc.ReadOnly = true;
            this.txtNrc.Size = new System.Drawing.Size(211, 26);
            this.txtNrc.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Nrc";
            // 
            // DetaliiRezervare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 445);
            this.Controls.Add(this.pnlControale);
            this.Controls.Add(this.lblOP);
            this.Controls.Add(this.btnConfirmare);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRenunta);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.btnActualizeaza);
            this.Controls.Add(this.btnAdauga);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DetaliiRezervare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetaliiRezervare";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DetaliiRezervare_FormClosing);
            this.Load += new System.EventHandler(this.DetaliiRezervare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlControale.ResumeLayout(false);
            this.pnlControale.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCamera;
        private System.Windows.Forms.DateTimePicker dtpDataInceput;
        private System.Windows.Forms.Button btnRenunta;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.Button btnActualizeaza;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblNrCamera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdRezervare;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCamera_;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button btnModificaCamera;
        private System.Windows.Forms.DateTimePicker dtpDataSfarsit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConfirmare;
        private System.Windows.Forms.Label lblOP;
        private System.Windows.Forms.Panel pnlControale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNrc;
    }
}