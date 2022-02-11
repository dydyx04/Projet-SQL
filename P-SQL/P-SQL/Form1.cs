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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnTable.Visible = false;
            btnBdd.Visible = false;
            btnBddDelete.Visible = false;
            btnDisconnect.Visible = false;
        }

        MySqlConnection connection; //Connexion à la base de données
        string connectionString = ""; //Contient la requête de connexion
        string userID = "root"; //Login pour le user
        string password = "root"; //Mot de passe du user

        /// <summary>
        /// Se connecter à la base de données
        /// </summary>
        /// <returns>Un bool pour la connexion</returns>
        private bool OpenConnection()
        {
            //Affichage pour la connexion et pour une erreur de connexion
            try
            {
                connection.Open();
                
                MessageBox.Show("Connecté !");
                btnBdd.Visible = true;
                btnBddDelete.Visible = true;
                btnTable.Visible = true;
                button1.Visible = false;
                btnDisconnect.Visible = true;
                lblName.Text = Convert.ToString(connection.DataSource);
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private bool CloseConnection()
        {
            connection.Close();
            MessageBox.Show("Vous êtes déconnecté");
            btnBdd.Visible = false;
            btnBddDelete.Visible = false;
            btnTable.Visible = false;
            button1.Visible = true;
            btnDisconnect.Visible = false;
            lblName.Text = Convert.ToString(connection.DataSource);
            return true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //MySQL connexion        
            userID = "root";
            password = "root";
            connectionString = "SERVER=localhost;" + "DATABASE=projet;" + "UID=" + userID + ";" + "PASSWORD=" + password + ";" + "SslMode = none";
            connection = new MySqlConnection(connectionString);
            if (!OpenConnection())
            {
                MessageBox.Show("Erreur de connexion", "Erreur");
            }
            
        }

        /// <summary>
        /// créer une base de donnée 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBdd_Click(object sender, EventArgs e)
        {
            try
            {
                //éxecute le code sql pour créer la base de donnée avec le nom à la fin 
                string queryCreate = "CREATE DATABASE IF NOT EXISTS nameDB";
                MySqlCommand querySQL = new MySqlCommand(queryCreate, connection);
                MySqlDataReader dataReader = querySQL.ExecuteReader();
                dataReader.Close();
                MessageBox.Show("Votre base de donnée a été créé");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BtnDisconnect_Click(object sender, EventArgs e)
        { 
            CloseConnection();
        }

        private void BtnTable_Click(object sender, EventArgs e)
        {
            string useDB = "USE nameDB";
            string queryCreate = "CREATE TABLE IF NOT EXISTS [test].[nameDB]";
            MySqlCommand querySQL = new MySqlCommand(queryCreate, connection);
            MySqlDataReader dataReader = querySQL.ExecuteReader();
        }
    }
}
