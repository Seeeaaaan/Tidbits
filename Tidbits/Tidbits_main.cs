using MySql.Data.MySqlClient;
using System.Linq.Expressions;


namespace Tidbits
{

    public partial class Tidbits_main : Form
    {
        public Tidbits_main()
        {
            InitializeComponent();
        }

        private void Username_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee_panel.Visible = true;
            InitializeDataGridViewEmployee();
            DisplayEmployeeData();
            Home_Panel.Visible = false;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Home_Panel.Visible = false;
            Consignee_Panel.Visible = true;
            InitializeDataGridViewConsignee();
            DisplayConsigneeData();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Home_Panel.Visible = false;
            Consignment_Panel.Visible = true;
            InitializeDataGridViewConsignment();
            DisplayConsignmentData();
        }

        private void Tidbits_main_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Home_Panel.Visible = true;
            Employee_panel.Visible = false;
        }

        private void Employee_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Employee_ID_txt_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Employee_ID_txt.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Employee_ID_txt.Text = Employee_ID_txt.Text.Remove(Employee_ID_txt.Text.Length - 1);
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=tidbitsdb;User Id=admin;Password=admin;Persist Security Info=True";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO tidbitsdb.employee (Employee_ID, Contact_Number, Last_Name, First_Name) " +
                                         "VALUES (@EmployeeID, @ContactNumber, @LastName, @FirstName)";

                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@EmployeeID", Employee_ID_txt.Text);
                        cmd.Parameters.AddWithValue("@ContactNumber", Contact_Number_txt.Text);
                        cmd.Parameters.AddWithValue("@LastName", Last_Name_txt.Text);
                        cmd.Parameters.AddWithValue("@FirstName", First_Name_txt.Text);

                        // Execute the query
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Employee added successfully!");
                        DisplayEmployeeData();
                    }
                }
            }

            catch
            {
                MessageBox.Show("Error! Please make sure you enter a valid input");
            }
        }

        private void Back_btn_department_Click(object sender, EventArgs e)
        {
            Home_Panel.Visible = true;
            Department_panel.Visible = false;
        }

        private void Department_btn_Click(object sender, EventArgs e)
        {
            Department_panel.Visible = true;
            Home_Panel.Visible = false;
            InitializeDataGridViewDepartment();
            DisplayDepartmentData();
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void Product_back_btn_Click(object sender, EventArgs e)
        {
            Home_Panel.Visible = true;
            Product_panel.Visible = false;
        }

        private void Product_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Product_btn_Click(object sender, EventArgs e)
        {
            Product_panel.Visible = true;
            Home_Panel.Visible = false;
            InitializeDataGridViewProduct();
            DisplayProductData();
        }

        private void Product_panel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Back_inventory_btn_Click(object sender, EventArgs e)
        {
            Home_Panel.Visible = true;
            Inventory_Panel.Visible = false;
        }

        private void Inventory_btn_Click(object sender, EventArgs e)
        {
            Home_Panel.Visible = false;
            Inventory_Panel.Visible = true;
            InitializeDataGridViewInventory();
            DisplayInventoryData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Consignee_Panel.Visible = false;
            Home_Panel.Visible = true;
        }

        private void Consignment_back_btn_Click(object sender, EventArgs e)
        {
            Home_Panel.Visible = true;
            Consignment_Panel.Visible = false;
        }

        private void Sale_btn_Click(object sender, EventArgs e)
        {
            Home_Panel.Visible = false;
            Sale_Panel.Visible = true;
            InitializeDataGridViewSale();
            DisplaySaleData();
        }

        private void Assigned_btn_Click(object sender, EventArgs e)
        {
            Home_Panel.Visible = false;
            Assigned_Panel.Visible = true;
            InitializeDataGridViewAssigned();
            DisplayAssignedData();
        }

        private void Monitor_btn_Click(object sender, EventArgs e)
        {
            Home_Panel.Visible = false;
            Monitor_Panel.Visible = true;
            InitializeDataGridViewMonitor();
            DisplayMonitorData();
        }
        //Display Start Initialize
        private void InitializeDataGridViewEmployee()
        {
            // Clear existing columns
            Employee_Table.Columns.Clear();

            // Add columns to the DataGridView
            Employee_Table.Columns.Add("Employee_ID", "Employee ID");
            Employee_Table.Columns.Add("Contact_Number", "Contact Number");
            Employee_Table.Columns.Add("Last_Name", "Last Name");
            Employee_Table.Columns.Add("First_Name", "First Name");
        }
        private void InitializeDataGridViewDepartment()
        {
            // Clear existing columns
            Department_Table.Columns.Clear();

            // Add columns to the DataGridView
            Department_Table.Columns.Add("Department_ID", "Department ID");
            Department_Table.Columns.Add("Department_Name", "Department Name");
        }
        private void InitializeDataGridViewProduct()
        {
            // Clear existing columns
            Product_Table.Columns.Clear();

            // Add columns to the DataGridView
            Product_Table.Columns.Add("Product_ID", "Product ID");
            Product_Table.Columns.Add("Product_Name", "Product Name");
            Product_Table.Columns.Add("Price", "Price");
        }
        private void InitializeDataGridViewInventory()
        {
            // Clear existing columns
            Inventory_table.Columns.Clear();

            // Add columns to the DataGridView
            Inventory_table.Columns.Add("Inventory_ID", "Inventory ID");
            Inventory_table.Columns.Add("I_Product_ID", "Product ID");
            Inventory_table.Columns.Add("Quantity", "Quantity");
        }
        private void InitializeDataGridViewConsignee()
        {
            // Clear existing columns
            Consignee_table.Columns.Clear();

            // Add columns to the DataGridView
            Consignee_table.Columns.Add("Consignee_ID", "Consignee_ID");
            Consignee_table.Columns.Add("Consignee_Name", "Consignee_Name");
        }

        private void InitializeDataGridViewConsignment()
        {
            // Clear existing columns
            Consignment_Table.Columns.Clear();

            // Add columns to the DataGridView
            Consignment_Table.Columns.Add("Consignment_ID", "Consignment ID");
            Consignment_Table.Columns.Add("Consignee_ID", "Consignee ID");
            Consignment_Table.Columns.Add("Product_ID", "Product ID");
            Consignment_Table.Columns.Add("Resell_Price", "Resell Price");
        }

        private void InitializeDataGridViewSale()
        {
            // Clear existing columns
            Sale_Table.Columns.Clear();

            // Add columns to the DataGridView
            Sale_Table.Columns.Add("Sale_ID", "Sale ID");
            Sale_Table.Columns.Add("Consignment_ID", "Consignment ID");
            Sale_Table.Columns.Add("Sold_Quantity", "Sold Quantity");
            Sale_Table.Columns.Add("Sold_Date", "Sold Date");
        }

        private void InitializeDataGridViewAssigned()
        {
            // Clear existing columns
            Assigned_Table.Columns.Clear();

            // Add columns to the DataGridView
            Assigned_Table.Columns.Add("Employee_ID", "Employee ID");
            Assigned_Table.Columns.Add("Department_ID", "Department ID");
            Assigned_Table.Columns.Add("Position", "Position");
        }

        private void InitializeDataGridViewMonitor()
        {
            // Clear existing columns
            Monitor_Table.Columns.Clear();

            // Add columns to the DataGridView
            Monitor_Table.Columns.Add("Employee_ID", "Employee ID");
            Monitor_Table.Columns.Add("Inventory_ID", "Inventory ID");
            Monitor_Table.Columns.Add("Date", "Date");
        }

        //Display End Initialize
        //Ge kapoy nako
        //Display Start Data
        private void DisplayEmployeeData()
        {
            // Clear existing rows in the DataGridView
            Employee_Table.Rows.Clear();

            string connectionString = "Server=localhost;Database=tidbitsdb;User Id=admin;Password=admin;Persist Security Info=True";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT * FROM tidbitsdb.employee";

                using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Check if the reader has any rows
                        if (reader.HasRows)
                        {
                            // Iterate through the rows and add them to the DataGridView
                            while (reader.Read())
                            {
                                // Assuming your DataGridView columns are named "Employee_ID," "Contact_Number," "Last_Name," "First_Name"
                                int employeeId = reader.GetInt32(reader.GetOrdinal("Employee_ID"));
                                string contactNumber = reader.GetString(reader.GetOrdinal("Contact_Number"));
                                string lastName = reader.GetString(reader.GetOrdinal("Last_Name"));
                                string firstName = reader.GetString(reader.GetOrdinal("First_Name"));

                                // Add a new row to the DataGridView
                                Employee_Table.Rows.Add(employeeId, contactNumber, lastName, firstName);
                            }
                        }
                    }
                }
            }
        }
        private void DisplayDepartmentData()
        {
            // Clear existing rows in the DataGridView
            Department_Table.Rows.Clear();

            string connectionString = "Server=localhost;Database=tidbitsdb;User Id=admin;Password=admin;Persist Security Info=True";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT * FROM tidbitsdb.department";

                using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Check if the reader has any rows
                        if (reader.HasRows)
                        {
                            // Iterate through the rows and add them to the DataGridView
                            while (reader.Read())
                            {
                                int departmentid = reader.GetInt32(reader.GetOrdinal("Department_ID"));
                                string departmentname = reader.GetString(reader.GetOrdinal("Department_Name"));

                                // Add a new row to the DataGridView
                                Department_Table.Rows.Add(departmentid, departmentname);
                            }
                        }
                    }
                }
            }
        }
        private void DisplayProductData()
        {
            // Clear existing rows in the DataGridView
            Product_Table.Rows.Clear();

            string connectionString = "Server=localhost;Database=tidbitsdb;User Id=admin;Password=admin;Persist Security Info=True";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT * FROM tidbitsdb.product";

                using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Check if the reader has any rows
                        if (reader.HasRows)
                        {
                            // Iterate through the rows and add them to the DataGridView
                            while (reader.Read())
                            {
                                int productId = reader.GetInt32(reader.GetOrdinal("Product_ID"));
                                string productName = reader.GetString(reader.GetOrdinal("Product_Name"));
                                string price = reader.GetString(reader.GetOrdinal("Price"));

                                Product_Table.Rows.Add(productId, productName, price);
                            }
                        }
                    }
                }
            }
        }
        private void DisplayInventoryData()
        {
            // Clear existing rows in the DataGridView
            Inventory_table.Rows.Clear();

            string connectionString = "Server=localhost;Database=tidbitsdb;User Id=admin;Password=admin;Persist Security Info=True";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT * FROM tidbitsdb.inventory";

                using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Check if the reader has any rows
                        if (reader.HasRows)
                        {
                            // Iterate through the rows and add them to the DataGridView
                            while (reader.Read())
                            {
                                // Assuming your DataGridView columns are named "Employee_ID," "Contact_Number," "Last_Name," "First_Name"
                                int inventoryid = reader.GetInt32(reader.GetOrdinal("Inventory_ID"));
                                string iproductid = reader.GetString(reader.GetOrdinal("Product_ID"));
                                string quantity = reader.GetString(reader.GetOrdinal("Quantity"));

                                // Add a new row to the DataGridView
                                Inventory_table.Rows.Add(inventoryid, iproductid, quantity);
                            }
                        }
                    }
                }
            }
        }

        private void DisplayConsigneeData()
        {
            // Clear existing rows in the DataGridView
            Consignee_table.Rows.Clear();

            string connectionString = "Server=localhost;Database=tidbitsdb;User Id=admin;Password=admin;Persist Security Info=True";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT * FROM tidbitsdb.consignee";

                using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {

                        if (reader.HasRows)
                        {
                            // Iterate through the rows and add them to the DataGridView
                            while (reader.Read())
                            {

                                string consigneeId = reader.GetString(reader.GetOrdinal("Consignee_ID"));
                                string consigneeName = reader.GetString(reader.GetOrdinal("Name"));

                                // Add a new row to the DataGridView
                                Consignee_table.Rows.Add(consigneeId, consigneeName);
                            }
                        }
                    }
                }
            }
        }

        private void DisplayConsignmentData()
        {
            Consignment_Table.Rows.Clear();

            string connectionString = "Server=localhost;Database=tidbitsdb;User Id=admin;Password=admin;Persist Security Info=True";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT * FROM tidbitsdb.consignment";

                using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string consignmentId = reader.GetString(reader.GetOrdinal("Consignment_ID"));
                                string consigneeID = reader.GetString(reader.GetOrdinal("Consignee_ID"));
                                string productID = reader.GetString(reader.GetOrdinal("Product_ID"));
                                string resellPrice = reader.GetString(reader.GetOrdinal("Resell_Price"));

                                Consignment_Table.Rows.Add(consignmentId, consigneeID, productID, resellPrice);
                            }
                        }
                    }
                }
            }
        }

        private void DisplaySaleData()
        {
            // Clear existing rows in the DataGridView
            Sale_Table.Rows.Clear();

            string connectionString = "Server=localhost;Database=tidbitsdb;User Id=admin;Password=admin;Persist Security Info=True";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT * FROM tidbitsdb.sale";

                using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                int saleID = reader.GetInt32(reader.GetOrdinal("Sale_ID"));
                                string consignmentID = reader.GetString(reader.GetOrdinal("Consignment_ID"));
                                string soldQuantity = reader.GetString(reader.GetOrdinal("Sold_Quantity"));
                                string soldDate = reader.GetString(reader.GetOrdinal("Sold_Date"));

                                // Add a new row to the DataGridView
                                Sale_Table.Rows.Add(saleID, consignmentID, soldQuantity, soldDate);
                            }
                        }
                    }
                }
            }
        }

        private void DisplayAssignedData()
        {
            Assigned_Table.Rows.Clear();

            string connectionString = "Server=localhost;Database=tidbitsdb;User Id=admin;Password=admin;Persist Security Info=True";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT * FROM tidbitsdb.assigned";

                using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                int employeeId = reader.GetInt32(reader.GetOrdinal("Employee_ID"));
                                string departmentID = reader.GetString(reader.GetOrdinal("Department_ID"));
                                string position = reader.GetString(reader.GetOrdinal("Position"));

                                Assigned_Table.Rows.Add(employeeId, departmentID, position);
                            }
                        }
                    }
                }
            }
        }

        private void DisplayMonitorData()
        {
            Monitor_Table.Rows.Clear();

            string connectionString = "Server=localhost;Database=tidbitsdb;User Id=admin;Password=admin;Persist Security Info=True";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT * FROM tidbitsdb.monitor";

                using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                int employeeId = reader.GetInt32(reader.GetOrdinal("Employee_ID"));
                                string inventoryId = reader.GetString(reader.GetOrdinal("Inventory_ID"));
                                string date = reader.GetString(reader.GetOrdinal("Date"));

                                Monitor_Table.Rows.Add(employeeId, inventoryId, date);
                            }
                        }
                    }
                }
            }
        }
        //Display End Data

        private void Employee_Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Sale_Panel.Visible = false;
            Home_Panel.Visible = true;
        }

        private void Sale_ID_txt_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Sale_ID_txt.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Sale_ID_txt.Text = Sale_ID_txt.Text.Remove(Sale_ID_txt.Text.Length - 1);
            }
        }

        private void Assigned_Back_btn_Click(object sender, EventArgs e)
        {
            Home_Panel.Visible = true;
            Assigned_Panel.Visible = false;
        }

        private void Monitor_Back_btn_Click(object sender, EventArgs e)
        {
            Home_Panel.Visible = true;
            Monitor_Panel.Visible = false;
        }

        private void Employee_Delete_btn_Click(object sender, EventArgs e)
        {
            // Check if a row is selected in the DataGridView
            if (Employee_Table.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = Employee_Table.SelectedRows[0];

                // Get the value from the "Employee_ID" column (assuming it's the first column)
                int employeeIdToDelete = Convert.ToInt32(selectedRow.Cells["Employee_ID"].Value);

                string connectionString = "Server=localhost;Database=tidbitsdb;User Id=admin;Password=admin;Persist Security Info=True";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string deleteAssignedQuery = "DELETE FROM tidbitsdb.Assigned WHERE Employee_ID = @EmployeeID";

                    using (MySqlCommand cmdAssigned = new MySqlCommand(deleteAssignedQuery, connection))
                    {
                        cmdAssigned.Parameters.AddWithValue("@EmployeeID", employeeIdToDelete);
                        cmdAssigned.ExecuteNonQuery();
                    }

                    string deleteMonitorQuery = "DELETE FROM tidbitsdb.Monitor WHERE Employee_ID = @EmployeeID";

                    using (MySqlCommand cmdAssignedTable = new MySqlCommand(deleteMonitorQuery, connection))
                    {
                        cmdAssignedTable.Parameters.AddWithValue("@EmployeeID", employeeIdToDelete);
                        cmdAssignedTable.ExecuteNonQuery();
                    }


                    string deleteEmployeeQuery = "DELETE FROM tidbitsdb.Employee WHERE Employee_ID = @EmployeeID";

                    using (MySqlCommand cmdEmployee = new MySqlCommand(deleteEmployeeQuery, connection))
                    {
                        cmdEmployee.Parameters.AddWithValue("@EmployeeID", employeeIdToDelete);

                        // Execute the query
                        int rowsAffected = cmdEmployee.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Remove the row from the DataGridView
                            Employee_Table.Rows.Remove(selectedRow);

                            MessageBox.Show("Employee and related records deleted successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete employee. Please try again.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void Employee_Update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Employee_Table.SelectedRows.Count > 0)
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = Employee_Table.SelectedRows[0];

                    int employeeIdToUpdate = Convert.ToInt32(selectedRow.Cells["Employee_ID"].Value);

                    string connectionString = "Server=localhost;Database=tidbitsdb;User Id=admin;Password=admin;Persist Security Info=True";

                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        string updateQuery = "UPDATE Employee SET Contact_Number = @ContactNumber, Last_Name = @LastName, First_Name = @FirstName " +
                                             "WHERE Employee_ID = @EmployeeID";

                        using (MySqlCommand cmd = new MySqlCommand(updateQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@EmployeeID", employeeIdToUpdate);
                            cmd.Parameters.AddWithValue("@ContactNumber", Contact_Number_txt.Text);
                            cmd.Parameters.AddWithValue("@LastName", Last_Name_txt.Text);
                            cmd.Parameters.AddWithValue("@FirstName", First_Name_txt.Text);

                            // Execute the query
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                // Update the values in the DataGridView
                                selectedRow.Cells["Contact_Number"].Value = Contact_Number_txt.Text;
                                selectedRow.Cells["Last_Name"].Value = Last_Name_txt.Text;
                                selectedRow.Cells["First_Name"].Value = First_Name_txt.Text;

                                MessageBox.Show("Employee updated successfully!");
                            }
                            else
                            {
                                MessageBox.Show("Failed to update employee. Please try again.");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row to update.");
                }
            }

            catch
            {
                MessageBox.Show("Error! Please make sure you enter a valid input");
            }

        }

        private void Contact_Number_txt_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Sale_ID_txt.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Sale_ID_txt.Text = Sale_ID_txt.Text.Remove(Sale_ID_txt.Text.Length - 1);
            }
        }

        private void Product_Add_btn_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=tidbitsdb;User Id=admin;Password=admin;Persist Security Info=True";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO tidbitsdb.product (Product_ID, Product_Name, Price) " +
                                         "VALUES (@ProductID, @ProductName, @Price)";

                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@ProductID", Product_ID_txt.Text);
                        cmd.Parameters.AddWithValue("@ProductName", Product_Name_txt.Text);
                        cmd.Parameters.AddWithValue("@Price", Price_txt.Text);

                        // Execute the query
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Product added successfully!");
                        //DisplayProductData();
                    }
                }
            }

            catch
            {
                MessageBox.Show("Error! Please make sure you enter a valid input");
            }
            InitializeDataGridViewProduct();
            DisplayProductData();
        }

        private void Product_Delete_btn_Click(object sender, EventArgs e)
        {
            try
            {

                if (Product_Table.SelectedRows.Count > 0)
                {

                    DataGridViewRow selectedRow = Product_Table.SelectedRows[0];


                    int ProductIdToDelete = Convert.ToInt32(selectedRow.Cells["Product_ID"].Value);


                    string connectionString = "Server=localhost;Database=tidbitsdb;User Id=admin;Password=admin;Persist Security Info=True";

                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();


                        string deleteInventoryQuery = "DELETE FROM tidbitsdb.Inventory WHERE Product_ID = @ProductID";

                        using (MySqlCommand cmdAssigned = new MySqlCommand(deleteInventoryQuery, connection))
                        {
                            cmdAssigned.Parameters.AddWithValue("@ProductID", ProductIdToDelete);
                            cmdAssigned.ExecuteNonQuery();
                        }

                        string deleteConsignmentQuery = "DELETE FROM tidbitsdb.Consignment WHERE Product_ID = @ProductID";

                        using (MySqlCommand cmdOtherTable1 = new MySqlCommand(deleteConsignmentQuery, connection))
                        {
                            cmdOtherTable1.Parameters.AddWithValue("@ProductID", ProductIdToDelete);
                            cmdOtherTable1.ExecuteNonQuery();
                        }

                        string deleteProductQuery = "DELETE FROM tidbitsdb.Product WHERE Product_ID = @ProductID";

                        using (MySqlCommand cmdProduct = new MySqlCommand(deleteProductQuery, connection))
                        {
                            cmdProduct.Parameters.AddWithValue("@ProductID", ProductIdToDelete);

                            // Execute the query
                            int rowsAffected = cmdProduct.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                // Remove the row from the DataGridView
                                Product_Table.Rows.Remove(selectedRow);

                                MessageBox.Show("Product and related records deleted successfully!");
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete Product. Please try again.");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row to delete.");
                }
            }

            catch
            {
                MessageBox.Show("Error! the data in relation to Consignment is being used in 'Sale' please delete it from their first.");
            }
        }

        private void Product_ID_txt_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Product_ID_txt.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Product_ID_txt.Text = Product_ID_txt.Text.Remove(Product_ID_txt.Text.Length - 1);
            }
        }

        private void Product_Update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Product_Table.SelectedRows.Count > 0)
                {

                    DataGridViewRow selectedRow = Product_Table.SelectedRows[0];


                    int productIdToUpdate = Convert.ToInt32(selectedRow.Cells["Product_ID"].Value);

                    string connectionString = "Server=localhost;Database=tidbitsdb;User Id=admin;Password=admin;Persist Security Info=True";

                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        string updateQuery = "UPDATE Product SET Product_Name = @ProductName, Price = @Price " +
                                             "WHERE Product_ID = @ProductID";

                        using (MySqlCommand cmd = new MySqlCommand(updateQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@ProductID", productIdToUpdate);
                            cmd.Parameters.AddWithValue("@ProductName", Product_Name_txt.Text);
                            cmd.Parameters.AddWithValue("@Price", Price_txt.Text);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                // Update the values in the DataGridView
                                selectedRow.Cells["Product_Name"].Value = Product_Name_txt.Text;
                                selectedRow.Cells["Price"].Value = Price_txt.Text;

                                MessageBox.Show("Product updated successfully!");
                            }
                            else
                            {
                                MessageBox.Show("Failed to update Product. Please try again.");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row to update.");
                }
            }
            catch
            {
                MessageBox.Show("Error! Please make sure you enter a valid input");
            }
        }

        private void Price_txt_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Price_txt.Text, "[^0-9.]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Price_txt.Text = Price_txt.Text.Remove(Price_txt.Text.Length - 1);
            }
        }

        private void Inventory_ID_txt_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Inventory_ID_txt.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Inventory_ID_txt.Text = Inventory_ID_txt.Text.Remove(Inventory_ID_txt.Text.Length - 1);
            }
        }

        private void I_Product_ID_txt_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(I_Product_ID_txt.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                I_Product_ID_txt.Text = I_Product_ID_txt.Text.Remove(I_Product_ID_txt.Text.Length - 1);
            }
        }

        private void Quantity_txt_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Quantity_txt.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Quantity_txt.Text = Quantity_txt.Text.Remove(Quantity_txt.Text.Length - 1);
            }
        }

        private void Inventory_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Inventory_add_btn_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=tidbitsdb;User Id=admin;Password=admin;Persist Security Info=True";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO tidbitsdb.inventory (Inventory_ID, Product_ID, Quantity) " +
                                         "VALUES (@InventoryID, @ProductID, @Quantity)";

                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, connection))
                    {

                        cmd.Parameters.AddWithValue("@InventoryID", Inventory_ID_txt.Text);
                        cmd.Parameters.AddWithValue("@ProductID", I_Product_ID_txt.Text);
                        cmd.Parameters.AddWithValue("@Quantity", Quantity_txt.Text);

                        // Execute the query
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Inventory added successfully!");
                    }
                }
                InitializeDataGridViewInventory();
                DisplayInventoryData();
            }

            catch
            {
                MessageBox.Show("Error! Please make sure you enter a valid input");
            }
        }

        private void Inventory_Delete_btn_Click(object sender, EventArgs e)
        {
            if (Inventory_table.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = Inventory_table.SelectedRows[0];


                int inventoryIdToDelete = Convert.ToInt32(selectedRow.Cells["Inventory_ID"].Value);


                string connectionString = "Server=localhost;Database=tidbitsdb;User Id=admin;Password=admin;Persist Security Info=True";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();




                    string deleteInventoryQuery = "DELETE FROM tidbitsdb.Inventory WHERE Inventory_ID = @InventoryID";

                    using (MySqlCommand cmdInventory = new MySqlCommand(deleteInventoryQuery, connection))
                    {
                        cmdInventory.Parameters.AddWithValue("@InventoryID", inventoryIdToDelete);

                        // Execute the query
                        int rowsAffected = cmdInventory.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Remove the row from the DataGridView
                            Inventory_table.Rows.Remove(selectedRow);

                            MessageBox.Show("Inventory and related records deleted successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete inventory. Please try again.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void Inventory_Update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Inventory_table.SelectedRows.Count > 0)
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = Inventory_table.SelectedRows[0];


                    int inventoryIdToUpdate = Convert.ToInt32(selectedRow.Cells["Inventory_ID"].Value);

                    string connectionString = "Server=localhost;Database=tidbitsdb;User Id=admin;Password=admin;Persist Security Info=True";

                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        string updateQuery = "UPDATE Inventory SET Product_ID = @Productid, Quantity = @Quantity " +
                                             "WHERE Inventory_ID = @InventoryID";

                        using (MySqlCommand cmd = new MySqlCommand(updateQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@InventoryID", inventoryIdToUpdate);
                            cmd.Parameters.AddWithValue("@ProductID", I_Product_ID_txt.Text);
                            cmd.Parameters.AddWithValue("@Quantity", Quantity_txt.Text);

                            // Execute the query
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                // Update the values in the DataGridView
                                selectedRow.Cells["I_Product_ID"].Value = I_Product_ID_txt.Text;
                                selectedRow.Cells["Quantity"].Value = Quantity_txt.Text;

                                MessageBox.Show("Inventory updated successfully!");
                            }
                            else
                            {
                                MessageBox.Show("Failed to update employee. Please try again.");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row to update.");
                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid input");
            }
        }

        private void Consignee_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Consignee_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Consignee_add_btn_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=tidbitsdb;User Id=admin;Password=admin;Persist Security Info=True";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO tidbitsdb.consignee (Consignee_ID, Name ) " +
                                         "VALUES (@ConsigneeID, @ConsigneeName)";

                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, connection))
                    {

                        cmd.Parameters.AddWithValue("@ConsigneeID", Consignee_txt.Text);
                        cmd.Parameters.AddWithValue("@ConsigneeName", Consignee_Name_txt.Text);

                        // Execute the query
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Consignee added successfully!");
                        DisplayConsigneeData();
                    }
                }
            }

            catch
            {
                MessageBox.Show("Error! Please make sure you enter a valid input");
            }
        }

        private void Consignee_Delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Consignee_table.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = Consignee_table.SelectedRows[0];

                    string ConsigneeIDToDelete = selectedRow.Cells["Consignee_ID"].Value.ToString();

                    string connectionString = "Server=localhost;Database=tidbitsdb;User Id=admin;Password=admin;Persist Security Info=True";

                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        string deleteQuery = "DELETE FROM tidbitsdb.consignee WHERE Consignee_ID = @ConsigneeID";

                        using (MySqlCommand cmd = new MySqlCommand(deleteQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@ConsigneeID", ConsigneeIDToDelete);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                Consignee_table.Rows.Remove(selectedRow);

                                MessageBox.Show("Consignee deleted successfully!");
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete consignee. Please try again.");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row to delete.");
                }
            }
            catch
            {
                MessageBox.Show("Error! Current data is being used in 'Consignment' please delete it from their first.");
            }
        }

        private void Consignee_update_btn_Click(object sender, EventArgs e)
        {
            if (Consignee_table.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = Consignee_table.SelectedRows[0];

                string consigneeIdToUpdate = selectedRow.Cells["Consignee_ID"].Value.ToString();

                string connectionString = "Server=localhost;Database=tidbitsdb;User Id=admin;Password=admin;Persist Security Info=True";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string updateQuery = "UPDATE tidbitsdb.consignee SET Name = @ConsigneeName " +
                                         "WHERE Consignee_ID = @ConsigneeID";

                    using (MySqlCommand cmd = new MySqlCommand(updateQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@ConsigneeID", consigneeIdToUpdate);
                        cmd.Parameters.AddWithValue("@ConsigneeName", Consignee_Name_txt.Text);

                        // Execute the query
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Update the values in the DataGridView
                            selectedRow.Cells["Consignee_Name"].Value = Consignee_Name_txt.Text;

                            MessageBox.Show("Consignee updated successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Failed to update Consignee. Please try again.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }

        private void C_Product_ID_txt_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(C_Product_ID_txt.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                C_Product_ID_txt.Text = C_Product_ID_txt.Text.Remove(C_Product_ID_txt.Text.Length - 1);
            }
        }

        private void Resell_Price_txt_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Resell_Price_txt.Text, "[^0-9.]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Resell_Price_txt.Text = Resell_Price_txt.Text.Remove(Resell_Price_txt.Text.Length - 1);
            }
        }

        private void Consignment_Add_btn_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=tidbitsdb;User Id=admin;Password=admin;Persist Security Info=True";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO tidbitsdb.consignment (Consignment_ID, Consignee_ID, Product_ID, Resell_Price) " +
                                         "VALUES (@ConsignmentID, @ConsigneeID, @ProductID, @ResellPrice)";

                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, connection))
                    {

                        cmd.Parameters.AddWithValue("@ConsignmentID", Consignment_ID_txt.Text);
                        cmd.Parameters.AddWithValue("@ConsigneeID", C_Consignee_ID_txt.Text);
                        cmd.Parameters.AddWithValue("@ProductID", C_Product_ID_txt.Text);
                        cmd.Parameters.AddWithValue("@ResellPrice", Resell_Price_txt.Text);

                        // Execute the query
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Consignment added successfully!");
                        DisplayConsignmentData();
                    }
                }
            }

            catch
            {
                MessageBox.Show("Error! Please make sure you enter a valid input");
            }
        }

        private void Consignment_Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Consignment_Delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Consignment_Table.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = Consignment_Table.SelectedRows[0];

                    string consignmentIDToDelete = selectedRow.Cells["Consignment_ID"].Value.ToString();

                    string connectionString = "Server=localhost;Database=tidbitsdb;User Id=admin;Password=admin;Persist Security Info=True";

                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        string deleteQuery = "DELETE FROM tidbitsdb.consignment WHERE Consignment_ID = @ConsignmentID";

                        using (MySqlCommand cmd = new MySqlCommand(deleteQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@ConsignmentID", consignmentIDToDelete);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                Consignment_Table.Rows.Remove(selectedRow);

                                MessageBox.Show("Consignment deleted successfully!");
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete consignment. Please try again.");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row to delete.");
                }
            }
            catch
            {
                MessageBox.Show("Error! Current data is being used in 'Sale' please delete it from their first.");
            }
        }

        private void Sale_Add_btn_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=tidbitsdb;User Id=admin;Password=admin;Persist Security Info=True";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO tidbitsdb.sale (Sale_ID, Consignment_ID, Sold_Quantity, Sold_Date ) " +
                                         "VALUES (@SaleID, @ConsignmentID, @SoldQuantity, @SoldDate)";

                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, connection))
                    {

                        cmd.Parameters.AddWithValue("@SaleID", Sale_ID_txt.Text);
                        cmd.Parameters.AddWithValue("@ConsignmentID", S_Consignment_ID_txt.Text);
                        cmd.Parameters.AddWithValue("@SoldQuantity", Sold_Quantity_txt.Text);
                        cmd.Parameters.AddWithValue("@SoldDate", Sold_Date_txt.Text);

                        // Execute the query
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Sale added successfully!");
                        DisplaySaleData();
                    }
                }
            }

            catch
            {
                MessageBox.Show("Error! Please make sure you enter a valid input");
            }
        }

        private void Sale_Delete_btn_Click(object sender, EventArgs e)
        {
            if (Sale_Table.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = Sale_Table.SelectedRows[0];


                int saleIdToDelete = Convert.ToInt32(selectedRow.Cells["Sale_ID"].Value);


                string connectionString = "Server=localhost;Database=tidbitsdb;User Id=admin;Password=admin;Persist Security Info=True";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();


                    string deleteSaleQuery = "DELETE FROM tidbitsdb.sale WHERE Sale_ID = @SaleID";

                    using (MySqlCommand cmdSale = new MySqlCommand(deleteSaleQuery, connection))
                    {
                        cmdSale.Parameters.AddWithValue("@SaleID", saleIdToDelete);

                        // Execute the query
                        int rowsAffected = cmdSale.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Remove the row from the DataGridView
                            Sale_Table.Rows.Remove(selectedRow);

                            MessageBox.Show("Sale deleted successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete employee. Please try again.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void A_Employee_ID_txt_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(A_Employee_ID_txt.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                A_Employee_ID_txt.Text = A_Employee_ID_txt.Text.Remove(A_Employee_ID_txt.Text.Length - 1);
            }
        }

        private void A_Department_ID_txt_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(A_Department_ID_txt.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                A_Department_ID_txt.Text = A_Department_ID_txt.Text.Remove(A_Department_ID_txt.Text.Length - 1);
            }
        }

        private void Sold_Quantity_txt_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Sold_Quantity_txt.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Sold_Quantity_txt.Text = Sold_Quantity_txt.Text.Remove(Sold_Quantity_txt.Text.Length - 1);
            }
        }

        private void Asssigned_Add_btn_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=tidbitsdb;User Id=admin;Password=admin;Persist Security Info=True";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO tidbitsdb.assigned (Employee_ID, Department_ID, Position ) " +
                                         "VALUES (@EmployeeID, @DepartmentID, @Position )";

                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, connection))
                    {

                        cmd.Parameters.AddWithValue("@EmployeeID", A_Employee_ID_txt.Text);
                        cmd.Parameters.AddWithValue("@DepartmentID", A_Department_ID_txt.Text);
                        cmd.Parameters.AddWithValue("@Position", Position_txt.Text);

                        // Execute the query
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Assigned added successfully!");
                        DisplayAssignedData();
                    }
                }
            }

            catch
            {
                MessageBox.Show("Error! Please make sure you enter a valid input");
            }
        }

        private void Assigned_Delete_btn_Click(object sender, EventArgs e)
        {
            if (Assigned_Table.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = Assigned_Table.SelectedRows[0];


                int employeeIdToDelete = Convert.ToInt32(selectedRow.Cells["Employee_ID"].Value);


                string connectionString = "Server=localhost;Database=tidbitsdb;User Id=admin;Password=admin;Persist Security Info=True";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string deleteEmployeeQuery = "DELETE FROM tidbitsdb.assigned WHERE Employee_ID = @EmployeeID";

                    using (MySqlCommand cmdEmployee = new MySqlCommand(deleteEmployeeQuery, connection))
                    {
                        cmdEmployee.Parameters.AddWithValue("@EmployeeID", employeeIdToDelete);

                        // Execute the query
                        int rowsAffected = cmdEmployee.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Remove the row from the DataGridView
                            Assigned_Table.Rows.Remove(selectedRow);

                            MessageBox.Show("Assigned deleted successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete assigned. Please try again.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void Assigned_Update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Assigned_Table.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = Assigned_Table.SelectedRows[0];

                    int employeeIdToUpdate = Convert.ToInt32(selectedRow.Cells["Employee_ID"].Value);

                    string connectionString = "Server=localhost;Database=tidbitsdb;User Id=admin;Password=admin;Persist Security Info=True";

                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        string updateQuery = "UPDATE tidbitsdb.assigned SET Department_ID = @DepartmentID, Position = @Position " +
                                             "WHERE Employee_ID = @EmployeeID";

                        using (MySqlCommand cmd = new MySqlCommand(updateQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@EmployeeID", employeeIdToUpdate);
                            cmd.Parameters.AddWithValue("@DepartmentID", A_Department_ID_txt.Text);
                            cmd.Parameters.AddWithValue("@Position", Position_txt.Text);

                            // Execute the query
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                // Update the values in the DataGridView
                                selectedRow.Cells["Department_ID"].Value = A_Department_ID_txt.Text;
                                selectedRow.Cells["Position"].Value = Position_txt.Text;

                                MessageBox.Show("Assigned updated successfully!");
                            }
                            else
                            {
                                MessageBox.Show("Failed to update assigned employee. Please try again.");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row to update.");
                }
            }
            catch
            {
                MessageBox.Show("Error! Please make sure you enter a valid input");
            }
        }

        private void M_Employee_ID_txt_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(M_Employee_ID_txt.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                M_Employee_ID_txt.Text = M_Employee_ID_txt.Text.Remove(M_Employee_ID_txt.Text.Length - 1);
            }
        }

        private void M_Inventory_ID_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(M_Inventory_ID.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                M_Inventory_ID.Text = M_Inventory_ID.Text.Remove(M_Inventory_ID.Text.Length - 1);
            }
        }

        private void Monitor_Add_btn_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=tidbitsdb;User Id=admin;Password=admin;Persist Security Info=True";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO tidbitsdb.monitor (Employee_ID, Inventory_ID, Date ) " +
                                         "VALUES (@EmployeeID, @InventoryID, @Date )";

                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, connection))
                    {

                        cmd.Parameters.AddWithValue("@EmployeeID", M_Employee_ID_txt.Text);
                        cmd.Parameters.AddWithValue("@InventoryID", M_Inventory_ID.Text);
                        cmd.Parameters.AddWithValue("@Date", Date_txt.Text);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Monitor added successfully!");
                        DisplayMonitorData();
                    }
                }
            }

            catch
            {
                MessageBox.Show("Error! Please make sure you enter a valid input");
            }
        }

        private void Monitor_Delte_btn_Click(object sender, EventArgs e)
        {
            if (Monitor_Table.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = Monitor_Table.SelectedRows[0];


                int employeeIdToDelete = Convert.ToInt32(selectedRow.Cells["Employee_ID"].Value);


                string connectionString = "Server=localhost;Database=tidbitsdb;User Id=admin;Password=admin;Persist Security Info=True";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string deleteEmployeeQuery = "DELETE FROM tidbitsdb.monitor WHERE Employee_ID = @EmployeeID";

                    using (MySqlCommand cmdEmployee = new MySqlCommand(deleteEmployeeQuery, connection))
                    {
                        cmdEmployee.Parameters.AddWithValue("@EmployeeID", employeeIdToDelete);

                        // Execute the query
                        int rowsAffected = cmdEmployee.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Remove the row from the DataGridView
                            Monitor_Table.Rows.Remove(selectedRow);

                            MessageBox.Show("Monitor deleted successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete monitor. Please try again.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void Monitor_Update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Monitor_Table.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = Monitor_Table.SelectedRows[0];

                    int employeeIdToUpdate = Convert.ToInt32(selectedRow.Cells["Employee_ID"].Value);

                    string connectionString = "Server=localhost;Database=tidbitsdb;User Id=admin;Password=admin;Persist Security Info=True";

                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        string updateQuery = "UPDATE tidbitsdb.monitor SET Inventory_ID = @InventoryID, Date = @Date " +
                                             "WHERE Employee_ID = @EmployeeID";

                        using (MySqlCommand cmd = new MySqlCommand(updateQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@EmployeeID", employeeIdToUpdate);
                            cmd.Parameters.AddWithValue("@InventoryID", M_Inventory_ID.Text);
                            cmd.Parameters.AddWithValue("@Date", Date_txt.Text);

                            // Execute the query
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                // Update the values in the DataGridView
                                selectedRow.Cells["Inventory_ID"].Value = M_Inventory_ID.Text;
                                selectedRow.Cells["Date"].Value = Date_txt.Text;

                                MessageBox.Show("Monitor updated successfully!");
                            }
                            else
                            {
                                MessageBox.Show("Failed to update monitor. Please try again.");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row to update.");
                }
            }

            catch
            {
                MessageBox.Show("Error! Please make sure you enter a valid input");
            }
        }

        private void Sale_Panel_Paint(object sender, PaintEventArgs e)
        {


        }
    }
}
