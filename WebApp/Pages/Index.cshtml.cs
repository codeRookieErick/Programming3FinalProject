using Core.Employees;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp.Models;

namespace WebApp.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public EmployeeViewModel employee { get; set; } = new();

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            
        }

        public void OnPost(EmployeeViewModel employeeViewModel)
        {
            employee = EmployeeViewModel.FromEmployee(
                employeeViewModel.ToEmployee(new EmployeeCalculator())
                .Recalculate()
                );
        }

        public string FormatAmount(decimal value)
        {
            return value < 0 ? $"-RD${(value*-1):#,##0.00}" : $"RD${value:#,##0.00}";
        }
    }
}