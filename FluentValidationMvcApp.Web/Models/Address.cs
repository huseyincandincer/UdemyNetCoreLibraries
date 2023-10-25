namespace FluentValidationMvcApp.Web.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string Province { get; set; }
        public string PostCode { get; set; }
        public Customer Customer { get; set; }
    }
}
