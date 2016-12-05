using Windows.Devices.Gpio;

namespace PushButtonLed
{
    public sealed class BoardController
    {
        private LedController led_;
        private ButtonController button_;

        public void Init()
        {
            led_ = new LedController(5);
            button_ = new ButtonController(6, GpioPinDriveMode.InputPullUp);
            button_.Pressed += (sender, args) =>
            {
                if (args.Edge == GpioPinEdge.FallingEdge)
                {
                    led_.Toggle();
                }
            };
        }
    }
}
