using System;
using System.Collections.Generic;
using Feedback.BL.Providers;
using Feedback.Common.Dto;

namespace Feedback.BL.Managers
{
    internal class FeedbackManager : IFeedbackManager
    {
        private readonly IFeedbackProvider _feedbackProvider;

        public FeedbackManager(IFeedbackProvider feedbackProvider)
        {
            if (feedbackProvider == null)
            {
                throw new ArgumentNullException(nameof(feedbackProvider));
            }

            _feedbackProvider = feedbackProvider;
        }

        public void AddFeedback(string message)
        {
            _feedbackProvider.AddFeedback(message);
        }

        public IReadOnlyList<FeedbackDto> GetFeedbacks()
        {
            return _feedbackProvider.GetFeedbacks();
        }
    }
}