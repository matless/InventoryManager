namespace InventoryManager
{
    partial class inventoryManagmentStudio
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
            this.label1 = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.inventoryGridView = new System.Windows.Forms.DataGridView();
            this.newButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.skuTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.skuButton = new System.Windows.Forms.Label();
            this.nameButton = new System.Windows.Forms.Label();
            this.categoryButton = new System.Windows.Forms.Label();
            this.priceButton = new System.Windows.Forms.Label();
            this.descriptionButton = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.quantityButton = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1097, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory Managment Studio Premium";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(12, 137);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(360, 20);
            this.priceTextBox.TabIndex = 1;
            // 
            // inventoryGridView
            // 
            this.inventoryGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.inventoryGridView.BackgroundColor = System.Drawing.Color.White;
            this.inventoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventoryGridView.Location = new System.Drawing.Point(12, 207);
            this.inventoryGridView.Name = "inventoryGridView";
            this.inventoryGridView.Size = new System.Drawing.Size(1097, 366);
            this.inventoryGridView.TabIndex = 2;
            this.inventoryGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inventoryGridView_CellDoubleClick);
            // 
            // newButton
            // 
            this.newButton.BackColor = System.Drawing.Color.White;
            this.newButton.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newButton.Location = new System.Drawing.Point(12, 163);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(360, 38);
            this.newButton.TabIndex = 3;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = false;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.White;
            this.deleteButton.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteButton.Location = new System.Drawing.Point(749, 163);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(360, 38);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.White;
            this.saveButton.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.saveButton.Location = new System.Drawing.Point(378, 163);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(365, 38);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(378, 137);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(365, 20);
            this.descriptionTextBox.TabIndex = 6;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(749, 137);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(360, 20);
            this.quantityTextBox.TabIndex = 7;
            // 
            // skuTextBox
            // 
            this.skuTextBox.Location = new System.Drawing.Point(12, 101);
            this.skuTextBox.Name = "skuTextBox";
            this.skuTextBox.Size = new System.Drawing.Size(360, 20);
            this.skuTextBox.TabIndex = 8;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(378, 101);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(365, 20);
            this.nameTextBox.TabIndex = 9;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Items.AddRange(new object[] {
            "Automotive",
            "Hardware",
            "Clothes",
            ""});
            this.categoryComboBox.Location = new System.Drawing.Point(749, 100);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(360, 21);
            this.categoryComboBox.TabIndex = 10;
            // 
            // skuButton
            // 
            this.skuButton.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.skuButton.ForeColor = System.Drawing.Color.White;
            this.skuButton.Location = new System.Drawing.Point(9, 84);
            this.skuButton.Name = "skuButton";
            this.skuButton.Size = new System.Drawing.Size(360, 14);
            this.skuButton.TabIndex = 11;
            this.skuButton.Text = "SKU:";
            // 
            // nameButton
            // 
            this.nameButton.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameButton.ForeColor = System.Drawing.Color.White;
            this.nameButton.Location = new System.Drawing.Point(375, 84);
            this.nameButton.Name = "nameButton";
            this.nameButton.Size = new System.Drawing.Size(360, 14);
            this.nameButton.TabIndex = 12;
            this.nameButton.Text = "Name:";
            // 
            // categoryButton
            // 
            this.categoryButton.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.categoryButton.ForeColor = System.Drawing.Color.White;
            this.categoryButton.Location = new System.Drawing.Point(746, 84);
            this.categoryButton.Name = "categoryButton";
            this.categoryButton.Size = new System.Drawing.Size(360, 14);
            this.categoryButton.TabIndex = 13;
            this.categoryButton.Text = "Category:";
            // 
            // priceButton
            // 
            this.priceButton.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.priceButton.ForeColor = System.Drawing.Color.White;
            this.priceButton.Location = new System.Drawing.Point(9, 120);
            this.priceButton.Name = "priceButton";
            this.priceButton.Size = new System.Drawing.Size(360, 14);
            this.priceButton.TabIndex = 14;
            this.priceButton.Text = "Price:";
            // 
            // descriptionButton
            // 
            this.descriptionButton.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.descriptionButton.ForeColor = System.Drawing.Color.White;
            this.descriptionButton.Location = new System.Drawing.Point(375, 120);
            this.descriptionButton.Name = "descriptionButton";
            this.descriptionButton.Size = new System.Drawing.Size(360, 14);
            this.descriptionButton.TabIndex = 15;
            this.descriptionButton.Text = "Description";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 0;
            // 
            // quantityButton
            // 
            this.quantityButton.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.quantityButton.ForeColor = System.Drawing.Color.White;
            this.quantityButton.Location = new System.Drawing.Point(746, 120);
            this.quantityButton.Name = "quantityButton";
            this.quantityButton.Size = new System.Drawing.Size(360, 14);
            this.quantityButton.TabIndex = 16;
            this.quantityButton.Text = "Quantity:";
            // 
            // inventoryManagmentStudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(1121, 585);
            this.Controls.Add(this.quantityButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.descriptionButton);
            this.Controls.Add(this.priceButton);
            this.Controls.Add(this.categoryButton);
            this.Controls.Add(this.nameButton);
            this.Controls.Add(this.skuButton);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.skuTextBox);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.inventoryGridView);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.label1);
            this.Name = "inventoryManagmentStudio";
            this.Text = "Inventory Managment Studio";
            this.Load += new System.EventHandler(this.inventoryManagmentStudio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.DataGridView inventoryGridView;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox skuTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label skuButton;
        private System.Windows.Forms.Label nameButton;
        private System.Windows.Forms.Label categoryButton;
        private System.Windows.Forms.Label priceButton;
        private System.Windows.Forms.Label descriptionButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label quantityButton;
    }
}

