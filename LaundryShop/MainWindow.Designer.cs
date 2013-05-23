namespace LaundryShop
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.OrderPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.ResetButton = new System.Windows.Forms.Button();
            this.MakeNextButton = new System.Windows.Forms.Button();
            this.AddOrderLabel = new System.Windows.Forms.Label();
            this.OrderHeaderText = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ServiceListBox = new System.Windows.Forms.ListBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.ServiceLabel = new System.Windows.Forms.Label();
            this.ServiceDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DueDateLabel = new System.Windows.Forms.Label();
            this.DueDateCalendar = new System.Windows.Forms.MonthCalendar();
            this.ItemizeButton = new System.Windows.Forms.Button();
            this.MakeAddButton = new System.Windows.Forms.Button();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.NoClothesTextBox = new System.Windows.Forms.TextBox();
            this.ItemizeCheckBox = new System.Windows.Forms.CheckBox();
            this.TotalWeightLabel = new System.Windows.Forms.Label();
            this.NoClothesLabel = new System.Windows.Forms.Label();
            this.DetailsLabel = new System.Windows.Forms.Label();
            this.ServicePanel = new System.Windows.Forms.Panel();
            this.CarpetButton = new System.Windows.Forms.Button();
            this.DryCleanButton = new System.Windows.Forms.Button();
            this.LaundryButton = new System.Windows.Forms.Button();
            this.ConfirmPage = new System.Windows.Forms.TabPage();
            this.ConfirmTotalCostLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.CancelOrderButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.ForwardOrderButton = new System.Windows.Forms.Button();
            this.BackwardOrderButton = new System.Windows.Forms.Button();
            this.OrderListTabControl = new System.Windows.Forms.TabControl();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.ConfirmCancelButton = new System.Windows.Forms.Button();
            this.ConfirmNextButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.LogInPage = new System.Windows.Forms.TabPage();
            this.LogInHeaderText = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label19 = new System.Windows.Forms.Label();
            this.ExistingUserPanel = new System.Windows.Forms.Panel();
            this.LogInDetailsPanel = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.LogInYesButton = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.NewUserPanel = new System.Windows.Forms.Panel();
            this.SignUpDetailsPanel = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ContactNoLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LogInNoButton = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.MainTabControl.SuspendLayout();
            this.OrderPage.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.ServicePanel.SuspendLayout();
            this.ConfirmPage.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.LogInPage.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.ExistingUserPanel.SuspendLayout();
            this.LogInDetailsPanel.SuspendLayout();
            this.NewUserPanel.SuspendLayout();
            this.SignUpDetailsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.MainTabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.MainTabControl.Controls.Add(this.OrderPage);
            this.MainTabControl.Controls.Add(this.ConfirmPage);
            this.MainTabControl.Controls.Add(this.LogInPage);
            this.MainTabControl.Controls.Add(this.tabPage1);
            this.MainTabControl.Location = new System.Drawing.Point(-1, 4);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(634, 573);
            this.MainTabControl.TabIndex = 0;
            this.MainTabControl.TabStop = false;
            this.MainTabControl.SelectedIndexChanged += new System.EventHandler(this.MainTabControl_SelectedIndexChanged);
            // 
            // OrderPage
            // 
            this.OrderPage.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.OrderPage.Controls.Add(this.tableLayoutPanel3);
            this.OrderPage.Controls.Add(this.OrderHeaderText);
            this.OrderPage.Controls.Add(this.tableLayoutPanel1);
            this.OrderPage.Location = new System.Drawing.Point(4, 25);
            this.OrderPage.Name = "OrderPage";
            this.OrderPage.Padding = new System.Windows.Forms.Padding(3);
            this.OrderPage.Size = new System.Drawing.Size(626, 544);
            this.OrderPage.TabIndex = 0;
            this.OrderPage.Text = "1.Make an Order";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.tableLayoutPanel3.Controls.Add(this.ResetButton, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.MakeNextButton, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.AddOrderLabel, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(8, 506);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(612, 34);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(3, 3);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 0;
            this.ResetButton.Text = "Start over";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // MakeNextButton
            // 
            this.MakeNextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MakeNextButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.MakeNextButton.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MakeNextButton.Location = new System.Drawing.Point(534, 3);
            this.MakeNextButton.Name = "MakeNextButton";
            this.MakeNextButton.Size = new System.Drawing.Size(75, 23);
            this.MakeNextButton.TabIndex = 1;
            this.MakeNextButton.Text = "Next >>";
            this.MakeNextButton.UseVisualStyleBackColor = true;
            this.MakeNextButton.Click += new System.EventHandler(this.MakeNextButton_Click);
            // 
            // AddOrderLabel
            // 
            this.AddOrderLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AddOrderLabel.AutoSize = true;
            this.AddOrderLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddOrderLabel.Location = new System.Drawing.Point(287, 0);
            this.AddOrderLabel.Name = "AddOrderLabel";
            this.AddOrderLabel.Size = new System.Drawing.Size(59, 19);
            this.AddOrderLabel.TabIndex = 2;
            this.AddOrderLabel.Text = "label1";
            // 
            // OrderHeaderText
            // 
            this.OrderHeaderText.AutoSize = true;
            this.OrderHeaderText.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderHeaderText.Location = new System.Drawing.Point(8, 7);
            this.OrderHeaderText.Name = "OrderHeaderText";
            this.OrderHeaderText.Size = new System.Drawing.Size(351, 29);
            this.OrderHeaderText.TabIndex = 1;
            this.OrderHeaderText.Text = "Hi! What can we do for you?";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ServicePanel, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 39);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(612, 461);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ServiceListBox);
            this.panel2.Controls.Add(this.DescriptionLabel);
            this.panel2.Controls.Add(this.ServiceLabel);
            this.panel2.Controls.Add(this.ServiceDescriptionTextBox);
            this.panel2.Location = new System.Drawing.Point(142, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(226, 446);
            this.panel2.TabIndex = 3;
            // 
            // ServiceListBox
            // 
            this.ServiceListBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceListBox.FormattingEnabled = true;
            this.ServiceListBox.ItemHeight = 19;
            this.ServiceListBox.Location = new System.Drawing.Point(6, 47);
            this.ServiceListBox.Name = "ServiceListBox";
            this.ServiceListBox.Size = new System.Drawing.Size(215, 156);
            this.ServiceListBox.TabIndex = 4;
            this.ServiceListBox.SelectedValueChanged += new System.EventHandler(this.ServiceListBox_SelectedValueChanged);
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLabel.Location = new System.Drawing.Point(3, 217);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(71, 13);
            this.DescriptionLabel.TabIndex = 3;
            this.DescriptionLabel.Text = "Description";
            // 
            // ServiceLabel
            // 
            this.ServiceLabel.AutoSize = true;
            this.ServiceLabel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceLabel.Location = new System.Drawing.Point(4, 9);
            this.ServiceLabel.Name = "ServiceLabel";
            this.ServiceLabel.Size = new System.Drawing.Size(165, 29);
            this.ServiceLabel.TabIndex = 0;
            this.ServiceLabel.Text = "Service Type";
            // 
            // ServiceDescriptionTextBox
            // 
            this.ServiceDescriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ServiceDescriptionTextBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceDescriptionTextBox.Location = new System.Drawing.Point(6, 233);
            this.ServiceDescriptionTextBox.Multiline = true;
            this.ServiceDescriptionTextBox.Name = "ServiceDescriptionTextBox";
            this.ServiceDescriptionTextBox.ReadOnly = true;
            this.ServiceDescriptionTextBox.Size = new System.Drawing.Size(215, 210);
            this.ServiceDescriptionTextBox.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DueDateLabel);
            this.panel1.Controls.Add(this.DueDateCalendar);
            this.panel1.Controls.Add(this.ItemizeButton);
            this.panel1.Controls.Add(this.MakeAddButton);
            this.panel1.Controls.Add(this.WeightTextBox);
            this.panel1.Controls.Add(this.NoClothesTextBox);
            this.panel1.Controls.Add(this.ItemizeCheckBox);
            this.panel1.Controls.Add(this.TotalWeightLabel);
            this.panel1.Controls.Add(this.NoClothesLabel);
            this.panel1.Controls.Add(this.DetailsLabel);
            this.panel1.Location = new System.Drawing.Point(374, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 446);
            this.panel1.TabIndex = 2;
            // 
            // DueDateLabel
            // 
            this.DueDateLabel.AutoEllipsis = true;
            this.DueDateLabel.AutoSize = true;
            this.DueDateLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DueDateLabel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DueDateLabel.Location = new System.Drawing.Point(3, 9);
            this.DueDateLabel.Name = "DueDateLabel";
            this.DueDateLabel.Size = new System.Drawing.Size(123, 29);
            this.DueDateLabel.TabIndex = 0;
            this.DueDateLabel.Text = "Due Date";
            // 
            // DueDateCalendar
            // 
            this.DueDateCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DueDateCalendar.ForeColor = System.Drawing.SystemColors.MenuText;
            this.DueDateCalendar.Location = new System.Drawing.Point(38, 47);
            this.DueDateCalendar.MaxSelectionCount = 1;
            this.DueDateCalendar.Name = "DueDateCalendar";
            this.DueDateCalendar.TabIndex = 1;
            this.DueDateCalendar.TitleBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DueDateCalendar.TrailingForeColor = System.Drawing.Color.Maroon;
            // 
            // ItemizeButton
            // 
            this.ItemizeButton.Enabled = false;
            this.ItemizeButton.Location = new System.Drawing.Point(75, 342);
            this.ItemizeButton.Name = "ItemizeButton";
            this.ItemizeButton.Size = new System.Drawing.Size(111, 23);
            this.ItemizeButton.TabIndex = 18;
            this.ItemizeButton.Text = "Items";
            this.ItemizeButton.UseVisualStyleBackColor = true;
            this.ItemizeButton.Click += new System.EventHandler(this.ItemizeButton_Click);
            // 
            // MakeAddButton
            // 
            this.MakeAddButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MakeAddButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MakeAddButton.Location = new System.Drawing.Point(26, 395);
            this.MakeAddButton.Name = "MakeAddButton";
            this.MakeAddButton.Size = new System.Drawing.Size(183, 48);
            this.MakeAddButton.TabIndex = 2;
            this.MakeAddButton.Text = "Add Order";
            this.MakeAddButton.UseVisualStyleBackColor = true;
            this.MakeAddButton.Click += new System.EventHandler(this.MakeAddButton_Click);
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WeightTextBox.Location = new System.Drawing.Point(75, 312);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(112, 21);
            this.WeightTextBox.TabIndex = 15;
            // 
            // NoClothesTextBox
            // 
            this.NoClothesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NoClothesTextBox.Location = new System.Drawing.Point(75, 273);
            this.NoClothesTextBox.Name = "NoClothesTextBox";
            this.NoClothesTextBox.Size = new System.Drawing.Size(112, 21);
            this.NoClothesTextBox.TabIndex = 14;
            // 
            // ItemizeCheckBox
            // 
            this.ItemizeCheckBox.AutoSize = true;
            this.ItemizeCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ItemizeCheckBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemizeCheckBox.Location = new System.Drawing.Point(6, 344);
            this.ItemizeCheckBox.Name = "ItemizeCheckBox";
            this.ItemizeCheckBox.Size = new System.Drawing.Size(64, 18);
            this.ItemizeCheckBox.TabIndex = 13;
            this.ItemizeCheckBox.Text = "Itemize";
            this.ItemizeCheckBox.UseVisualStyleBackColor = true;
            this.ItemizeCheckBox.CheckedChanged += new System.EventHandler(this.ItemizeCheckBox_CheckedChanged);
            // 
            // TotalWeightLabel
            // 
            this.TotalWeightLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalWeightLabel.Location = new System.Drawing.Point(5, 307);
            this.TotalWeightLabel.Name = "TotalWeightLabel";
            this.TotalWeightLabel.Size = new System.Drawing.Size(64, 30);
            this.TotalWeightLabel.TabIndex = 12;
            this.TotalWeightLabel.Text = "Total Weight (Kg)";
            // 
            // NoClothesLabel
            // 
            this.NoClothesLabel.AutoSize = true;
            this.NoClothesLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoClothesLabel.Location = new System.Drawing.Point(3, 276);
            this.NoClothesLabel.Name = "NoClothesLabel";
            this.NoClothesLabel.Size = new System.Drawing.Size(67, 13);
            this.NoClothesLabel.TabIndex = 11;
            this.NoClothesLabel.Text = "# of Clothes";
            // 
            // DetailsLabel
            // 
            this.DetailsLabel.AutoSize = true;
            this.DetailsLabel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailsLabel.Location = new System.Drawing.Point(3, 224);
            this.DetailsLabel.Name = "DetailsLabel";
            this.DetailsLabel.Size = new System.Drawing.Size(95, 29);
            this.DetailsLabel.TabIndex = 0;
            this.DetailsLabel.Text = "Details";
            // 
            // ServicePanel
            // 
            this.ServicePanel.Controls.Add(this.CarpetButton);
            this.ServicePanel.Controls.Add(this.DryCleanButton);
            this.ServicePanel.Controls.Add(this.LaundryButton);
            this.ServicePanel.Location = new System.Drawing.Point(3, 3);
            this.ServicePanel.Name = "ServicePanel";
            this.ServicePanel.Size = new System.Drawing.Size(133, 446);
            this.ServicePanel.TabIndex = 1;
            // 
            // CarpetButton
            // 
            this.CarpetButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarpetButton.Location = new System.Drawing.Point(13, 355);
            this.CarpetButton.Name = "CarpetButton";
            this.CarpetButton.Size = new System.Drawing.Size(97, 88);
            this.CarpetButton.TabIndex = 2;
            this.CarpetButton.Text = "Carpet Cleaning";
            this.CarpetButton.UseVisualStyleBackColor = true;
            this.CarpetButton.Click += new System.EventHandler(this.CarpetButton_Click);
            // 
            // DryCleanButton
            // 
            this.DryCleanButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DryCleanButton.Location = new System.Drawing.Point(13, 206);
            this.DryCleanButton.Name = "DryCleanButton";
            this.DryCleanButton.Size = new System.Drawing.Size(97, 88);
            this.DryCleanButton.TabIndex = 1;
            this.DryCleanButton.Text = "Dry Cleaning";
            this.DryCleanButton.UseVisualStyleBackColor = true;
            this.DryCleanButton.Click += new System.EventHandler(this.DryCleanButton_Click);
            // 
            // LaundryButton
            // 
            this.LaundryButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaundryButton.Location = new System.Drawing.Point(13, 49);
            this.LaundryButton.Name = "LaundryButton";
            this.LaundryButton.Size = new System.Drawing.Size(97, 88);
            this.LaundryButton.TabIndex = 0;
            this.LaundryButton.Text = "Laundry";
            this.LaundryButton.UseVisualStyleBackColor = true;
            this.LaundryButton.Click += new System.EventHandler(this.LaundryButton_Click);
            // 
            // ConfirmPage
            // 
            this.ConfirmPage.Controls.Add(this.ConfirmTotalCostLabel);
            this.ConfirmPage.Controls.Add(this.tableLayoutPanel7);
            this.ConfirmPage.Controls.Add(this.tableLayoutPanel6);
            this.ConfirmPage.Controls.Add(this.OrderListTabControl);
            this.ConfirmPage.Controls.Add(this.tableLayoutPanel4);
            this.ConfirmPage.Controls.Add(this.label6);
            this.ConfirmPage.Location = new System.Drawing.Point(4, 25);
            this.ConfirmPage.Name = "ConfirmPage";
            this.ConfirmPage.Padding = new System.Windows.Forms.Padding(3);
            this.ConfirmPage.Size = new System.Drawing.Size(626, 544);
            this.ConfirmPage.TabIndex = 1;
            this.ConfirmPage.Text = "2. Confirm Order";
            this.ConfirmPage.UseVisualStyleBackColor = true;
            this.ConfirmPage.Enter += new System.EventHandler(this.ConfirmPage_Enter);
            // 
            // ConfirmTotalCostLabel
            // 
            this.ConfirmTotalCostLabel.AutoSize = true;
            this.ConfirmTotalCostLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmTotalCostLabel.Location = new System.Drawing.Point(414, 454);
            this.ConfirmTotalCostLabel.Name = "ConfirmTotalCostLabel";
            this.ConfirmTotalCostLabel.Size = new System.Drawing.Size(199, 23);
            this.ConfirmTotalCostLabel.TabIndex = 9;
            this.ConfirmTotalCostLabel.Text = "Total Cost: 210 Php";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.CancelOrderButton, 0, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(13, 392);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(590, 41);
            this.tableLayoutPanel7.TabIndex = 8;
            // 
            // CancelOrderButton
            // 
            this.CancelOrderButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CancelOrderButton.Location = new System.Drawing.Point(110, 3);
            this.CancelOrderButton.Name = "CancelOrderButton";
            this.CancelOrderButton.Size = new System.Drawing.Size(75, 35);
            this.CancelOrderButton.TabIndex = 3;
            this.CancelOrderButton.Text = "Cancel Order";
            this.CancelOrderButton.UseVisualStyleBackColor = true;
            this.CancelOrderButton.Click += new System.EventHandler(this.CancelOrderButton_Click);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.ForwardOrderButton, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.BackwardOrderButton, 0, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(208, 439);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(200, 41);
            this.tableLayoutPanel6.TabIndex = 6;
            // 
            // ForwardOrderButton
            // 
            this.ForwardOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ForwardOrderButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForwardOrderButton.Location = new System.Drawing.Point(103, 3);
            this.ForwardOrderButton.Name = "ForwardOrderButton";
            this.ForwardOrderButton.Size = new System.Drawing.Size(94, 35);
            this.ForwardOrderButton.TabIndex = 1;
            this.ForwardOrderButton.Text = "Next Order";
            this.ForwardOrderButton.UseVisualStyleBackColor = true;
            this.ForwardOrderButton.Click += new System.EventHandler(this.ForwardOrderButton_Click);
            // 
            // BackwardOrderButton
            // 
            this.BackwardOrderButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackwardOrderButton.Location = new System.Drawing.Point(3, 3);
            this.BackwardOrderButton.Name = "BackwardOrderButton";
            this.BackwardOrderButton.Size = new System.Drawing.Size(94, 35);
            this.BackwardOrderButton.TabIndex = 0;
            this.BackwardOrderButton.Text = "Previous Order";
            this.BackwardOrderButton.UseVisualStyleBackColor = true;
            this.BackwardOrderButton.Click += new System.EventHandler(this.BackwardOrderButton_Click);
            // 
            // OrderListTabControl
            // 
            this.OrderListTabControl.Location = new System.Drawing.Point(13, 40);
            this.OrderListTabControl.Name = "OrderListTabControl";
            this.OrderListTabControl.SelectedIndex = 0;
            this.OrderListTabControl.Size = new System.Drawing.Size(604, 346);
            this.OrderListTabControl.TabIndex = 5;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.50754F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.49246F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 211F));
            this.tableLayoutPanel4.Controls.Add(this.ConfirmCancelButton, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.ConfirmNextButton, 2, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(8, 506);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(612, 34);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // ConfirmCancelButton
            // 
            this.ConfirmCancelButton.Location = new System.Drawing.Point(3, 3);
            this.ConfirmCancelButton.Name = "ConfirmCancelButton";
            this.ConfirmCancelButton.Size = new System.Drawing.Size(75, 23);
            this.ConfirmCancelButton.TabIndex = 0;
            this.ConfirmCancelButton.Text = "Cancel";
            this.ConfirmCancelButton.UseVisualStyleBackColor = true;
            // 
            // ConfirmNextButton
            // 
            this.ConfirmNextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfirmNextButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ConfirmNextButton.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmNextButton.Location = new System.Drawing.Point(534, 3);
            this.ConfirmNextButton.Name = "ConfirmNextButton";
            this.ConfirmNextButton.Size = new System.Drawing.Size(75, 23);
            this.ConfirmNextButton.TabIndex = 1;
            this.ConfirmNextButton.Text = "Next >>";
            this.ConfirmNextButton.UseVisualStyleBackColor = true;
            this.ConfirmNextButton.Click += new System.EventHandler(this.ConfirmNextButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(338, 29);
            this.label6.TabIndex = 2;
            this.label6.Text = "Kindly check your order(s).";
            // 
            // LogInPage
            // 
            this.LogInPage.Controls.Add(this.LogInHeaderText);
            this.LogInPage.Controls.Add(this.tableLayoutPanel5);
            this.LogInPage.Location = new System.Drawing.Point(4, 25);
            this.LogInPage.Name = "LogInPage";
            this.LogInPage.Padding = new System.Windows.Forms.Padding(3);
            this.LogInPage.Size = new System.Drawing.Size(626, 544);
            this.LogInPage.TabIndex = 2;
            this.LogInPage.Text = "3. Log-in";
            this.LogInPage.UseVisualStyleBackColor = true;
            // 
            // LogInHeaderText
            // 
            this.LogInHeaderText.AutoSize = true;
            this.LogInHeaderText.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInHeaderText.Location = new System.Drawing.Point(8, 7);
            this.LogInHeaderText.Name = "LogInHeaderText";
            this.LogInHeaderText.Size = new System.Drawing.Size(347, 29);
            this.LogInHeaderText.TabIndex = 2;
            this.LogInHeaderText.Text = "Have you been here before?";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 198F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 206F));
            this.tableLayoutPanel5.Controls.Add(this.label19, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.ExistingUserPanel, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.NewUserPanel, 2, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(8, 39);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(612, 376);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(278, 172);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(57, 31);
            this.label19.TabIndex = 0;
            this.label19.Text = "OR";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExistingUserPanel
            // 
            this.ExistingUserPanel.Controls.Add(this.LogInDetailsPanel);
            this.ExistingUserPanel.Controls.Add(this.LogInYesButton);
            this.ExistingUserPanel.Controls.Add(this.label21);
            this.ExistingUserPanel.Location = new System.Drawing.Point(3, 3);
            this.ExistingUserPanel.Name = "ExistingUserPanel";
            this.ExistingUserPanel.Size = new System.Drawing.Size(202, 370);
            this.ExistingUserPanel.TabIndex = 1;
            // 
            // LogInDetailsPanel
            // 
            this.LogInDetailsPanel.Controls.Add(this.button8);
            this.LogInDetailsPanel.Controls.Add(this.textBox6);
            this.LogInDetailsPanel.Controls.Add(this.textBox5);
            this.LogInDetailsPanel.Controls.Add(this.label25);
            this.LogInDetailsPanel.Controls.Add(this.label24);
            this.LogInDetailsPanel.Enabled = false;
            this.LogInDetailsPanel.Location = new System.Drawing.Point(2, 56);
            this.LogInDetailsPanel.Name = "LogInDetailsPanel";
            this.LogInDetailsPanel.Size = new System.Drawing.Size(197, 311);
            this.LogInDetailsPanel.TabIndex = 24;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(5, 109);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(149, 45);
            this.button8.TabIndex = 24;
            this.button8.Text = "Submit";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Location = new System.Drawing.Point(5, 71);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(149, 21);
            this.textBox6.TabIndex = 26;
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Location = new System.Drawing.Point(5, 30);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(149, 21);
            this.textBox5.TabIndex = 25;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(2, 54);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(53, 13);
            this.label25.TabIndex = 23;
            this.label25.Text = "Surname:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(3, 14);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(52, 13);
            this.label24.TabIndex = 22;
            this.label24.Text = "Mobile #:";
            // 
            // LogInYesButton
            // 
            this.LogInYesButton.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInYesButton.Location = new System.Drawing.Point(3, 1);
            this.LogInYesButton.Name = "LogInYesButton";
            this.LogInYesButton.Size = new System.Drawing.Size(75, 36);
            this.LogInYesButton.TabIndex = 23;
            this.LogInYesButton.Text = "Yes!";
            this.LogInYesButton.UseVisualStyleBackColor = true;
            this.LogInYesButton.Click += new System.EventHandler(this.LogInYesButton_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(4, 40);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(96, 13);
            this.label21.TabIndex = 1;
            this.label21.Text = "Please log-in here.";
            // 
            // NewUserPanel
            // 
            this.NewUserPanel.Controls.Add(this.SignUpDetailsPanel);
            this.NewUserPanel.Controls.Add(this.LogInNoButton);
            this.NewUserPanel.Controls.Add(this.label23);
            this.NewUserPanel.Location = new System.Drawing.Point(409, 3);
            this.NewUserPanel.Name = "NewUserPanel";
            this.NewUserPanel.Size = new System.Drawing.Size(200, 370);
            this.NewUserPanel.TabIndex = 2;
            // 
            // SignUpDetailsPanel
            // 
            this.SignUpDetailsPanel.Controls.Add(this.button6);
            this.SignUpDetailsPanel.Controls.Add(this.button7);
            this.SignUpDetailsPanel.Controls.Add(this.textBox4);
            this.SignUpDetailsPanel.Controls.Add(this.textBox3);
            this.SignUpDetailsPanel.Controls.Add(this.textBox2);
            this.SignUpDetailsPanel.Controls.Add(this.textBox1);
            this.SignUpDetailsPanel.Controls.Add(this.ContactNoLabel);
            this.SignUpDetailsPanel.Controls.Add(this.AddressLabel);
            this.SignUpDetailsPanel.Controls.Add(this.SurnameLabel);
            this.SignUpDetailsPanel.Controls.Add(this.FirstNameLabel);
            this.SignUpDetailsPanel.Enabled = false;
            this.SignUpDetailsPanel.Location = new System.Drawing.Point(4, 56);
            this.SignUpDetailsPanel.Name = "SignUpDetailsPanel";
            this.SignUpDetailsPanel.Size = new System.Drawing.Size(200, 311);
            this.SignUpDetailsPanel.TabIndex = 24;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 255);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(149, 23);
            this.button6.TabIndex = 29;
            this.button6.Text = "Cancel";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 177);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(149, 45);
            this.button7.TabIndex = 28;
            this.button7.Text = "Submit";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Location = new System.Drawing.Point(6, 149);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(149, 21);
            this.textBox4.TabIndex = 27;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(6, 110);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(149, 21);
            this.textBox3.TabIndex = 26;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(6, 71);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(149, 21);
            this.textBox2.TabIndex = 25;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(6, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 21);
            this.textBox1.TabIndex = 24;
            // 
            // ContactNoLabel
            // 
            this.ContactNoLabel.AutoSize = true;
            this.ContactNoLabel.Location = new System.Drawing.Point(3, 133);
            this.ContactNoLabel.Name = "ContactNoLabel";
            this.ContactNoLabel.Size = new System.Drawing.Size(52, 13);
            this.ContactNoLabel.TabIndex = 23;
            this.ContactNoLabel.Text = "Mobile #:";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(3, 94);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(50, 13);
            this.AddressLabel.TabIndex = 22;
            this.AddressLabel.Text = "Address:";
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Location = new System.Drawing.Point(3, 55);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(53, 13);
            this.SurnameLabel.TabIndex = 21;
            this.SurnameLabel.Text = "Surname:";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(3, 14);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(62, 13);
            this.FirstNameLabel.TabIndex = 20;
            this.FirstNameLabel.Text = "First Name:";
            // 
            // LogInNoButton
            // 
            this.LogInNoButton.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInNoButton.Location = new System.Drawing.Point(3, 1);
            this.LogInNoButton.Name = "LogInNoButton";
            this.LogInNoButton.Size = new System.Drawing.Size(75, 36);
            this.LogInNoButton.TabIndex = 23;
            this.LogInNoButton.Text = "Nope.";
            this.LogInNoButton.UseVisualStyleBackColor = true;
            this.LogInNoButton.Click += new System.EventHandler(this.LogInNoButton_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(3, 40);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(168, 13);
            this.label23.TabIndex = 2;
            this.label23.Text = "Fill up the form below to proceed.";
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(626, 544);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "4. Print Receipt";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 578);
            this.Controls.Add(this.MainTabControl);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainWindow";
            this.Text = "Laundry Shop";
            this.MainTabControl.ResumeLayout(false);
            this.OrderPage.ResumeLayout(false);
            this.OrderPage.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ServicePanel.ResumeLayout(false);
            this.ConfirmPage.ResumeLayout(false);
            this.ConfirmPage.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.LogInPage.ResumeLayout(false);
            this.LogInPage.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ExistingUserPanel.ResumeLayout(false);
            this.ExistingUserPanel.PerformLayout();
            this.LogInDetailsPanel.ResumeLayout(false);
            this.LogInDetailsPanel.PerformLayout();
            this.NewUserPanel.ResumeLayout(false);
            this.NewUserPanel.PerformLayout();
            this.SignUpDetailsPanel.ResumeLayout(false);
            this.SignUpDetailsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage OrderPage;
        private System.Windows.Forms.TabPage ConfirmPage;
        private System.Windows.Forms.Label OrderHeaderText;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabPage LogInPage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label DetailsLabel;
        private System.Windows.Forms.Panel ServicePanel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox ServiceDescriptionTextBox;
        private System.Windows.Forms.Label ServiceLabel;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.TextBox NoClothesTextBox;
        private System.Windows.Forms.CheckBox ItemizeCheckBox;
        private System.Windows.Forms.Label TotalWeightLabel;
        private System.Windows.Forms.Label NoClothesLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button MakeNextButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button ConfirmCancelButton;
        private System.Windows.Forms.Button ConfirmNextButton;
        private System.Windows.Forms.Label LogInHeaderText;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel ExistingUserPanel;
        private System.Windows.Forms.Panel NewUserPanel;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button MakeAddButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TabControl OrderListTabControl;
        private System.Windows.Forms.Label ConfirmTotalCostLabel;
        private System.Windows.Forms.Button CancelOrderButton;
        private System.Windows.Forms.Button ForwardOrderButton;
        private System.Windows.Forms.Button BackwardOrderButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MonthCalendar DueDateCalendar;
        private System.Windows.Forms.Label DueDateLabel;
        private System.Windows.Forms.Button ItemizeButton;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button CarpetButton;
        private System.Windows.Forms.Button DryCleanButton;
        private System.Windows.Forms.Button LaundryButton;
        private System.Windows.Forms.ListBox ServiceListBox;
        private System.Windows.Forms.Label AddOrderLabel;
        private System.Windows.Forms.Panel LogInDetailsPanel;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button LogInYesButton;
        private System.Windows.Forms.Panel SignUpDetailsPanel;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label ContactNoLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Button LogInNoButton;
    }
}

