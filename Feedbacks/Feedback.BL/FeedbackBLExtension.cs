using Feedback.BL.Managers;
using Feedback.BL.Providers;
using Unity;
using Unity.Extension;
using Unity.Lifetime;

namespace Feedback.BL
{
    public class FeedbackBLExtension : UnityContainerExtension
    {
        protected override void Initialize()
        {
            Container.RegisterType<IFeedbackProvider, FeedbackProvider>(new SingletonLifetimeManager());
            Container.RegisterType<IFeedbackManager, FeedbackManager>(new SingletonLifetimeManager());
        }
    }
}