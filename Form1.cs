namespace PizzaAppAttempt2
{
    public partial class PizzaOrderApp : Form
    {
        // initialise prices for pizzas
        private const double MarPrice = 9.99;
        private const double PeppPrice = 10.99;
        private const double PinePrice = 11.49;
        private const double CalPrice = 11.99;

        // initialise variables for required company statistics
        private decimal AverageSale, TotalSales;
        private int TotalNumberTransactions, TotalNumberPizzasOrdered;

        // initialise varaibles for order summary
        private int OrderdedPizzas;
        private decimal OrderedPrice;

        private void SummaryButton_Click(object sender, EventArgs e)
        {

        }

        public PizzaOrderApp()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            this.DefaultPanel.Visible = false;
            this.OrderGroupBox.Visible = true;
            this.OptionsPanel.Visible = true;
            // change title of app dynamically
            this.Text = ServerTextBox.Text + " @Table Number: " + TableNumberTextBox.Text;
            MargeritaText.Focus();
        }

    }
}