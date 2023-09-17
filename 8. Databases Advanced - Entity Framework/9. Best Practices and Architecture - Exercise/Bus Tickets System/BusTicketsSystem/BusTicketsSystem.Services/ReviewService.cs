using BusTicketsSystem.Data;
using BusTicketsSystem.Models;
using BusTicketsSystem.Services.Contracts;
using System;
using System.Linq;

namespace BusTicketsSystem.Services
{
    public class ReviewService : IReviewService
    {
        private readonly BusTicketsSystemContext context;

        public ReviewService(BusTicketsSystemContext context)
        {
            this.context = context;
        }

        public void AddReview(int customerId, double grade, string busCompanyName, string content)
        {
            var busCompanyId = context.BusCompanies.Where(x => x.Name == busCompanyName).FirstOrDefault().Id;

            var review = new Review
            {
                Content = content,
                CustomerId = customerId,
                Grade = grade,
                DateAndTimeOfPublishing = DateTime.Now,
                BusCompanyId = busCompanyId
            };

            context.Reviews.Add(review);
            context.SaveChanges();
        }
    }
}
