using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rhino.Mocks;
using System.IO;
using Rhino.Mocks.Constraints;
using Video_Rental;

namespace TestProject2
{
    [TestFixture]
    public class RentalTests4
    {
        [Test]
        public static void Test4_ReportManagerCreateSimpleReport()
        {
            MockRepository rhinoEngine = new MockRepository();
            var mockWriter = rhinoEngine.DynamicMock<TextWriter>();

            TextWriterFactory.SetTextWriter(mockWriter);

            using (rhinoEngine.Record())
            {
                mockWriter.Write("Nothing");

                LastCall.Constraints(new Rhino.Mocks.Constraints.Contains("TestCustomer") &
                                     new Rhino.Mocks.Constraints.Contains("TestMovie") &
                                     new Rhino.Mocks.Constraints.Contains("6 days") &
                                     new Rhino.Mocks.Constraints.Contains(12.ToString("C")) &
                                     new Rhino.Mocks.Constraints.Contains("(Regular)"));

                mockWriter.Flush();
            }

            Customer customer = new Customer("TestCustomer");
            customer.Rentals.Add(new Rental(Movie.Regular("TestMovie"), 6));

            ReportManager.CreateSimpleReport("SomePath", customer);

            rhinoEngine.VerifyAll();
        }
    }
}
