namespace Core.Employees;

public interface IEmployeeCalculator
{
    decimal CalculateEarningAmount(Employee employee);
    decimal CalculateIncentives(Employee employee);
    decimal CalculateTotalEarnings(Employee employee);
    decimal CalculateIncomeTax(Employee employee);
    decimal CalculateCashAdvances(Employee employee);
    decimal CalculateTotalDeductions(Employee employee);
    decimal CalculateTotalToReceive(Employee employee);
}
