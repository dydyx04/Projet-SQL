using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace P_SQL
{
    public partial class createTable : Form
    {
        MySqlConnection connection; //Connexion à la base de données

        public createTable()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Créer une table 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string userID = "root";
            string password = "root";
            string connectionString = "SERVER=localhost;" + "DATABASE=projet;" + "UID=" + userID + ";" + "PASSWORD=" + password + ";" + "SslMode = none";
            connection = new MySqlConnection(connectionString);//se connecte au serveur 
            connection.Open(); //ouvre la connexion
            MySqlCommand createTable = new MySqlCommand("CREATE TABLE IF NOT EXISTS " + txtNameDB.Text + "." + txtTableName.Text + "("+ txtNameLine.Text + " " + txtTypeData.Text + ")", connection);//la commande sql pour créer une table
            try
            {
                //éxecute le code sql pour créer une table avec le nom à la fin 
                createTable.ExecuteNonQuery();
                MessageBox.Show("la table " + txtTableName.Text + " a été créer dans la base de donnée " + txtNameDB.Text);
            }
            catch (Exception ex)
            {
                //affiche un message d'erreur
                MessageBox.Show(ex.Message);

            }


        }
         /// <summary>
         /// Retourne sur la page de connexion
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
        private void BtnEnableDelete_Click(object sender, EventArgs e)
        {
            Hide();
            connectionPage mainPage = new connectionPage();
            mainPage.Show();
        }
    }
}
