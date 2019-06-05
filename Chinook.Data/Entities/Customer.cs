namespace Chinook.Data
{
    partial class Customer : Entity
    {
        public override string ToText()
        {
            return LastName;
        }

        public string EmployeeName { get; internal set; }

        
    }
}
