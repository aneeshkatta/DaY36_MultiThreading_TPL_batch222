using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading_EmpPayRoll_222Batch
{
    public  class Program
    {
        public static void Main()
        {
            List<EmployeeModel> employeeDetails = new List<EmployeeModel>();
            employeeDetails.Add(new EmployeeModel(Name: "ram", Salary: 30000, StartDate: new DateTime(2022, 07, 08), Gender: "M", MobileNo: 987732, Address: "Goa", Department: "IT", Deductions: 1200, Taxable_Pay: 500, Income_Tax: 600, Net_Pay: 19500, Basic_pay: 29500));
            employeeDetails.Add(new EmployeeModel(Name: "raju", Salary: 80000, StartDate: new DateTime(2022, 05, 09), Gender: "M", MobileNo: 716098, Address: "shimla", Department: "HR", Deductions: 1200, Taxable_Pay: 500, Income_Tax: 600, Net_Pay: 19500 , Basic_pay: 39500));
            employeeDetails.Add(new EmployeeModel(Name: "kranthi", Salary: 90000, StartDate: new DateTime(2022, 04, 11), Gender: "M", MobileNo: 610987, Address: "haryana", Department: "Accounts", Deductions: 1200, Taxable_Pay: 500, Income_Tax: 600, Net_Pay: 19500, Basic_pay: 29500));
            employeeDetails.Add(new EmployeeModel(Name: "manoj", Salary: 60000, StartDate: new DateTime(2022, 03, 12), Gender: "M", MobileNo: 721098, Address: "punjab", Department: "IT", Deductions: 1200, Taxable_Pay: 500, Income_Tax: 600, Net_Pay: 19500, Basic_pay: 19000));
            employeeDetails.Add(new EmployeeModel(Name: "vikram", Salary:86000, StartDate: new DateTime(2022, 02, 13), Gender: "F", MobileNo: 895321, Address: "ahmedabad", Department: "Finance", Deductions: 1200, Taxable_Pay: 500, Income_Tax: 600, Net_Pay: 19500, Basic_pay: 19000));
            EmployeeRepo objRepo = new EmployeeRepo();
            objRepo.CheckConnection();   
            DateTime startTime = DateTime.Now;
            objRepo.TestMethod1_AddingEmployeeData_Without_Thread(employeeDetails);
            DateTime endTime = DateTime.Now;
            Console.WriteLine("Duration without thread = " + (endTime - startTime));
            // objRepo.GetAllEmployee();
            DateTime startTime2 = DateTime.Now;
            objRepo.TestMethod1_AddingEmployeeData_With_Thread(employeeDetails);
            DateTime endTime2 = DateTime.Now;
            Console.WriteLine("Duration with thread = " + (endTime2 - startTime2));
           // objRepo.GetAllEmployee();
        }
    }
}
