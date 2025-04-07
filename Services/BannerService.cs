using web_api_labclass_4_mar_25.DTOs;
using web_api_labclass_4_mar_25.Entities;
using web_api_labclass_4_mar_25.Repositories;

namespace web_api_labclass_4_mar_25.Services
{
    public class BannerService : IBannerService
    {
        private IBannerRepository _bannerRepository;

        public BannerService(IBannerRepository bannerRepository)
        {
            _bannerRepository = bannerRepository;
        }

        public bool AddBanner(BannerDTO bannerDTO)
        {
            var newBanner = new Banner
            {
                Title = bannerDTO.Title,
                StartDate = bannerDTO.StartDate,
                EndDate = bannerDTO.EndDate,
                CompanyId = bannerDTO.CompanyId,
            };

            _bannerRepository.InsertBanner(newBanner);
            return true;
        }

        public List<Banner> GetBanners()
        {
            return _bannerRepository.GetBanners();
        }

        public bool UpdateBannerTitle(string currentTitle, string newTitle)
        {
            var isBannerTitleUpdated = _bannerRepository.UpdateBannerTitle(currentTitle, newTitle);

            return isBannerTitleUpdated;
        }

        public bool DeleteBanner(string title)
        {
            var isBannerDeleted = _bannerRepository.DeleteBanner(title);

            return isBannerDeleted;
        }
    }
}
