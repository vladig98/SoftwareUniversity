namespace BusTicketsSystem.Services.Contracts
{
    public interface IReviewService
    {
        void AddReview(int customerId, double grade, string busCompanyName, string content);
    }
}
