using System.Collections.Generic;
using Feedback.Common.Dto;

namespace Feedback.BL.Providers
{
    internal interface IFeedbackProvider
    {
        void AddFeedback(string message);

        IReadOnlyList<FeedbackDto> GetFeedbacks();
    }
}