namespace P_SQL
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.btnTable = new System.Windows.Forms.Button();
            this.btnBdd = new System.Windows.Forms.Button();
            this.btnBddDelete = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(217, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(289, 61);
            this.button1.TabIndex = 0;
            this.button1.Text = "Se connecter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(641, 27);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // btnTable
            // 
            this.btnTable.Location = new System.Drawing.Point(26, 117);
            this.btnTable.Name = "btnTable";
            this.btnTable.Size = new System.Drawing.Size(289, 61);
            this.btnTable.TabIndex = 2;
            this.btnTable.Text = "Créer une table";
            this.btnTable.UseVisualStyleBackColor = true;
            this.btnTable.Click += new System.EventHandler(this.BtnTable_Click);
            // 
            // btnBdd
            // 
            this.btnBdd.Location = new System.Drawing.Point(387, 117);
            this.btnBdd.Name = "btnBdd";
            this.btnBdd.Size = new System.Drawing.Size(289, 61);
            this.btnBdd.TabIndex = 3;
            this.btnBdd.Text = "Créer une base de donnée";
            this.btnBdd.UseVisualStyleBackColor = true;
            this.btnBdd.Click += new System.EventHandler(this.BtnBdd_Click);
            // 
            // btnBddDelete
            // 
            this.btnBddDelete.Location = new System.Drawing.Point(217, 275);
            this.btnBddDelete.Name = "btnBddDelete";
            this.btnBddDelete.Size = new System.Drawing.Size(289, 61);
            this.btnBddDelete.TabIndex = 4;
            this.btnBddDelete.Text = "Supprimer une base de donnée";
            this.btnBddDelete.UseVisualStyleBackColor = true;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(26, 12);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(99, 61);
            this.btnDisconnect.TabIndex = 5;
            this.btnDisconnect.Text = "Déconnexion";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.BtnDisconnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 372);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnBddDelete);
            this.Controls.Add(this.btnBdd);
            this.Controls.Add(this.btnTable);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnTable;
        private System.Windows.Forms.Button btnBdd;
        private System.Windows.Forms.Button btnBddDelete;
        private System.Windows.Forms.Button btnDisconnect;
    }
}

