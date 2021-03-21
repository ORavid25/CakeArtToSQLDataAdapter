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

namespace CakeArtToSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static string connectionString = @"Data Source=DESKTOP-5M58GH9\SQLEXPRESS;Initial Catalog=CakeArt;Integrated Security=True";
        private static SqlConnection connection = new SqlConnection(connectionString);
        
        SqlDataReader reader;

        


        private void ExcNQ(string Command)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand comm = new SqlCommand(Command, con);
           
            con.Open();
            int res = comm.ExecuteNonQuery(); // Insert, Update, Delete
            con.Close();

            MessageBox.Show((res == 1 ? "" : "Not ") + "Done!");
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (rbCake.Checked)
            {

                ExcNQ($"INSERT INTO Cakes (Name, Price) VALUES('{txtName.Text}', '{txtPrice.Text}')");
            }
            else if (rbCookie.Checked)
            {
                ExcNQ($"INSERT INTO Cookies (Name, Price) VALUES('{txtName.Text}', '{txtPrice.Text}')");
            }
            else if (rbSpecial.Checked)
            {
                ExcNQ($"INSERT INTO Special (Name, Price) VALUES('{txtName.Text}', '{txtPrice.Text}')");
            }
            ShowTable();

        }

        

        private void DeleteProduct_Click(object sender, EventArgs e)
        {
            if (rbCake.Checked)
            {
                ExcNQ($"DELETE FROM Cakes WHERE ID ='{txtID.Text}'");
            }
            else if (rbCookie.Checked)
            {
                ExcNQ($"DELETE FROM Cookies WHERE ID ='{txtID.Text}'");
            }
            else if (rbSpecial.Checked)
            {
                ExcNQ($"DELETE FROM Special WHERE ID ='{txtID.Text}'");
            }
            ShowTable();
        }


        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            ShowTable();
        }

        private void UpdateProduct_Click(object sender, EventArgs e)
        {
            
            if (rbCake.Checked)
            {
                string str = "Update Cakes SET ";
                if (txtName.Text != null)
                {
                    str += $"Name = '{txtName.Text}' ,"; 
                }
                if (txtPrice.Text != null)
                {
                    str += $"Price = '{txtPrice.Text}' ";
                }
                str += $" WHERE ID = '{txtID.Text}'";
                ExcNQ(str);
            }
            else if (rbCookie.Checked)
            {
                ExcNQ($"Update Cookies SET Name = '{txtName.Text}' , Price = '{txtPrice.Text}' WHERE ID = '{txtID.Text}'");
            }
            else if (rbSpecial.Checked)
            {
                ExcNQ($"Update Special SET Name = '{txtName.Text}' , Price = '{txtPrice.Text}' WHERE ID = '{txtID.Text}'");
            }
            ShowTable();
        }


        private void ShowTable()
        {
            string res="";
            connection.Open();

            if (rbCake.Checked)
            {
                res = $"SELECT * FROM Cakes";
                
            }
            else if (rbCookie.Checked)
            {
                res = $"SELECT * FROM Cookies";
            }
            else if (rbSpecial.Checked)
            {
                res = $"SELECT * FROM Special";
            }

            SqlCommand comm = new SqlCommand(res, connection);
            string output = "";
            reader = comm.ExecuteReader();
            while (reader.Read())
            {
                output += "ID: " + reader["ID"] + "  " + "Name: " + reader["Name"] + "  " + "Price: " + reader["Price"] + "\n";
            }
            connection.Close();
            lblResult.Text = output;
           
             
        }

        
    }
}
