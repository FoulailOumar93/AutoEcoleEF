namespace AutoEcoleEF
{
    partial class FrmListeVehicule
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
            this.components = new System.ComponentModel.Container();
            this.dgvVehicule = new System.Windows.Forms.DataGridView();
            this.numImmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.couleurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enEtatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bdgVehicules = new System.Windows.Forms.BindingSource(this.components);
            this.Save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgVehicules)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVehicule
            // 
            this.dgvVehicule.AllowUserToOrderColumns = true;
            this.dgvVehicule.AutoGenerateColumns = false;
            this.dgvVehicule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numImmaDataGridViewTextBoxColumn,
            this.modeleDataGridViewTextBoxColumn,
            this.couleurDataGridViewTextBoxColumn,
            this.enEtatDataGridViewTextBoxColumn});
            this.dgvVehicule.DataSource = this.bdgVehicules;
            this.dgvVehicule.Location = new System.Drawing.Point(2, -1);
            this.dgvVehicule.Name = "dgvVehicule";
            this.dgvVehicule.RowHeadersWidth = 51;
            this.dgvVehicule.RowTemplate.Height = 24;
            this.dgvVehicule.Size = new System.Drawing.Size(766, 129);
            this.dgvVehicule.TabIndex = 0;
            // 
            // numImmaDataGridViewTextBoxColumn
            // 
            this.numImmaDataGridViewTextBoxColumn.DataPropertyName = "numImma";
            this.numImmaDataGridViewTextBoxColumn.HeaderText = "numImma";
            this.numImmaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numImmaDataGridViewTextBoxColumn.Name = "numImmaDataGridViewTextBoxColumn";
            this.numImmaDataGridViewTextBoxColumn.ReadOnly = true;
            this.numImmaDataGridViewTextBoxColumn.Width = 125;
            // 
            // modeleDataGridViewTextBoxColumn
            // 
            this.modeleDataGridViewTextBoxColumn.DataPropertyName = "modele";
            this.modeleDataGridViewTextBoxColumn.HeaderText = "modele";
            this.modeleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.modeleDataGridViewTextBoxColumn.Name = "modeleDataGridViewTextBoxColumn";
            this.modeleDataGridViewTextBoxColumn.ReadOnly = true;
            this.modeleDataGridViewTextBoxColumn.Width = 125;
            // 
            // couleurDataGridViewTextBoxColumn
            // 
            this.couleurDataGridViewTextBoxColumn.DataPropertyName = "couleur";
            this.couleurDataGridViewTextBoxColumn.HeaderText = "couleur";
            this.couleurDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.couleurDataGridViewTextBoxColumn.Name = "couleurDataGridViewTextBoxColumn";
            this.couleurDataGridViewTextBoxColumn.ReadOnly = true;
            this.couleurDataGridViewTextBoxColumn.Width = 125;
            // 
            // enEtatDataGridViewTextBoxColumn
            // 
            this.enEtatDataGridViewTextBoxColumn.DataPropertyName = "enEtat";
            this.enEtatDataGridViewTextBoxColumn.HeaderText = "enEtat";
            this.enEtatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.enEtatDataGridViewTextBoxColumn.Name = "enEtatDataGridViewTextBoxColumn";
            this.enEtatDataGridViewTextBoxColumn.ReadOnly = true;
            this.enEtatDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.enEtatDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.enEtatDataGridViewTextBoxColumn.Width = 125;
            // 
            // bdgVehicules
            // 
            this.bdgVehicules.DataSource = typeof(AutoEcoleEF.vehicule);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(265, 162);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(128, 38);
            this.Save.TabIndex = 1;
            this.Save.Text = "Sauvegarder";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // FrmListeVehicule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 212);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.dgvVehicule);
            this.Name = "FrmListeVehicule";
            this.Text = "FrmListeVehicule";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgVehicules)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bdgVehicules;
        private System.Windows.Forms.DataGridView dgvVehicule;
        private System.Windows.Forms.DataGridViewTextBoxColumn numImmaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn couleurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn enEtatDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Save;
    }
}