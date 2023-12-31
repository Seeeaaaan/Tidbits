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
                        // Assuming you want to insert values from textboxes
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
        }

        private void Assigned_btn_Click(object sender, EventArgs e)
        {
            Home_Panel.Visible = false;
            Assigned_Panel.Visible = true;
        }

        private void Monitor_btn_Click(object sender, EventArgs e)
        {
            Home_Panel.Visible = false;
            Monitor_Panel.Visible = true;
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

        //Display End Initialize

        //Display Start Data
        private void DisplayEmployeeData()
        {
            // Clear existing rows in the DataGridView
            Employee_Table.Rows.Clear();

            string connectionString = "Server=localhost;Database=tidbitsdb;User Id=admin;Password=admin;Persist Security Info=True";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Assuming your table is named "Employee"
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

                                int consigneeId = reader.GetInt32(reader.GetOrdinal("Consignee_ID"));
                                string consigneeName = reader.GetString(reader.GetOrdinal("Name"));

                                // Add a new row to the DataGridView
                                Consignee_table.Rows.Add(consigneeId, consigneeName);
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

                // Replace "YourConnectionString" with your actual connection string
                string connectionString = "Server=localhost;Database=tidbitsdb;User Id=admin;Password=admin;Persist Security Info=True";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Delete related records in the "Assigned" table
                    string deleteAssignedQuery = "DELETE FROM Assigned WHERE Employee_ID = @EmployeeID";

                    using (MySqlCommand cmdAssigned = new MySqlCommand(deleteAssignedQuery, connection))
                    {
                        cmdAssigned.Parameters.AddWithValue("@EmployeeID", employeeIdToDelete);
                        cmdAssigned.ExecuteNonQuery();
                    }

                    string deleteMonitorQuery = "DELETE FROM Monitor WHERE Employee_ID = @EmployeeID";

                    using (MySqlCommand cmdAssignedTable = new MySqlCommand(deleteMonitorQuery, connection))
                    {
                        cmdAssignedTable.Parameters.AddWithValue("@EmployeeID", employeeIdToDelete);
                        cmdAssignedTable.ExecuteNonQuery();
                    }


                    // Now, delete the parent record in the "Employee" table
                    string deleteEmployeeQuery = "DELETE FROM Employee WHERE Employee_ID = @EmployeeID";

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

                    // Get the value from the "Employee_ID" column (assuming it's the first column)
                    int employeeIdToUpdate = Convert.ToInt32(selectedRow.Cells["Employee_ID"].Value);

                    // Replace "YourConnectionString" with your actual connection string
                    string connectionString = "Server=localhost;Database=tidbitsdb;User Id=admin;Password=admin;Persist Security Info=True";

                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        // Assuming your table is named "Employee" and columns are "Employee_ID," "Contact_Number," "Last_Name," "First_Name"
                        string updateQuery = "UPDATE Employee SET Contact_Number = @ContactNumber, Last_Name = @LastName, First_Name = @FirstName " +
                                             "WHERE Employee_ID = @EmployeeID";

                        using (MySqlCommand cmd = new MySqlCommand(updateQuery, connection))
                        {
                            // Assuming you want to update values from textboxes
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
                        // Assuming you want to insert values from textboxes
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

            if (Product_Table.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = Product_Table.SelectedRows[0];


                int ProductIdToDelete = Convert.ToInt32(selectedRow.Cells["Product_ID"].Value);


                string connectionString = "Server=localhost;Database=tidbitsdb;User Id=admin;Password=admin;Persist Security Info=True";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();


                    string deleteInventoryQuery = "DELETE FROM Inventory WHERE Product_ID = @ProductID";

                    using (MySqlCommand cmdAssigned = new MySqlCommand(deleteInventoryQuery, connection))
                    {
                        cmdAssigned.Parameters.AddWithValue("@ProductID", ProductIdToDelete);
                        cmdAssigned.ExecuteNonQuery();
                    }

                    // Delete related records in "OtherTable1"
                    string deleteConsignmentQuery = "DELETE FROM Consignment WHERE Product_ID = @ProductID";

                    using (MySqlCommand cmdOtherTable1 = new MySqlCommand(deleteConsignmentQuery, connection))
                    {
                        cmdOtherTable1.Parameters.AddWithValue("@ProductID", ProductIdToDelete);
                        cmdOtherTable1.ExecuteNonQuery();
                    }

                    string deleteProductQuery = "DELETE FROM Product WHERE Product_ID = @ProductID";

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
                            // Assuming you want to update values from textboxes
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




                    // Now, delete the parent record in the "Employee" table
                    string deleteInventoryQuery = "DELETE FROM Inventory WHERE Inventory_ID = @InventoryID";

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
            // Check if a row is selected in the DataGridView
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
                            // Assuming you want to update values from textboxes
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
            if (System.Text.RegularExpressions.Regex.IsMatch(Consignee_txt.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Consignee_txt.Text = Consignee_txt.Text.Remove(Consignee_txt.Text.Length - 1);
            }
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
            if (Consignee_table.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = Consignee_table.SelectedRows[0];


                int ConsigneeIDToDelete = Convert.ToInt32(selectedRow.Cells["Consignee_ID"].Value);


                string connectionString = "Server=localhost;Database=tidbitsdb;User Id=admin;Password=admin;Persist Security Info=True";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();


                    string deleteConsignmentQuery = "DELETE FROM Consignment WHERE Consignee_ID = @ConsigneeID";

                    using (MySqlCommand cmdConsignmentTable = new MySqlCommand(deleteConsignmentQuery, connection))
                    {
                        cmdConsignmentTable.Parameters.AddWithValue("@ConsigneeID", ConsigneeIDToDelete);
                        cmdConsignmentTable.ExecuteNonQuery();
                    }

                    string deleteConsigneeQuery = "DELETE FROM Consignee WHERE Consignee_ID = @ConsigneeID";

                    using (MySqlCommand cmdConsignee = new MySqlCommand(deleteConsigneeQuery, connection))
                    {
                        cmdConsignee.Parameters.AddWithValue("@ConsigneeID", ConsigneeIDToDelete);


                        int rowsAffected = cmdConsignee.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Consignee_table.Rows.Remove(selectedRow);

                            MessageBox.Show("Consignee and related records deleted successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete Consignee. Please try again.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void Consignee_update_btn_Click(object sender, EventArgs e)
        {
            if (Consignee_table.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = Consignee_table.SelectedRows[0];

                int consigneeIdToUpdate = Convert.ToInt32(selectedRow.Cells["Consignee_ID"].Value);

                string connectionString = "Server=localhost;Database=tidbitsdb;User Id=admin;Password=admin;Persist Security Info=True";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string updateQuery = "UPDATE Consignee SET Name = @ConsigneeName " +
                                         "WHERE Consignee_ID = @ConsigneeID";

                    using (MySqlCommand cmd = new MySqlCommand(updateQuery, connection))
                    {
                        // Assuming you want to update values from textboxes
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
    }
}
