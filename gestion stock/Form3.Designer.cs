namespace WindowsFormsApplication1
{
    partial class Form3
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.enregistrer = new System.Windows.Forms.Button();
            this.Nouveau = new System.Windows.Forms.Button();
            this.fermer = new System.Windows.Forms.Button();
            this.txtn = new System.Windows.Forms.ComboBox();
            this.Ajouter = new System.Windows.Forms.Button();
            this.tableau = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtp = new System.Windows.Forms.TextBox();
            this.txttp = new System.Windows.Forms.ComboBox();
            this.txtde = new System.Windows.Forms.DateTimePicker();
            this.txtq = new System.Windows.Forms.TextBox();
            this.txtpr = new System.Windows.Forms.TextBox();
            this.txtne = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txts = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tableau)).BeginInit();
            this.SuspendLayout();
            // 
            // enregistrer
            // 
            this.enregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.enregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enregistrer.Location = new System.Drawing.Point(450, 73);
            this.enregistrer.Name = "enregistrer";
            this.enregistrer.Size = new System.Drawing.Size(190, 30);
            this.enregistrer.TabIndex = 79;
            this.enregistrer.Text = "enregistrer";
            this.enregistrer.UseVisualStyleBackColor = false;
            this.enregistrer.Click += new System.EventHandler(this.enregistrer_Click);
            // 
            // Nouveau
            // 
            this.Nouveau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Nouveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nouveau.Location = new System.Drawing.Point(450, 42);
            this.Nouveau.Name = "Nouveau";
            this.Nouveau.Size = new System.Drawing.Size(190, 30);
            this.Nouveau.TabIndex = 78;
            this.Nouveau.Text = "Nouveau";
            this.Nouveau.UseVisualStyleBackColor = false;
            this.Nouveau.Click += new System.EventHandler(this.Nouveau_Click);
            // 
            // fermer
            // 
            this.fermer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fermer.Location = new System.Drawing.Point(450, 7);
            this.fermer.Name = "fermer";
            this.fermer.Size = new System.Drawing.Size(190, 30);
            this.fermer.TabIndex = 77;
            this.fermer.Text = "Fermer";
            this.fermer.UseVisualStyleBackColor = false;
            this.fermer.Click += new System.EventHandler(this.fermer_Click);
            // 
            // txtn
            // 
            this.txtn.FormattingEnabled = true;
            this.txtn.Location = new System.Drawing.Point(23, 162);
            this.txtn.Name = "txtn";
            this.txtn.Size = new System.Drawing.Size(109, 21);
            this.txtn.TabIndex = 76;
            this.txtn.SelectedIndexChanged += new System.EventHandler(this.txtn_SelectedIndexChanged);
            // 
            // Ajouter
            // 
            this.Ajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ajouter.Location = new System.Drawing.Point(534, 160);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(69, 25);
            this.Ajouter.TabIndex = 75;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = false;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // tableau
            // 
            this.tableau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableau.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.col3});
            this.tableau.Location = new System.Drawing.Point(24, 197);
            this.tableau.Name = "tableau";
            this.tableau.Size = new System.Drawing.Size(510, 132);
            this.tableau.TabIndex = 74;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "N°PRODUIT";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "NOM PRODUIT";
            this.Column2.Name = "Column2";
            this.Column2.Width = 250;
            // 
            // col3
            // 
            this.col3.HeaderText = "QUANTITE";
            this.col3.Name = "col3";
            // 
            // txtp
            // 
            this.txtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtp.ForeColor = System.Drawing.Color.Blue;
            this.txtp.Location = new System.Drawing.Point(127, 77);
            this.txtp.Name = "txtp";
            this.txtp.Size = new System.Drawing.Size(199, 21);
            this.txtp.TabIndex = 73;
            // 
            // txttp
            // 
            this.txttp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttp.ForeColor = System.Drawing.Color.Blue;
            this.txttp.FormattingEnabled = true;
            this.txttp.Items.AddRange(new object[] {
            "Facture",
            "Bon livraison"});
            this.txttp.Location = new System.Drawing.Point(123, 44);
            this.txttp.Name = "txttp";
            this.txttp.Size = new System.Drawing.Size(203, 23);
            this.txttp.TabIndex = 72;
            // 
            // txtde
            // 
            this.txtde.CalendarForeColor = System.Drawing.Color.Blue;
            this.txtde.CalendarTitleForeColor = System.Drawing.Color.Blue;
            this.txtde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtde.Location = new System.Drawing.Point(127, 117);
            this.txtde.Name = "txtde";
            this.txtde.Size = new System.Drawing.Size(226, 21);
            this.txtde.TabIndex = 71;
            // 
            // txtq
            // 
            this.txtq.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtq.ForeColor = System.Drawing.Color.Blue;
            this.txtq.Location = new System.Drawing.Point(415, 162);
            this.txtq.Name = "txtq";
            this.txtq.Size = new System.Drawing.Size(113, 21);
            this.txtq.TabIndex = 70;
            // 
            // txtpr
            // 
            this.txtpr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpr.ForeColor = System.Drawing.Color.Blue;
            this.txtpr.Location = new System.Drawing.Point(142, 162);
            this.txtpr.Name = "txtpr";
            this.txtpr.ReadOnly = true;
            this.txtpr.Size = new System.Drawing.Size(242, 21);
            this.txtpr.TabIndex = 69;
            // 
            // txtne
            // 
            this.txtne.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtne.ForeColor = System.Drawing.Color.Blue;
            this.txtne.Location = new System.Drawing.Point(121, 16);
            this.txtne.Name = "txtne";
            this.txtne.Size = new System.Drawing.Size(157, 21);
            this.txtne.TabIndex = 68;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 67;
            this.label4.Text = "Date Sortie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 66;
            this.label3.Text = "N°Pièce";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 65;
            this.label2.Text = "type pièce";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 64;
            this.label1.Text = "N°Sortie";
            // 
            // txts
            // 
            this.txts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txts.ForeColor = System.Drawing.Color.Blue;
            this.txts.Location = new System.Drawing.Point(540, 207);
            this.txts.Name = "txts";
            this.txts.ReadOnly = true;
            this.txts.Size = new System.Drawing.Size(113, 21);
            this.txts.TabIndex = 80;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 364);
            this.Controls.Add(this.txts);
            this.Controls.Add(this.enregistrer);
            this.Controls.Add(this.Nouveau);
            this.Controls.Add(this.fermer);
            this.Controls.Add(this.txtn);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.tableau);
            this.Controls.Add(this.txtp);
            this.Controls.Add(this.txttp);
            this.Controls.Add(this.txtde);
            this.Controls.Add(this.txtq);
            this.Controls.Add(this.txtpr);
            this.Controls.Add(this.txtne);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Gestion Des Sorties ";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enregistrer;
        private System.Windows.Forms.Button Nouveau;
        private System.Windows.Forms.Button fermer;
        private System.Windows.Forms.ComboBox txtn;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.DataGridView tableau;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col3;
        private System.Windows.Forms.TextBox txtp;
        private System.Windows.Forms.ComboBox txttp;
        private System.Windows.Forms.DateTimePicker txtde;
        private System.Windows.Forms.TextBox txtq;
        private System.Windows.Forms.TextBox txtpr;
        private System.Windows.Forms.TextBox txtne;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txts;
    }
}