namespace MiniKindle501
{
    public class Controller
    {
        public Model model { get; set; }
        public UpdateDel refresh { get; set; }
        public int bkmkCount { get; set; }

        public Controller(Model m)
        {
            model = m;
            bkmkCount = 0;
        }

        public void Registar(UpdateDel v)
        {
            refresh = v;
        }

        public void FlipPage(int dir)
        {
            if (model?.currBook != null)
            {
                model.currBook.FlipPage(dir);
                refresh?.Invoke(true); // Notify view to update
            }
        }

        public void AddRemBkMk(int p, bool a)
        {
            if (model?.currBook != null)
            {
                if (a && model.currBook.bookmarks.Count >= 5)
                {
                    // Already at maximum bookmarks, don't add
                    return;
                }

                model.currBook.AddRemBkMk(p, a);
                
                // Update bookmark count
                bkmkCount = model.currBook.bookmarks.Count;
                
                refresh?.Invoke(true); // Notify view to update
            }
        }

        public void SwapBook(int bookIndex)
        {
            if (model?.library?.library != null && 
                bookIndex >= 0 && 
                bookIndex < model.library.library.Count)
            {
                model.currBook = model.library.library[bookIndex];
                model.currBook.currentPage = 0; // Reset to first page
                bkmkCount = model.currBook.bookmarks.Count;
                refresh?.Invoke(true); // Notify view to update
            }
        }

        public void DeleteBookmark(int bookmarkIndex)
        {
            if (model?.currBook?.bookmarks != null && 
                bookmarkIndex >= 0 && 
                bookmarkIndex < model.currBook.bookmarks.Count)
            {
                model.currBook.bookmarks.RemoveAt(bookmarkIndex);
                bkmkCount = model.currBook.bookmarks.Count;
                refresh?.Invoke(true); // Notify view to update
            }
        }
    }
}