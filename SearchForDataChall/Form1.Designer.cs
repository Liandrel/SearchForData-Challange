namespace SearchForDataChall
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
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SearchResults = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ChallangeChoice = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(15, 70);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(6);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(299, 39);
            this.SearchBox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(353, 68);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SearchResults
            // 
            this.SearchResults.FormattingEnabled = true;
            this.SearchResults.ItemHeight = 32;
            this.SearchResults.Location = new System.Drawing.Point(15, 176);
            this.SearchResults.Margin = new System.Windows.Forms.Padding(6);
            this.SearchResults.Name = "SearchResults";
            this.SearchResults.Size = new System.Drawing.Size(1304, 484);
            this.SearchResults.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search Box";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 137);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "results";
            // 
            // ChallangeChoice
            // 
            this.ChallangeChoice.FormattingEnabled = true;
            this.ChallangeChoice.Location = new System.Drawing.Point(811, 69);
            this.ChallangeChoice.Name = "ChallangeChoice";
            this.ChallangeChoice.Size = new System.Drawing.Size(428, 40);
            this.ChallangeChoice.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(811, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Goal/bonus";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 674);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ChallangeChoice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchResults);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SearchBox);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox SearchBox;
        private Button button1;
        private ListBox SearchResults;
        private Label label1;
        private Label label2;
        private ComboBox ChallangeChoice;
        private Label label3;
    }
}