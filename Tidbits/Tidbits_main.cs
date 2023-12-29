using MySql.Data.MySqlClient;


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
            InitializeDataGridView();
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

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=tidbitsdb;User Id=admin;Password=admin;Persist Security Info=True";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Assuming your table is named "Employee" and columns are "Employee_ID," "Contact_Number," "Last_Name," "First_Name"
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

                    // You can add additional logic here, like clearing textboxes or updating the UI
                    MessageBox.Show("Employee added successfully!");
                }
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
        private void InitializeDataGridView()
        {
            // Clear existing columns
            Employee_Table.Columns.Clear();

            // Add columns to the DataGridView
            Employee_Table.Columns.Add("Employee_ID", "Employee ID");
            Employee_Table.Columns.Add("Contact_Number", "Contact Number");
            Employee_Table.Columns.Add("Last_Name", "Last Name");
            Employee_Table.Columns.Add("First_Name", "First Name");
        }
        private void DisplayEmployeeData()
        {
            // Clear existing rows in the DataGridView
            Employee_Table.Rows.Clear();

            string connectionString = "Server=localhost;Database=tidbitsdb;User Id=admin;Password=admin;Persist Security Info=True"; // Replace with your actual connection string

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

    }
}
