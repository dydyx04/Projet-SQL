namespace P_SQL
{
    partial class NewDatabase
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
            this.txtNewDB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEnableDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNewDB
            // 
            this.txtNewDB.Location = new System.Drawing.Point(211, 93);
            this.txtNewDB.Name = "txtNewDB";
            this.txtNewDB.Size = new System.Drawing.Size(145, 20);
            this.txtNewDB.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nom de la base de donnée";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(40, 187);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(183, 52);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Créer une base de donnée";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnEnableDelete
            // 
            this.btnEnableDelete.Location = new System.Drawing.Point(345, 187);
            this.btnEnableDelete.Name = "btnEnableDelete";
            this.btnEnableDelete.Size = new System.Drawing.Size(183, 52);
            this.btnEnableDelete.TabIndex = 6;
            this.btnEnableDelete.Text = "Annuler";
            this.btnEnableDelete.UseVisualStyleBackColor = true;
            this.btnEnableDelete.Click += new System.EventHandler(this.BtnEnableDelete_Click);
            // 
            // NewDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 324);
            this.Controls.Add(this.txtNewDB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEnableDelete);
            this.Name = "NewDatabase";
            this.Text = "Créer une base de donnée";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNewDB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEnableDelete;
    }
}