using web_api_labclass_4_mar_25.DTOs;
using web_api_labclass_4_mar_25.Entities;
using web_api_labclass_4_mar_25.Repositories;

namespace web_api_labclass_4_mar_25.Services
{
    public class CompanyService: ICompanyService
    {
        private ICompanyRepository _companyRepository;

        public CompanyService(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        public bool AddCompany(CompanyDTO companyDTO)
        {
            var newCompany = new Company
            {
                Name = companyDTO.Name,
                Email = companyDTO.Email,
                Password = companyDTO.Password,
                Phone = companyDTO.Phone,
            };

            _companyRepository.InsertCompany(newCompany);
            return true;
        }

        public List<Company> GetCompanies()
        {
            return _companyRepository.GetCompanies();
        }

        public bool UpdateCompanyName(string currentName, string newName)
        {
            var isCompanyNameUpdated = _companyRepository.UpdateCompanyName(currentName, newName);

            return isCompanyNameUpdated;
        }

        public bool DeleteCompany(string name)
        {
            var isCompanyDeleted = _companyRepository.DeleteCompany(name);

            return isCompanyDeleted;
        }
    }
}
