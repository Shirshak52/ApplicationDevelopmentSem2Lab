using web_api_labclass_4_mar_25.DTOs;
using web_api_labclass_4_mar_25.Entities;

namespace web_api_labclass_4_mar_25.Services
{
    public interface ICompanyService
    {
        bool AddCompany(CompanyDTO companyDTO);
        List<Company> GetCompanies();
        bool UpdateCompanyName(string currentName, string newName);
        bool DeleteCompany(string name);

    }
}
