using System;
using System.Windows.Input;

namespace Feedbacks.UI.ViewModels
{
    public interface INewFeedbackVm
    {
        string Message { get; set; }

        ICommand SendMessage { get; }

        bool DialogResult { get; set; }

        event EventHandler RequestClose;
    }
}