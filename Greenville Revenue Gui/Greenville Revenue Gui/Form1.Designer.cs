namespace Greenville_Revenue_Gui
{
    partial class Form1
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
            this.lastYearBox = new System.Windows.Forms.TextBox();
            this.thisYearBox = new System.Windows.Forms.TextBox();
            this.lastYearBoxLabel = new System.Windows.Forms.Label();
            this.currentYearBoxLabel = new System.Windows.Forms.Label();
            this.totalContestants1 = new System.Windows.Forms.Label();
            this.totalContestants2 = new System.Windows.Forms.Label();
            this.lastRevenueLabel = new System.Windows.Forms.Label();
            this.thisRevenueLabel = new System.Windows.Forms.Label();
            this.dividerLabel = new System.Windows.Forms.Label();
            this.madeMoreLabel = new System.Windows.Forms.Label();
            this.findOutButton = new System.Windows.Forms.Button();
            this.lastYearNumberContestantsLabel = new System.Windows.Forms.Label();
            this.thisYearContestantNumberLabel = new System.Windows.Forms.Label();
            this.lastRevenueTotalLabel = new System.Windows.Forms.Label();
            this.thisRevenueTotalLabel = new System.Windows.Forms.Label();
            this.greaterThanLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lastYearBox
            // 
            this.lastYearBox.Location = new System.Drawing.Point(99, 86);
            this.lastYearBox.Name = "lastYearBox";
            this.lastYearBox.Size = new System.Drawing.Size(100, 20);
            this.lastYearBox.TabIndex = 0;
            // 
            // thisYearBox
            // 
            this.thisYearBox.Location = new System.Drawing.Point(394, 86);
            this.thisYearBox.Name = "thisYearBox";
            this.thisYearBox.Size = new System.Drawing.Size(100, 20);
            this.thisYearBox.TabIndex = 1;
            // 
            // lastYearBoxLabel
            // 
            this.lastYearBoxLabel.AutoSize = true;
            this.lastYearBoxLabel.Location = new System.Drawing.Point(80, 49);
            this.lastYearBoxLabel.Name = "lastYearBoxLabel";
            this.lastYearBoxLabel.Size = new System.Drawing.Size(138, 13);
            this.lastYearBoxLabel.TabIndex = 2;
            this.lastYearBoxLabel.Text = "Total Contestants Last Year";
            // 
            // currentYearBoxLabel
            // 
            this.currentYearBoxLabel.AutoSize = true;
            this.currentYearBoxLabel.Location = new System.Drawing.Point(375, 56);
            this.currentYearBoxLabel.Name = "currentYearBoxLabel";
            this.currentYearBoxLabel.Size = new System.Drawing.Size(138, 13);
            this.currentYearBoxLabel.TabIndex = 3;
            this.currentYearBoxLabel.Text = "Total Contestants This Year";
            // 
            // totalContestants1
            // 
            this.totalContestants1.AutoSize = true;
            this.totalContestants1.Location = new System.Drawing.Point(44, 123);
            this.totalContestants1.Name = "totalContestants1";
            this.totalContestants1.Size = new System.Drawing.Size(211, 13);
            this.totalContestants1.TabIndex = 4;
            this.totalContestants1.Text = "There were this many contestants last year:";
            // 
            // totalContestants2
            // 
            this.totalContestants2.AutoSize = true;
            this.totalContestants2.Location = new System.Drawing.Point(339, 130);
            this.totalContestants2.Name = "totalContestants2";
            this.totalContestants2.Size = new System.Drawing.Size(211, 13);
            this.totalContestants2.TabIndex = 5;
            this.totalContestants2.Text = "There were this many contestants this year:";
            // 
            // lastRevenueLabel
            // 
            this.lastRevenueLabel.AutoSize = true;
            this.lastRevenueLabel.Location = new System.Drawing.Point(96, 165);
            this.lastRevenueLabel.Name = "lastRevenueLabel";
            this.lastRevenueLabel.Size = new System.Drawing.Size(100, 13);
            this.lastRevenueLabel.TabIndex = 6;
            this.lastRevenueLabel.Text = "Last years revenue:";
            // 
            // thisRevenueLabel
            // 
            this.thisRevenueLabel.AutoSize = true;
            this.thisRevenueLabel.Location = new System.Drawing.Point(394, 165);
            this.thisRevenueLabel.Name = "thisRevenueLabel";
            this.thisRevenueLabel.Size = new System.Drawing.Size(100, 13);
            this.thisRevenueLabel.TabIndex = 6;
            this.thisRevenueLabel.Text = "This years revenue:";
            // 
            // dividerLabel
            // 
            this.dividerLabel.AutoSize = true;
            this.dividerLabel.Location = new System.Drawing.Point(151, 202);
            this.dividerLabel.Name = "dividerLabel";
            this.dividerLabel.Size = new System.Drawing.Size(292, 13);
            this.dividerLabel.TabIndex = 7;
            this.dividerLabel.Text = "---------------------------------------------------------------------------------" +
    "--------------";
            // 
            // madeMoreLabel
            // 
            this.madeMoreLabel.AutoSize = true;
            this.madeMoreLabel.Location = new System.Drawing.Point(151, 240);
            this.madeMoreLabel.Name = "madeMoreLabel";
            this.madeMoreLabel.Size = new System.Drawing.Size(83, 13);
            this.madeMoreLabel.TabIndex = 8;
            this.madeMoreLabel.Text = "Who had more?";
            // 
            // findOutButton
            // 
            this.findOutButton.Location = new System.Drawing.Point(260, 259);
            this.findOutButton.Name = "findOutButton";
            this.findOutButton.Size = new System.Drawing.Size(75, 23);
            this.findOutButton.TabIndex = 9;
            this.findOutButton.Text = "Find Out!";
            this.findOutButton.UseVisualStyleBackColor = true;
            this.findOutButton.Click += new System.EventHandler(this.findOutButton_Click);
            // 
            // lastYearNumberContestantsLabel
            // 
            this.lastYearNumberContestantsLabel.AutoSize = true;
            this.lastYearNumberContestantsLabel.Location = new System.Drawing.Point(261, 123);
            this.lastYearNumberContestantsLabel.Name = "lastYearNumberContestantsLabel";
            this.lastYearNumberContestantsLabel.Size = new System.Drawing.Size(0, 13);
            this.lastYearNumberContestantsLabel.TabIndex = 10;
            // 
            // thisYearContestantNumberLabel
            // 
            this.thisYearContestantNumberLabel.AutoSize = true;
            this.thisYearContestantNumberLabel.Location = new System.Drawing.Point(556, 130);
            this.thisYearContestantNumberLabel.Name = "thisYearContestantNumberLabel";
            this.thisYearContestantNumberLabel.Size = new System.Drawing.Size(0, 13);
            this.thisYearContestantNumberLabel.TabIndex = 10;
            // 
            // lastRevenueTotalLabel
            // 
            this.lastRevenueTotalLabel.AutoSize = true;
            this.lastRevenueTotalLabel.Location = new System.Drawing.Point(202, 165);
            this.lastRevenueTotalLabel.Name = "lastRevenueTotalLabel";
            this.lastRevenueTotalLabel.Size = new System.Drawing.Size(0, 13);
            this.lastRevenueTotalLabel.TabIndex = 11;
            // 
            // thisRevenueTotalLabel
            // 
            this.thisRevenueTotalLabel.AutoSize = true;
            this.thisRevenueTotalLabel.Location = new System.Drawing.Point(494, 165);
            this.thisRevenueTotalLabel.Name = "thisRevenueTotalLabel";
            this.thisRevenueTotalLabel.Size = new System.Drawing.Size(0, 13);
            this.thisRevenueTotalLabel.TabIndex = 11;
            // 
            // greaterThanLabel
            // 
            this.greaterThanLabel.AutoSize = true;
            this.greaterThanLabel.Location = new System.Drawing.Point(303, 240);
            this.greaterThanLabel.Name = "greaterThanLabel";
            this.greaterThanLabel.Size = new System.Drawing.Size(0, 13);
            this.greaterThanLabel.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 285);
            this.Controls.Add(this.greaterThanLabel);
            this.Controls.Add(this.thisRevenueTotalLabel);
            this.Controls.Add(this.lastRevenueTotalLabel);
            this.Controls.Add(this.thisYearContestantNumberLabel);
            this.Controls.Add(this.lastYearNumberContestantsLabel);
            this.Controls.Add(this.findOutButton);
            this.Controls.Add(this.madeMoreLabel);
            this.Controls.Add(this.dividerLabel);
            this.Controls.Add(this.thisRevenueLabel);
            this.Controls.Add(this.lastRevenueLabel);
            this.Controls.Add(this.totalContestants2);
            this.Controls.Add(this.totalContestants1);
            this.Controls.Add(this.currentYearBoxLabel);
            this.Controls.Add(this.lastYearBoxLabel);
            this.Controls.Add(this.thisYearBox);
            this.Controls.Add(this.lastYearBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lastYearBox;
        private System.Windows.Forms.TextBox thisYearBox;
        private System.Windows.Forms.Label lastYearBoxLabel;
        private System.Windows.Forms.Label currentYearBoxLabel;
        private System.Windows.Forms.Label totalContestants1;
        private System.Windows.Forms.Label totalContestants2;
        private System.Windows.Forms.Label lastRevenueLabel;
        private System.Windows.Forms.Label thisRevenueLabel;
        private System.Windows.Forms.Label dividerLabel;
        private System.Windows.Forms.Label madeMoreLabel;
        private System.Windows.Forms.Button findOutButton;
        private System.Windows.Forms.Label lastYearNumberContestantsLabel;
        private System.Windows.Forms.Label thisYearContestantNumberLabel;
        private System.Windows.Forms.Label lastRevenueTotalLabel;
        private System.Windows.Forms.Label thisRevenueTotalLabel;
        private System.Windows.Forms.Label greaterThanLabel;
    }
}

