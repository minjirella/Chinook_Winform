namespace Chinook.Data
{
    partial class InvoiceLine : Entity
    {
        public string TrackName { get; internal set; }
        public string ArtistName { get; internal set; }

        public override string ToText()
        {
            return TrackName;
        }
    }
}
