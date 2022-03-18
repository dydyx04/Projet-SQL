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
    public partial class connectionPage : Form
    {
        private DataBase db;
        public connectionPage()
        {
            InitializeComponent();
            btnTable.Visible = false;
            btnBdd.Visible = false;
            btnBddDelete.Visible = false;
            btnDisconnect.Visible = false;
            btnTreeView.Visible = false;
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
                btnConnexion.Visible = false;
                btnDisconnect.Visible = true;
                btnTreeView.Visible = true;
                btnLeft.Visible = false;
                lblName.Text = Convert.ToString(connection.DataSource);
                
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Se déconnecter de mySQL
        /// </summary>
        /// <returns>vrai quand on clique sur le bouton</returns>
        private bool CloseConnection()
        {
            connection.Close();
            MessageBox.Show("Vous êtes déconnecté");
            btnBdd.Visible = false;
            btnBddDelete.Visible = false;
            btnTable.Visible = false;
            btnConnexion.Visible = true;
            btnDisconnect.Visible = false;
            btnLeft.Visible = true;
            btnTreeView.Visible = false;
            lblName.Text = "Nom";
            return true;
        }

        /// <summary>
        /// Permet de se connecter à mySQL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// ouvre la page pour créer une base de donnée 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBdd_Click(object sender, EventArgs e)
        {
            Hide();
            NewDatabase db = new NewDatabase();
            db.Show();
            
        }

        /// <summary>
        /// de déconnectede mysql
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDisconnect_Click(object sender, EventArgs e)
        { 
            CloseConnection();
        }

        /// <summary>
        /// ouvre la page pour créer une table dans une base de donnée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnTable_Click(object sender, EventArgs e)
        {
            Hide();
            createTable createTable = new createTable();
            createTable.Show();
        }

        /// <summary>
        /// ouvre la page pour supprimer une base de donnée 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBddDelete_Click(object sender, EventArgs e)
        {
            Hide();
            deleteDatabases deletedb = new deleteDatabases();
            deletedb.Show();
        }

        /// <summary>
        /// Quitte le programme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLeft_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Affiche la treeview avec les db 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnTreeView_Click(object sender, EventArgs e)
        {
            Hide();//cache la page actuelle
            AfficherDatabase afficherDatabase = new AfficherDatabase();//instancie une nouvelle page pour afficher les db

            db = new DataBase();//instancie une nouvelle treeview

            //requête sql pour afficher les db dans la treeview
            string strSQL = "SHOW DATABASES";
            MySqlCommand cmd = new MySqlCommand(strSQL, connection);
            var reader = cmd.ExecuteReader();

            //pendant que le reader est actif il affiche les bases de donnée dans le treeview
            while (reader.Read())
            {
                db.DataShow = reader[0].ToString();
            }

            reader.Close();//ferme le reader
            db.Location = new Point(12, 10);
            afficherDatabase.Controls.Add(db);
            afficherDatabase.Show();
        }
    }
}
