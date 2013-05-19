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
            this.MakeAddButton = new System.Windows.Forms.Button();
            this.OrderLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DueDateCalendar = new System.Windows.Forms.MonthCalendar();
            this.DueDateLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TotalCostLabel = new System.Windows.Forms.Label();
            this.CostHeadingLabel = new System.Windows.Forms.Label();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.NoClothesTextBox = new System.Windows.Forms.TextBox();
            this.ItemizeCheckBox = new System.Windows.Forms.CheckBox();
            this.TotalWeightLabel = new System.Windows.Forms.Label();
            this.NoClothesLabel = new System.Windows.Forms.Label();
            this.DetailsLabel = new System.Windows.Forms.Label();
            this.ServicePanel = new System.Windows.Forms.Panel();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.ServiceDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.ServiceComboBox = new System.Windows.Forms.ComboBox();
            this.ServiceLabel = new System.Windows.Forms.Label();
            this.ConfirmPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.EditOrderButton = new System.Windows.Forms.Button();
            this.ConfirmCancelButton = new System.Windows.Forms.Button();
            this.ConfirmNextButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label18 = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label19 = new System.Windows.Forms.Label();
            this.ExistingUserPanel = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.NewUserPanel = new System.Windows.Forms.Panel();
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
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.OrderListTabControl = new System.Windows.Forms.TabControl();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.ConfirmTotalCostLabel = new System.Windows.Forms.Label();
            this.CancelOrderButton = new System.Windows.Forms.Button();
            this.BackwardOrderButton = new System.Windows.Forms.Button();
            this.ForwardOrderButton = new System.Windows.Forms.Button();
            this.MainTabControl.SuspendLayout();
            this.OrderPage.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.ServicePanel.SuspendLayout();
            this.ConfirmPage.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.ExistingUserPanel.SuspendLayout();
            this.NewUserPanel.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.MainTabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.MainTabControl.Controls.Add(this.OrderPage);
            this.MainTabControl.Controls.Add(this.ConfirmPage);
            this.MainTabControl.Controls.Add(this.tabPage1);
            this.MainTabControl.Location = new System.Drawing.Point(-1, 4);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(634, 452);
            this.MainTabControl.TabIndex = 0;
            this.MainTabControl.TabStop = false;
            // 
            // OrderPage
            // 
            this.OrderPage.Controls.Add(this.tableLayoutPanel3);
            this.OrderPage.Controls.Add(this.OrderLabel);
            this.OrderPage.Controls.Add(this.tableLayoutPanel1);
            this.OrderPage.Location = new System.Drawing.Point(4, 25);
            this.OrderPage.Name = "OrderPage";
            this.OrderPage.Padding = new System.Windows.Forms.Padding(3);
            this.OrderPage.Size = new System.Drawing.Size(626, 423);
            this.OrderPage.TabIndex = 0;
            this.OrderPage.Text = "1.Make an Order";
            this.OrderPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.tableLayoutPanel3.Controls.Add(this.ResetButton, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.MakeNextButton, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.MakeAddButton, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(8, 389);
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
            // MakeAddButton
            // 
            this.MakeAddButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MakeAddButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MakeAddButton.Location = new System.Drawing.Point(279, 3);
            this.MakeAddButton.Name = "MakeAddButton";
            this.MakeAddButton.Size = new System.Drawing.Size(75, 23);
            this.MakeAddButton.TabIndex = 2;
            this.MakeAddButton.Text = "Add Order";
            this.MakeAddButton.UseVisualStyleBackColor = true;
            this.MakeAddButton.Click += new System.EventHandler(this.MakeAddButton_Click);
            // 
            // OrderLabel
            // 
            this.OrderLabel.AutoSize = true;
            this.OrderLabel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderLabel.Location = new System.Drawing.Point(8, 7);
            this.OrderLabel.Name = "OrderLabel";
            this.OrderLabel.Size = new System.Drawing.Size(311, 29);
            this.OrderLabel.TabIndex = 1;
            this.OrderLabel.Text = "What can we do for you?";
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(612, 343);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DueDateCalendar);
            this.panel2.Controls.Add(this.DueDateLabel);
            this.panel2.Location = new System.Drawing.Point(209, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 334);
            this.panel2.TabIndex = 3;
            // 
            // DueDateCalendar
            // 
            this.DueDateCalendar.ForeColor = System.Drawing.SystemColors.MenuText;
            this.DueDateCalendar.Location = new System.Drawing.Point(8, 86);
            this.DueDateCalendar.Name = "DueDateCalendar";
            this.DueDateCalendar.TabIndex = 1;
            this.DueDateCalendar.TitleBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DueDateCalendar.TrailingForeColor = System.Drawing.Color.Maroon;
            // 
            // DueDateLabel
            // 
            this.DueDateLabel.AutoSize = true;
            this.DueDateLabel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DueDateLabel.Location = new System.Drawing.Point(3, 0);
            this.DueDateLabel.Name = "DueDateLabel";
            this.DueDateLabel.Size = new System.Drawing.Size(123, 29);
            this.DueDateLabel.TabIndex = 0;
            this.DueDateLabel.Text = "Due Date";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TotalCostLabel);
            this.panel1.Controls.Add(this.CostHeadingLabel);
            this.panel1.Controls.Add(this.WeightTextBox);
            this.panel1.Controls.Add(this.NoClothesTextBox);
            this.panel1.Controls.Add(this.ItemizeCheckBox);
            this.panel1.Controls.Add(this.TotalWeightLabel);
            this.panel1.Controls.Add(this.NoClothesLabel);
            this.panel1.Controls.Add(this.DetailsLabel);
            this.panel1.Location = new System.Drawing.Point(415, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 334);
            this.panel1.TabIndex = 2;
            // 
            // TotalCostLabel
            // 
            this.TotalCostLabel.AutoSize = true;
            this.TotalCostLabel.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalCostLabel.Location = new System.Drawing.Point(5, 230);
            this.TotalCostLabel.Name = "TotalCostLabel";
            this.TotalCostLabel.Size = new System.Drawing.Size(134, 35);
            this.TotalCostLabel.TabIndex = 17;
            this.TotalCostLabel.Text = "210 Php";
            // 
            // CostHeadingLabel
            // 
            this.CostHeadingLabel.AutoSize = true;
            this.CostHeadingLabel.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostHeadingLabel.Location = new System.Drawing.Point(6, 205);
            this.CostHeadingLabel.Name = "CostHeadingLabel";
            this.CostHeadingLabel.Size = new System.Drawing.Size(59, 25);
            this.CostHeadingLabel.TabIndex = 16;
            this.CostHeadingLabel.Text = "Cost:";
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WeightTextBox.Location = new System.Drawing.Point(75, 122);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(112, 21);
            this.WeightTextBox.TabIndex = 15;
            // 
            // NoClothesTextBox
            // 
            this.NoClothesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NoClothesTextBox.Location = new System.Drawing.Point(75, 83);
            this.NoClothesTextBox.Name = "NoClothesTextBox";
            this.NoClothesTextBox.Size = new System.Drawing.Size(112, 21);
            this.NoClothesTextBox.TabIndex = 14;
            // 
            // ItemizeCheckBox
            // 
            this.ItemizeCheckBox.AutoSize = true;
            this.ItemizeCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ItemizeCheckBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemizeCheckBox.Location = new System.Drawing.Point(6, 154);
            this.ItemizeCheckBox.Name = "ItemizeCheckBox";
            this.ItemizeCheckBox.Size = new System.Drawing.Size(74, 22);
            this.ItemizeCheckBox.TabIndex = 13;
            this.ItemizeCheckBox.Text = "Itemize";
            this.ItemizeCheckBox.UseVisualStyleBackColor = true;
            // 
            // TotalWeightLabel
            // 
            this.TotalWeightLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalWeightLabel.Location = new System.Drawing.Point(5, 117);
            this.TotalWeightLabel.Name = "TotalWeightLabel";
            this.TotalWeightLabel.Size = new System.Drawing.Size(64, 30);
            this.TotalWeightLabel.TabIndex = 12;
            this.TotalWeightLabel.Text = "Total Weight (Kg)";
            // 
            // NoClothesLabel
            // 
            this.NoClothesLabel.AutoSize = true;
            this.NoClothesLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoClothesLabel.Location = new System.Drawing.Point(3, 86);
            this.NoClothesLabel.Name = "NoClothesLabel";
            this.NoClothesLabel.Size = new System.Drawing.Size(67, 13);
            this.NoClothesLabel.TabIndex = 11;
            this.NoClothesLabel.Text = "# of Clothes";
            // 
            // DetailsLabel
            // 
            this.DetailsLabel.AutoSize = true;
            this.DetailsLabel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailsLabel.Location = new System.Drawing.Point(3, 0);
            this.DetailsLabel.Name = "DetailsLabel";
            this.DetailsLabel.Size = new System.Drawing.Size(95, 29);
            this.DetailsLabel.TabIndex = 0;
            this.DetailsLabel.Text = "Details";
            // 
            // ServicePanel
            // 
            this.ServicePanel.Controls.Add(this.DescriptionLabel);
            this.ServicePanel.Controls.Add(this.ServiceDescriptionTextBox);
            this.ServicePanel.Controls.Add(this.ServiceComboBox);
            this.ServicePanel.Controls.Add(this.ServiceLabel);
            this.ServicePanel.Location = new System.Drawing.Point(3, 3);
            this.ServicePanel.Name = "ServicePanel";
            this.ServicePanel.Size = new System.Drawing.Size(200, 334);
            this.ServicePanel.TabIndex = 1;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLabel.Location = new System.Drawing.Point(5, 125);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(71, 13);
            this.DescriptionLabel.TabIndex = 3;
            this.DescriptionLabel.Text = "Description";
            // 
            // ServiceDescriptionTextBox
            // 
            this.ServiceDescriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ServiceDescriptionTextBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceDescriptionTextBox.Location = new System.Drawing.Point(8, 141);
            this.ServiceDescriptionTextBox.Multiline = true;
            this.ServiceDescriptionTextBox.Name = "ServiceDescriptionTextBox";
            this.ServiceDescriptionTextBox.ReadOnly = true;
            this.ServiceDescriptionTextBox.Size = new System.Drawing.Size(189, 175);
            this.ServiceDescriptionTextBox.TabIndex = 2;
            this.ServiceDescriptionTextBox.Text = "Description for each service goes here.";
            // 
            // ServiceComboBox
            // 
            this.ServiceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ServiceComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ServiceComboBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceComboBox.Items.AddRange(new object[] {
            "",
            "--LAUNDRY--",
            "*Wash and Fold",
            "*Wash and Press",
            "*Press Only",
            "*Hand Wash",
            "*Comforter",
            "--DRY CLEANING--",
            "*Barong/Coat",
            "*Gown",
            "Carpet Cleaning"});
            this.ServiceComboBox.Location = new System.Drawing.Point(8, 86);
            this.ServiceComboBox.Name = "ServiceComboBox";
            this.ServiceComboBox.Size = new System.Drawing.Size(189, 27);
            this.ServiceComboBox.TabIndex = 1;
            // 
            // ServiceLabel
            // 
            this.ServiceLabel.AutoSize = true;
            this.ServiceLabel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceLabel.Location = new System.Drawing.Point(3, 0);
            this.ServiceLabel.Name = "ServiceLabel";
            this.ServiceLabel.Size = new System.Drawing.Size(165, 29);
            this.ServiceLabel.TabIndex = 0;
            this.ServiceLabel.Text = "Service Type";
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
            this.ConfirmPage.Size = new System.Drawing.Size(626, 423);
            this.ConfirmPage.TabIndex = 1;
            this.ConfirmPage.Text = "2. Confirm Order";
            this.ConfirmPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.50754F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.49246F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 208F));
            this.tableLayoutPanel4.Controls.Add(this.ConfirmCancelButton, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.ConfirmNextButton, 2, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(8, 389);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(612, 34);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // EditOrderButton
            // 
            this.EditOrderButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EditOrderButton.Location = new System.Drawing.Point(405, 3);
            this.EditOrderButton.Name = "EditOrderButton";
            this.EditOrderButton.Size = new System.Drawing.Size(75, 23);
            this.EditOrderButton.TabIndex = 2;
            this.EditOrderButton.Text = "Edit Order";
            this.EditOrderButton.UseVisualStyleBackColor = true;
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
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(525, 29);
            this.label6.TabIndex = 2;
            this.label6.Text = "Kindly make sure that your order\'s correct.";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.tableLayoutPanel5);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(626, 423);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "3. Log-in";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(8, 7);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(347, 29);
            this.label18.TabIndex = 2;
            this.label18.Text = "Have you been here before?";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 264F));
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
            this.label19.Location = new System.Drawing.Point(249, 172);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(57, 31);
            this.label19.TabIndex = 0;
            this.label19.Text = "OR";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExistingUserPanel
            // 
            this.ExistingUserPanel.Controls.Add(this.button8);
            this.ExistingUserPanel.Controls.Add(this.textBox6);
            this.ExistingUserPanel.Controls.Add(this.textBox5);
            this.ExistingUserPanel.Controls.Add(this.label25);
            this.ExistingUserPanel.Controls.Add(this.label21);
            this.ExistingUserPanel.Controls.Add(this.label24);
            this.ExistingUserPanel.Controls.Add(this.label20);
            this.ExistingUserPanel.Location = new System.Drawing.Point(3, 3);
            this.ExistingUserPanel.Name = "ExistingUserPanel";
            this.ExistingUserPanel.Size = new System.Drawing.Size(202, 370);
            this.ExistingUserPanel.TabIndex = 1;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(7, 149);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(149, 45);
            this.button8.TabIndex = 20;
            this.button8.Text = "Submit";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Location = new System.Drawing.Point(7, 111);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(149, 21);
            this.textBox6.TabIndex = 21;
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Location = new System.Drawing.Point(7, 70);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(149, 21);
            this.textBox5.TabIndex = 21;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(4, 94);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(57, 13);
            this.label25.TabIndex = 20;
            this.label25.Text = "Password:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(4, 23);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(96, 13);
            this.label21.TabIndex = 1;
            this.label21.Text = "Please log-in here.";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(4, 53);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(59, 13);
            this.label24.TabIndex = 20;
            this.label24.Text = "Username:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(3, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(51, 23);
            this.label20.TabIndex = 0;
            this.label20.Text = "Yes!";
            // 
            // NewUserPanel
            // 
            this.NewUserPanel.Controls.Add(this.button6);
            this.NewUserPanel.Controls.Add(this.button7);
            this.NewUserPanel.Controls.Add(this.textBox4);
            this.NewUserPanel.Controls.Add(this.textBox3);
            this.NewUserPanel.Controls.Add(this.textBox2);
            this.NewUserPanel.Controls.Add(this.textBox1);
            this.NewUserPanel.Controls.Add(this.ContactNoLabel);
            this.NewUserPanel.Controls.Add(this.AddressLabel);
            this.NewUserPanel.Controls.Add(this.SurnameLabel);
            this.NewUserPanel.Controls.Add(this.FirstNameLabel);
            this.NewUserPanel.Controls.Add(this.label23);
            this.NewUserPanel.Controls.Add(this.label22);
            this.NewUserPanel.Location = new System.Drawing.Point(351, 3);
            this.NewUserPanel.Name = "NewUserPanel";
            this.NewUserPanel.Size = new System.Drawing.Size(258, 370);
            this.NewUserPanel.TabIndex = 2;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 332);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(149, 23);
            this.button6.TabIndex = 19;
            this.button6.Text = "Cancel";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 233);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(149, 45);
            this.button7.TabIndex = 18;
            this.button7.Text = "Submit";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Location = new System.Drawing.Point(12, 188);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(149, 21);
            this.textBox4.TabIndex = 17;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(12, 149);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(149, 21);
            this.textBox3.TabIndex = 16;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(12, 110);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(149, 21);
            this.textBox2.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(12, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 21);
            this.textBox1.TabIndex = 14;
            // 
            // ContactNoLabel
            // 
            this.ContactNoLabel.AutoSize = true;
            this.ContactNoLabel.Location = new System.Drawing.Point(9, 172);
            this.ContactNoLabel.Name = "ContactNoLabel";
            this.ContactNoLabel.Size = new System.Drawing.Size(86, 13);
            this.ContactNoLabel.TabIndex = 13;
            this.ContactNoLabel.Text = "Phone/Mobile #:";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(9, 133);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(50, 13);
            this.AddressLabel.TabIndex = 12;
            this.AddressLabel.Text = "Address:";
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Location = new System.Drawing.Point(9, 94);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(53, 13);
            this.SurnameLabel.TabIndex = 11;
            this.SurnameLabel.Text = "Surname:";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(9, 53);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(62, 13);
            this.FirstNameLabel.TabIndex = 10;
            this.FirstNameLabel.Text = "First Name:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(4, 23);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(168, 13);
            this.label23.TabIndex = 2;
            this.label23.Text = "Fill up the form below to proceed.";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(3, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(66, 23);
            this.label22.TabIndex = 2;
            this.label22.Text = "Nope.";
            // 
            // OrderListTabControl
            // 
            this.OrderListTabControl.Location = new System.Drawing.Point(13, 40);
            this.OrderListTabControl.Name = "OrderListTabControl";
            this.OrderListTabControl.SelectedIndex = 0;
            this.OrderListTabControl.Size = new System.Drawing.Size(604, 250);
            this.OrderListTabControl.TabIndex = 5;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.ForwardOrderButton, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.BackwardOrderButton, 0, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(215, 340);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(200, 41);
            this.tableLayoutPanel6.TabIndex = 6;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.CancelOrderButton, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.EditOrderButton, 1, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(20, 293);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(590, 41);
            this.tableLayoutPanel7.TabIndex = 8;
            // 
            // ConfirmTotalCostLabel
            // 
            this.ConfirmTotalCostLabel.AutoSize = true;
            this.ConfirmTotalCostLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmTotalCostLabel.Location = new System.Drawing.Point(422, 341);
            this.ConfirmTotalCostLabel.Name = "ConfirmTotalCostLabel";
            this.ConfirmTotalCostLabel.Size = new System.Drawing.Size(199, 23);
            this.ConfirmTotalCostLabel.TabIndex = 9;
            this.ConfirmTotalCostLabel.Text = "Total Cost: 210 Php";
            // 
            // CancelOrderButton
            // 
            this.CancelOrderButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CancelOrderButton.Location = new System.Drawing.Point(110, 3);
            this.CancelOrderButton.Name = "CancelOrderButton";
            this.CancelOrderButton.Size = new System.Drawing.Size(75, 23);
            this.CancelOrderButton.TabIndex = 3;
            this.CancelOrderButton.Text = "Cancel Order";
            this.CancelOrderButton.UseVisualStyleBackColor = true;
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
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.MainTabControl);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainWindow";
            this.Text = "Laundry Shop";
            this.MainTabControl.ResumeLayout(false);
            this.OrderPage.ResumeLayout(false);
            this.OrderPage.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ServicePanel.ResumeLayout(false);
            this.ServicePanel.PerformLayout();
            this.ConfirmPage.ResumeLayout(false);
            this.ConfirmPage.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ExistingUserPanel.ResumeLayout(false);
            this.ExistingUserPanel.PerformLayout();
            this.NewUserPanel.ResumeLayout(false);
            this.NewUserPanel.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage OrderPage;
        private System.Windows.Forms.TabPage ConfirmPage;
        private System.Windows.Forms.Label OrderLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MonthCalendar DueDateCalendar;
        private System.Windows.Forms.Label DueDateLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label DetailsLabel;
        private System.Windows.Forms.Panel ServicePanel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox ServiceDescriptionTextBox;
        private System.Windows.Forms.ComboBox ServiceComboBox;
        private System.Windows.Forms.Label ServiceLabel;
        private System.Windows.Forms.Label TotalCostLabel;
        private System.Windows.Forms.Label CostHeadingLabel;
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
        private System.Windows.Forms.Button EditOrderButton;
        private System.Windows.Forms.Button ConfirmCancelButton;
        private System.Windows.Forms.Button ConfirmNextButton;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel ExistingUserPanel;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel NewUserPanel;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
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
        private System.Windows.Forms.Button MakeAddButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TabControl OrderListTabControl;
        private System.Windows.Forms.Label ConfirmTotalCostLabel;
        private System.Windows.Forms.Button CancelOrderButton;
        private System.Windows.Forms.Button ForwardOrderButton;
        private System.Windows.Forms.Button BackwardOrderButton;
    }
}

