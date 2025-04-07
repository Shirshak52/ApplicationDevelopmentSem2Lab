using Microsoft.AspNetCore.Mvc;
using web_api_labclass_4_mar_25.DTOs;
using web_api_labclass_4_mar_25.Services;
using web_api_labclass_4_mar_25.Entities;

namespace web_api_labclass_4_mar_25.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BannerController : ControllerBase
    {
        private IBannerService _bannerService;
        public BannerController(IBannerService bannerService)
        {
            _bannerService = bannerService;
        }

        [HttpPost("add-banner")]
        public IActionResult AddBanner(BannerDTO bannerInfo)
        {
            var isBannerCreated = _bannerService.AddBanner(bannerInfo);

            if (isBannerCreated)
            {
                return Ok("Banner created");
            }
            return BadRequest("Unable to create banner");
        }

        [HttpGet("get-banners")]
        public List<Banner> GetBanners()
        {
            var bannerList = _bannerService.GetBanners();
            return bannerList;
        }

        [HttpPut("update-banner-title")]
        public IActionResult UpdateBannerTitle(string currentTitle, string newTitle)
        {
            var isBannerTitleUpdated = _bannerService.UpdateBannerTitle(currentTitle, newTitle);
            if (isBannerTitleUpdated)
            {
                return Ok($"Banner title {currentTitle} updated to {newTitle} successfully");
            }
            else
            {
                return BadRequest("Unable to update banner title");
            }
        }

        [HttpDelete("delete-banner")]
        public IActionResult DeleteBanner(string title)
        {
            var isBannerDeleted = _bannerService.DeleteBanner(title);
            if (isBannerDeleted)
            {
                return Ok($"Banner {title} deleted successfully");
            }
            else
            {
                return BadRequest("Unable to delete banner");
            }
        }
    }
}
