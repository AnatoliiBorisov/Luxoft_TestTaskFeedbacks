using System.Windows;
using Feedback.BL;
using Feedbacks.UI.Services.Windows;
using Feedbacks.UI.ViewModels;
using Unity;

namespace Feedbacks.UI
{    
    public partial class App : Application
    {
        public IUnityContainer Container { get; private set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            Container = new UnityContainer();

            Container.AddNewExtension<FeedbackBLExtension>();
            Container.RegisterType<IFeedbackListVm, FeedbackListVm>();
            Container.RegisterType<INewFeedbackVm, NewFeedbackVm>();

            Container.RegisterType<INewFeedbackWindowService, NewFeedbackWindowService>();

            var mainWindow = Container.Resolve<MainWindow>();
            mainWindow.Show();
        }
    }
}
