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
            var pageNo = 1;
            var result = WpfApp1.Helper.EmployeeService.GetEmployeeData(pageNo);

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetEmployeeDetails()
        {
            var employeeId = 1;
            var result = WpfApp1.Helper.EmployeeService.GetEmployeeDetails(employeeId);

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void AddNewEmployee()
        {
            try
            {
                WpfApp1.Datum emplDetail = new WpfApp1.Datum();
                emplDetail.Name = "abc";
                emplDetail.Email = "abc@gmail.com";
                emplDetail.Status = WpfApp1.Helper.Common.inactive;
                emplDetail.Gender = WpfApp1.Helper.Common.male;
                
                var response = WpfApp1.Helper.EmployeeService.AddEmployee(emplDetail);

                Assert.AreSame(response.IsSuccessStatusCode, true);
            }
            catch
            {
                Assert.Fail();
            }

        }

        [TestMethod]
        public void UpdateEmployeeDetails()
        {
            try
            {

                WpfApp1.Datum emplDetail = new WpfApp1.Datum();
                emplDetail.Id = 1;
                emplDetail.Name = "abc";
                emplDetail.Email = "abc@gmail.com";
                emplDetail.Status = WpfApp1.Helper.Common.inactive;
                emplDetail.Gender = WpfApp1.Helper.Common.male;

                WpfApp1.Helper.EmployeeService.UpdateEmployeeDetailsAsync(emplDetail);
            }
            catch
            {
                Assert.Fail();
            }

        }

        [TestMethod]
        public void DeleteEmployeeData()
        {
            try
            {
                var employeeId = 1;
                WpfApp1.Helper.EmployeeService.DeleteEmployeeData(employeeId);
            }
            catch
            {
                Assert.Fail();
            }

        }

        [TestMethod]
        public void ValidateEmail()
        {
            var emailId = "abc@gmail.com";
            var expected = true;
            var result = WpfApp1.Helper.Common.IsValidEmail(emailId);
            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void NumericText()
        {
           var txt = "abc@gmail.com";
            var expected = false;

           var result = WpfApp1.Helper.Common.IsTextAllowed(txt);

           Assert.AreEqual(expected, result);
        }

    }

}
