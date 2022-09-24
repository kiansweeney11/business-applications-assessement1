// Name: Kian Sweeney
// ID: 22220670
// MS806 Assignment 1
// Due Date: 30/9/22
// Simple Table Order App
// Create a well-designed application that allows “PizzaBothán” staff
// to take table orders from customers.
namespace PizzaAppAttempt2
{
    public partial class PizzaOrderApp : Form
    {
        // initialise prices for pizzas
        // const as these will not change
        private const decimal MarPrice = 9.99m;
        private const decimal PeppPrice = 10.99m;
        private const decimal PinePrice = 11.49m;
        private const decimal CalPrice = 12.49m;

        // initialise variables for required company statistics
        private decimal AverageSale, TotalSales;
        private int TotalNumberTransactions, TotalNumberPizzasOrdered;

        // initialise varaibles for order summary
        private int OrderdedPizzas, CurrentServerOrderTotal;
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
                    this.StarterPictureBox.Visible = false;
                    this.OrderGroupBox.Visible = true;
                    this.OptionsPanel.Visible = true;
                    // change title of app dynamically
                    this.Text = ServerTextBox.Text + " @Table Number: " + TableNo.ToString();
                    MargeritaText.Text = "0";
                    PepperoniText.Text = "0";
                    PineappleText.Text = "0";
                    CalzoniText.Text = "0";
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
            // need to nest try/catch statements
            // if we leave them just in a line this would work
            // but this would go through each indivdual error
            // instead we want it to stop at first error only as per design outline
            // also need to do this as if we have 3 valid values lets say that are ordered
            // and one incorrectly inputted value we can't just add the totals of the valid inputs
            // as the total order isnt valid. this is also where nesting the try statements comes
            // in handy
            this.OrderSummaryGroupBox.Visible = true;
            // setting these visibility settings here in case someone orders, then checks
            // total company transactions then goes back to hit order again.
            this.CompanySummaryGroupBox.Visible = false;
            try
            {
                int MargeritaTotal = int.Parse(MargeritaText.Text);
                try
                {
                    int PepperoniTotal = int.Parse(PepperoniText.Text);
                    try
                    {
                        int PineappleTotal = int.Parse(PineappleText.Text);
                        try
                        {
                            int CalzoniTotal = int.Parse(CalzoniText.Text);

                            OrderdedPizzas = MargeritaTotal + PepperoniTotal + CalzoniTotal +
                                PineappleTotal;

                            // had an issue that if one server had two tranasctions
                            // that ordered 1 pizza then 2 pizzas the total would appear as 4 for example
                            // this variable is used to deal exclusively with a server's pizza
                            // count. this is reset in the clear button then
                            CurrentServerOrderTotal += OrderdedPizzas;

                            TableReceipts = MarPrice * MargeritaTotal + PeppPrice * PepperoniTotal +
                                PinePrice * PineappleTotal + CalPrice * CalzoniTotal;
                            // transaction successfully completed, add 1
                            TotalNumberTransactions += 1;
                            // add sale value to total company sales from this transaction
                            TotalSales += TableReceipts;
                            // finally, add total number of pizzas sold from this transaction
                            TotalNumberPizzasOrdered += OrderdedPizzas;
                            this.Text = "Table Summary";
                            this.OrderSummaryGroupBox.Visible = true;
                            ServerTextOrderSummary.Text = ServerTextBox.Text;
                            OrderSummaryPizzas.Text = CurrentServerOrderTotal.ToString();
                            ReceiptsOrderSummary.Text = "€" + TotalSales.ToString();
                        }
                        catch
                        {
                            MessageBox.Show("Expecting numeric values." +
                                                    "\nInvalid value type for inputted Calzoni quantities.", "Invalid Input",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            CalzoniText.Focus();
                            CalzoniText.SelectAll();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Expecting numeric values." +
                                                "\nInvalid value type for inputted Pineapple quantities.", "Invalid Input",
                                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        PineappleText.Focus();
                        PineappleText.SelectAll();
                    }
                }
                catch
                {
                    MessageBox.Show("Expecting numeric values." +
                                            "\nInvalid value type for inputted Pepperoni quantities.", "Invalid Input",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    PepperoniText.Focus();
                    PepperoniText.SelectAll();
                }
            }
            catch
            {
                MessageBox.Show("Expecting numeric values." +
                                        "\nInvalid value type for inputted Margerita quantities.", "Invalid Input",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                MargeritaText.Focus();
                MargeritaText.SelectAll();
            }
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            // reset values back to zero on order panel and pizza quantity panel when
            // clear button is selected
            // also make order/company summary groupbox's invisible (for if they are currently present)
            //OrderSummaryPizzas.Text = "0";
            //ReceiptsOrderSummary.Text = "€0.00";
            MargeritaText.Text = "0";
            PepperoniText.Text = "0";
            PineappleText.Text = "0";
            CalzoniText.Text = "0";
            TableReceipts = 0.00m;
            OrderdedPizzas = 0;
            CurrentServerOrderTotal = 0;
            this.OrderSummaryGroupBox.Visible = false;
            this.CompanySummaryGroupBox.Visible = false;
            this.OrderGroupBox.Visible = false;
            this.OptionsPanel.Visible = false;
            this.PictureBoxMainMenu.Visible = false;
            this.StarterPictureBox.Visible = true;
            this.DefaultPanel.Visible = true;
            this.ServerTextBox.Text = "";
            this.TableNumberTextBox.Text = "";
        }
        // summary button clicked function
        private void SummaryButton_Click(object sender, EventArgs e)
        {
            // as per specifications -> "If the user presses the Summary button,
            // the application (if at least one transaction has taken place
            // prior to being pressed) displays the total number of transactions" and so forth
            // if statement to handle if there has been transactions or not
            if (TotalNumberTransactions > 0)
            {
                this.CompanySummaryGroupBox.Visible = true;
                AverageSale = TotalSales / TotalNumberTransactions;
                this.AverageTransactionText.Text = "€" + AverageSale.ToString("0.00");
                this.TotalCompanyTransactionsText.Text = TotalNumberTransactions.ToString();
                this.TotalPizzaOrderedTextBox.Text = TotalNumberPizzasOrdered.ToString();
                this.TotalCompanyReceiptsTextBox.Text = "€" + TotalSales.ToString();
            }
            else
            {
                MessageBox.Show("No Transactions Present on The System.", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }
// more user friendly functions for orders
// when text box is clicked all text present is selected making it easier to remove for new orders
        private void MargeritaText_TextChanged(object sender, EventArgs e)
        {
            this.MargeritaText.Focus();
        }
        private void PineappleText_TextChanged(object sender, EventArgs e)
        {
            this.PineappleText.Focus();
        }
        private void CalzoniText_TextChanged(object sender, EventArgs e)
        {
            this.CalzoniText.Focus();
        }
        private void PepperoniText_TextChanged(object sender, EventArgs e)
        {
            this.PepperoniText.Focus();
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}