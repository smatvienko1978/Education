using System;
using System.IO;
using System.Text;

namespace Video_Rental
{
    public static class ReportManager
    {
        public static void CreateSimpleReport(string path, Customer customer)
        {
            TextWriter textWriter = TextWriterFactory.GetTextWriter(path);
            var strBuilder = new StringBuilder();
            strBuilder.AppendLine(string.Format("Отчет по клиенту {0}", customer.Name));
            foreach (var rental in customer.Rentals)
                strBuilder.AppendLine(string.Format("{0} ({1}) - {2} days: {3:C}", rental.Movie.Name,
                    rental.Movie.Type.ToString(), rental.Days, rental.CalculateDebt()));
            strBuilder.AppendLine(string.Format("Сумма долга клиента: {0:C}", customer.CalculateDebt()));

            textWriter.Write(strBuilder.ToString());
            textWriter.Flush();
        }
    }
}