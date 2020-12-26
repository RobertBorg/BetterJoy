using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;
using BetterJoyForCemu.ControllerTester.XInput;

namespace BetterJoyForCemu {
    public partial class XInputControllerTester : Form {
        public XInputControllerTester() {
            InitializeComponent();
        }

        async private void XInputControllerTester_Load(object sender, EventArgs e) {
            
            while(true) {
                var state = new XInputState();
                Api.XInputGetState(0, ref state);
                //Dispatcher.Invoke(() => {
                var gamepad = state.Gamepad;

                trigger_left.Text = gamepad.bLeftTrigger.ToString();
                button_shoulder_left.Checked = gamepad.IsButtonPressed(XInputButtons.LEFT_SHOULDER);
                button_trigger_left.Checked = gamepad.IsButtonPressed(XInputButtons.LEFT_THUMB);
                analog_left_x.Text = gamepad.sThumbLX.ToString();
                analog_left_y.Text = gamepad.sThumbLY.ToString();

                trigger_right.Text = gamepad.bRightTrigger.ToString();
                button_shoulder_right.Checked = gamepad.IsButtonPressed(XInputButtons.RIGHT_SHOULDER);
                button_trigger_right.Checked = gamepad.IsButtonPressed(XInputButtons.RIGHT_THUMB);
                analog_right_x.Text = gamepad.sThumbRX.ToString();
                analog_right_y.Text = gamepad.sThumbRY.ToString();

                button_a.Checked = gamepad.IsButtonPressed(XInputButtons.A);
                button_b.Checked = gamepad.IsButtonPressed(XInputButtons.B);
                button_x.Checked = gamepad.IsButtonPressed(XInputButtons.X);
                button_y.Checked = gamepad.IsButtonPressed(XInputButtons.Y);

                button_dpad_up.Checked = gamepad.IsButtonPressed(XInputButtons.DPAD_UP);
                button_dpad_right.Checked = gamepad.IsButtonPressed(XInputButtons.DPAD_RIGHT);
                button_dpad_down.Checked = gamepad.IsButtonPressed(XInputButtons.DPAD_DOWN);
                button_dpad_left.Checked = gamepad.IsButtonPressed(XInputButtons.DPAD_LEFT);

                button_select.Checked = gamepad.IsButtonPressed(XInputButtons.BACK);
                button_start.Checked = gamepad.IsButtonPressed(XInputButtons.START);

                //});
                await Task.Delay(10);
            }
            
        }
    }
}
