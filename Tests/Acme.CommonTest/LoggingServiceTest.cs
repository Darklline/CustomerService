using System;
using System.Collections.Generic;
using ACM.BL;
using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.CommonTest
{
    [TestClass]
    public class LoggingServiceTest
    {
        [TestMethod]
        public void WriteToFileTest()
        {
            // Arrange
            var changedItems = new List<ILoggable>();
            var customer = new Customer(1)
            {
                EmailAddress = "asd@asd.com",
                FirstName = "Asd",
                LastName = "Asd",
                AddressList = null
            };
            changedItems.Add(customer);
            // Act
            LoggingService.WriteToFile(changedItems);
            // Assert
            // Checkout the output
        }
    }
}
