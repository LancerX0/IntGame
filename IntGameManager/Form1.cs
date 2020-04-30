using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntGameManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {   
            InitializeComponent();
            string connetionString = "Data Source=C:\\Users\\home\\Documents\\mydatabase.sqlite";
            SQLiteConnection cnn;
            cnn = new SQLiteConnection(connetionString);
            cnn.Open();
            MessageBox.Show("Connection Open  !");
            cnn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddTopic_Click(object sender, EventArgs e)
        {
            
        }
    }
}
