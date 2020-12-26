
using System.Runtime.InteropServices;

namespace BetterJoyForCemu.ControllerTester.XInput {
    class Api {
        [DllImport("xinput1_4.dll")]
        public static extern int XInputGetState
        (
            int dwUserIndex,  // [in] Index of the gamer associated with the device
            ref XInputState pState        // [out] Receives the current state
        );

        [DllImport("xinput1_4.dll")]
        public static extern int XInputSetState
        (
            int dwUserIndex,  // [in] Index of the gamer associated with the device
            ref XInputVibration pVibration    // [in, out] The vibration information to send to the controller
        );

        [DllImport("xinput1_4.dll")]
        public static extern int XInputGetCapabilities
        (
            int dwUserIndex,   // [in] Index of the gamer associated with the device
            int dwFlags,       // [in] Input flags that identify the device type
            ref XInputCapabilities pCapabilities  // [out] Receives the capabilities
        );


        [DllImport("xinput1_4.dll")]
        public static extern int XInputGetBatteryInformation
        (
              int dwUserIndex,        // Index of the gamer associated with the device
              byte devType,            // Which device on this user index
            ref XInputBatteryInformation pBatteryInformation // Contains the level and types of batteries
        );
    }
}
