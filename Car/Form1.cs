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
using System.Collections;

namespace Car
{
    public partial class Form1 : Form
    {
        //Build the connection Object
        SqlConnection sqlConn = new SqlConnection(@"Data Source=host;Initial Catalog=dbname;User ID=username;Password=pwd");

        //Needed for the dgvCar_DoubleClick -> Select the cell
        int CID = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Refresh the DataGridView
            Reset();
            cbYesNoInit();
            fillManufacturerIn();
            DialogResult result = MessageBox.Show("Do you wanna do something?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                //code for Yes
            }
            else if (result == DialogResult.No)
            {
                //code for No
            }
            this.carTableAdapter.Fill(this.testDataSet.Car);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //Check the connection status of sql server, if closed, open it.
                if (sqlConn.State == ConnectionState.Closed)
                    sqlConn.Open();

                //Save mode
                if(btnSave.Text == "Save")
                {
                    //Method Store Procedure - start
                    SqlCommand sqlCmd = new SqlCommand("CarAddOrEdit", sqlConn);
                    sqlCmd.CommandType = CommandType.StoredProcedure;

                    //Insert value to parameters in Store Procedure
                    sqlCmd.Parameters.AddWithValue("@mode", "Add");
                    sqlCmd.Parameters.AddWithValue("@CID", 0);
                    sqlCmd.Parameters.AddWithValue("@CarName", txtCarName.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Country", txtCountry.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@EngineDisplacement", Int32.Parse(txtEngineDisplacement.Text.Trim()));
                    sqlCmd.Parameters.AddWithValue("@Transmission", txtTransmission.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@HorsePower", Int32.Parse(txtHorsePower.Text.Trim()));
                    sqlCmd.Parameters.AddWithValue("@Turbo", Int32.Parse(txtTurbo.Text.Trim()));
                    sqlCmd.Parameters.AddWithValue("@TopSpeed", Int32.Parse(txtTopSpeed.Text.Trim()));
                    sqlCmd.Parameters.AddWithValue("@SeatNumber", Int32.Parse(txtSeatNumber.Text.Trim()));

                    //Check if the input text is in dropdown menu or not
                    if (ddMenuManufacturer.Items.IndexOf(ddMenuManufacturer.Text) == -1)
                    {
                        //Case false：set input text as the value to parameters in Store Procedure
                        sqlCmd.Parameters.AddWithValue("@Manufacturer", ddMenuManufacturer.Text.Trim());
                    }
                    else
                    {
                        //Case True：set dropdown menu selected value as the value to parameters in Store Procedure
                        sqlCmd.Parameters.AddWithValue("@Manufacturer", ddMenuManufacturer.SelectedValue.ToString().Trim());
                    }
                    //Method Store Procedure - end

                    //Execute
                    sqlCmd.ExecuteNonQuery();

                    MessageBox.Show("Saved successfully.");
                }

                //Update mode
                else
                {
                    //Method Store Procedure - start
                    SqlCommand sqlCmd = new SqlCommand("CarAddOrEdit", sqlConn);
                    sqlCmd.CommandType = CommandType.StoredProcedure;

                    //Insert value to parameters in Store Procedure
                    sqlCmd.Parameters.AddWithValue("@mode", "Edit");
                    sqlCmd.Parameters.AddWithValue("@CID", CID);
                    sqlCmd.Parameters.AddWithValue("@CarName", txtCarName.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Country", txtCountry.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@EngineDisplacement", Int32.Parse(txtEngineDisplacement.Text.Trim()));
                    sqlCmd.Parameters.AddWithValue("@Transmission", txtTransmission.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@HorsePower", Int32.Parse(txtHorsePower.Text.Trim()));
                    sqlCmd.Parameters.AddWithValue("@Turbo", Int32.Parse(txtTurbo.Text.Trim()));
                    sqlCmd.Parameters.AddWithValue("@TopSpeed", Int32.Parse(txtTopSpeed.Text.Trim()));
                    sqlCmd.Parameters.AddWithValue("@SeatNumber", Int32.Parse(txtSeatNumber.Text.Trim()));

                    //Check if the input text is in dropdown menu or not
                    if (ddMenuManufacturer.Items.IndexOf(ddMenuManufacturer.Text) == -1)
                    {
                        //Case false：set input text as the value to parameters in Store Procedure
                        sqlCmd.Parameters.AddWithValue("@Manufacturer", ddMenuManufacturer.Text.Trim());
                    }
                    else
                    {
                        //Case True：set dropdown menu selected value as the value to parameters in Store Procedure
                        sqlCmd.Parameters.AddWithValue("@Manufacturer", ddMenuManufacturer.SelectedValue.ToString().Trim());
                    }
                    //Method Store Procedure - end

                    //Execute
                    sqlCmd.ExecuteNonQuery();

                    MessageBox.Show("Updated successfully.");
                }

                //Refresh the DataGridView
                Reset();
                FillDataGridView();
                fillManufacturerIn();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Some error occurs.");
            }
            finally
            {
                //Close the connection
                sqlConn.Close();
            }
        }

        void FillDataGridView()
        {
            //Check the connection status of sql server, if closed, open it.
            if (sqlConn.State == ConnectionState.Closed)
                sqlConn.Open();

            //Call the stored Procedure
            SqlDataAdapter sqlData = new SqlDataAdapter("select * from Car where CarName like @searchQuery + '%' or Manufacturer like @searchQuery + '%'", sqlConn);
            //sqlData.SelectCommand.CommandType = CommandType.StoredProcedure;

            //Pass the search query to Stored Procedure parameter
            sqlData.SelectCommand.Parameters.AddWithValue("@searchQuery",txtSearch.Text.Trim());

            //New a datatable
            DataTable datatb = new DataTable();

            //Assign the search result to the datatable
            sqlData.Fill(datatb);

            //Set the datasource of DataGridView to the search result
            dgvCar.DataSource = datatb;

            //Not to show the CID
            dgvCar.Columns[0].Visible = false;

            //Close the Connection
            sqlConn.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                //Read the command in Function FillDataGridView()
                FillDataGridView();
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message, "Some error occurs.");
            }
        }

        private void dgvCar_DoubleClick(object sender, EventArgs e)
        {
            //Double click the row
            if(dgvCar.CurrentRow.Index != -1)
            {
                //Save for the usage of Edit or Delete
                CID = Convert.ToInt32(dgvCar.CurrentRow.Cells[0].Value.ToString());

                //Fill the textbox with the selected cell
                txtCarName.Text = dgvCar.CurrentRow.Cells[1].Value.ToString();
                ddMenuManufacturer.SelectedItem = dgvCar.CurrentRow.Cells[2].Value.ToString();
                ddMenuManufacturer.Text = dgvCar.CurrentRow.Cells[2].Value.ToString();
                txtCountry.Text = dgvCar.CurrentRow.Cells[3].Value.ToString();
                txtEngineDisplacement.Text = dgvCar.CurrentRow.Cells[4].Value.ToString();
                txtTransmission.Text = dgvCar.CurrentRow.Cells[5].Value.ToString();
                txtHorsePower.Text = dgvCar.CurrentRow.Cells[6].Value.ToString();
                txtTurbo.Text = dgvCar.CurrentRow.Cells[7].Value.ToString();
                txtTopSpeed.Text = dgvCar.CurrentRow.Cells[8].Value.ToString();
                txtSeatNumber.Text = dgvCar.CurrentRow.Cells[9].Value.ToString();

                //Change the mode to Update
                btnSave.Text = "Update";

                //Delete button enabled
                btnDelete.Enabled = true;
                
                dgvCar.BeginEdit(true);

            }
        }

        void Reset()
        {
            //Set the textbox to "" -> Cancel the selected cell
            txtCarName.Text = txtCountry.Text
            = txtEngineDisplacement.Text = txtTransmission.Text
            = txtHorsePower.Text = txtTurbo.Text
            = txtTopSpeed.Text = txtSeatNumber.Text = "";
            ddMenuManufacturer.SelectedItem = null;
            ddMenuManufacturer.Text = "";
            //Change mode to Save
            btnSave.Text = "Save";

            //Reset the status -> nothing is selected
            CID = 0;

            //Delete button disabled
            btnDelete.Enabled = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Read the command in Function Reset()
            Reset();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //Check the connection status of sql server, if closed, open it.
                if (sqlConn.State == ConnectionState.Closed)
                    sqlConn.Open();

                //Call the Stored Procedure
                SqlCommand sqlCmd = new SqlCommand("CarDeletion", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;

                //Insert value to parameters in Stored Procedure
                sqlCmd.Parameters.AddWithValue("@CID", CID);

                //Execute
                sqlCmd.ExecuteNonQuery();

                MessageBox.Show("Deleted successfully.");

                //Refresh the DataGridView
                Reset();
                FillDataGridView();
                fillManufacturerIn();
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message, "Some error occurs.");
            }
        }

        void fillManufacturerIn()
        {
            //Check the connection status of sql server, if closed, open it.
            if (sqlConn.State == ConnectionState.Closed)
                sqlConn.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("select distinct * from Manufacturer", sqlConn);
            DataTable datatb = new DataTable();
            sqlData.Fill(datatb);
            ddMenuManufacturer.DataSource = datatb;
            ddMenuManufacturer.DisplayMember = "Manufacturer";
            ddMenuManufacturer.ValueMember = "MID";
            //ddMenuManufacturer.SelectedItem = null;
            //ddMenuManufacturer.SelectedText = "";
            sqlConn.Close();
        } //Update the item in Dropdown Menu Manufacturer

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //讓下個TextBox Focused或是按下Button
                FillDataGridView();
            }
        } //search query can submit by enter key

        void cbYesNoInit()
        {
            ArrayList data = new ArrayList();
            data.Add(new DictionaryEntry("Yes", 1));
            data.Add(new DictionaryEntry("No", 0));
            cbYesNo.DisplayMember = "Key";
            cbYesNo.ValueMember = "Value";
            cbYesNo.DataSource = data;
            cbYesNo.Text = "";
        }

        private void cbYesNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("Key：{0}\nValue：{1}", cbYesNo.Text, cbYesNo.SelectedValue));
        }
    }
}
