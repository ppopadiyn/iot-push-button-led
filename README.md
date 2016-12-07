# Push Button and Led

Basic setup and application, which uses a push button to control LED. Demos on:

- C# and UWP (win10iot)
- Node.js with JohnnyFive and raspi-io.
  - Running on Raspbian is required. Node v6 recommended.
  - npm install
  - npm start
- Python (win10iot)

## Raspberry Setup
1. LED cathode to pin 5.
2. LED anode to 330ohm resistor to the 3.3V pin.
3. One of the button legs to the ground.
4. The other button leg to pin 6 (pull up).

![alt tag](https://github.com/ppopadiyn/iot-push-button-led/blob/master/assets/PushButtonLed_bb.png)
