using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading_EmpPayRoll_222Batch
{
    public class EmployeeModel
    {
        public int EmployeeId { get; set; }
        public double Salary { get; set; }
        public DateTime StartDate { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public double MobileNo { get; set; }
        public string Department { get; set; }
        public double Deductions { get; set; }
        public double Basic_pay { get; set; }
        public double Taxable_Pay { get; set; }
        public double Income_Tax { get; set; }
        public double Net_Pay { get; set; }

        public EmployeeModel(string Name, int Salary, DateTime StartDate, string Gender, int MobileNo, string Address, string Department, int Deductions, int Taxable_Pay, int Income_Tax, int Net_Pay, double Basic_pay)
        {
            this.Name = Name;
            this.Salary = Salary;
            this.StartDate = StartDate;
            this.Gender = Gender;
            this.MobileNo = MobileNo;
            this.Address = Address;
            this.Department = Department;
            this.Deductions = Deductions;
            this.Taxable_Pay = Taxable_Pay;
            this.Income_Tax = Income_Tax;
            this.Net_Pay = Net_Pay;
            this.Basic_pay = Basic_pay;
        }
    }
}
