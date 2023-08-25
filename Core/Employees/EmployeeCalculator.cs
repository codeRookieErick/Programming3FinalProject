namespace Core.Employees;

public class EmployeeCalculator : IEmployeeCalculator
{

    decimal IEmployeeCalculator.CalculateEarningAmount(Employee employee)
        => employee.PricePerHour * employee.HoursCount;

    decimal IEmployeeCalculator.CalculateIncentives(Employee employee)
        => employee.EarningAmount * (employee.EarningAmount < 15000 ? 0.05M : 0.15M);

    decimal IEmployeeCalculator.CalculateTotalEarnings(Employee employee)
        => employee.EarningAmount + employee.Incentives;

    decimal IEmployeeCalculator.CalculateIncomeTax(Employee employee)
    {
        decimal percentage = employee.EarningAmount switch
        {
            decimal x when x <= 10000 => -0M,
            decimal x when x <= 15000 => -0.04M,
            _ => -0.15M
        };

        return employee.EarningAmount * percentage;
    }

    decimal IEmployeeCalculator.CalculateCashAdvances(Employee employee)
        => new List<int> { 1, 2, 7}.Contains(employee.Code) ? -5000 : 0;

    decimal IEmployeeCalculator.CalculateTotalDeductions(Employee employee)
        => employee.IncomeTax + employee.CashAdvances;

    decimal IEmployeeCalculator.CalculateTotalToReceive(Employee employee)
        => employee.TotalEarning + employee.TotalDeductions;
}
