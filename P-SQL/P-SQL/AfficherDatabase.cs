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
    public partial class AfficherDatabase : Form
    {

        public AfficherDatabase()
        {
            InitializeComponent();
        }

        /// <summary>
        /// retourne à la page de connexion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEnable_Click(object sender, EventArgs e)
        {
            Hide();
            connectionPage mainPage = new connectionPage();
            mainPage.Show();
        }
    }
}
