using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntGameManager
{
    public partial class TopicForm : Form
    {
        public SQLiteConnection cnn;
        public TopicForm(SQLiteConnection cnn)
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ok_Click(object sender, EventArgs e)
        {
            if (Topic.Text != "")
            {

            }
            else
                MessageBox.Show("Заполните тему");
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
