namespace Spending_Data_Handler
{
    partial class spendingForm
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
            this.txtTime = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.btnAdd_Spending = new System.Windows.Forms.Button();
            this.txtType = new System.Windows.Forms.CheckedListBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtItems = new System.Windows.Forms.TextBox();
            this.lblItems = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblPayment_Method = new System.Windows.Forms.Label();
            this.txtPayment_Method = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(488, 259);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(148, 20);
            this.txtTime.TabIndex = 4;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(379, 143);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 4;
            this.lblType.Text = "Type";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(379, 229);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Date";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(379, 259);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(30, 13);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "Time";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(116, 376);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(191, 20);
            this.txtAmount.TabIndex = 6;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(41, 376);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(43, 13);
            this.lblAmount.TabIndex = 9;
            this.lblAmount.Text = "Amount";
            // 
            // btnAdd_Spending
            // 
            this.btnAdd_Spending.Location = new System.Drawing.Point(382, 371);
            this.btnAdd_Spending.Name = "btnAdd_Spending";
            this.btnAdd_Spending.Size = new System.Drawing.Size(92, 23);
            this.btnAdd_Spending.TabIndex = 7;
            this.btnAdd_Spending.Text = "Add Spending";
            this.btnAdd_Spending.UseVisualStyleBackColor = true;
            this.btnAdd_Spending.Click += new System.EventHandler(this.btnAdd_Spending_Click);
            // 
            // txtType
            // 
            this.txtType.BackColor = System.Drawing.SystemColors.Window;
            this.txtType.FormattingEnabled = true;
            this.txtType.Items.AddRange(new object[] {
            "Food",
            "Alcohol",
            "Travel",
            "Other"});
            this.txtType.Location = new System.Drawing.Point(488, 143);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(148, 64);
            this.txtType.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(41, 89);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(116, 89);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(520, 20);
            this.txtName.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(279, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(143, 36);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "Spending";
            // 
            // txtItems
            // 
            this.txtItems.AcceptsReturn = true;
            this.txtItems.Location = new System.Drawing.Point(116, 143);
            this.txtItems.Multiline = true;
            this.txtItems.Name = "txtItems";
            this.txtItems.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtItems.Size = new System.Drawing.Size(191, 163);
            this.txtItems.TabIndex = 1;
            // 
            // lblItems
            // 
            this.lblItems.AutoSize = true;
            this.lblItems.Location = new System.Drawing.Point(41, 143);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(32, 13);
            this.lblItems.TabIndex = 17;
            this.lblItems.Text = "Items";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(561, 374);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblPayment_Method
            // 
            this.lblPayment_Method.AutoSize = true;
            this.lblPayment_Method.Location = new System.Drawing.Point(379, 286);
            this.lblPayment_Method.Name = "lblPayment_Method";
            this.lblPayment_Method.Size = new System.Drawing.Size(87, 13);
            this.lblPayment_Method.TabIndex = 20;
            this.lblPayment_Method.Text = "Payment Method";
            // 
            // txtPayment_Method
            // 
            this.txtPayment_Method.FormattingEnabled = true;
            this.txtPayment_Method.Items.AddRange(new object[] {
            "Cash",
            "Card",
            "Other"});
            this.txtPayment_Method.Location = new System.Drawing.Point(488, 286);
            this.txtPayment_Method.Name = "txtPayment_Method";
            this.txtPayment_Method.Size = new System.Drawing.Size(148, 21);
            this.txtPayment_Method.TabIndex = 5;
            this.txtPayment_Method.Text = "Cash";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(488, 229);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(148, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // spendingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(701, 438);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtPayment_Method);
            this.Controls.Add(this.lblPayment_Method);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblItems);
            this.Controls.Add(this.txtItems);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.btnAdd_Spending);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.txtTime);
            this.Name = "spendingForm";
            this.Text = "Spending";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Button btnAdd_Spending;
        private System.Windows.Forms.CheckedListBox txtType;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtItems;
        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblPayment_Method;
        private System.Windows.Forms.ComboBox txtPayment_Method;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

