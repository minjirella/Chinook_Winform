namespace Chinook.Data
{
    partial class Invoice : Entity
    {
        public string CustomerName { get; internal set; }
        public override string ToText()
        {
            return CustomerName;
        }
    }
}
