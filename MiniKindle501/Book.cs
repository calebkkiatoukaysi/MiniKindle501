namespace MiniKindle501
{
    public class Book
    {
        public int currentPage { get; set; }
        public List<string> pages { get; set; }
        public string author { get; set; }
        public List<int> bookmarks { get; set; }

        public Book()
        {
            currentPage = 0;
            pages = new List<string>();
            author = string.Empty;
            bookmarks = new List<int>();
        }

        public void AddRemBkMk(int p, bool a)
        {
            if (a) // Add bookmark
            {
                if (!bookmarks.Contains(p) && bookmarks.Count < 5)
                {
                    bookmarks.Add(p);
                }
            }
            else // Remove bookmark
            {
                bookmarks.Remove(p);
            }
        }

        public void FlipPage(int dir)
        {
            if (dir > 0) // Next page
            {
                if (currentPage < pages.Count - 1)
                {
                    currentPage++;
                }
            }
            else if (dir < 0) // Previous page
            {
                if (currentPage > 0)
                {
                    currentPage--;
                }
            }
        }
    }
}