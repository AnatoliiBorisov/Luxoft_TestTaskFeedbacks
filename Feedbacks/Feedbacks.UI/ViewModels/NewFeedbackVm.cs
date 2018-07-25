using System;
using System.Windows.Input;
using Feedback.BL.Managers;
using Feedbacks.UI.Comonents;

namespace Feedbacks.UI.ViewModels
{
    public class NewFeedbackVm : BaseVm, INewFeedbackVm
    {
        private bool _dialogResult;

        private readonly IFeedbackManager _feedbackManager;
        public string Message { get; set; }
        public ICommand SendMessage { get; }

        public event EventHandler RequestClose;

        public bool DialogResult { get; set; }
        

        public NewFeedbackVm(IFeedbackManager feedbackManager)
        {
            if (feedbackManager == null)
            {
                throw new ArgumentNullException(nameof(feedbackManager));
            }

            _feedbackManager = feedbackManager;

            SendMessage = new RelayCommand(_ => OnSendMessageClick());
        }

        public void OnRequestClose()
        {
            EventHandler handler = this.RequestClose;
            if (handler != null)
                handler(this, EventArgs.Empty);
        }

        private void OnSendMessageClick()
        {
            _feedbackManager.AddFeedback(Message);
            DialogResult = true;
            OnRequestClose();
        }
    }
}