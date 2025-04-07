using web_api_labclass_4_mar_25.Entities;

namespace web_api_labclass_4_mar_25.DTOs
{
    public class BannerDTO
    {
        public string Title { get; set; }
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int CompanyId { get; set; }
    }
}
