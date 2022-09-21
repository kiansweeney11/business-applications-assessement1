namespace PizzaAppAttempt2
{
    public partial class PizzaOrderApp : Form
    {
        // initialise prices for pizzas
        private const decimal MarPrice = 9.99m;
        private const decimal PeppPrice = 10.99m;
        private const decimal PinePrice = 11.49m;
        private const decimal CalPrice = 12.49m;

        // initialise variables for required company statistics
        private decimal AverageSale, TotalSales;
        private int TotalNumberTransactions, TotalNumberPizzasOrdered;

        // initialise varaibles for order summary
        private int OrderdedPizzas;
        private decimal TableReceipts;

        public PizzaOrderApp()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            // add checks to ensure server names and table numbers inputted correctly.
            // from a business perspective we would not know who is taking orders
            // at specific tables if these are not filled out on the application.
            // we also want consistency in our table numbers. we do not want one server
            // labelling a table as "ten" and another as 10. these would be treated differently
            // then which do not want.
            if (ServerTextBox.Text.Length < 1)
            {
                MessageBox.Show("Please Input Server Name." +
                                        "\nEmpty string for server name.", "Invalid Input",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            // else statement to make sure main screen does not load without a name inputted
            {
                try
                {
                    int TableNo = int.Parse(TableNumberTextBox.Text);
                    this.DefaultPanel.Visible = false;
                    this.OrderGroupBox.Visible = true;
                    this.OptionsPanel.Visible = true;
                    // change title of app dynamically
                    this.Text = ServerTextBox.Text + " @Table Number: " + TableNo.ToString();
                    MargeritaText.Text = "0";
                    PepperoniText.Text = "0";
                    PineappleText.Text = "0";
                    CalzoniText.Text = "0";
                    this.PictureBoxStartMenu.Visible = false;
                    this.PictureBoxMainMenu.Visible = true;
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
                OrderdedPizzas += MargeritaTotal;
                TableReceipts += MargeritaTotal * MarPrice;
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
                OrderdedPizzas += PepperoniTotal;
                TableReceipts += PepperoniTotal * PeppPrice;
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
                OrderdedPizzas += PineappleTotal;
                TableReceipts += PineappleTotal * PinePrice;
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
                OrderdedPizzas += CalzoniTotal;
                TableReceipts += CalzoniTotal * CalPrice;
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
            ServerTextOrderSummary.Text = ServerTextBox.Text;
            OrderSummaryPizzas.Text = OrderdedPizzas.ToString();
            ReceiptsOrderSummary.Text = "€" + TableReceipts.ToString();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            OrderSummaryPizzas.Text = "0";
            ReceiptsOrderSummary.Text = "€0.00";
            MargeritaText.Text = "0";
            PepperoniText.Text = "0";
            PineappleText.Text = "0";
            CalzoniText.Text = "0";
            TableReceipts = 0.00m;
            OrderdedPizzas = 0;
        }

        private void SummaryButton_Click(object sender, EventArgs e)
        {
            this.OrderSummaryGroupBox.Visible = false;
            this.CompanySummaryGroupBox.Visible = true;

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}