using web_api_labclass_4_mar_25.Entities;

namespace web_api_labclass_4_mar_25.Repositories
{
    public interface IBannerRepository
    {
        void InsertBanner(Banner newBanner);
        List<Banner> GetBanners();
        bool UpdateBannerTitle(string currentTitle, string newTitle);
        bool DeleteBanner(string title);
    }
}
