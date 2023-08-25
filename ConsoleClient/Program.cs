// See https://aka.ms/new-console-template for more information
using Core.Employees;

Console.WriteLine("Hello, World!");

static string Capture(string message)
{
    Console.Write($"{message}: ");
    return Console.ReadLine() ?? string.Empty;
}

static void Print(Employee employee)
{
    Console.WriteLine($"#{employee.Code}: {employee.LastName}, {employee.FirstName}");
    Console.WriteLine();
    Console.WriteLine($"Precio por hora     : {employee.PricePerHour:.##} RD$ / hora");
    Console.WriteLine($"Cantidad de horas   : {employee.HoursCount:.##} horas");
    Console.WriteLine();
    Console.WriteLine($"Monto ganado        : RD$ {employee.EarningAmount:.##}");
    Console.WriteLine($"Incentivos          : RD$ {employee.Incentives:.##}");
    Console.WriteLine($"Total ganado        : RD$ {employee.TotalEarning:.##}");
    Console.WriteLine();
    Console.WriteLine($"ISR                 : RD$ {employee.IncomeTax:.##}");
    Console.WriteLine($"Avances             : RD$ {employee.CashAdvances:.##}");
    Console.WriteLine($"Deducciones         : RD$ {employee.TotalDeductions:.##}");
    Console.WriteLine();
    Console.WriteLine($"Total a recibir     : RD$ {employee.TotalToReceive:.##}");

}

IEmployeeCalculator calculator = new EmployeeCalculator();

Employee employee = new Employee(calculator)
{
    Code = Convert.ToInt32(Capture("Ingrese el codigo del profesor")),
    FirstName = Capture("Ingrese el nombre del profesor"),
    LastName = Capture("Ingrese el apellido del profesor"),
    PricePerHour = Convert.ToDecimal(Capture("Ingrese el precio por hora")),
    HoursCount = Convert.ToDecimal(Capture("Ingrese la cantidad de horas"))
};

Print(employee);
Console.ReadLine();