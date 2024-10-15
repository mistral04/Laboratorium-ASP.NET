namespace Laboratorium_1.Models
{
    public class Birth
    {
        public string? X { get; set; }
        public DateTime Y { get; set; }

        public bool IsValid()
        {
            return X != null && DateTime.Compare(DateTime.Now, Y) >= 0;
        }

       public void Birth1()
        {
            Y = DateTime.;
        }
}
