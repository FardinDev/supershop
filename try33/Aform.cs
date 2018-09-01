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
    public partial class Aform : Form
    {
        SqlCeConnection connection = null;
        SqlCeCommand command = null;
        int c = 0;
        public Aform()
        {
            InitializeComponent();
            connection = new SqlCeConnection(@"Data Source=C:\Users\jaber\Desktop\try33\try33\supershop.sdf");
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            addpanel.Show();
            removepanel.Hide();
        }

        private void bunifuFlatButton10_Click(object sender, EventArgs e)
        {
            removepanel.Show();
            addpanel.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void addtolistbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();


                string query = "INSERT INTO Inventory (pro_name, unit_price, unit) VALUES (@pro_name, @unit_price, @unit)";
                command = new SqlCeCommand(query, connection);
                command.Parameters.AddWithValue("@mode", "Add");
                //command.Parameters.AddWithValue("@pro_id", bunifuCustomTextbox5.Text.Trim());
                command.Parameters.AddWithValue("@pro_name", itembox.Text.Trim());
                command.Parameters.AddWithValue("@unit_price", unitbox.Text.Trim());
                command.Parameters.AddWithValue("@unit", bunifuMetroTextbox1.Text.Trim());
                command.ExecuteNonQuery();
                MessageBox.Show("Adding Successful !!!!");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Try Again !!!! ");
            }
            finally
            {
                connection.Close();
            }
        }

        private void bunifuFlatButton11_Click(object sender, EventArgs e)
        {
          
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            productpanel.Show();
            historypanel.Hide();
            manguser.Hide();

            if (connection.State == ConnectionState.Closed)
                connection.Open();
            SqlCeDataAdapter sqa = new SqlCeDataAdapter("SELECT * FROM Inventory where pro_name like '" + bunifuMetroTextbox7.Text + "%'", connection);
            DataTable dt = new DataTable();
            sqa.Fill(dt);

            bunifuCustomDataGrid1.DataSource = dt;
            connection.Close();

            
            
        
        }

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
            Inventory_panel.Show();
            productpanel.Hide();
            manguser.Hide();
            historypanel.Hide();
            

        }

        private void bunifuFlatButton13_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();


                string query = "INSERT INTO Inventory (pro_name, unit_price, unit) VALUES (@pro_name, @unit_price, @unit)";
                command = new SqlCeCommand(query, connection);
                command.Parameters.AddWithValue("@mode", "Add");
                //command.Parameters.AddWithValue("@pro_id", bunifuCustomTextbox5.Text.Trim());
                command.Parameters.AddWithValue("@pro_name", itembox.Text.Trim());
                command.Parameters.AddWithValue("@unit_price", unitbox.Text.Trim());
                command.Parameters.AddWithValue("@unit", bunifuMetroTextbox1.Text.Trim());
                command.ExecuteNonQuery();
                MessageBox.Show("Adding Successful !!!!");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Try Again !!!! ");
            }
            finally
            {
                connection.Close();
            }
        }

        private void bunifuFlatButton14_Click(object sender, EventArgs e)
        {
            addpanel.Show();
            removepanel.Hide();
            UPDATEP.Hide();
        }

        private void bunifuFlatButton10_Click_1(object sender, EventArgs e)
        {
            removepanel.Show();
            addpanel.Hide();
            UPDATEP.Hide();
        }

        private void bunifuFlatButton11_Click_1(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "delete from Inventory where pro_name='" + bunifuMetroTextbox2.Text + "'";
                command.ExecuteNonQuery();
                //connection.Close();
                MessageBox.Show("Successfully Deleted !!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sorry!!! Try Again");
            }
            finally
            {
                connection.Close();
            }
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        
           
         {
             if (connection.State == ConnectionState.Closed)
                 connection.Open();
             SqlCeDataAdapter sqa = new SqlCeDataAdapter("SELECT * FROM Inventory where pro_name like '" + bunifuMetroTextbox3.Text + "%'", connection);
             DataTable dt = new DataTable();
             sqa.Fill(dt);
             //dataGridView1.DataSource = dt;
             connection.Close();
         }
        

        private void Aform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'supershopDataSet1.salestable' table. You can move, or remove it, as needed.
            this.salestableTableAdapter.Fill(this.supershopDataSet1.salestable);
            // TODO: This line of code loads data into the 'supershopDataSet.login' table. You can move, or remove it, as needed.
            this.loginTableAdapter.Fill(this.supershopDataSet.login);
            // TODO: This line of code loads data into the 'supershopDataSet.Inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.supershopDataSet.Inventory);

        }
        
        private void bunifuFlatButton15_Click(object sender, EventArgs e)
        {
           
                useradd.Show();
                userrmv.Hide();
            
           

        }

        private void bunifuFlatButton12_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "delete from login where Username='" + bunifuMetroTextbox3.Text + "'";
                command.ExecuteNonQuery();
                //connection.Close();
                MessageBox.Show("Successfully Deleted !!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sorry!!! Try Again");
            }
            finally
            {
                connection.Close();
            }
        }

        private void bunifuFlatButton1_Click_2(object sender, EventArgs e)
        {
            useradd.Hide();
            userrmv.Show();
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            manguser.Show();
            Inventory_panel.Hide();
            productpanel.Hide();
            historypanel.Hide();
        }

        private void bunifuFlatButton16_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            SqlCeDataAdapter sqa = new SqlCeDataAdapter("SELECT * FROM Inventory where pro_name like '" + bunifuMetroTextbox7.Text + "%'", connection);
            DataTable dt = new DataTable();
            sqa.Fill(dt);
            
            bunifuCustomDataGrid1.DataSource = dt;
            connection.Close();

        }

        private void bunifuFlatButton13_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();


                string query = "INSERT INTO login (Username, Password, Type) VALUES (@Username, @Password, @Type)";
                command = new SqlCeCommand(query, connection);
                command.Parameters.AddWithValue("@mode", "Add");
                //command.Parameters.AddWithValue("@pro_id", bunifuCustomTextbox5.Text.Trim());
                command.Parameters.AddWithValue("@Username", bunifuMetroTextbox6.Text.Trim());
                command.Parameters.AddWithValue("@Password", bunifuMetroTextbox5.Text.Trim());
                command.Parameters.AddWithValue("@Type", bunifuMetroTextbox4.Text.Trim());
                command.ExecuteNonQuery();
                MessageBox.Show("Adding Successful !!!!");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Try Again !!!! ");
            }
            finally
            {
                connection.Close();
            }
        }

        private void datetime_Tick(object sender, EventArgs e)
        {
            datetimelabel.Text = DateTime.Now.ToString();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            c++;
            if (c % 2 == 0)
            {
                panel7.Hide();

            }
            else
            {
                panel7.Show();
            }
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            login l = new login();
            l.Show();
        }

        private void bunifuFlatButton17_Click(object sender, EventArgs e)
        {
            addpanel.Hide();
            removepanel.Hide();
            

            UPDATEP.Show();
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            productpanel.Hide();
            Inventory_panel.Hide();
            
            manguser.Hide();
            

            historypanel.Show();

            if (connection.State == ConnectionState.Closed)
                connection.Open();
            SqlCeDataAdapter sqa = new SqlCeDataAdapter("SELECT * FROM login where Type like '" + bunifuDropdown1.Text + "%'", connection);
            DataTable dt = new DataTable();
            sqa.Fill(dt);

            bunifuCustomDataGrid2.DataSource = dt;
            connection.Close();



        }

        private void bunifuFlatButton19_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            SqlCeDataAdapter sqa = new SqlCeDataAdapter("SELECT * FROM login where Type like '" + bunifuDropdown1.Text + "%'", connection);
            DataTable dt = new DataTable();
            sqa.Fill(dt);

            bunifuCustomDataGrid2.DataSource = dt;
            connection.Close();

        }

        private void bunifuFlatButton16_Click_1(object sender, EventArgs e)
        {

            if (connection.State == ConnectionState.Closed)
                connection.Open();
            SqlCeDataAdapter sqa = new SqlCeDataAdapter("SELECT * FROM Inventory where pro_name like '" + bunifuMetroTextbox7.Text + "%'", connection);
            DataTable dt = new DataTable();
            sqa.Fill(dt);
            bunifuCustomDataGrid1.DataSource = dt;
            connection.Close();
        }

        private void bunifuFlatButton18_Click(object sender, EventArgs e)
        {
            
            float unit_price = float.Parse(bunifuMetroTextbox9.Text);
            int unit = Int32.Parse(bunifuMetroTextbox8.Text);
            try
            {
                connection.Open();
                SqlCeDataAdapter sqa = new SqlCeDataAdapter("UPDATE Inventory SET unit_price='" + unit_price + "', unit='" + unit + "' WHERE pro_name='" + bunifuMetroTextbox10.Text + "'", connection);
                sqa.SelectCommand.ExecuteNonQuery();
                //connection.Close();
                MessageBox.Show("Update Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                connection.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bunifuCircleProgressbar1.Value++;

            if (bunifuCircleProgressbar1.Value > 99)
            {
                p33.Hide();
                bunifuCircleProgressbar1.Value = 99;

            }

        }
    }
}
