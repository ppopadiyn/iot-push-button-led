using Windows.Devices.Gpio;

namespace PushButtonLed
{
    public sealed class LedController
    {
        private readonly GpioPin pin_;

        public LedController(int gpio)
        {
            Gpio = gpio;
            pin_ = GpioController.GetDefault().OpenPin(gpio);
            Value = GpioPinValue.High;
            pin_.SetDriveMode(GpioPinDriveMode.Output);
        }

        public int Gpio { get; }

        public GpioPinValue Value
        {
            get
            {
                return pin_.Read();
            }
            set
            {
                pin_.Write(value);
            }
        }

        public void Toggle()
        {
            pin_.Write(Value == GpioPinValue.Low ? GpioPinValue.High : GpioPinValue.Low);
        }
    }
}
