using System;

namespace Feedbacks.UI.Models
{
    public class FeedbackUI
    {
        public long Id { get; }

        public string Message { get; }

        public DateTime Date { get; }

        public FeedbackUI(long id, string message, DateTime date)
        {
            Id = id;

            Message = message;

            Date = date;
        }
    }
}