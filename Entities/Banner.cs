namespace web_api_labclass_4_mar_25.Entities
{
    public class Banner
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string Status => EndDate < DateTime.UtcNow ? "Active" : "Completed";
        public Company Company { get; set; }
        public int CompanyId { get; set; }

        public bool IsValidDateRange() => EndDate >= StartDate;
    }
}
