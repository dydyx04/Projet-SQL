using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace P_SQL
{
    public partial class DataBase : UserControl
    {
        MySqlConnection connection;
        MySqlDataAdapter _dataAdapter;
        DataSet _dataSet;
        public DataBase()
        {
            InitializeComponent();
        }

        public string DataShow { get { return tr_Database.Nodes.ToString(); } set { tr_Database.Nodes.Add(value); } }


        private void Tr_Database_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            /*if (tr_Database.SelectedNode.Parent != null)
            {
                string sql = $"SELECT * FROM {tr_Database.SelectedNode.Parent.Text}.{tr_Database.SelectedNode.Text} ;";
                
                _mySqlCommand.Connection = connection;
                _dataSet = new DataSet();
                _dataAdapter = new MySqlDataAdapter(sql, connection);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(_dataAdapter); //Builder fait appelle à databuilders
                _dataAdapter.Fill(_dataSet, tr_Database.SelectedNode.Text);
                DV.DataSource = _dataSet;
                DV.DataMember = tr_Database.SelectedNode.Text;
                this.Controls.Remove(tr_Database);
                DV.Location = tr_Database.Location;
                DV.Size = tr_Database.Size;
                this.Controls.Add(DV);
            }*/
        }
    }
}
