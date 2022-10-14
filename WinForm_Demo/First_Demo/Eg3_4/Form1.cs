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

namespace Eg3_4
{
    public partial class Form1ConnState : Form
    {
        //private SqlConnection conn;

        //SqlConnection conn;
        MySqlConnection conn = new MySqlConnection();
        public Form1ConnState()
        {
            //需使用SQL Server服务器;
            //conn = new SqlConnection("server=(local);database=sys;Integrated Security=sspi");
            //conn = new MySqlConnection("server=(local);database=sys");

            conn.ConnectionString = "server=127.0.0.1;port=3306;user=root;password=123123;database=sys";

            //public static string connectionString = "Database=test;Data Source=test;Port=3306;UserId=root;Password=root;Charset=utf8;TreatTinyAsBoolean=false;Allow User Variables=True";
            //public static string connectionString = "Database=test;Data Source=test;Port=3306;UserId=root;Password=root;Charset=utf8;TreatTinyAsBoolean=false;Allow User Variables=True";
            //conn = new MySqlConnection("Database=sys;Data Source=sys;Port=3306;UserId=root;Password=root;Charset=utf8;TreatTinyAsBoolean=false;Allow User Variables=True");
            //conn.ConnectionString = "server=(local);database=sys";
            InitializeComponent();

        }

        private void button1Open_Click(object sender, EventArgs e)
        {
            conn.Open();
            MessageBox.Show(conn.State.ToString());
            textBox1State.Text = conn.State.ToString();

            button1Open.Enabled = false;
            button2Close.Enabled = true;

        }

        private void button2Close_Click(object sender, EventArgs e)
        {
            conn.Close();
            textBox1State.Text = conn.State.ToString();

            button1Open.Enabled = true;
            button2Close.Enabled = false;

        }
    }
}
