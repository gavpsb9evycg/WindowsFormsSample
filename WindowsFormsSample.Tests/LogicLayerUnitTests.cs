using NUnit.Framework;
using System.Collections.Generic;
using WindowsFormsSample.DataLayer;
using WindowsFormsSample.LogicLayer;

namespace WindowsFormsSample.Tests
{
    public class LogicLayerUnitTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(@"..\..\..\TestData\TestEmployees.csv")]
        public void GetEmployeeListFromCsvTest(string fileName)
        {
            IEnumerable<IEmployee> employeeList = CsvImportHelper.GetEmployeeListFromCsv(fileName);
            CollectionAssert.IsNotEmpty(employeeList);
        }
    }
}