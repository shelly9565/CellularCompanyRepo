using Autofac;
using BL.Registrations;
using Common.Dtoes;
using Common.Infra.Providers.Info;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Providers.Logic
{
    public class InvoiceProvider 
    {
        private Object _obj;
        private readonly ICallProvider _callProvider;
        private readonly ISmsProvider _smsProvider;

        public InvoiceProvider()
        {
            _obj = new Object();
            _callProvider = GetContainer().Resolve<ICallProvider>();
            _smsProvider = GetContainer().Resolve<ISmsProvider>();
        }

        private IContainer GetContainer()
        {
            return ModulesRegistrations.RegisterInvoiceModule();
        }

        public async Task<CallDto> CreateCall(CallDto call)
        {
            Task<CallDto> callDto;
            lock (_obj)
            {
                callDto = _callProvider.AddCall(call);
            }
            return await callDto;
        }

        public async Task<SMSDto> CreateSMS(SMSDto sms)
        {
            Task<SMSDto> smsDto;
            lock (_obj)
            {
                smsDto = _smsProvider.AddSMS(sms);
            }
            return await smsDto;
        }

        public void GetDetails(PaymentDto payment)
        {
            List<LineDto> lines = payment.Customer.Lines.ToList();
            double callsExternalPrice = lines.Sum(l => l.Calls.Sum(c => c.ExternalPrice));
            double smsExternalPrice = lines.Sum(l => l.SMSes.Sum(s => s.ExternalPrice));
            double minutePrice = payment.Customer.CustomerType.MinutePrice;
            double smsPrice = payment.Customer.CustomerType.SMSPrice;
            int numberOfSms = lines.Select(l => l.SMSes).Count();
            double packagesPrice = lines.Sum(l => l.Package.PackageTotalPrice);
            //payment.TotalPayment = minutePrice * numberOfCalls + smsPrice * numberOfSms+packagesPrice+callsExternalPrice+smsExternalPrice;
        }

        public void ExportDataToExcel()
        {
            //using (ExcelPackage excel = new ExcelPackage())
            //{
            //    excel.Workbook.Worksheets.Add("Worksheet1");

            //    List<string[]> headerRow = new List<string[]>()
            //    {
            //     new string[] { "Line", "Permanent Billings", "Changed Billings", "Packages Use" }
            //    };
            //    string headerRange = "A1:" + Char.ConvertFromUtf32(headerRow[0].Length + 64) + "1";
            //    var excelWorksheet = excel.Workbook.Worksheets["Worksheet1"];
            //    excelWorksheet.Cells[headerRange].LoadFromArrays(headerRow);

            //    FileInfo excelFile = new FileInfo(@"C:\Users\idoda\Desktop\MonthlyBilling\test.xlsx");
            //    excel.SaveAs(excelFile);
            //}
        }
    }
}
