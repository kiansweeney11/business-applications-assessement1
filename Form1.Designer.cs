namespace PizzaAppAttempt2
{
    partial class PizzaOrderApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PizzaOrderApp));
            this.DefaultPanel = new System.Windows.Forms.Panel();
            this.StartButton = new System.Windows.Forms.Button();
            this.TableNumberTextBox = new System.Windows.Forms.TextBox();
            this.TableNumberLabel = new System.Windows.Forms.Label();
            this.ServerTextBox = new System.Windows.Forms.TextBox();
            this.ServerLabel = new System.Windows.Forms.Label();
            this.OrderGroupBox = new System.Windows.Forms.GroupBox();
            this.CalzoniLabelPrice = new System.Windows.Forms.Label();
            this.PineappleLabelPrice = new System.Windows.Forms.Label();
            this.PepperoniPriceLabel = new System.Windows.Forms.Label();
            this.MargeritaPriceLabel = new System.Windows.Forms.Label();
            this.CalzoniText = new System.Windows.Forms.TextBox();
            this.PineappleText = new System.Windows.Forms.TextBox();
            this.PepperoniText = new System.Windows.Forms.TextBox();
            this.MargeritaText = new System.Windows.Forms.TextBox();
            this.CalzoniLabel = new System.Windows.Forms.Label();
            this.PineappleLabel = new System.Windows.Forms.Label();
            this.PepperoniLabel = new System.Windows.Forms.Label();
            this.MargeritaLabel = new System.Windows.Forms.Label();
            this.OptionsPanel = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Button();
            this.SummaryButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.OrderButton = new System.Windows.Forms.Button();
            this.StarterPictureBox = new System.Windows.Forms.PictureBox();
            this.PictureBoxMainMenu = new System.Windows.Forms.PictureBox();
            this.ExitToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ClearToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.OrderSummaryGroupBox = new System.Windows.Forms.GroupBox();
            this.CompanySummaryGroupBox = new System.Windows.Forms.GroupBox();
            this.TotalCompanyTransactionsLabel = new System.Windows.Forms.Label();
            this.AverageTransactionText = new System.Windows.Forms.TextBox();
            this.TotalCompanyReceiptsTextBox = new System.Windows.Forms.TextBox();
            this.TotalPizzaOrderedTextBox = new System.Windows.Forms.TextBox();
            this.TotalCompanyTransactionsText = new System.Windows.Forms.TextBox();
            this.AverageTransactionVal = new System.Windows.Forms.Label();
            this.TotalCompanyReceiptsSum = new System.Windows.Forms.Label();
            this.NumberOfPizzasOrder = new System.Windows.Forms.Label();
            this.TotalComTransactions = new System.Windows.Forms.Label();
            this.ReceiptsOrderSummary = new System.Windows.Forms.TextBox();
            this.OrderSummaryPizzas = new System.Windows.Forms.TextBox();
            this.ServerTextOrderSummary = new System.Windows.Forms.TextBox();
            this.OrderSummaryTableReceipts = new System.Windows.Forms.Label();
            this.NumberPizzaOrderedOrderSum = new System.Windows.Forms.Label();
            this.ServerOrderSummary = new System.Windows.Forms.Label();
            this.DefaultPanel.SuspendLayout();
            this.OrderGroupBox.SuspendLayout();
            this.OptionsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StarterPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMainMenu)).BeginInit();
            this.OrderSummaryGroupBox.SuspendLayout();
            this.CompanySummaryGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // DefaultPanel
            // 
            this.DefaultPanel.BackColor = System.Drawing.SystemColors.Window;
            this.DefaultPanel.Controls.Add(this.StartButton);
            this.DefaultPanel.Controls.Add(this.TableNumberTextBox);
            this.DefaultPanel.Controls.Add(this.TableNumberLabel);
            this.DefaultPanel.Controls.Add(this.ServerTextBox);
            this.DefaultPanel.Controls.Add(this.ServerLabel);
            this.DefaultPanel.Location = new System.Drawing.Point(32, 22);
            this.DefaultPanel.Name = "DefaultPanel";
            this.DefaultPanel.Size = new System.Drawing.Size(727, 130);
            this.DefaultPanel.TabIndex = 0;
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.StartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.StartButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StartButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StartButton.Location = new System.Drawing.Point(598, 39);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(112, 34);
            this.StartButton.TabIndex = 4;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // TableNumberTextBox
            // 
            this.TableNumberTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TableNumberTextBox.Location = new System.Drawing.Point(489, 42);
            this.TableNumberTextBox.Name = "TableNumberTextBox";
            this.TableNumberTextBox.Size = new System.Drawing.Size(64, 34);
            this.TableNumberTextBox.TabIndex = 3;
            this.TableNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TableNumberLabel
            // 
            this.TableNumberLabel.AutoSize = true;
            this.TableNumberLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TableNumberLabel.Location = new System.Drawing.Point(332, 42);
            this.TableNumberLabel.Name = "TableNumberLabel";
            this.TableNumberLabel.Size = new System.Drawing.Size(151, 28);
            this.TableNumberLabel.TabIndex = 2;
            this.TableNumberLabel.Text = "Table Number:";
            // 
            // ServerTextBox
            // 
            this.ServerTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ServerTextBox.Location = new System.Drawing.Point(154, 42);
            this.ServerTextBox.Name = "ServerTextBox";
            this.ServerTextBox.Size = new System.Drawing.Size(150, 34);
            this.ServerTextBox.TabIndex = 1;
            this.ServerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ServerLabel
            // 
            this.ServerLabel.AutoSize = true;
            this.ServerLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ServerLabel.Location = new System.Drawing.Point(8, 42);
            this.ServerLabel.Name = "ServerLabel";
            this.ServerLabel.Size = new System.Drawing.Size(140, 28);
            this.ServerLabel.TabIndex = 0;
            this.ServerLabel.Text = "Server Name:";
            // 
            // OrderGroupBox
            // 
            this.OrderGroupBox.BackColor = System.Drawing.SystemColors.Window;
            this.OrderGroupBox.Controls.Add(this.CalzoniLabelPrice);
            this.OrderGroupBox.Controls.Add(this.PineappleLabelPrice);
            this.OrderGroupBox.Controls.Add(this.PepperoniPriceLabel);
            this.OrderGroupBox.Controls.Add(this.MargeritaPriceLabel);
            this.OrderGroupBox.Controls.Add(this.CalzoniText);
            this.OrderGroupBox.Controls.Add(this.PineappleText);
            this.OrderGroupBox.Controls.Add(this.PepperoniText);
            this.OrderGroupBox.Controls.Add(this.MargeritaText);
            this.OrderGroupBox.Controls.Add(this.CalzoniLabel);
            this.OrderGroupBox.Controls.Add(this.PineappleLabel);
            this.OrderGroupBox.Controls.Add(this.PepperoniLabel);
            this.OrderGroupBox.Controls.Add(this.MargeritaLabel);
            this.OrderGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OrderGroupBox.Location = new System.Drawing.Point(32, 22);
            this.OrderGroupBox.Name = "OrderGroupBox";
            this.OrderGroupBox.Size = new System.Drawing.Size(727, 217);
            this.OrderGroupBox.TabIndex = 1;
            this.OrderGroupBox.TabStop = false;
            this.OrderGroupBox.Text = "Order";
            this.OrderGroupBox.Visible = false;
            // 
            // CalzoniLabelPrice
            // 
            this.CalzoniLabelPrice.AutoSize = true;
            this.CalzoniLabelPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CalzoniLabelPrice.Location = new System.Drawing.Point(452, 164);
            this.CalzoniLabelPrice.Name = "CalzoniLabelPrice";
            this.CalzoniLabelPrice.Size = new System.Drawing.Size(193, 28);
            this.CalzoniLabelPrice.TabIndex = 10;
            this.CalzoniLabelPrice.Text = "@ €12.49 Per Pizza";
            // 
            // PineappleLabelPrice
            // 
            this.PineappleLabelPrice.AutoSize = true;
            this.PineappleLabelPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PineappleLabelPrice.Location = new System.Drawing.Point(452, 123);
            this.PineappleLabelPrice.Name = "PineappleLabelPrice";
            this.PineappleLabelPrice.Size = new System.Drawing.Size(193, 28);
            this.PineappleLabelPrice.TabIndex = 9;
            this.PineappleLabelPrice.Text = "@ €11.49 Per Pizza";
            // 
            // PepperoniPriceLabel
            // 
            this.PepperoniPriceLabel.AutoSize = true;
            this.PepperoniPriceLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PepperoniPriceLabel.Location = new System.Drawing.Point(452, 82);
            this.PepperoniPriceLabel.Name = "PepperoniPriceLabel";
            this.PepperoniPriceLabel.Size = new System.Drawing.Size(193, 28);
            this.PepperoniPriceLabel.TabIndex = 8;
            this.PepperoniPriceLabel.Text = "@ €10.99 Per Pizza";
            // 
            // MargeritaPriceLabel
            // 
            this.MargeritaPriceLabel.AutoSize = true;
            this.MargeritaPriceLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MargeritaPriceLabel.Location = new System.Drawing.Point(452, 41);
            this.MargeritaPriceLabel.Name = "MargeritaPriceLabel";
            this.MargeritaPriceLabel.Size = new System.Drawing.Size(181, 28);
            this.MargeritaPriceLabel.TabIndex = 2;
            this.MargeritaPriceLabel.Text = "@ €9.99 Per Pizza";
            // 
            // CalzoniText
            // 
            this.CalzoniText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CalzoniText.Location = new System.Drawing.Point(312, 164);
            this.CalzoniText.Name = "CalzoniText";
            this.CalzoniText.Size = new System.Drawing.Size(72, 34);
            this.CalzoniText.TabIndex = 7;
            this.CalzoniText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CalzoniText.TextChanged += new System.EventHandler(this.CalzoniText_TextChanged);
            // 
            // PineappleText
            // 
            this.PineappleText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PineappleText.Location = new System.Drawing.Point(312, 121);
            this.PineappleText.Name = "PineappleText";
            this.PineappleText.Size = new System.Drawing.Size(72, 34);
            this.PineappleText.TabIndex = 6;
            this.PineappleText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PineappleText.TextChanged += new System.EventHandler(this.PineappleText_TextChanged);
            // 
            // PepperoniText
            // 
            this.PepperoniText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PepperoniText.Location = new System.Drawing.Point(312, 78);
            this.PepperoniText.Name = "PepperoniText";
            this.PepperoniText.Size = new System.Drawing.Size(72, 34);
            this.PepperoniText.TabIndex = 5;
            this.PepperoniText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PepperoniText.TextChanged += new System.EventHandler(this.PepperoniText_TextChanged);
            // 
            // MargeritaText
            // 
            this.MargeritaText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MargeritaText.Location = new System.Drawing.Point(312, 35);
            this.MargeritaText.Name = "MargeritaText";
            this.MargeritaText.Size = new System.Drawing.Size(72, 34);
            this.MargeritaText.TabIndex = 4;
            this.MargeritaText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MargeritaText.TextChanged += new System.EventHandler(this.MargeritaText_TextChanged);
            // 
            // CalzoniLabel
            // 
            this.CalzoniLabel.AutoSize = true;
            this.CalzoniLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CalzoniLabel.Location = new System.Drawing.Point(80, 165);
            this.CalzoniLabel.Name = "CalzoniLabel";
            this.CalzoniLabel.Size = new System.Drawing.Size(148, 30);
            this.CalzoniLabel.TabIndex = 3;
            this.CalzoniLabel.Text = "Calzoni Pizza";
            // 
            // PineappleLabel
            // 
            this.PineappleLabel.AutoSize = true;
            this.PineappleLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PineappleLabel.Location = new System.Drawing.Point(80, 123);
            this.PineappleLabel.Name = "PineappleLabel";
            this.PineappleLabel.Size = new System.Drawing.Size(176, 30);
            this.PineappleLabel.TabIndex = 2;
            this.PineappleLabel.Text = "Pineapple Pizza";
            // 
            // PepperoniLabel
            // 
            this.PepperoniLabel.AutoSize = true;
            this.PepperoniLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PepperoniLabel.Location = new System.Drawing.Point(80, 81);
            this.PepperoniLabel.Name = "PepperoniLabel";
            this.PepperoniLabel.Size = new System.Drawing.Size(179, 30);
            this.PepperoniLabel.TabIndex = 1;
            this.PepperoniLabel.Text = "Pepperoni Pizza";
            // 
            // MargeritaLabel
            // 
            this.MargeritaLabel.AutoSize = true;
            this.MargeritaLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MargeritaLabel.Location = new System.Drawing.Point(80, 39);
            this.MargeritaLabel.Name = "MargeritaLabel";
            this.MargeritaLabel.Size = new System.Drawing.Size(177, 30);
            this.MargeritaLabel.TabIndex = 0;
            this.MargeritaLabel.Text = "Margerita Pizza";
            // 
            // OptionsPanel
            // 
            this.OptionsPanel.BackColor = System.Drawing.SystemColors.Window;
            this.OptionsPanel.Controls.Add(this.Exit);
            this.OptionsPanel.Controls.Add(this.SummaryButton);
            this.OptionsPanel.Controls.Add(this.ClearButton);
            this.OptionsPanel.Controls.Add(this.OrderButton);
            this.OptionsPanel.Location = new System.Drawing.Point(32, 255);
            this.OptionsPanel.Name = "OptionsPanel";
            this.OptionsPanel.Size = new System.Drawing.Size(727, 69);
            this.OptionsPanel.TabIndex = 2;
            this.OptionsPanel.Visible = false;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Exit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Exit.Location = new System.Drawing.Point(545, 20);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(112, 34);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "E&xit";
            this.ExitToolTip.SetToolTip(this.Exit, "Press to exit application.");
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // SummaryButton
            // 
            this.SummaryButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SummaryButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SummaryButton.Location = new System.Drawing.Point(387, 20);
            this.SummaryButton.Name = "SummaryButton";
            this.SummaryButton.Size = new System.Drawing.Size(112, 34);
            this.SummaryButton.TabIndex = 2;
            this.SummaryButton.Text = "Summary";
            this.SummaryButton.UseVisualStyleBackColor = false;
            this.SummaryButton.Click += new System.EventHandler(this.SummaryButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClearButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClearButton.Location = new System.Drawing.Point(229, 20);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(112, 34);
            this.ClearButton.TabIndex = 1;
            this.ClearButton.Text = "C&lear";
            this.ClearToolTip.SetToolTip(this.ClearButton, "Press to Clear Form for New Order.");
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // OrderButton
            // 
            this.OrderButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.OrderButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OrderButton.Location = new System.Drawing.Point(71, 20);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(112, 34);
            this.OrderButton.TabIndex = 0;
            this.OrderButton.Text = "O&rder";
            this.OrderButton.UseVisualStyleBackColor = false;
            this.OrderButton.Click += new System.EventHandler(this.OrderButton_Click);
            // 
            // StarterPictureBox
            // 
            this.StarterPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("StarterPictureBox.Image")));
            this.StarterPictureBox.Location = new System.Drawing.Point(247, 176);
            this.StarterPictureBox.Name = "StarterPictureBox";
            this.StarterPictureBox.Size = new System.Drawing.Size(268, 105);
            this.StarterPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.StarterPictureBox.TabIndex = 12;
            this.StarterPictureBox.TabStop = false;
            // 
            // PictureBoxMainMenu
            // 
            this.PictureBoxMainMenu.BackColor = System.Drawing.SystemColors.Window;
            this.PictureBoxMainMenu.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxMainMenu.Image")));
            this.PictureBoxMainMenu.InitialImage = ((System.Drawing.Image)(resources.GetObject("PictureBoxMainMenu.InitialImage")));
            this.PictureBoxMainMenu.Location = new System.Drawing.Point(247, 552);
            this.PictureBoxMainMenu.Name = "PictureBoxMainMenu";
            this.PictureBoxMainMenu.Size = new System.Drawing.Size(268, 105);
            this.PictureBoxMainMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBoxMainMenu.TabIndex = 3;
            this.PictureBoxMainMenu.TabStop = false;
            this.PictureBoxMainMenu.Visible = false;
            // 
            // ExitToolTip
            // 
            this.ExitToolTip.AutoPopDelay = 5000;
            this.ExitToolTip.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ExitToolTip.InitialDelay = 300;
            this.ExitToolTip.ReshowDelay = 100;
            this.ExitToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ExitToolTip.ToolTipTitle = "Info";
            // 
            // ClearToolTip
            // 
            this.ClearToolTip.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ClearToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ClearToolTip.ToolTipTitle = "Info";
            // 
            // OrderSummaryGroupBox
            // 
            this.OrderSummaryGroupBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.OrderSummaryGroupBox.Controls.Add(this.CompanySummaryGroupBox);
            this.OrderSummaryGroupBox.Controls.Add(this.ReceiptsOrderSummary);
            this.OrderSummaryGroupBox.Controls.Add(this.OrderSummaryPizzas);
            this.OrderSummaryGroupBox.Controls.Add(this.ServerTextOrderSummary);
            this.OrderSummaryGroupBox.Controls.Add(this.OrderSummaryTableReceipts);
            this.OrderSummaryGroupBox.Controls.Add(this.NumberPizzaOrderedOrderSum);
            this.OrderSummaryGroupBox.Controls.Add(this.ServerOrderSummary);
            this.OrderSummaryGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OrderSummaryGroupBox.Location = new System.Drawing.Point(32, 336);
            this.OrderSummaryGroupBox.Name = "OrderSummaryGroupBox";
            this.OrderSummaryGroupBox.Size = new System.Drawing.Size(727, 198);
            this.OrderSummaryGroupBox.TabIndex = 11;
            this.OrderSummaryGroupBox.TabStop = false;
            this.OrderSummaryGroupBox.Text = "Table Order Summary Data";
            this.OrderSummaryGroupBox.Visible = false;
            // 
            // CompanySummaryGroupBox
            // 
            this.CompanySummaryGroupBox.BackColor = System.Drawing.SystemColors.Window;
            this.CompanySummaryGroupBox.Controls.Add(this.TotalCompanyTransactionsLabel);
            this.CompanySummaryGroupBox.Controls.Add(this.AverageTransactionText);
            this.CompanySummaryGroupBox.Controls.Add(this.TotalCompanyReceiptsTextBox);
            this.CompanySummaryGroupBox.Controls.Add(this.TotalPizzaOrderedTextBox);
            this.CompanySummaryGroupBox.Controls.Add(this.TotalCompanyTransactionsText);
            this.CompanySummaryGroupBox.Controls.Add(this.AverageTransactionVal);
            this.CompanySummaryGroupBox.Controls.Add(this.TotalCompanyReceiptsSum);
            this.CompanySummaryGroupBox.Controls.Add(this.NumberOfPizzasOrder);
            this.CompanySummaryGroupBox.Controls.Add(this.TotalComTransactions);
            this.CompanySummaryGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CompanySummaryGroupBox.Location = new System.Drawing.Point(0, 0);
            this.CompanySummaryGroupBox.Name = "CompanySummaryGroupBox";
            this.CompanySummaryGroupBox.Size = new System.Drawing.Size(728, 198);
            this.CompanySummaryGroupBox.TabIndex = 6;
            this.CompanySummaryGroupBox.TabStop = false;
            this.CompanySummaryGroupBox.Text = "Company Summary Data";
            this.CompanySummaryGroupBox.Visible = false;
            // 
            // TotalCompanyTransactionsLabel
            // 
            this.TotalCompanyTransactionsLabel.AutoSize = true;
            this.TotalCompanyTransactionsLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TotalCompanyTransactionsLabel.Location = new System.Drawing.Point(82, 33);
            this.TotalCompanyTransactionsLabel.Name = "TotalCompanyTransactionsLabel";
            this.TotalCompanyTransactionsLabel.Size = new System.Drawing.Size(303, 30);
            this.TotalCompanyTransactionsLabel.TabIndex = 8;
            this.TotalCompanyTransactionsLabel.Text = "Total Company Transactions";
            // 
            // AverageTransactionText
            // 
            this.AverageTransactionText.Location = new System.Drawing.Point(388, 154);
            this.AverageTransactionText.Name = "AverageTransactionText";
            this.AverageTransactionText.Size = new System.Drawing.Size(211, 31);
            this.AverageTransactionText.TabIndex = 7;
            this.AverageTransactionText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TotalCompanyReceiptsTextBox
            // 
            this.TotalCompanyReceiptsTextBox.Location = new System.Drawing.Point(388, 114);
            this.TotalCompanyReceiptsTextBox.Name = "TotalCompanyReceiptsTextBox";
            this.TotalCompanyReceiptsTextBox.Size = new System.Drawing.Size(211, 31);
            this.TotalCompanyReceiptsTextBox.TabIndex = 6;
            this.TotalCompanyReceiptsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TotalPizzaOrderedTextBox
            // 
            this.TotalPizzaOrderedTextBox.Location = new System.Drawing.Point(388, 74);
            this.TotalPizzaOrderedTextBox.Name = "TotalPizzaOrderedTextBox";
            this.TotalPizzaOrderedTextBox.Size = new System.Drawing.Size(211, 31);
            this.TotalPizzaOrderedTextBox.TabIndex = 5;
            this.TotalPizzaOrderedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TotalCompanyTransactionsText
            // 
            this.TotalCompanyTransactionsText.Location = new System.Drawing.Point(388, 34);
            this.TotalCompanyTransactionsText.Name = "TotalCompanyTransactionsText";
            this.TotalCompanyTransactionsText.Size = new System.Drawing.Size(211, 31);
            this.TotalCompanyTransactionsText.TabIndex = 4;
            this.TotalCompanyTransactionsText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AverageTransactionVal
            // 
            this.AverageTransactionVal.AutoSize = true;
            this.AverageTransactionVal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AverageTransactionVal.Location = new System.Drawing.Point(82, 153);
            this.AverageTransactionVal.Name = "AverageTransactionVal";
            this.AverageTransactionVal.Size = new System.Drawing.Size(241, 30);
            this.AverageTransactionVal.TabIndex = 3;
            this.AverageTransactionVal.Text = "Avg Transaction Value";
            // 
            // TotalCompanyReceiptsSum
            // 
            this.TotalCompanyReceiptsSum.AutoSize = true;
            this.TotalCompanyReceiptsSum.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TotalCompanyReceiptsSum.Location = new System.Drawing.Point(81, 111);
            this.TotalCompanyReceiptsSum.Name = "TotalCompanyReceiptsSum";
            this.TotalCompanyReceiptsSum.Size = new System.Drawing.Size(261, 30);
            this.TotalCompanyReceiptsSum.TabIndex = 2;
            this.TotalCompanyReceiptsSum.Text = "Total Company Receipts";
            // 
            // NumberOfPizzasOrder
            // 
            this.NumberOfPizzasOrder.AutoSize = true;
            this.NumberOfPizzasOrder.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NumberOfPizzasOrder.Location = new System.Drawing.Point(82, 73);
            this.NumberOfPizzasOrder.Name = "NumberOfPizzasOrder";
            this.NumberOfPizzasOrder.Size = new System.Drawing.Size(266, 30);
            this.NumberOfPizzasOrder.TabIndex = 1;
            this.NumberOfPizzasOrder.Text = "Number Pizza\'s Ordered";
            // 
            // TotalComTransactions
            // 
            this.TotalComTransactions.AutoSize = true;
            this.TotalComTransactions.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TotalComTransactions.Location = new System.Drawing.Point(76, 6);
            this.TotalComTransactions.Name = "TotalComTransactions";
            this.TotalComTransactions.Size = new System.Drawing.Size(0, 30);
            this.TotalComTransactions.TabIndex = 0;
            // 
            // ReceiptsOrderSummary
            // 
            this.ReceiptsOrderSummary.Location = new System.Drawing.Point(403, 122);
            this.ReceiptsOrderSummary.Name = "ReceiptsOrderSummary";
            this.ReceiptsOrderSummary.Size = new System.Drawing.Size(150, 31);
            this.ReceiptsOrderSummary.TabIndex = 5;
            this.ReceiptsOrderSummary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OrderSummaryPizzas
            // 
            this.OrderSummaryPizzas.Location = new System.Drawing.Point(403, 76);
            this.OrderSummaryPizzas.Name = "OrderSummaryPizzas";
            this.OrderSummaryPizzas.Size = new System.Drawing.Size(150, 31);
            this.OrderSummaryPizzas.TabIndex = 4;
            this.OrderSummaryPizzas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ServerTextOrderSummary
            // 
            this.ServerTextOrderSummary.Location = new System.Drawing.Point(403, 30);
            this.ServerTextOrderSummary.Name = "ServerTextOrderSummary";
            this.ServerTextOrderSummary.Size = new System.Drawing.Size(150, 31);
            this.ServerTextOrderSummary.TabIndex = 3;
            this.ServerTextOrderSummary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OrderSummaryTableReceipts
            // 
            this.OrderSummaryTableReceipts.AutoSize = true;
            this.OrderSummaryTableReceipts.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OrderSummaryTableReceipts.Location = new System.Drawing.Point(101, 123);
            this.OrderSummaryTableReceipts.Name = "OrderSummaryTableReceipts";
            this.OrderSummaryTableReceipts.Size = new System.Drawing.Size(218, 30);
            this.OrderSummaryTableReceipts.TabIndex = 2;
            this.OrderSummaryTableReceipts.Text = "Total Table Receipts";
            // 
            // NumberPizzaOrderedOrderSum
            // 
            this.NumberPizzaOrderedOrderSum.AutoSize = true;
            this.NumberPizzaOrderedOrderSum.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NumberPizzaOrderedOrderSum.Location = new System.Drawing.Point(101, 80);
            this.NumberPizzaOrderedOrderSum.Name = "NumberPizzaOrderedOrderSum";
            this.NumberPizzaOrderedOrderSum.Size = new System.Drawing.Size(293, 30);
            this.NumberPizzaOrderedOrderSum.TabIndex = 1;
            this.NumberPizzaOrderedOrderSum.Text = "Number of Pizza\'s Ordered";
            // 
            // ServerOrderSummary
            // 
            this.ServerOrderSummary.AutoSize = true;
            this.ServerOrderSummary.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ServerOrderSummary.Location = new System.Drawing.Point(101, 37);
            this.ServerOrderSummary.Name = "ServerOrderSummary";
            this.ServerOrderSummary.Size = new System.Drawing.Size(147, 30);
            this.ServerOrderSummary.TabIndex = 0;
            this.ServerOrderSummary.Text = "Server Name";
            // 
            // PizzaOrderApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 669);
            this.Controls.Add(this.StarterPictureBox);
            this.Controls.Add(this.OrderSummaryGroupBox);
            this.Controls.Add(this.PictureBoxMainMenu);
            this.Controls.Add(this.OptionsPanel);
            this.Controls.Add(this.OrderGroupBox);
            this.Controls.Add(this.DefaultPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PizzaOrderApp";
            this.Text = "PizzaOrderApp";
            this.DefaultPanel.ResumeLayout(false);
            this.DefaultPanel.PerformLayout();
            this.OrderGroupBox.ResumeLayout(false);
            this.OrderGroupBox.PerformLayout();
            this.OptionsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StarterPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMainMenu)).EndInit();
            this.OrderSummaryGroupBox.ResumeLayout(false);
            this.OrderSummaryGroupBox.PerformLayout();
            this.CompanySummaryGroupBox.ResumeLayout(false);
            this.CompanySummaryGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel DefaultPanel;
        private Button StartButton;
        private TextBox TableNumberTextBox;
        private Label TableNumberLabel;
        private TextBox ServerTextBox;
        private Label ServerLabel;
        private GroupBox OrderGroupBox;
        private Label CalzoniLabel;
        private Label PineappleLabel;
        private Label PepperoniLabel;
        private Label MargeritaLabel;
        private TextBox MargeritaText;
        private TextBox CalzoniText;
        private TextBox PineappleText;
        private TextBox PepperoniText;
        private Label MargeritaPriceLabel;
        private Label PepperoniPriceLabel;
        private Label CalzoniLabelPrice;
        private Label PineappleLabelPrice;
        private Panel OptionsPanel;
        private Button OrderButton;
        private Button ClearButton;
        private Button Exit;
        private Button SummaryButton;
        private PictureBox PictureBoxMainMenu;
        private ToolTip ExitToolTip;
        private ToolTip ClearToolTip;
        private GroupBox OrderSummaryGroupBox;
        private Label OrderSummaryTableReceipts;
        private Label NumberPizzaOrderedOrderSum;
        private Label ServerOrderSummary;
        private TextBox ReceiptsOrderSummary;
        private TextBox OrderSummaryPizzas;
        private TextBox ServerTextOrderSummary;
        private GroupBox CompanySummaryGroupBox;
        private Label TotalComTransactions;
        private Label NumberOfPizzasOrder;
        private Label TotalCompanyReceiptsSum;
        private Label AverageTransactionVal;
        private TextBox TotalCompanyTransactionsText;
        private TextBox TotalPizzaOrderedTextBox;
        private TextBox TotalCompanyReceiptsTextBox;
        private TextBox AverageTransactionText;
        private Label TotalCompanyTransactionsLabel;
        private PictureBox StarterPictureBox;
    }
}