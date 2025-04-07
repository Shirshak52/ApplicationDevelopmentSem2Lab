using web_api_labclass_4_mar_25.Entities;

namespace web_api_labclass_4_mar_25.Repositories
{
    public class BannerRepository : IBannerRepository
    {
        private ApplicationDbContext _context;

        public BannerRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void InsertBanner(Banner newBanner)
        {
            _context.Banner.Add(newBanner);
            _context.SaveChanges();
        }

        public List<Banner> GetBanners()
        {
            return _context.Banner.ToList();
        }

        public bool UpdateBannerTitle(string currentTitle, string newTitle)
        {
            var banner = _context.Banner.Where(b => b.Title == currentTitle).FirstOrDefault();
            if (banner == null) { return false; }
            else
            {
                banner.Title = newTitle;
                _context.SaveChanges();
                return true;
            }
        }

        public bool DeleteBanner(string title)
        {
            var banner = _context.Banner.FirstOrDefault(b => b.Title == title);
            if (banner != null)
            {
                _context.Banner.Remove(banner);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
