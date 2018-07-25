using System;
using System.Runtime.Serialization;

namespace Feedback.Service.Dto
{
    [DataContract]
    public class ServerFeedbackDto
    {
        [DataMember]
        public long Id { get; set; }

        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public DateTime Date { get; set; }        
    }
}