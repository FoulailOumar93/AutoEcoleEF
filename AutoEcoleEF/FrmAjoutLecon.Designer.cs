namespace AutoEcoleEF
{
    partial class FrmAjoutLecon
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtLecon = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.ButSave = new System.Windows.Forms.Button();
            this.cmbEleve = new System.Windows.Forms.ComboBox();
            this.bdgEleve = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.CmbHeure = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bdgEleve)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Élève";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date";
            // 
            // dtLecon
            // 
            this.dtLecon.Location = new System.Drawing.Point(64, 77);
            this.dtLecon.Name = "dtLecon";
            this.dtLecon.Size = new System.Drawing.Size(200, 22);
            this.dtLecon.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Durée";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(64, 166);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(93, 20);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Une Heure";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(163, 166);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(106, 20);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Deux Heures";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // ButSave
            // 
            this.ButSave.Location = new System.Drawing.Point(63, 206);
            this.ButSave.Name = "ButSave";
            this.ButSave.Size = new System.Drawing.Size(143, 29);
            this.ButSave.TabIndex = 8;
            this.ButSave.Text = "Enregistrer";
            this.ButSave.UseVisualStyleBackColor = true;
            this.ButSave.Click += new System.EventHandler(this.ButSave_Click);
            // 
            // cmbEleve
            // 
            this.cmbEleve.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdgEleve, "nom", true));
            this.cmbEleve.DataSource = this.bdgEleve;
            this.cmbEleve.DisplayMember = "nom";
            this.cmbEleve.FormattingEnabled = true;
            this.cmbEleve.Location = new System.Drawing.Point(63, 42);
            this.cmbEleve.Name = "cmbEleve";
            this.cmbEleve.Size = new System.Drawing.Size(121, 24);
            this.cmbEleve.TabIndex = 9;
            this.cmbEleve.ValueMember = "dateInscription";
            // 
            // bdgEleve
            // 
            this.bdgEleve.DataSource = typeof(AutoEcoleEF.eleve);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Heure";
            // 
            // CmbHeure
            // 
            this.CmbHeure.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdgEleve, "lecons", true));
            this.CmbHeure.DataSource = this.bdgEleve;
            this.CmbHeure.DisplayMember = "nom";
            this.CmbHeure.FormattingEnabled = true;
            this.CmbHeure.Location = new System.Drawing.Point(64, 115);
            this.CmbHeure.Name = "CmbHeure";
            this.CmbHeure.Size = new System.Drawing.Size(159, 24);
            this.CmbHeure.TabIndex = 11;
            // 
            // FrmAjoutLecon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 257);
            this.Controls.Add(this.CmbHeure);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbEleve);
            this.Controls.Add(this.ButSave);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtLecon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdgEleve, "nom", true));
            this.Name = "FrmAjoutLecon";
            this.Text = "Ajouter Une Leçon";
            this.Load += new System.EventHandler(this.FrmAjoutLecon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdgEleve)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtLecon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button ButSave;
        private System.Windows.Forms.ComboBox cmbEleve;
        private System.Windows.Forms.BindingSource bdgEleve;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmbHeure;
    }
}