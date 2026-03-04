namespace MiniKindle501
{
    public partial class MiniKindleView : Form
    {
        public Model model { get; set; }
        public FlipDel flip { get; set; }
        public BkMkDel bkmk { get; set; }
        public SwapBookDel swapBook { get; set; }
        public DeleteBookmarkDel deleteBookmark { get; set; }

        public MiniKindleView(FlipDel fl, BkMkDel mk, Model m, SwapBookDel sb, DeleteBookmarkDel db)
        {
            InitializeComponent();
            flip = fl;
            bkmk = mk;
            swapBook = sb;
            deleteBookmark = db;
            model = m;
            SetupEventHandlers();
            PopulateBookSelector();
        }

        public void Update(bool b)
        {
            if (model?.currBook != null)
            {
                // Update page display
                pageLabel.Text = $"Page {model.currBook.currentPage + 1}";
                
                // Update content if pages exist
                if (model.currBook.pages.Count > 0 && 
                    model.currBook.currentPage >= 0 && 
                    model.currBook.currentPage < model.currBook.pages.Count)
                {
                    contentTextBox.Text = model.currBook.pages[model.currBook.currentPage];
                }
                
                // Update bookmarks display
                UpdateBookmarksList();
                
                // Enable/disable navigation buttons
                previousButton.Enabled = model.currBook.currentPage > 0;
                nextButton.Enabled = model.currBook.currentPage < model.currBook.pages.Count - 1;
                
                // Enable/disable bookmark button based on limit
                addBookmarkButton.Enabled = model.currBook.bookmarks.Count < 5;

                // Update book selector to show current book
                UpdateBookSelector();
            }
        }

        public void OnFlipPress(object o, EventArgs e)
        {
            Button button = o as Button;
            if (button != null && flip != null)
            {
                if (button == nextButton)
                {
                    flip.Invoke(1); // Next page
                }
                else if (button == previousButton)
                {
                    flip.Invoke(-1); // Previous page
                }
            }
        }

        public void OnBkMkPress(object o, EventArgs e)
        {
            if (bkmk != null && model?.currBook != null)
            {
                int currentPage = model.currBook.currentPage;
                bool isBookmarked = model.currBook.bookmarks.Contains(currentPage);
                
                if (isBookmarked)
                {
                    bkmk.Invoke(currentPage, false); // Remove bookmark
                }
                else
                {
                    bkmk.Invoke(currentPage, true); // Add bookmark
                }
            }
        }

        private void OnBookSelectorChanged(object sender, EventArgs e)
        {
            if (swapBook != null && bookSelector.SelectedIndex >= 0)
            {
                swapBook.Invoke(bookSelector.SelectedIndex);
            }
        }

        private void OnDeleteBookmarkPress(object sender, EventArgs e)
        {
            if (deleteBookmark != null && bookmarksListBox.SelectedIndex >= 0)
            {
                deleteBookmark.Invoke(bookmarksListBox.SelectedIndex);
            }
        }

        private void SetupEventHandlers()
        {
            if (previousButton != null) previousButton.Click += OnFlipPress;
            if (nextButton != null) nextButton.Click += OnFlipPress;
            if (addBookmarkButton != null) addBookmarkButton.Click += OnBkMkPress;
            if (bookSelector != null) bookSelector.SelectedIndexChanged += OnBookSelectorChanged;
            if (bookmarksListBox != null) bookmarksListBox.DoubleClick += OnDeleteBookmarkPress;
            if (deleteBookmarkButton != null) deleteBookmarkButton.Click += OnDeleteBookmarkPress;
        }

        private void UpdateBookmarksList()
        {
            bookmarksListBox.Items.Clear();
            if (model?.currBook?.bookmarks != null)
            {
                foreach (int bookmarkPage in model.currBook.bookmarks)
                {
                    bookmarksListBox.Items.Add($"Page {bookmarkPage + 1}");
                }
            }
        }

        private void PopulateBookSelector()
        {
            if (model?.library?.library != null && bookSelector != null)
            {
                bookSelector.Items.Clear();
                for (int i = 0; i < model.library.library.Count; i++)
                {
                    var book = model.library.library[i];
                    bookSelector.Items.Add($"Book {i + 1} - {book.author}");
                }
            }
        }

        private void UpdateBookSelector()
        {
            if (model?.library?.library != null && model.currBook != null && bookSelector != null)
            {
                int currentBookIndex = model.library.library.IndexOf(model.currBook);
                if (currentBookIndex >= 0)
                {
                    bookSelector.SelectedIndex = currentBookIndex;
                }
            }
        }
    }
}