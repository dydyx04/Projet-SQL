namespace P_SQL
{
    partial class createTable
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
            this.txtNameDB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateTable = new System.Windows.Forms.Button();
            this.btnEnableDelete = new System.Windows.Forms.Button();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNameLine = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTypeData = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNameDB
            // 
            this.txtNameDB.Location = new System.Drawing.Point(141, 95);
            this.txtNameDB.Name = "txtNameDB";
            this.txtNameDB.Size = new System.Drawing.Size(145, 20);
            this.txtNameDB.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Choisissez une base de donnée";
            // 
            // btnCreateTable
            // 
            this.btnCreateTable.Location = new System.Drawing.Point(80, 249);
            this.btnCreateTable.Name = "btnCreateTable";
            this.btnCreateTable.Size = new System.Drawing.Size(183, 52);
            this.btnCreateTable.TabIndex = 11;
            this.btnCreateTable.Text = "Créer la table ";
            this.btnCreateTable.UseVisualStyleBackColor = true;
            this.btnCreateTable.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnEnableDelete
            // 
            this.btnEnableDelete.Location = new System.Drawing.Point(385, 249);
            this.btnEnableDelete.Name = "btnEnableDelete";
            this.btnEnableDelete.Size = new System.Drawing.Size(183, 52);
            this.btnEnableDelete.TabIndex = 10;
            this.btnEnableDelete.Text = "Annuler";
            this.btnEnableDelete.UseVisualStyleBackColor = true;
            this.btnEnableDelete.Click += new System.EventHandler(this.BtnEnableDelete_Click);
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(369, 95);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(145, 20);
            this.txtTableName.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(366, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nom de la table";
            // 
            // txtNameLine
            // 
            this.txtNameLine.Location = new System.Drawing.Point(141, 180);
            this.txtNameLine.Name = "txtNameLine";
            this.txtNameLine.Size = new System.Drawing.Size(145, 20);
            this.txtNameLine.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nom de la ligne";
            // 
            // txtTypeData
            // 
            this.txtTypeData.Location = new System.Drawing.Point(369, 180);
            this.txtTypeData.Name = "txtTypeData";
            this.txtTypeData.Size = new System.Drawing.Size(145, 20);
            this.txtTypeData.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(366, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Type de donnée";
            // 
            // createTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 411);
            this.Controls.Add(this.txtTypeData);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNameLine);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTableName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNameDB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreateTable);
            this.Controls.Add(this.btnEnableDelete);
            this.Name = "createTable";
            this.Text = "Créer une table";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNameDB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateTable;
        private System.Windows.Forms.Button btnEnableDelete;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNameLine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTypeData;
        private System.Windows.Forms.Label label4;
    }
}