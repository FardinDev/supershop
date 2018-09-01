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
    public partial class Uform : Form
    {

        SqlCeConnection connection = null;
        SqlCeCommand command = null;
        public Uform()
        {
            InitializeComponent();
            connection = new SqlCeConnection(@"Data Source=C:\Users\ksk\Desktop\try33\try33\supershop.sdf");
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
        int k = 0;
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            k++;
            if (k % 2 == 0)
            {
                logoutpanel.Hide();

            }
            else
            {
                logoutpanel.Show();
            }

        }

        private void userlogout_Click(object sender, EventArgs e)
        {
            this.Hide();

            login l = new login();
            l.Show();
        }

        private void sellpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void datetime_Tick(object sender, EventArgs e)
        {
            datetimelabel.Text = DateTime.Now.ToString();
        }

        private void returnpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addtolistbutton_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
            productpanel.Hide();
            returnpanel.Hide();
            sellpanel.Show();
        }

        private void Uform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'supershopDataSet1.temp' table. You can move, or remove it, as needed.
            this.tempTableAdapter.Fill(this.supershopDataSet1.temp);
            // TODO: This line of code loads data into the 'supershopDataSet1.salestable' table. You can move, or remove it, as needed.
            this.salestableTableAdapter.Fill(this.supershopDataSet1.salestable);
            // TODO: This line of code loads data into the 'supershopDataSet1.Saletable' table. You can move, or remove it, as needed.
            // this.saletableTableAdapter.Fill(this.supershopDataSet1.Saletable);
            // TODO: This line of code loads data into the 'supershopDataSet.Saletable' table. You can move, or remove it, as needed.
            //  this.saletableTableAdapter.Fill(this.supershopDataSet.Saletable);
            // TODO: This line of code loads data into the 'supershopDataSet.Inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.supershopDataSet.Inventory);

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void bunifuFlatButton10_Click(object sender, EventArgs e)
        {
            this.Hide();
            login l = new login();
            l.Show();


        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            SqlCeDataAdapter sqa = new SqlCeDataAdapter("SELECT * FROM Inventory where pro_name like '" + bunifuMetroTextbox7.Text + "%'", connection);
            DataTable dt = new DataTable();
            sqa.Fill(dt);
            bunifuCustomDataGrid1.DataSource = dt;
            connection.Close();
            productpanel.Show();
            returnpanel.Hide();
            sellpanel.Hide();
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

        private void addtolistbutton_Click_1(object sender, EventArgs e)
        {
            int unit = Int32.Parse(unitbox.Text);
            try
          {
              if (connection.State == ConnectionState.Closed)
                  connection.Open();


              string query = "INSERT INTO salestable (pro_name, unit_price, unit) select pro_name, unit_price, unit from Inventory where pro_name='" + itembox.Text + "'";
              command = new SqlCeCommand(query, connection);
              string query1 = "INSERT INTO temp (pro_name, unit_price, unit) select pro_name, unit_price, unit from Inventory where pro_name='" + itembox.Text + "'";
              command = new SqlCeCommand(query1, connection);
              SqlCeDataAdapter sqa = new SqlCeDataAdapter("UPDATE Inventory SET unit=unit-'" + unit + "' WHERE pro_name='" + itembox.Text + "'", connection);
              sqa.SelectCommand.ExecuteNonQuery();
              SqlCeDataAdapter sqa2 = new SqlCeDataAdapter("SELECT * FROM inventory ", connection);
               DataTable dt = new DataTable();
                sqa2.Fill(dt);
                bunifuCustomDataGrid3.DataSource = dt;
              
               command.Parameters.AddWithValue("@mode", "Add");
              command.Parameters.AddWithValue("@date", DateTime.Now.ToString());
              
              command.ExecuteNonQuery();
              MessageBox.Show("Adding Successful !!!!");
              if (connection.State == ConnectionState.Closed)
                  connection.Open();
              SqlCeDataAdapter sqa1 = new SqlCeDataAdapter("SELECT * FROM temp ", connection);
              DataTable dt1 = new DataTable();
              sqa1.Fill(dt1);

              bunifuCustomDataGrid2.DataSource = dt1;

                


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

        private void donebutton_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            ///SqlCeDataAdapter sqa1 = new SqlCeDataAdapter("drop table temp ", connection);
            DataTable dt1 = new DataTable();
            //sqa1.Fill(dt1);

            bunifuCustomDataGrid2.DataSource = dt1;
        }

        private void bunifuFlatButton11_Click(object sender, EventArgs e)
        {
            SqlCeDataAdapter sqa2 = new SqlCeDataAdapter("SELECT * FROM inventory ", connection);
            DataTable dt = new DataTable();
            sqa2.Fill(dt);
            bunifuCustomDataGrid3.DataSource = dt;
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            sellpanel.Hide();
            productpanel.Hide();
            profilepanel.Hide();

            returnpanel.Show();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            sellpanel.Hide();
            productpanel.Hide();
            returnpanel.Hide();

            profilepanel.Show();
            bunifuCustomLabel6.Text = unamelabel.Text;
        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }
        }
    }


