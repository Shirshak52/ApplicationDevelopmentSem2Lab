using web_api_labclass_4_mar_25.Entities;

namespace web_api_labclass_4_mar_25.Repositories
{
    public interface ICompanyRepository
    {
        void InsertCompany(Company newCompany);
        List<Company> GetCompanies();
        bool UpdateCompanyName(string currentName, string newName);
        bool DeleteCompany(string name);
    }
}
