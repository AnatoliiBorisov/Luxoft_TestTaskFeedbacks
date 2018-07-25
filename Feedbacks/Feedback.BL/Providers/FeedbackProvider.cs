using System.Collections.Generic;
using System.Linq;
using Feedback.BL.FeedbackService;
using Feedback.Common.Dto;

namespace Feedback.BL.Providers
{
    internal class FeedbackProvider : IFeedbackProvider
    {
        public void AddFeedback(string message)
        {
            var feedbackService = new FeedbackServiceClient();
            feedbackService.AddFeedback(message);
            feedbackService.Close();
        }

        public IReadOnlyList<FeedbackDto> GetFeedbacks()
        {
            var feedbackService = new FeedbackServiceClient();
            var feedbacks = feedbackService.GetFeedbacks();
            feedbackService.Close();           

            return feedbacks.Select(x => new FeedbackDto(x.Id, x.Message, x.Date)).ToList();
        }
    }
}