using System;
using Windows.Devices.Gpio;

namespace PushButtonLed
{
    public sealed class ButtonController
    {
        private readonly GpioPin pin_;

        public event EventHandler<GpioPinValueChangedEventArgs> Pressed;

        public ButtonController(int gpio, GpioPinDriveMode driveMode)
        {
            Gpio = gpio;
            pin_ = GpioController.GetDefault().OpenPin(gpio);
            pin_.SetDriveMode(driveMode);
            pin_.DebounceTimeout = TimeSpan.FromMilliseconds(50);
            pin_.ValueChanged += ButtonPressedHandler;
        }

        public int Gpio { get; }

        private void ButtonPressedHandler(GpioPin sender, GpioPinValueChangedEventArgs args)
        {
            Pressed?.Invoke(this, args);
        }
    }
}
