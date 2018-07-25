using System.Data.Entity;

namespace Feedback.Service.DAL
{
    public class FeedbackContext : DbContext
    {
        public FeedbackContext() : base("name=FeedbackConnectionString")
        {
            
        }

        public DbSet<Entities.Feedback> Feedbacks { get; set; }
    }
}