using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // when accessing the database
using System.Data.SqlTypes; // when retrieving from database
//using System.Data; // for different data containers

namespace GUIUnit2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // initialise pages
        StaffPage staffPage = new StaffPage();
        CustomerAccount customerForm = new CustomerAccount();
        ProductsForm productsPage = new ProductsForm();
        Bag bagPage = new Bag();

        private void signIn_Click(object sender, EventArgs e)
        {
            // variables
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            if (username == "admin" && password == "staff123")
            {
                staffPage.Show();
            }
            else if (username == "shopislife" && password == "password123")
            {
                customerForm.Show();
            }
            else
            {
                MessageBox.Show("Wrong username and password combination");
            }
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void browseItems_Click(object sender, EventArgs e)
        {
            productsPage.Show();
        }

        private void bagLudo_Click(object sender, EventArgs e)
        {
            // SQL stuff
            SqlConnection conn; // set a connection variable

            // info about the server + database to connect to
            string connString = "Data source = tolmount.abertay.ac.uk; Initial Catalog = mssql2004466; User ID = mssql2004466; Password = kNmHbV9uf7";

            // initialize the connection variable with this information
            conn = new SqlConnection(connString);

            try      // prevents application from crashing if it can't connect
            {
                conn.Open();         // open the connection
                Console.WriteLine("Connection successfully established.\n");

                // data things

                // set a string with the sql statement
                string insertQuery = "INSERT INTO STORE.ORDERS (Order_id, Total_cost, User_id, Postage_cost, First_item_id) VALUES (47, 6, 2, 0.00, 5)";

                // initialise a command variable with this string
                SqlCommand command = new SqlCommand(insertQuery, conn);

                int n = command.ExecuteNonQuery();

                Console.WriteLine(n + " rows affected");

                conn.Close();         // close the connection
                Console.WriteLine("\nConnection successfully terminated.");
            }     // try
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }      // catch 
            bagPage.Show();
        }


        /*public void bagItem(SqlConnection conn)
        {
            
            bagPage.Show();
        }

        public SqlConnection connectSQL()
        {
            // SQL stuff
            SqlConnection conn; // set a connection variable

            // info about the server + database to connect to
            string connString = "Data source = tolmount.abertay.ac.uk; Initial Catalog = mssql2004466; User ID = mssql2004466; Password = kNmHbV9uf7";

            // initialize the connection variable with this information
            conn = new SqlConnection(connString);

            return conn;
        } */

        /*private void bagHulkToy_Click(object sender, EventArgs e, SqlConnection conn)
        {
            connectSQL();

            try      // prevents application from crashing if it can't connect
            {
                conn.Open();         // open the connection
                Console.WriteLine("Connection successfully established.\n");

                // data things

                // set a string with the sql statement
                string insertQuery = "INSERT INTO STORE.ORDERS (Order_id, Total_cost, User_id, Postage_cost, First_item_id) VALUES (41, 11.99, 'shopislife', 0.00, 6)";

                // initialise a command variable with this string
                SqlCommand command = new SqlCommand(insertQuery, conn);

                int n = command.ExecuteNonQuery();

                Console.WriteLine(n + " rows affected");

                conn.Close();         // close the connection
                Console.WriteLine("\nConnection successfully terminated.");
            }     // try
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }      // catch
            bagPage.Show(); */
    }
    }

