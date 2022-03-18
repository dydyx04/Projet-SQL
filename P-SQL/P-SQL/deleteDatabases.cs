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
    public partial class deleteDatabases : Form
    {
        MySqlConnection connection; //Connexion à la base de données
        public deleteDatabases()
        {
            InitializeComponent();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string userID = "root";
            string password = "root";
            string connectionString = "SERVER=localhost;" + "DATABASE=projet;" + "UID=" + userID + ";" + "PASSWORD=" + password + ";" + "SslMode = none";
            connection = new MySqlConnection(connectionString);//se connecte au serveur
            connection.Open();//ouvre la connexion
            MySqlCommand deleteDB = new MySqlCommand("DROP DATABASE " + txtName.Text, connection);//requête sql pour supprimer une bd
            try
            {
                //éxecute le code sql pour supprimer une base de donnée avec le nom à la fin 
                deleteDB.ExecuteNonQuery();
                MessageBox.Show("la base de donnée " + txtName.Text +  " a été supprimé");
                
            }
            catch (Exception ex)
            {
                //affiche un message d'erreur
                MessageBox.Show(ex.Message);
                
            }
        }

        private void BtnEnableDelete_Click(object sender, EventArgs e)
        {
            Hide();
            connectionPage mainPage = new connectionPage();
            mainPage.Show();
        }
    }
}
