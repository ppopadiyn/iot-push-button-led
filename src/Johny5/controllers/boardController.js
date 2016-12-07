var five = require("johnny-five");
var raspi = require("raspi-io");

module.exports = class BoardController {
    constructor() {
        this.board = new five.Board({
            io: new raspi()
        });
    }

    init() {
        this.board.on('ready', function () {
            var led = new five.Led('GPIO5');
            led.on();

            var button = new five.Button({ pin: "GPIO6", isPullup: true });
            button.on("down", function () {
                led.toggle();
            });

            this.on('exit', function () {
                led.on();
            });
        });
    }
}