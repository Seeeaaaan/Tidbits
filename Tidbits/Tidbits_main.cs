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
