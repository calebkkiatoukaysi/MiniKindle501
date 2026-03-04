namespace MiniKindle501
{
    partial class MiniKindleView
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
            this.titleLabel = new Label();
            this.bookSelector = new ComboBox();
            this.contentTextBox = new TextBox();
            this.bookmarksLabel = new Label();
            this.addBookmarkButton = new Button();
            this.deleteBookmarkButton = new Button();
            this.bookmarksListBox = new ListBox();
            this.previousButton = new Button();
            this.nextButton = new Button();
            this.pageLabel = new Label();
            this.instructionLabel = new Label();
            this.SuspendLayout();
            
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.titleLabel.Location = new Point(20, 20);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new Size(105, 25);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Mini Kindle";
            
            // 
            // bookSelector
            // 
            this.bookSelector.DropDownStyle = ComboBoxStyle.DropDownList;
            this.bookSelector.Font = new Font("Segoe UI", 9F);
            this.bookSelector.FormattingEnabled = true;
            this.bookSelector.Location = new Point(300, 22);
            this.bookSelector.Name = "bookSelector";
            this.bookSelector.Size = new Size(200, 23);
            this.bookSelector.TabIndex = 1;
            
            // 
            // contentTextBox
            // 
            this.contentTextBox.Font = new Font("Arial", 11F);
            this.contentTextBox.Location = new Point(20, 70);
            this.contentTextBox.Multiline = true;
            this.contentTextBox.Name = "contentTextBox";
            this.contentTextBox.ReadOnly = true;
            this.contentTextBox.ScrollBars = ScrollBars.Vertical;
            this.contentTextBox.Size = new Size(500, 320);
            this.contentTextBox.TabIndex = 2;
            this.contentTextBox.Text = "Welcome to Mini Kindle!\n\n" +
                                      "Select a book to start reading. " +
                                      "Use the navigation buttons to flip through pages " +
                                      "and add bookmarks to save your progress.";
            
            // 
            // bookmarksLabel
            // 
            this.bookmarksLabel.AutoSize = true;
            this.bookmarksLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.bookmarksLabel.Location = new Point(550, 70);
            this.bookmarksLabel.Name = "bookmarksLabel";
            this.bookmarksLabel.Size = new Size(77, 19);
            this.bookmarksLabel.TabIndex = 3;
            this.bookmarksLabel.Text = "Bookmarks";
            
            // 
            // addBookmarkButton
            // 
            this.addBookmarkButton.Font = new Font("Segoe UI", 9F);
            this.addBookmarkButton.Location = new Point(550, 95);
            this.addBookmarkButton.Name = "addBookmarkButton";
            this.addBookmarkButton.Size = new Size(85, 25);
            this.addBookmarkButton.TabIndex = 4;
            this.addBookmarkButton.Text = "Add Bookmark";
            this.addBookmarkButton.UseVisualStyleBackColor = true;
            
            // 
            // deleteBookmarkButton
            // 
            this.deleteBookmarkButton.BackColor = Color.FromArgb(220, 53, 69);
            this.deleteBookmarkButton.ForeColor = Color.White;
            this.deleteBookmarkButton.FlatStyle = FlatStyle.Flat;
            this.deleteBookmarkButton.Font = new Font("Segoe UI", 9F);
            this.deleteBookmarkButton.Location = new Point(645, 95);
            this.deleteBookmarkButton.Name = "deleteBookmarkButton";
            this.deleteBookmarkButton.Size = new Size(85, 25);
            this.deleteBookmarkButton.TabIndex = 5;
            this.deleteBookmarkButton.Text = "Delete Selected";
            this.deleteBookmarkButton.UseVisualStyleBackColor = false;
            
            // 
            // bookmarksListBox
            // 
            this.bookmarksListBox.Font = new Font("Segoe UI", 9F);
            this.bookmarksListBox.FormattingEnabled = true;
            this.bookmarksListBox.ItemHeight = 15;
            this.bookmarksListBox.Location = new Point(550, 155);
            this.bookmarksListBox.Name = "bookmarksListBox";
            this.bookmarksListBox.Size = new Size(180, 234);
            this.bookmarksListBox.TabIndex = 6;
            
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Font = new Font("Segoe UI", 8F);
            this.instructionLabel.ForeColor = Color.Gray;
            this.instructionLabel.Location = new Point(550, 130);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new Size(150, 13);
            this.instructionLabel.TabIndex = 7;
            this.instructionLabel.Text = "Double-click to delete bookmark";
            
            // 
            // previousButton
            // 
            this.previousButton.Font = new Font("Segoe UI", 9F);
            this.previousButton.Location = new Point(20, 410);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new Size(75, 30);
            this.previousButton.TabIndex = 8;
            this.previousButton.Text = "Previous";
            this.previousButton.UseVisualStyleBackColor = true;
            
            // 
            // nextButton
            // 
            this.nextButton.Font = new Font("Segoe UI", 9F);
            this.nextButton.Location = new Point(445, 410);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new Size(75, 30);
            this.nextButton.TabIndex = 9;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            
            // 
            // pageLabel
            // 
            this.pageLabel.AutoSize = true;
            this.pageLabel.Font = new Font("Segoe UI", 10F);
            this.pageLabel.Location = new Point(250, 417);
            this.pageLabel.Name = "pageLabel";
            this.pageLabel.Size = new Size(45, 19);
            this.pageLabel.TabIndex = 10;
            this.pageLabel.Text = "Page 1";
            
            // 
            // MiniKindleView
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(750, 460);
            this.Controls.Add(this.pageLabel);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.bookmarksListBox);
            this.Controls.Add(this.deleteBookmarkButton);
            this.Controls.Add(this.addBookmarkButton);
            this.Controls.Add(this.bookmarksLabel);
            this.Controls.Add(this.contentTextBox);
            this.Controls.Add(this.bookSelector);
            this.Controls.Add(this.titleLabel);
            this.Font = new Font("Segoe UI", 9F);
            this.Name = "MiniKindleView";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Mini Kindle";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private ComboBox bookSelector;
        private TextBox contentTextBox;
        private Label bookmarksLabel;
        private Button addBookmarkButton;
        private Button deleteBookmarkButton;
        private ListBox bookmarksListBox;
        private Button previousButton;
        private Button nextButton;
        private Label pageLabel;
        private Label instructionLabel;
    }
}