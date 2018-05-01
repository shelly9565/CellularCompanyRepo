using Common.Dtoes;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class ModelExtantions
    {
        public static CallDto ToDto(this Call call)
        {
            if (call == null) return null;
            return new CallDto
            {
                CallId = call.CallId,
                DestinationNumber = call.DestinationNumber,
                Duration = call.Duration,
                ExternalPrice = call.ExternalPrice,
                LineId = call.LineId,
                Line = call.Line.ToDto()
            };
        }

        public static Call ToModel(this CallDto callDto)
        {
            if (callDto == null) return null;
            return new Call
            {
                CallId = callDto.CallId,
                DestinationNumber = callDto.DestinationNumber,
                Duration = callDto.Duration,
                ExternalPrice = callDto.ExternalPrice,
                LineId = callDto.LineId,
                Line = callDto.Line.ToModel()
            };
        }

        public static CustomerDto ToDto(this Customer customer)
        {
            if (customer == null) return null;
            //return new CustomerDto
            //{
            //    CustomerId = customer.CustomerId,
            //    Address = customer.Address,
            //    CallsToCenter = customer.CallsToCenter,
            //    ContactNumber = customer.ContactNumber,
            //    CustomerTypeId = customer.CustomerTypeId,
            //    FirstName = customer.FirstName,
            //    LastName = customer.LastName,
            //    CustomerType = customer.CustomerType.ToDto(),
            //    Lines = customer.Lines.Select(line => line.ToDto()).ToList()
            //};
            CustomerDto c = new CustomerDto();
            c.CustomerId = customer.CustomerId;
            c.Address = customer.Address;
            c.CallsToCenter = customer.CallsToCenter;
            c.ContactNumber = customer.ContactNumber;
            c.CustomerTypeId = customer.CustomerTypeId;
            c.FirstName = customer.FirstName;
            c.LastName = customer.LastName;
            c.CustomerType = customer.CustomerType.ToDto();
            if (c.Lines != null)
                c.Lines = customer.Lines.Select(line => line.ToDto()).ToList();
            return c;

        }

        public static Customer ToModel(this CustomerDto customerDto)
        {
            if (customerDto == null) return null;
            return new Customer
            {
                CustomerId = customerDto.CustomerId,
                Address = customerDto.Address,
                CallsToCenter = customerDto.CallsToCenter,
                ContactNumber = customerDto.ContactNumber,
                CustomerTypeId = customerDto.CustomerTypeId,
                FirstName = customerDto.FirstName,
                LastName = customerDto.LastName,
                CustomerType = customerDto.CustomerType.ToModel(),
                Lines = customerDto.Lines.Select(line => line.ToModel()).ToList()
            };
        }

        public static CustomerTypeDto ToDto(this CustomerType customerType)
        {
            if (customerType == null) return null;
            return new CustomerTypeDto
            {
                CustomerTypeId = customerType.CustomerTypeId,
                TypeName = customerType.TypeName,
                MinutePrice = customerType.MinutePrice,
                SMSPrice = customerType.SMSPrice,
                Customers = customerType.Customers.Select(customer => customer.ToDto()).ToList()
            };
        }

        public static CustomerType ToModel(this CustomerTypeDto customerTypeDto)
        {
            if (customerTypeDto == null) return null;
            return new CustomerType
            {
                CustomerTypeId = customerTypeDto.CustomerTypeId,
                TypeName = customerTypeDto.TypeName,
                MinutePrice = customerTypeDto.MinutePrice,
                SMSPrice = customerTypeDto.SMSPrice,
                Customers = customerTypeDto.Customers.Select(customer => customer.ToModel()).ToList()
            };
        }

        public static LineDto ToDto(this Line line)
        {
            if (line == null) return null;
            return new LineDto
            {
                LineId = line.LineId,
                CustomerId = line.CustomerId,
                Number = line.Number,
                PackageId = line.PackageId,
                Status = line.Status,
                Customer = line.Customer.ToDto(),
                Package = line.Package.ToDto(),
                SMSes = line.SMSes.Select(sms => sms.ToDto()).ToList(),
                Calls = line.Calls.Select(sms => sms.ToDto()).ToList()

            };
        }

        public static Line ToModel(this LineDto lineDto)
        {
            if (lineDto == null) return null;
            return new Line
            {
                LineId = lineDto.LineId,
                CustomerId = lineDto.CustomerId,
                Number = lineDto.Number,
                PackageId = lineDto.PackageId,
                Status = lineDto.Status,
                Customer = lineDto.Customer.ToModel(),
                Package = lineDto.Package.ToModel(),
                SMSes = lineDto.SMSes.Select(sms => sms.ToModel()).ToList(),
                Calls = lineDto.Calls.Select(sms => sms.ToModel()).ToList()
            };
        }

        public static PackageDto ToDto(this Package package)
        {
            if (package == null) return null;
            return new PackageDto
            {
                PackageId = package.PackageId,
                PackageName = package.PackageName,
                PackageTotalPrice = package.PackageTotalPrice,
                PackageIncludes = package.PackageIncludes.Select(packageInclude => packageInclude.ToDto()).ToList(),
                Lines = package.Lines.Select(line => line.ToDto()).ToList()
            };
        }

        public static Package ToModel(this PackageDto packageDto)
        {
            if (packageDto == null) return null;
            return new Package
            {
                PackageId = packageDto.PackageId,
                PackageName = packageDto.PackageName,
                PackageTotalPrice = packageDto.PackageTotalPrice,
                PackageIncludes = packageDto.PackageIncludes.Select(packageInclude => packageInclude.ToModel()).ToList(),
                Lines = packageDto.Lines.Select(line => line.ToModel()).ToList()
            };
        }

        public static PackageIncludeDto ToDto(this PackageInclude packageInclude)
        {
            if (packageInclude == null) return null;
            return new PackageIncludeDto
            {
                PackageIncludeId = packageInclude.PackageIncludeId,
                FavoriteNumbersId = packageInclude.FavoriteNumbersId,
                PackageId = packageInclude.PackageId,
                FixedPrice = packageInclude.FixedPrice,
                IncludeName = packageInclude.IncludeName,
                DiscountPrecentage = packageInclude.DiscountPrecentage,
                MaxMinute = packageInclude.MaxMinute,
                MostCalledNumber = packageInclude.MostCalledNumber,
                InsideFamilyCalls = packageInclude.InsideFamilyCalls,
                Package = packageInclude.Package.ToDto(),
                SelectedNumber = packageInclude.SelectedNumber.ToDto()
            };
        }

        public static PackageInclude ToModel(this PackageIncludeDto packageIncludeDto)
        {
            if (packageIncludeDto == null) return null;
            return new PackageInclude
            {
                PackageIncludeId = packageIncludeDto.PackageIncludeId,
                FavoriteNumbersId = packageIncludeDto.FavoriteNumbersId,
                PackageId = packageIncludeDto.PackageId,
                FixedPrice = packageIncludeDto.FixedPrice,
                IncludeName = packageIncludeDto.IncludeName,
                DiscountPrecentage = packageIncludeDto.DiscountPrecentage,
                MaxMinute = packageIncludeDto.MaxMinute,
                MostCalledNumber = packageIncludeDto.MostCalledNumber,
                InsideFamilyCalls = packageIncludeDto.InsideFamilyCalls,
                Package = packageIncludeDto.Package.ToModel(),
                SelectedNumber = packageIncludeDto.SelectedNumber.ToModel()

            };
        }

        public static PaymentDto ToDto(this Payment payment)
        {
            if (payment == null) return null;
            return new PaymentDto
            {
                CustomerId = payment.CustomerId,
                PaymentId = payment.PaymentId,
                Date = payment.Date,
                TotalPayment = payment.TotalPayment,
                Customer = payment.Customer.ToDto()
            };
        }

        public static Payment ToModel(this PaymentDto paymentDto)
        {
            if (paymentDto == null) return null;
            return new Payment
            {
                CustomerId = paymentDto.CustomerId,
                PaymentId = paymentDto.PaymentId,
                Date = paymentDto.Date,
                TotalPayment = paymentDto.TotalPayment,
                Customer = paymentDto.Customer.ToModel()
            };
        }

        public static SelectedNumberDto ToDto(this SelectedNumber selectedNumber)
        {
            if (selectedNumber == null) return null;
            return new SelectedNumberDto
            {
                SelectedNumberId = selectedNumber.SelectedNumberId,
                FirstNumber = selectedNumber.FirstNumber,
                SecondNumber = selectedNumber.SecondNumber,
                ThirdNumber = selectedNumber.ThirdNumber,
                PackageIncludes = selectedNumber.PackageIncludes.Select(packageIncludes => packageIncludes.ToDto()).ToList()
            };
        }

        public static SelectedNumber ToModel(this SelectedNumberDto selectedNumberDto)
        {
            if (selectedNumberDto == null) return null;
            return new SelectedNumber
            {
                SelectedNumberId = selectedNumberDto.SelectedNumberId,
                FirstNumber = selectedNumberDto.FirstNumber,
                SecondNumber = selectedNumberDto.SecondNumber,
                ThirdNumber = selectedNumberDto.ThirdNumber,
                PackageIncludes = selectedNumberDto.PackageIncludes.Select(packageIncludes => packageIncludes.ToModel()).ToList()

            };
        }

        public static SMSDto ToDto(this SMS sms)
        {
            if (sms == null) return null;
            return new SMSDto
            {
                LineId = sms.LineId,
                SMSId = sms.SMSId,
                DestinationNumber = sms.DestinationNumber,
                ExternalPrice = sms.ExternalPrice,
                Line = sms.Line.ToDto()
            };
        }

        public static SMS ToModel(this SMSDto smsDto)
        {
            if (smsDto == null) return null;
            return new SMS
            {
                LineId = smsDto.LineId,
                SMSId = smsDto.SMSId,
                DestinationNumber = smsDto.DestinationNumber,
                ExternalPrice = smsDto.ExternalPrice,
                Line = smsDto.Line.ToModel()
            };
        }

    }
}
