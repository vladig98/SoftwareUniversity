using BusTicketsSystem.Client.Core.Contracts;
using BusTicketsSystem.Client.Core.Dtos;
using BusTicketsSystem.Services.Contracts;
using System;
using System.Linq;

namespace BusTicketsSystem.Client.Core.Commands
{
    public class PublishReviewCommand : ICommand
    {
        private readonly ICustomerService customerService;
        private readonly IBusCompanyService busCompanyService;
        private readonly IReviewService reviewService;

        public PublishReviewCommand(ICustomerService customerService, IBusCompanyService busCompanyService, IReviewService reviewService)
        {
            this.customerService = customerService;
            this.busCompanyService = busCompanyService;
            this.reviewService = reviewService;
        }

        public string Execute(string[] args)
        {
            if (args.Length < 4)
            {
                throw new ArgumentException("Invalid data!");
            }

            var isCustomerIdValid = int.TryParse(args[0], out int customerId);
            var isGradeValid = double.TryParse(args[1], out double grade);
            var busCompanyName = args[2].Replace("_", " ");
            var content = string.Join(" ", args.Skip(3).ToArray());

            if (!isCustomerIdValid || !isGradeValid || string.IsNullOrEmpty(busCompanyName) || string.IsNullOrWhiteSpace(busCompanyName)
                || string.IsNullOrEmpty(content) || string.IsNullOrWhiteSpace(content))
            {
                throw new ArgumentException("Invalid data!");
            }

            var customerExists = customerService.Exist(customerId);

            if (!customerExists)
            {
                throw new ArgumentException("Customer not found!");
            }

            if (grade < 1.0 || grade > 10.0)
            {
                throw new ArgumentException("Grade not found!");
            }

            var busCompanyExists = busCompanyService.Exist(busCompanyName);

            if (!busCompanyExists)
            {
                throw new ArgumentException("Bus company not found!");
            }

            reviewService.AddReview(customerId, grade, busCompanyName, content);

            var customer = customerService.ById<CustomerDto>(customerId);

            return $"Customer {customer.FirstName} {customer.LastName} published review for company {busCompanyName}";
        }
    }
}
