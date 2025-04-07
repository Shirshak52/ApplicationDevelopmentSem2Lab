using System.ComponentModel.DataAnnotations;

namespace web_api_labclass_4_mar_25.DTOs
{
    public class CompanyDTO
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

        [Required]
        public string Phone { get; set; }
    }
}
