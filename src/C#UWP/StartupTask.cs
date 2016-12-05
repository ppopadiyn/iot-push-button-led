using Windows.ApplicationModel.Background;

namespace PushButtonLed
{
    public sealed class StartupTask : IBackgroundTask
    {
        private BackgroundTaskDeferral deferral_;

        public void Run(IBackgroundTaskInstance taskInstance)
        {
            deferral_ = taskInstance.GetDeferral();

            new BoardController().Init();
        }
    }
}
