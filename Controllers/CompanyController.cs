using Microsoft.AspNetCore.Mvc;
using web_api_labclass_4_mar_25.DTOs;
using web_api_labclass_4_mar_25.Services;
using web_api_labclass_4_mar_25.Entities;

namespace web_api_labclass_4_mar_25.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CompanyController : ControllerBase
    {
        private ICompanyService _companyService;
        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        [HttpPost("add-company")]
        public IActionResult AddCompany(CompanyDTO companyInfo)
        {
            var isCompanyCreated = _companyService.AddCompany(companyInfo);

            if (isCompanyCreated)
            {
                return Ok("Company created");
            }
            return BadRequest("Unable to create company");
        }

        [HttpGet("get-companies")]
        public List<Company> GetCompanies()
        {
            var companyList = _companyService.GetCompanies();
            return companyList;
        }

        [HttpPut("update-company-name")]
        public IActionResult UpdateCompanyName(string currentName, string newName)
        {
            var isCompanyNameUpdated = _companyService.UpdateCompanyName(currentName, newName);
            if (isCompanyNameUpdated)
            {
                return Ok($"Company name {currentName} updated to {newName} successfully");
            }
            else
            {
                return BadRequest("Unable to update company name");
            }
        }

        [HttpDelete("delete-company")]
        public IActionResult DeleteCompany(string name)
        {
            var isCompanyDeleted = _companyService.DeleteCompany(name);
            if (isCompanyDeleted)
            {
                return Ok($"Company {name} deleted successfully");
            }
            else
            {
                return BadRequest("Unable to delete company");
            }
        }
    }
}
