using web_api_labclass_4_mar_25.Entities;

namespace web_api_labclass_4_mar_25.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        private ApplicationDbContext _context;

        public CompanyRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void InsertCompany(Company newCompany)
        {
            _context.Companies.Add(newCompany);
            _context.SaveChanges();
        }

        public List<Company> GetCompanies()
        {
            return _context.Companies.ToList();
        }

        public bool UpdateCompanyName(string currentName, string newName)
        {
            var company = _context.Companies.Where(c => c.Name == currentName).FirstOrDefault();
            if (company == null) { return false; }
            else
            {
                company.Name = newName;
                _context.SaveChanges();
                return true;
            }
        }

        public bool DeleteCompany(string name)
        {
            var company = _context.Companies.FirstOrDefault(c => c.Name == name);
            if (company != null)
            {
                _context.Companies.Remove(company);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
