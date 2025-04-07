using web_api_labclass_4_mar_25.DTOs;
using web_api_labclass_4_mar_25.Entities;

namespace web_api_labclass_4_mar_25.Services
{
    public interface IBannerService
    {
        bool AddBanner(BannerDTO bannerDTO);
        List<Banner> GetBanners();
        bool UpdateBannerTitle(string currentTitle, string newTitle);
        bool DeleteBanner(string title);
    }
}
