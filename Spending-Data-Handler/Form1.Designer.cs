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
            this.dateTxt = new System.Windows.Forms.TextBox();
            this.timeTxt = new System.Windows.Forms.TextBox();
            this.typeLbl = new System.Windows.Forms.Label();
            this.dateLbl = new System.Windows.Forms.Label();
            this.timeLbl = new System.Windows.Forms.Label();
            this.amountTxt = new System.Windows.Forms.TextBox();
            this.AmountLbl = new System.Windows.Forms.Label();
            this.add_SpendingBtn = new System.Windows.Forms.Button();
            this.typeTxt = new System.Windows.Forms.CheckedListBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.titleTxt = new System.Windows.Forms.Label();
            this.itemsTxt = new System.Windows.Forms.TextBox();
            this.itemsLbl = new System.Windows.Forms.Label();
            this.resetBtn = new System.Windows.Forms.Button();
            this.payment_MethodLbl = new System.Windows.Forms.Label();
            this.payment_MethodTxt = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dateTxt
            // 
            this.dateTxt.Location = new System.Drawing.Point(488, 229);
            this.dateTxt.Name = "dateTxt";
            this.dateTxt.Size = new System.Drawing.Size(100, 20);
            this.dateTxt.TabIndex = 3;
            // 
            // timeTxt
            // 
            this.timeTxt.Location = new System.Drawing.Point(488, 259);
            this.timeTxt.Name = "timeTxt";
            this.timeTxt.Size = new System.Drawing.Size(100, 20);
            this.timeTxt.TabIndex = 4;
            // 
            // typeLbl
            // 
            this.typeLbl.AutoSize = true;
            this.typeLbl.Location = new System.Drawing.Point(379, 143);
            this.typeLbl.Name = "typeLbl";
            this.typeLbl.Size = new System.Drawing.Size(31, 13);
            this.typeLbl.TabIndex = 4;
            this.typeLbl.Text = "Type";
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Location = new System.Drawing.Point(379, 229);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(30, 13);
            this.dateLbl.TabIndex = 6;
            this.dateLbl.Text = "Date";
            // 
            // timeLbl
            // 
            this.timeLbl.AutoSize = true;
            this.timeLbl.Location = new System.Drawing.Point(379, 259);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(30, 13);
            this.timeLbl.TabIndex = 7;
            this.timeLbl.Text = "Time";
            // 
            // amountTxt
            // 
            this.amountTxt.Location = new System.Drawing.Point(135, 376);
            this.amountTxt.Name = "amountTxt";
            this.amountTxt.Size = new System.Drawing.Size(172, 20);
            this.amountTxt.TabIndex = 6;
            // 
            // AmountLbl
            // 
            this.AmountLbl.AutoSize = true;
            this.AmountLbl.Location = new System.Drawing.Point(55, 376);
            this.AmountLbl.Name = "AmountLbl";
            this.AmountLbl.Size = new System.Drawing.Size(43, 13);
            this.AmountLbl.TabIndex = 9;
            this.AmountLbl.Text = "Amount";
            // 
            // add_SpendingBtn
            // 
            this.add_SpendingBtn.Location = new System.Drawing.Point(382, 376);
            this.add_SpendingBtn.Name = "add_SpendingBtn";
            this.add_SpendingBtn.Size = new System.Drawing.Size(92, 23);
            this.add_SpendingBtn.TabIndex = 7;
            this.add_SpendingBtn.Text = "Add Spending";
            this.add_SpendingBtn.UseVisualStyleBackColor = true;
            // 
            // typeTxt
            // 
            this.typeTxt.BackColor = System.Drawing.SystemColors.Window;
            this.typeTxt.FormattingEnabled = true;
            this.typeTxt.Items.AddRange(new object[] {
            "Food",
            "Alcohol",
            "Travel",
            "Other"});
            this.typeTxt.Location = new System.Drawing.Point(488, 143);
            this.typeTxt.Name = "typeTxt";
            this.typeTxt.Size = new System.Drawing.Size(100, 64);
            this.typeTxt.TabIndex = 2;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(55, 89);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(35, 13);
            this.nameLbl.TabIndex = 13;
            this.nameLbl.Text = "Name";
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(135, 89);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(453, 20);
            this.nameTxt.TabIndex = 0;
            // 
            // titleTxt
            // 
            this.titleTxt.AutoSize = true;
            this.titleTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTxt.Location = new System.Drawing.Point(254, 28);
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.Size = new System.Drawing.Size(143, 36);
            this.titleTxt.TabIndex = 15;
            this.titleTxt.Text = "Spending";
            // 
            // itemsTxt
            // 
            this.itemsTxt.AcceptsReturn = true;
            this.itemsTxt.Location = new System.Drawing.Point(135, 143);
            this.itemsTxt.Multiline = true;
            this.itemsTxt.Name = "itemsTxt";
            this.itemsTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.itemsTxt.Size = new System.Drawing.Size(172, 163);
            this.itemsTxt.TabIndex = 1;
            // 
            // itemsLbl
            // 
            this.itemsLbl.AutoSize = true;
            this.itemsLbl.Location = new System.Drawing.Point(55, 143);
            this.itemsLbl.Name = "itemsLbl";
            this.itemsLbl.Size = new System.Drawing.Size(32, 13);
            this.itemsLbl.TabIndex = 17;
            this.itemsLbl.Text = "Items";
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(503, 376);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(75, 23);
            this.resetBtn.TabIndex = 8;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            // 
            // payment_MethodLbl
            // 
            this.payment_MethodLbl.AutoSize = true;
            this.payment_MethodLbl.Location = new System.Drawing.Point(379, 286);
            this.payment_MethodLbl.Name = "payment_MethodLbl";
            this.payment_MethodLbl.Size = new System.Drawing.Size(87, 13);
            this.payment_MethodLbl.TabIndex = 20;
            this.payment_MethodLbl.Text = "Payment Method";
            // 
            // payment_MethodTxt
            // 
            this.payment_MethodTxt.FormattingEnabled = true;
            this.payment_MethodTxt.Items.AddRange(new object[] {
            "Cash",
            "Card",
            "Other"});
            this.payment_MethodTxt.Location = new System.Drawing.Point(488, 286);
            this.payment_MethodTxt.Name = "payment_MethodTxt";
            this.payment_MethodTxt.Size = new System.Drawing.Size(100, 21);
            this.payment_MethodTxt.TabIndex = 5;
            // 
            // spendingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(648, 438);
            this.Controls.Add(this.payment_MethodTxt);
            this.Controls.Add(this.payment_MethodLbl);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.itemsLbl);
            this.Controls.Add(this.itemsTxt);
            this.Controls.Add(this.titleTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.typeTxt);
            this.Controls.Add(this.add_SpendingBtn);
            this.Controls.Add(this.AmountLbl);
            this.Controls.Add(this.amountTxt);
            this.Controls.Add(this.timeLbl);
            this.Controls.Add(this.dateLbl);
            this.Controls.Add(this.typeLbl);
            this.Controls.Add(this.timeTxt);
            this.Controls.Add(this.dateTxt);
            this.Name = "spendingForm";
            this.Text = "Spending";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox dateTxt;
        private System.Windows.Forms.TextBox timeTxt;
        private System.Windows.Forms.Label typeLbl;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.TextBox amountTxt;
        private System.Windows.Forms.Label AmountLbl;
        private System.Windows.Forms.Button add_SpendingBtn;
        private System.Windows.Forms.CheckedListBox typeTxt;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label titleTxt;
        private System.Windows.Forms.TextBox itemsTxt;
        private System.Windows.Forms.Label itemsLbl;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Label payment_MethodLbl;
        private System.Windows.Forms.ComboBox payment_MethodTxt;
    }
}

