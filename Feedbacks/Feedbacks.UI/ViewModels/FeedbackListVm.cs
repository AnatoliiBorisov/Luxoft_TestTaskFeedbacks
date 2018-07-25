using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Feedbacks.UI.Comonents;
using Feedback.BL.Managers;
using Feedbacks.UI.Models;
using Feedbacks.UI.Services.Windows;

namespace Feedbacks.UI.ViewModels
{
    public class FeedbackListVm: BaseVm, IFeedbackListVm
    {
        private readonly ICommand _addfeedback;
        private readonly ICommand _getFeedbacks;
        private readonly IFeedbackManager _feedbackManager;
        private readonly INewFeedbackWindowService _newFeedbackWindowService;

        public FeedbackListVm(IFeedbackManager feedbackManager, INewFeedbackWindowService newFeedbackWindowService)
        {
            if (feedbackManager == null)
            {
                throw new ArgumentNullException(nameof(feedbackManager));
            }

            if (newFeedbackWindowService == null)
            {
                throw new ArgumentNullException(nameof(newFeedbackWindowService));
            }

            _feedbackManager = feedbackManager;
            _newFeedbackWindowService = newFeedbackWindowService;

            _addfeedback = new RelayCommand(_ => OnAddfeedbackClick());
            _getFeedbacks = new RelayCommand(_ => OnGetFeedbacksClick());

            OnGetFeedbacksClick();
        }

        private void OnGetFeedbacksClick()
        {            
            var feedbacks = _feedbackManager
                .GetFeedbacks()
                //TODO: automapper
                .Select(x => new FeedbackUI(x.Id, x.Message, x.Date));

            Feedbacks = new ObservableCollection<FeedbackUI>(feedbacks);

            OnPropertyChanged(nameof(Feedbacks));
        }

        private void OnAddfeedbackClick()
        {
            var viewModel = _newFeedbackWindowService.ShowDialog();

            if (viewModel.DialogResult)
            {
                OnGetFeedbacksClick();
            }            
        }

        public ICommand Addfeedback => _addfeedback;

        public ICommand GetFeedbacks => _getFeedbacks;
        public ObservableCollection<FeedbackUI> Feedbacks { get; set; }
    }
}