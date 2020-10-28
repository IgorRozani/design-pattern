namespace DesignPattern.Creational
{
    public enum Calculator
    {
        Hourly,
        Monthly
    }

    public abstract class SalaryCalculator
    {
        public abstract decimal Calculate(decimal salary);
    }

    public class MonthlySalaryCalculator : SalaryCalculator
    {
        public override decimal Calculate(decimal salary)
        {
            return 12 * salary;
        }
    }

    public class HourlySalaryCalculator : SalaryCalculator
    {
        public override decimal Calculate(decimal salary)
        {
            return 120 * salary * 12;
        }
    }

    public static class SalaryCalculatorFactory
    {
        public static SalaryCalculator Create(Calculator salaryCalculator)
        {
            if (salaryCalculator == Calculator.Hourly)
                return new HourlySalaryCalculator();
            else if (salaryCalculator == Calculator.Monthly)
                return new MonthlySalaryCalculator();
            else
                throw new System.Exception("Invalid option");
        }
    }
}
