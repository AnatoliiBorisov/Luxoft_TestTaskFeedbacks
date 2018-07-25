using System.Windows;
using Feedbacks.UI.ViewModels;
using Unity.Attributes;

namespace Feedbacks.UI
{
    public partial class MainWindow : Window
    {
        [Dependency]
        public IFeedbackListVm ViewModel
        {
            set
            {
                DataContext = value;
            }
        }

        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
