using System;

namespace Feedback.Common.Dto
{
    public class FeedbackDto
    {
        public long Id { get; }

        public string Message { get; }

        public DateTime Date { get; }

        public FeedbackDto(long id, string message, DateTime date)
        {
            Id = id;

            Message = message;

            Date = date;
        }
    }
}