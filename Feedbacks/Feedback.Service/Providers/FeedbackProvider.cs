using System;
using System.Collections.Generic;
using System.Linq;
using Feedback.Service.DAL;
using Feedback.Service.Dto;

namespace Feedback.Service.Providers
{
    public class FeedbackProvider: IFeedbackProvider
    {
        public void AddFeedback(string message)
        {
            using (var context = new FeedbackContext())
            {
                var newFeedback = new DAL.Entities.Feedback();
                newFeedback.Message = message;
                newFeedback.Date = DateTime.Now;

                context.Feedbacks.Add(newFeedback);
                context.SaveChanges();
            }            
        }

        public List<ServerFeedbackDto> GetFeedbacks()
        {
            using (var context = new FeedbackContext())
            {
                var feedbacks = context.Feedbacks.ToList();

                //TODO: automapper
                return feedbacks.Select(x => new ServerFeedbackDto
                {
                    Id = x.Id,
                    Message = x.Message,
                    Date = x.Date
                }).ToList();
            }
        }
    }
}