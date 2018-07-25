using System.Collections.Generic;
using System.ServiceModel;
using Feedback.Service.Dto;

namespace Feedback.Service
{
    [ServiceContract]
    public interface IFeedbackService
    {
        [OperationContract]
        void AddFeedback(string message);

        [OperationContract]
        List<ServerFeedbackDto> GetFeedbacks();
    }
}
