using System.Windows;
using Unity;

namespace Feedbacks.UI.Services.Windows
{
    public class WindowService<TWindow, TViewModel> : IWindowService<TWindow, TViewModel> where TWindow : Window
    {                  
        public TViewModel ShowDialog()
        {
            var window = ((App)Application.Current).Container.Resolve<TWindow>();
            window.ShowDialog();

            return (TViewModel) window.DataContext;
        }
    }
}