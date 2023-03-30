using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EmployeeDetailTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetAllEmployeeData()
        {
            var result = WpfApp1.Helper.EmployeeService.GetEmployeeData();
        }

        [TestMethod]
        public void GetEmployeeDetails()
        {
            var employeeId = 1;
            var result = WpfApp1.Helper.EmployeeService.GetEmployeeDetails(employeeId);
        }

        [TestMethod]
        public void AddNewEmployee()
        {

            WpfApp1.Datum emplDetail = new WpfApp1.Datum();
            emplDetail.Name = "abc";
            emplDetail.Email = "abc@gmail.com";
            emplDetail.Status = WpfApp1.Helper.Common.inactive;
            emplDetail.Gender = WpfApp1.Helper.Common.male;

            var response = WpfApp1.Helper.EmployeeService.AddEmployee(emplDetail);

        }

        [TestMethod]
        public void UpdateEmployeeDetails()
        {

            WpfApp1.Datum emplDetail = new WpfApp1.Datum();
            emplDetail.Id = 1;
            emplDetail.Name = "abc";
            emplDetail.Email = "abc@gmail.com";
            emplDetail.Status = WpfApp1.Helper.Common.inactive;
            emplDetail.Gender = WpfApp1.Helper.Common.male;

            WpfApp1.Helper.EmployeeService.UpdateEmployeeDetailsAsync(emplDetail);

        }

        [TestMethod]
        public void DeleteEmployeeData()
        {
            var employeeId = 1;
            WpfApp1.Helper.EmployeeService.DeleteEmployeeData(employeeId);
        }

        [TestMethod]
        public void ValidateEmail()
        {
            var emailId = "abc@gmail.com";
            WpfApp1.Helper.Common.IsValidEmail(emailId);
        }


        [TestMethod]
        public void NumericText()
        {
            var txt = "abc@gmail.com";
            WpfApp1.Helper.Common.IsTextAllowed(txt);
        }

    }

}
