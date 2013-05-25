namespace LaundryShop.Components
{
    partial class ItemizationWindow
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
            this.ItemizationTable = new System.Windows.Forms.DataGridView();
            this.BrandColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColoredColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ItemizationDoneButton = new System.Windows.Forms.Button();
            this.ItemizationCancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ItemizationTable)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemizationTable
            // 
            this.ItemizationTable.AllowUserToDeleteRows = false;
            this.ItemizationTable.AllowUserToResizeRows = false;
            this.ItemizationTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemizationTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BrandColumn,
            this.TypeColumn,
            this.ColoredColumn});
            this.ItemizationTable.Location = new System.Drawing.Point(22, 12);
            this.ItemizationTable.Name = "ItemizationTable";
            this.ItemizationTable.Size = new System.Drawing.Size(446, 225);
            this.ItemizationTable.TabIndex = 0;
            // 
            // BrandColumn
            // 
            this.BrandColumn.HeaderText = "Brand";
            this.BrandColumn.Name = "BrandColumn";
            // 
            // TypeColumn
            // 
            this.TypeColumn.HeaderText = "Type";
            this.TypeColumn.Name = "TypeColumn";
            // 
            // ColoredColumn
            // 
            this.ColoredColumn.HeaderText = "Color";
            this.ColoredColumn.Name = "ColoredColumn";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ItemizationDoneButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ItemizationCancelButton, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(22, 244);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(446, 31);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // ItemizationDoneButton
            // 
            this.ItemizationDoneButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemizationDoneButton.AutoEllipsis = true;
            this.ItemizationDoneButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemizationDoneButton.Location = new System.Drawing.Point(368, 3);
            this.ItemizationDoneButton.Name = "ItemizationDoneButton";
            this.ItemizationDoneButton.Size = new System.Drawing.Size(75, 23);
            this.ItemizationDoneButton.TabIndex = 0;
            this.ItemizationDoneButton.Text = "Done";
            this.ItemizationDoneButton.UseVisualStyleBackColor = true;
            this.ItemizationDoneButton.Click += new System.EventHandler(this.ItemizationDoneButton_Click);
            // 
            // ItemizationCancelButton
            // 
            this.ItemizationCancelButton.Location = new System.Drawing.Point(3, 3);
            this.ItemizationCancelButton.Name = "ItemizationCancelButton";
            this.ItemizationCancelButton.Size = new System.Drawing.Size(75, 23);
            this.ItemizationCancelButton.TabIndex = 1;
            this.ItemizationCancelButton.Text = "Cancel";
            this.ItemizationCancelButton.UseVisualStyleBackColor = true;
            this.ItemizationCancelButton.Click += new System.EventHandler(this.ItemizationCancelButton_Click);
            // 
            // ItemizationWindow
            // 
            this.AcceptButton = this.ItemizationDoneButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ItemizationCancelButton;
            this.ClientSize = new System.Drawing.Size(491, 308);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ItemizationTable);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ItemizationWindow";
            this.Text = "Itemization";
            ((System.ComponentModel.ISupportInitialize)(this.ItemizationTable)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ItemizationTable;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button ItemizationDoneButton;
        private System.Windows.Forms.Button ItemizationCancelButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrandColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColoredColumn;
    }
}