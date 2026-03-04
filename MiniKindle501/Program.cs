namespace MiniKindle501
{
    // Delegate definitions
    public delegate void FlipDel(int direction);
    public delegate void UpdateDel(bool b);
    public delegate void BkMkDel(int page, bool add);
    public delegate void SwapBookDel(int bookIndex);
    public delegate void DeleteBookmarkDel(int bookmarkIndex);

    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Create sample books
            var book1 = new Book
            {
                author = "F. Scott Fitzgerald",
                pages = new List<string>
                {
                    "In my younger and more vulnerable years my father gave me some advice that I've carried with me ever since.",
                    "'Whenever you feel like criticizing anyone,' he told me, 'just remember that all the people in this world haven't had the advantages that you've had.'",
                    "He didn't say any more, but we've always been unusually communicative in a reserved way, and I understood that he meant a great deal more than that.",
                    "In consequence, I'm inclined to reserve all judgments, a habit that has opened up many curious natures to me."
                }
            };

            var book2 = new Book
            {
                author = "George Orwell",
                pages = new List<string>
                {
                    "It was a bright cold day in April, and the clocks were striking thirteen.",
                    "Winston Smith, his chin nuzzled into his breast in an effort to escape the vile wind, slipped quickly through the glass doors of Victory Mansions.",
                    "The hallway smelt of boiled cabbage and old rag mats.",
                    "At one end of it a coloured poster, too large for indoor display, had been tacked to the wall."
                }
            };

            var book3 = new Book
            {
                author = "Harper Lee",
                pages = new List<string>
                {
                    "When I was almost six and Jem was nearly ten, our summertime boundaries were Mrs. Henry Lafayette Dubose's house.",
                    "Maycomb was an old town, but it was a tired old town when I first knew it.",
                    "In rainy weather the streets turned to red slop; grass grew on the sidewalks, the courthouse sagged in the square."
                }
            };

            var book4 = new Book
            {
                author = "Barak Snir",
                pages = new List<string>
                {
                    "Test page 1 with random words lorem ipsum sitar amat",
                    "Test page 2 with random words dawpihfa0ihnbfboibhfpffu fbnviuabnvuiapbviupbarviupb bvpiuaebrviupbaeriuvbiaebrvuijbapefriuv",
                    "Test page 3 with random words dawddjjhdaobhfbaowfcb  jnjhfhnfhnfhfehhfhewofhfuoefoubfouwbet",
                    "Test page 4 with random words qweqweqeqweqewqeqw rqwrqwrqwrqwrqwrqwfsf sfasfasfdasfdsaf",
                    "Test page 5 with random words cxvxcvcxvxvxcvnxc,vn,xc nv,mxcnv,mxcnvkjbvkjhbskjbvkjhxcbxivbsioud",
                    "Test page 6 with random words popopopo opo[poj pojop kjpoj pojp ojpo jpoj poj pojpo jpojpojpijpokj poij po"
                }
            };

            // Create library with sample books
            var library = new Library(new List<Book> { book1, book2, book3, book4 });

            // Create model with library and current book
            var model = new Model(library, book1);

            // Create controller with model
            var controller = new Controller(model);

            // Create delegates explicitly
            FlipDel flipDelegate = new FlipDel(controller.FlipPage);
            BkMkDel bookmarkDelegate = new BkMkDel(controller.AddRemBkMk);
            SwapBookDel swapBookDelegate = new SwapBookDel(controller.SwapBook);
            DeleteBookmarkDel deleteBookmarkDelegate = new DeleteBookmarkDel(controller.DeleteBookmark);

            // Create view with all delegates
            var view = new MiniKindleView(
                flipDelegate,
                bookmarkDelegate,
                model,
                swapBookDelegate
            );

            // Register view's Update method with controller
            UpdateDel updateDelegate = new UpdateDel(view.Update);
            controller.Registar(updateDelegate);

            // Initial update to populate view
            view.Update(true);

            Application.Run(view);
        }
    }
}