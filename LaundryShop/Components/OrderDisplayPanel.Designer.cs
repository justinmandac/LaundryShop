namespace LaundryShop.Components
{
    partial class OrderDisplayPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OrderPanel = new System.Windows.Forms.TableLayoutPanel();
            this.OrderCostLabel = new System.Windows.Forms.Label();
            this.CostLabel = new System.Windows.Forms.Label();
            this.ForItemizationLabel = new System.Windows.Forms.Label();
            this.ServiceTypeLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.OrderNoClothesLabel = new System.Windows.Forms.Label();
            this.OrderWeightLabel = new System.Windows.Forms.Label();
            this.SelectedServiceLabel = new System.Windows.Forms.Label();
            this.SelectedDueDateLabel = new System.Windows.Forms.Label();
            this.InputNoClothesLabel = new System.Windows.Forms.Label();
            this.InputWeightLabel = new System.Windows.Forms.Label();
            this.InputItemizationCheckBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.OrderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrderPanel
            // 
            this.OrderPanel.ColumnCount = 3;
            this.OrderPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.24272F));
            this.OrderPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.OrderPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 361F));
            this.OrderPanel.Controls.Add(this.OrderCostLabel, 1, 6);
            this.OrderPanel.Controls.Add(this.CostLabel, 0, 6);
            this.OrderPanel.Controls.Add(this.ForItemizationLabel, 0, 5);
            this.OrderPanel.Controls.Add(this.ServiceTypeLabel, 0, 1);
            this.OrderPanel.Controls.Add(this.label8, 0, 2);
            this.OrderPanel.Controls.Add(this.OrderNoClothesLabel, 0, 3);
            this.OrderPanel.Controls.Add(this.OrderWeightLabel, 0, 4);
            this.OrderPanel.Controls.Add(this.SelectedServiceLabel, 1, 1);
            this.OrderPanel.Controls.Add(this.SelectedDueDateLabel, 1, 2);
            this.OrderPanel.Controls.Add(this.InputNoClothesLabel, 1, 3);
            this.OrderPanel.Controls.Add(this.InputWeightLabel, 1, 4);
            this.OrderPanel.Controls.Add(this.InputItemizationCheckBox, 1, 5);
            this.OrderPanel.Controls.Add(this.button1, 2, 2);
            this.OrderPanel.Controls.Add(this.button2, 2, 5);
            this.OrderPanel.Location = new System.Drawing.Point(3, 3);
            this.OrderPanel.Name = "OrderPanel";
            this.OrderPanel.RowCount = 7;
            this.OrderPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.OrderPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.98039F));
            this.OrderPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.01961F));
            this.OrderPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OrderPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OrderPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OrderPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OrderPanel.Size = new System.Drawing.Size(590, 259);
            this.OrderPanel.TabIndex = 5;
            // 
            // OrderCostLabel
            // 
            this.OrderCostLabel.AutoSize = true;
            this.OrderCostLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderCostLabel.Location = new System.Drawing.Point(133, 216);
            this.OrderCostLabel.Name = "OrderCostLabel";
            this.OrderCostLabel.Size = new System.Drawing.Size(54, 16);
            this.OrderCostLabel.TabIndex = 8;
            this.OrderCostLabel.Text = "210 Php";
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostLabel.Location = new System.Drawing.Point(3, 216);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(46, 18);
            this.CostLabel.TabIndex = 6;
            this.CostLabel.Text = "Cost:";
            // 
            // ForItemizationLabel
            // 
            this.ForItemizationLabel.AutoSize = true;
            this.ForItemizationLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForItemizationLabel.Location = new System.Drawing.Point(3, 177);
            this.ForItemizationLabel.Name = "ForItemizationLabel";
            this.ForItemizationLabel.Size = new System.Drawing.Size(99, 36);
            this.ForItemizationLabel.TabIndex = 5;
            this.ForItemizationLabel.Text = "For Itemization:";
            // 
            // ServiceTypeLabel
            // 
            this.ServiceTypeLabel.AutoSize = true;
            this.ServiceTypeLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceTypeLabel.Location = new System.Drawing.Point(3, 20);
            this.ServiceTypeLabel.Name = "ServiceTypeLabel";
            this.ServiceTypeLabel.Size = new System.Drawing.Size(110, 18);
            this.ServiceTypeLabel.TabIndex = 1;
            this.ServiceTypeLabel.Text = "Service Type:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 18);
            this.label8.TabIndex = 2;
            this.label8.Text = "Due Date:";
            // 
            // OrderNoClothesLabel
            // 
            this.OrderNoClothesLabel.AutoSize = true;
            this.OrderNoClothesLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderNoClothesLabel.Location = new System.Drawing.Point(3, 99);
            this.OrderNoClothesLabel.Name = "OrderNoClothesLabel";
            this.OrderNoClothesLabel.Size = new System.Drawing.Size(104, 18);
            this.OrderNoClothesLabel.TabIndex = 3;
            this.OrderNoClothesLabel.Text = "# of Clothes:";
            // 
            // OrderWeightLabel
            // 
            this.OrderWeightLabel.AutoSize = true;
            this.OrderWeightLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderWeightLabel.Location = new System.Drawing.Point(3, 138);
            this.OrderWeightLabel.Name = "OrderWeightLabel";
            this.OrderWeightLabel.Size = new System.Drawing.Size(107, 36);
            this.OrderWeightLabel.TabIndex = 4;
            this.OrderWeightLabel.Text = "Total Weight (Kg):";
            // 
            // SelectedServiceLabel
            // 
            this.SelectedServiceLabel.AutoSize = true;
            this.SelectedServiceLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedServiceLabel.Location = new System.Drawing.Point(133, 20);
            this.SelectedServiceLabel.Name = "SelectedServiceLabel";
            this.SelectedServiceLabel.Size = new System.Drawing.Size(93, 16);
            this.SelectedServiceLabel.TabIndex = 7;
            this.SelectedServiceLabel.Text = "Wash and Fold";
            // 
            // SelectedDueDateLabel
            // 
            this.SelectedDueDateLabel.AutoSize = true;
            this.SelectedDueDateLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedDueDateLabel.Location = new System.Drawing.Point(133, 60);
            this.SelectedDueDateLabel.Name = "SelectedDueDateLabel";
            this.SelectedDueDateLabel.Size = new System.Drawing.Size(74, 16);
            this.SelectedDueDateLabel.TabIndex = 8;
            this.SelectedDueDateLabel.Text = "03/30/2013";
            // 
            // InputNoClothesLabel
            // 
            this.InputNoClothesLabel.AutoSize = true;
            this.InputNoClothesLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputNoClothesLabel.Location = new System.Drawing.Point(133, 99);
            this.InputNoClothesLabel.Name = "InputNoClothesLabel";
            this.InputNoClothesLabel.Size = new System.Drawing.Size(22, 16);
            this.InputNoClothesLabel.TabIndex = 9;
            this.InputNoClothesLabel.Text = "20";
            // 
            // InputWeightLabel
            // 
            this.InputWeightLabel.AutoSize = true;
            this.InputWeightLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputWeightLabel.Location = new System.Drawing.Point(133, 138);
            this.InputWeightLabel.Name = "InputWeightLabel";
            this.InputWeightLabel.Size = new System.Drawing.Size(15, 16);
            this.InputWeightLabel.TabIndex = 10;
            this.InputWeightLabel.Text = "7";
            // 
            // InputItemizationCheckBox
            // 
            this.InputItemizationCheckBox.AutoSize = true;
            this.InputItemizationCheckBox.Checked = true;
            this.InputItemizationCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.InputItemizationCheckBox.Location = new System.Drawing.Point(133, 180);
            this.InputItemizationCheckBox.Name = "InputItemizationCheckBox";
            this.InputItemizationCheckBox.Size = new System.Drawing.Size(15, 14);
            this.InputItemizationCheckBox.TabIndex = 11;
            this.InputItemizationCheckBox.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(232, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(232, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "View Items";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // OrderDisplayPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.OrderPanel);
            this.Name = "OrderDisplayPanel";
            this.Size = new System.Drawing.Size(597, 265);
            this.OrderPanel.ResumeLayout(false);
            this.OrderPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel OrderPanel;
        private System.Windows.Forms.Label OrderCostLabel;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label ForItemizationLabel;
        private System.Windows.Forms.Label ServiceTypeLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label OrderNoClothesLabel;
        private System.Windows.Forms.Label OrderWeightLabel;
        private System.Windows.Forms.Label SelectedServiceLabel;
        private System.Windows.Forms.Label SelectedDueDateLabel;
        private System.Windows.Forms.Label InputNoClothesLabel;
        private System.Windows.Forms.Label InputWeightLabel;
        private System.Windows.Forms.CheckBox InputItemizationCheckBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

    }
}
