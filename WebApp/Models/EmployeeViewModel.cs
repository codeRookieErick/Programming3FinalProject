using Core.Employees;

namespace WebApp.Models;

public class EmployeeViewModel
{
    public int Code { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public decimal PricePerHour { get; set; }
    public decimal HoursCount { get; set; }

    public decimal EarningAmount { get; private set; }
    public decimal Incentives { get; private set; }
    public decimal TotalEarning { get; private set; }
    public decimal IncomeTax { get; private set; }
    public decimal CashAdvances { get; private set; }
    public decimal TotalDeductions { get; private set; }
    public decimal TotalToReceive { get; private set; }
    public Employee ToEmployee(IEmployeeCalculator employeeCalculator) => new Employee(employeeCalculator)
    {
        Code = this.Code,
        FirstName = this.FirstName,
        LastName = this.LastName,
        HoursCount = this.HoursCount,
        PricePerHour = this.PricePerHour,
    };

    public static EmployeeViewModel FromEmployee(Employee employee) => new EmployeeViewModel
    {
        Code = employee.Code,
        FirstName = employee.FirstName,
        LastName = employee.LastName,
        CashAdvances = employee.CashAdvances,
        EarningAmount = employee.EarningAmount,
        HoursCount = employee.HoursCount,
        Incentives = employee.Incentives,
        IncomeTax = employee.IncomeTax,
        PricePerHour = employee.PricePerHour,
        TotalDeductions = employee.TotalDeductions,
        TotalEarning = employee.TotalEarning,
        TotalToReceive = employee.TotalToReceive
    };
}
