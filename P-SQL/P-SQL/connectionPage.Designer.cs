namespace P_SQL
{
    partial class connectionPage
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
            this.btnConnexion = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.btnTable = new System.Windows.Forms.Button();
            this.btnBdd = new System.Windows.Forms.Button();
            this.btnBddDelete = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnTreeView = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConnexion
            // 
            this.btnConnexion.Location = new System.Drawing.Point(217, 162);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(289, 61);
            this.btnConnexion.TabIndex = 0;
            this.btnConnexion.Text = "Se connecter";
            this.btnConnexion.UseVisualStyleBackColor = true;
            this.btnConnexion.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(641, 27);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(29, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nom";
            // 
            // btnTable
            // 
            this.btnTable.Location = new System.Drawing.Point(12, 106);
            this.btnTable.Name = "btnTable";
            this.btnTable.Size = new System.Drawing.Size(289, 61);
            this.btnTable.TabIndex = 2;
            this.btnTable.Text = "Créer une table";
            this.btnTable.UseVisualStyleBackColor = true;
            this.btnTable.Click += new System.EventHandler(this.BtnTable_Click);
            // 
            // btnBdd
            // 
            this.btnBdd.Location = new System.Drawing.Point(381, 106);
            this.btnBdd.Name = "btnBdd";
            this.btnBdd.Size = new System.Drawing.Size(289, 61);
            this.btnBdd.TabIndex = 3;
            this.btnBdd.Text = "Créer une base de donnée";
            this.btnBdd.UseVisualStyleBackColor = true;
            this.btnBdd.Click += new System.EventHandler(this.BtnBdd_Click);
            // 
            // btnBddDelete
            // 
            this.btnBddDelete.Location = new System.Drawing.Point(12, 229);
            this.btnBddDelete.Name = "btnBddDelete";
            this.btnBddDelete.Size = new System.Drawing.Size(289, 61);
            this.btnBddDelete.TabIndex = 4;
            this.btnBddDelete.Text = "Supprimer une base de donnée";
            this.btnBddDelete.UseVisualStyleBackColor = true;
            this.btnBddDelete.Click += new System.EventHandler(this.BtnBddDelete_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(12, 12);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(99, 61);
            this.btnDisconnect.TabIndex = 5;
            this.btnDisconnect.Text = "Déconnexion";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.BtnDisconnect_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(586, 275);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(90, 61);
            this.btnLeft.TabIndex = 6;
            this.btnLeft.Text = "Quitter";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.BtnLeft_Click);
            // 
            // btnTreeView
            // 
            this.btnTreeView.Location = new System.Drawing.Point(381, 229);
            this.btnTreeView.Name = "btnTreeView";
            this.btnTreeView.Size = new System.Drawing.Size(289, 61);
            this.btnTreeView.TabIndex = 7;
            this.btnTreeView.Text = "Afficher les bases de donnée";
            this.btnTreeView.UseVisualStyleBackColor = true;
            this.btnTreeView.Click += new System.EventHandler(this.BtnTreeView_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 372);
            this.Controls.Add(this.btnTreeView);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnBddDelete);
            this.Controls.Add(this.btnBdd);
            this.Controls.Add(this.btnTable);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnConnexion);
            this.Name = "Form1";
            this.Text = "Connexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnTable;
        private System.Windows.Forms.Button btnBdd;
        private System.Windows.Forms.Button btnBddDelete;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnTreeView;
    }
}

