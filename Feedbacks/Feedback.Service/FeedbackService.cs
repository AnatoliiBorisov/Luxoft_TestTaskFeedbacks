using System;
using System.Collections.Generic;
using Feedback.Service.Dto;
using Feedback.Service.Providers;

namespace Feedback.Service
{
    public class FeedbackService : IFeedbackService
    {        
        private readonly IFeedbackProvider _feedbackProvider;

        public FeedbackService(IFeedbackProvider feedbackProvider)
        {
            if (feedbackProvider == null)
            {
                throw new ArgumentNullException(nameof(feedbackProvider));
            }

            _feedbackProvider = feedbackProvider;
        }

        public FeedbackService():this(DependencyFactory.Resolve<IFeedbackProvider>())
        {

        }

        public void AddFeedback(string message)
        {
            _feedbackProvider.AddFeedback(message);
        }

        public List<ServerFeedbackDto> GetFeedbacks()
        {
            return _feedbackProvider.GetFeedbacks();
        }
    }
}
