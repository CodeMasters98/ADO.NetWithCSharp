namespace ADO.NetWithCSharp
{
    partial class Form1
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
            this.PeopleGridView = new System.Windows.Forms.DataGridView();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.callApiButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PeopleGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PeopleGridView
            // 
            this.PeopleGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PeopleGridView.Location = new System.Drawing.Point(12, 130);
            this.PeopleGridView.Name = "PeopleGridView";
            this.PeopleGridView.RowTemplate.Height = 25;
            this.PeopleGridView.Size = new System.Drawing.Size(637, 302);
            this.PeopleGridView.TabIndex = 0;
            this.PeopleGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.PeopleGridView_CellEnter);
            this.PeopleGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.PeopleGridView_RowEnter);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(103, 8);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(146, 23);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(103, 37);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(146, 23);
            this.lastNameTextBox.TabIndex = 2;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(103, 66);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(146, 23);
            this.phoneNumberTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "FirstName: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "LastName:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "PhoneNumber:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "Insert Record";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // callApiButton
            // 
            this.callApiButton.Location = new System.Drawing.Point(255, 9);
            this.callApiButton.Name = "callApiButton";
            this.callApiButton.Size = new System.Drawing.Size(202, 51);
            this.callApiButton.TabIndex = 8;
            this.callApiButton.Text = "Call Api";
            this.callApiButton.UseVisualStyleBackColor = true;
            this.callApiButton.Click += new System.EventHandler(this.callApiButton_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(255, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(202, 58);
            this.button2.TabIndex = 9;
            this.button2.Text = "Call Api Async";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 444);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.callApiButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.PeopleGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PeopleGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView PeopleGridView;
        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private TextBox phoneNumberTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button callApiButton;
        private Button button2;
    }
}