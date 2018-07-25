using System.Windows;
using Feedbacks.UI.ViewModels;
using Unity.Attributes;

namespace Feedbacks.UI
{
    public partial class NewFeedback : Window
    {
        [Dependency]
        public INewFeedbackVm ViewModel
        {
            set
            {
                DataContext = value;
                value.RequestClose += (s, e) => this.Close();
            }
        }

        public NewFeedback()
        {
            InitializeComponent();
        }
    }
}
