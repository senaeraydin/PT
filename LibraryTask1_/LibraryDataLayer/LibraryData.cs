namespace LibraryDataLayer
{
    public class LibraryData
    {
        public List<User> Users { get; set; }
        public List<CatalogItem> CatalogItems { get; set; }
        public State State { get; set; }
        public List<Event> Events { get; set; }
    }
}
