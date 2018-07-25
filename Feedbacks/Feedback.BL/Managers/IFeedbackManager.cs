using System.Collections.Generic;
using Feedback.Common.Dto;

namespace Feedback.BL.Managers
{
    public interface IFeedbackManager
    {
        void AddFeedback(string message);

        IReadOnlyList<FeedbackDto> GetFeedbacks();
    }
}