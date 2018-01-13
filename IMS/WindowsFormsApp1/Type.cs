using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Type : Form
    {
        public Type()
        {
            InitializeComponent();
        }

        private void Type_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iMSDataSet.Type' table. You can move, or remove it, as needed.
            this.typeTableAdapter.Fill(this.iMSDataSet.Type);
            string connectionString = "Server=Nan-PC\\MSSQLSERVER01;Database=IMS;Integrated Security=True";

            string sqlCmd = "SELECT * FROM [dbo].[Type] ";
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            //Method 1. sql command method
            SqlCommand cmd = new SqlCommand(sqlCmd, conn);

            SqlDataReader reader = cmd.ExecuteReader();

            typeListBox.Items.Clear();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    typeListBox.Items.Add(reader["Name"]);
                }

            }

            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var typeNew = new TypeNew();
            var dialogResult = typeNew.ShowDialog();

            if (dialogResult == DialogResult.Cancel)
            {
                MessageBox.Show(@"User clicked cancel!");
            }
            if (dialogResult == DialogResult.OK)
            {
                MessageBox.Show(@"New Type created!");
            }
        }
    }
}
