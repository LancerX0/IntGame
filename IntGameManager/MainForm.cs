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
    public partial class MainForm : Form
    {
        public SQLiteConnection cnn;
        private QuestionForm questionForm;
        private TopicForm topicForm;
        public MainForm()
        {   
            InitializeComponent();
            string connetionString = "Data Source=C:\\Users\\home\\Documents\\mydatabase.sqlite";
            //SQLiteConnection cnn;
            cnn = new SQLiteConnection(connetionString);
            cnn.Open();
            //MessageBox.Show("Connection Open  !");
            //cnn.Close();
            questionForm = new QuestionForm(cnn);
            topicForm = new TopicForm(cnn);
        }

        private void AddTopic_Click(object sender, EventArgs e)
        {
            topicForm.Show(this);
        }

        private void AddQuestion_Click(object sender, EventArgs e)
        {
            questionForm.Text = "Добавление вопроса";
            questionForm.Show(this);
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            questionForm.Text = "Редактирование вопроса";
            questionForm.Show(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cnn.Close();
        }
    }
}
