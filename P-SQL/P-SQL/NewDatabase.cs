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
    public partial class NewDatabase : Form
    {
        MySqlConnection connection; //Connexion à la base de données

        public NewDatabase()
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

            MySqlCommand createDB = new MySqlCommand("CREATE DATABASE IF NOT EXISTS " + txtNewDB.Text,connection);//requête sql pour créer une base de donnée
            try
            {
                //éxecute le code sql pour créer la base de donnée avec le nom à la fin 
                createDB.ExecuteNonQuery();
                MessageBox.Show("La base de donnée " + txtNewDB.Text + " a été créé");
                
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
