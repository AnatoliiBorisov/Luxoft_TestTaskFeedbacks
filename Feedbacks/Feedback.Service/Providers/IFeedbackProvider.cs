using System.Collections.Generic;
using Feedback.Service.Dto;

namespace Feedback.Service.Providers
{
    public interface IFeedbackProvider
    {
        void AddFeedback(string message);

        List<ServerFeedbackDto> GetFeedbacks();
    }
}