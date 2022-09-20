namespace PizzaAppAttempt2
{
    public partial class PizzaOrderApp : Form
    {
        // initialise prices for pizzas
        private const double MarPrice = 9.99;
        private const double PeppPrice = 10.99;
        private const double PinePrice = 11.49;
        private const double CalPrice = 12.49;

        // initialise variables for required company statistics
        private decimal AverageSale, TotalSales;
        private int TotalNumberTransactions, TotalNumberPizzasOrdered;

        // initialise varaibles for order summary
        private int OrderdedPizzas;
        private decimal OrderedPrice;


        public PizzaOrderApp()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            // add checks to ensure server names and table numbers inputted correctly.
            // from a business perspective we would not know who is taking orders
            // at specific tables if these are not filled out on the application.
            if(ServerTextBox.Text.Length < 1)
            {
                MessageBox.Show("Please Input Server Name." +
                                        "\nEmpty string for server name.", "Invalid Input",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int TableNo = int.Parse(TableNumberTextBox.Text);
                    this.DefaultPanel.Visible = false;
                    this.OrderGroupBox.Visible = true;
                    this.OptionsPanel.Visible = true;
                    // change title of app dynamically
                    this.Text = ServerTextBox.Text + " @Table Number: " + TableNo.ToString();
                    MargeritaText.Focus();
                }
                catch
                {
                    MessageBox.Show("Please Input Valid Table Number." +
                                            "\nIncorrect type for table number.", "Invalid Input",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
  
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            try
            {
                int MargeritaTotal = int.Parse(MargeritaText.Text);
            }
            catch
            {
                MessageBox.Show("Expecting numeric values." +
                                        "\nInvalid value type for inputted Margerita quantities.", "Invalid Input",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                MargeritaText.Focus();
            }
            try
            {
                int PepperoniTotal = int.Parse(PepperoniText.Text);
            }
            catch
            {
                MessageBox.Show("Expecting numeric values." +
                                        "\nInvalid value type for inputted Pepperoni quantities.", "Invalid Input",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                PepperoniText.Focus();
            }

            try
            {
                int PineappleTotal = int.Parse(PineappleText.Text);
            }
            catch
            {
                MessageBox.Show("Expecting numeric values." +
                                        "\nInvalid value type for inputted Pineapple quantities.", "Invalid Input",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                PineappleText.Focus();
            }

            try
            {
                int CalzoniTotal = int.Parse(CalzoniText.Text);
            }
            catch
            {
                MessageBox.Show("Expecting numeric values." +
                                        "\nInvalid value type for inputted Calzoni quantities.", "Invalid Input",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                CalzoniText.Focus();
            }

            this.Text = "Table Summary";
            this.OrderSummaryGroupBox.Visible = true;

            

            //this.ServerTextOrderSummary = this.ServerTextBox.Text;
        }

    }
}