using BusTicketsSystem.Client.Core.Contracts;
using BusTicketsSystem.Client.Core.Dtos;
using BusTicketsSystem.Services.Contracts;
using System;
using System.Globalization;
using System.Text;

namespace BusTicketsSystem.Client.Core.Commands
{
    public class PrintReviewsCommand : ICommand
    {
        private readonly IBusCompanyService busCompanyService;

        public PrintReviewsCommand(IBusCompanyService busCompanyService)
        {
            this.busCompanyService = busCompanyService;
        }

        public string Execute(string[] args)
        {
            if (args.Length != 1)
            {
                throw new ArgumentException("Invalid data!");
            }

            var isBusCompanyIdValid = int.TryParse(args[0], out int busCompanyId);

            if (!isBusCompanyIdValid)
            {
                throw new ArgumentException("Invalid data!");
            }

            var busCompanyExists = busCompanyService.Exist(busCompanyId);

            if (!busCompanyExists)
            {
                throw new ArgumentException("Bus company not found!");
            }

            var busCompany = busCompanyService.ById<BusCompanyDto>(busCompanyId);

            StringBuilder sb = new StringBuilder();

            foreach (var review in busCompany.Reviews)
            {
                sb.AppendLine($"{review.Id} {review.Grade} " +
                    $"{review.DateAndTimeOfPublishing.ToString("yyyy/MM/dd HH:mm:ss", CultureInfo.InvariantCulture)}");
                sb.AppendLine($"{review.Customer.FirstName} {review.Customer.LastName}");
                sb.AppendLine($"{review.Content}");
                sb.AppendLine();
            }

            return sb.ToString();
        }
    }
}
