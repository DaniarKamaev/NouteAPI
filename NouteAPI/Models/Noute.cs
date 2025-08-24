namespace NouteAPI.Models
{
    public class Noute
    {
        public Guid id { get; set; }
        public Guid ounerId { get; set; }
        public DateTime date { get; set; }
        public string lable { get; set; }
        public string text { get; set; }
    }
}
