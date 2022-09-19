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
            this.DefaultPanel.SuspendLayout();
            this.OrderGroupBox.SuspendLayout();
            this.OptionsPanel.SuspendLayout();
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
            this.OrderGroupBox.Size = new System.Drawing.Size(727, 234);
            this.OrderGroupBox.TabIndex = 1;
            this.OrderGroupBox.TabStop = false;
            this.OrderGroupBox.Text = "Order";
            this.OrderGroupBox.Visible = false;
            // 
            // CalzoniLabelPrice
            // 
            this.CalzoniLabelPrice.AutoSize = true;
            this.CalzoniLabelPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CalzoniLabelPrice.Location = new System.Drawing.Point(452, 166);
            this.CalzoniLabelPrice.Name = "CalzoniLabelPrice";
            this.CalzoniLabelPrice.Size = new System.Drawing.Size(193, 28);
            this.CalzoniLabelPrice.TabIndex = 10;
            this.CalzoniLabelPrice.Text = "@ €12.49 Per Pizza";
            // 
            // PineappleLabelPrice
            // 
            this.PineappleLabelPrice.AutoSize = true;
            this.PineappleLabelPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PineappleLabelPrice.Location = new System.Drawing.Point(452, 122);
            this.PineappleLabelPrice.Name = "PineappleLabelPrice";
            this.PineappleLabelPrice.Size = new System.Drawing.Size(193, 28);
            this.PineappleLabelPrice.TabIndex = 9;
            this.PineappleLabelPrice.Text = "@ €11.49 Per Pizza";
            // 
            // PepperoniPriceLabel
            // 
            this.PepperoniPriceLabel.AutoSize = true;
            this.PepperoniPriceLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PepperoniPriceLabel.Location = new System.Drawing.Point(452, 79);
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
            this.CalzoniText.Location = new System.Drawing.Point(312, 166);
            this.CalzoniText.Name = "CalzoniText";
            this.CalzoniText.Size = new System.Drawing.Size(72, 34);
            this.CalzoniText.TabIndex = 7;
            this.CalzoniText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PineappleText
            // 
            this.PineappleText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PineappleText.Location = new System.Drawing.Point(312, 119);
            this.PineappleText.Name = "PineappleText";
            this.PineappleText.Size = new System.Drawing.Size(72, 34);
            this.PineappleText.TabIndex = 6;
            this.PineappleText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PepperoniText
            // 
            this.PepperoniText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PepperoniText.Location = new System.Drawing.Point(312, 76);
            this.PepperoniText.Name = "PepperoniText";
            this.PepperoniText.Size = new System.Drawing.Size(72, 34);
            this.PepperoniText.TabIndex = 5;
            this.PepperoniText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MargeritaText
            // 
            this.MargeritaText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MargeritaText.Location = new System.Drawing.Point(312, 35);
            this.MargeritaText.Name = "MargeritaText";
            this.MargeritaText.Size = new System.Drawing.Size(72, 34);
            this.MargeritaText.TabIndex = 4;
            this.MargeritaText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CalzoniLabel
            // 
            this.CalzoniLabel.AutoSize = true;
            this.CalzoniLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CalzoniLabel.Location = new System.Drawing.Point(109, 166);
            this.CalzoniLabel.Name = "CalzoniLabel";
            this.CalzoniLabel.Size = new System.Drawing.Size(148, 30);
            this.CalzoniLabel.TabIndex = 3;
            this.CalzoniLabel.Text = "Calzoni Pizza";
            // 
            // PineappleLabel
            // 
            this.PineappleLabel.AutoSize = true;
            this.PineappleLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PineappleLabel.Location = new System.Drawing.Point(109, 122);
            this.PineappleLabel.Name = "PineappleLabel";
            this.PineappleLabel.Size = new System.Drawing.Size(176, 30);
            this.PineappleLabel.TabIndex = 2;
            this.PineappleLabel.Text = "Pineapple Pizza";
            // 
            // PepperoniLabel
            // 
            this.PepperoniLabel.AutoSize = true;
            this.PepperoniLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PepperoniLabel.Location = new System.Drawing.Point(109, 79);
            this.PepperoniLabel.Name = "PepperoniLabel";
            this.PepperoniLabel.Size = new System.Drawing.Size(179, 30);
            this.PepperoniLabel.TabIndex = 1;
            this.PepperoniLabel.Text = "Pepperoni Pizza";
            // 
            // MargeritaLabel
            // 
            this.MargeritaLabel.AutoSize = true;
            this.MargeritaLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MargeritaLabel.Location = new System.Drawing.Point(111, 39);
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
            this.OptionsPanel.Location = new System.Drawing.Point(32, 279);
            this.OptionsPanel.Name = "OptionsPanel";
            this.OptionsPanel.Size = new System.Drawing.Size(727, 81);
            this.OptionsPanel.TabIndex = 2;
            this.OptionsPanel.Visible = false;
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Exit.Location = new System.Drawing.Point(545, 20);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(112, 34);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            // 
            // SummaryButton
            // 
            this.SummaryButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SummaryButton.Location = new System.Drawing.Point(391, 20);
            this.SummaryButton.Name = "SummaryButton";
            this.SummaryButton.Size = new System.Drawing.Size(112, 34);
            this.SummaryButton.TabIndex = 2;
            this.SummaryButton.Text = "Summary";
            this.SummaryButton.UseVisualStyleBackColor = true;
            this.SummaryButton.Click += new System.EventHandler(this.SummaryButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClearButton.Location = new System.Drawing.Point(232, 20);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(112, 34);
            this.ClearButton.TabIndex = 1;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // OrderButton
            // 
            this.OrderButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OrderButton.Location = new System.Drawing.Point(71, 20);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(112, 34);
            this.OrderButton.TabIndex = 0;
            this.OrderButton.Text = "Order";
            this.OrderButton.UseVisualStyleBackColor = true;
            // 
            // PizzaOrderApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 669);
            this.Controls.Add(this.OptionsPanel);
            this.Controls.Add(this.OrderGroupBox);
            this.Controls.Add(this.DefaultPanel);
            this.Name = "PizzaOrderApp";
            this.Text = "PizzaOrderApp";
            this.DefaultPanel.ResumeLayout(false);
            this.DefaultPanel.PerformLayout();
            this.OrderGroupBox.ResumeLayout(false);
            this.OrderGroupBox.PerformLayout();
            this.OptionsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

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
    }
}