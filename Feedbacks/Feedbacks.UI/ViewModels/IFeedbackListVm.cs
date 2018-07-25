using System.Collections.ObjectModel;
using System.Windows.Input;
using Feedbacks.UI.Models;

namespace Feedbacks.UI.ViewModels
{
    public interface IFeedbackListVm
    {        
        ICommand Addfeedback { get; }

        ICommand GetFeedbacks { get; }

        ObservableCollection<FeedbackUI> Feedbacks { get; set; }
    }
}