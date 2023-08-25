namespace Core.Employees;

public class Employee
{
    private readonly IEmployeeCalculator calculator;

    public Employee(IEmployeeCalculator calculator)
    {
        this.calculator = calculator;
    }
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

    public Employee Recalculate()
    {
        EarningAmount = calculator.CalculateEarningAmount(this);
        Incentives = calculator.CalculateIncentives(this);
        TotalEarning = calculator.CalculateTotalEarnings(this);
        IncomeTax = calculator.CalculateIncomeTax(this);
        CashAdvances = calculator.CalculateCashAdvances(this);
        TotalDeductions = calculator.CalculateTotalDeductions(this);
        TotalToReceive = calculator.CalculateTotalToReceive(this);
        return this;
    }
}
