namespace Chinook.Data
{
    public class DataRepository
    {
        static DataRepository()
        {
            Album = new AlbumData();
            Artist = new ArtistData();
            Track = new TrackData();
            Employee = new EmployeeData();
            Customer = new CustomerData();
            Invoice = new InvoiceData();
            InvoiceLine = new InvoiceLineData();
        }

        public static ArtistData Artist { get; }

        public static AlbumData Album { get; }

        public static TrackData Track { get; }

        public static EmployeeData Employee { get; }
        
        public static CustomerData Customer { get; }
        public static InvoiceData Invoice { get; }
        public static InvoiceLineData InvoiceLine { get; }
    }
}
