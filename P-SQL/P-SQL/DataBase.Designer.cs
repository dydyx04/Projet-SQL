namespace P_SQL
{
    partial class DataBase
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tr_Database = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // tr_Database
            // 
            this.tr_Database.Location = new System.Drawing.Point(27, 21);
            this.tr_Database.Name = "tr_Database";
            this.tr_Database.Size = new System.Drawing.Size(310, 333);
            this.tr_Database.TabIndex = 0;
            this.tr_Database.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Tr_Database_MouseDoubleClick);
            // 
            // DataBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tr_Database);
            this.Name = "DataBase";
            this.Size = new System.Drawing.Size(526, 417);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tr_Database;
    }
}
