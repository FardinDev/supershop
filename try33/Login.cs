using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace try33
{
    public partial class login : Form
    {
        SqlCeConnection connection = null;
        SqlCeCommand command = null;
        public login()
        {
            
            InitializeComponent();
            connection = new SqlCeConnection(@"Data Source=C:\Users\ksk\Desktop\try33\try33\supershop.sdf");
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void signinbutton_Click(object sender, EventArgs e)
        {

          try
            {
                String username = UserBox.Text;
                String password = PassBox.Text;
                connection.Open();
                command = new SqlCeCommand("SELECT * from login where Username='" + username + "' and  Password = '" + password + "'", connection);
                command.CommandType = CommandType.Text;
                SqlCeDataReader reader = command.ExecuteReader();
                int counter = 0;

                while (reader.Read())
                {
                    if (reader["Type"].ToString() == "seller")
                    {
                        counter = 1;
                        this.Hide();
                        Uform user = new Uform();
                        user.unamelabel.Text = UserBox.Text;
                        user.Show();

                    }
                    else if (reader["Type"].ToString() == "admin")
                    {
                        counter = 1;
                        this.Hide();
                        Aform admin = new Aform();
                        
                        admin.Show();
                    }


                }


                if (counter == 0)
                {
                    MessageBox.Show("Username or Password Error!");
                }


                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }


        }



        }

        
    }

