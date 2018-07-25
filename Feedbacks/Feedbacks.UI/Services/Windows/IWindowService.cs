using System.Windows;

namespace Feedbacks.UI.Services.Windows
{
    public interface IWindowService<TWindow, TViewModel> where TWindow : Window
    {
        TViewModel ShowDialog();
    }
}