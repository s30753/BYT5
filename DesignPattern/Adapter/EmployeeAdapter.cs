// In case you need some guidance: https://refactoring.guru/design-patterns/adapter
namespace DesignPattern.Adapter
{
    public class EmployeeAdapter : ITarget
    {
        private readonly BillingSystem thirdPartyBillingSystem = new();

        //converting array of strings with employee data to a list of employees suitable for BillingSystem
        public void ProcessCompanySalary(string[,] employeesArray)
        {
            List<Employee> employeeList = new List<Employee>();

            int rows = employeesArray.GetLength(0);

            //taking data from the array and each row being one Employee, and afterward adding employee to the employeeList
            for (int i = 0; i < rows; i++)
            {
                int id = int.Parse(employeesArray[i, 0]);
                string name = employeesArray[i, 1];
                string designation = employeesArray[i, 2];
                decimal salary = decimal.Parse(employeesArray[i, 3]);

                employeeList.Add(new Employee(id, name, designation, salary));
            }

            thirdPartyBillingSystem.ProcessSalary(employeeList);
        }
    }
}
