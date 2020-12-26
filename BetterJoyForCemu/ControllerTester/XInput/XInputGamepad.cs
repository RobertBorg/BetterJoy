using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BetterJoyForCemu.ControllerTester.XInput {

    public enum XInputButtons {
        DPAD_UP = 0x0001,
        DPAD_DOWN = 0x0002,
        DPAD_LEFT = 0x0004,
        DPAD_RIGHT = 0x0008,
        START = 0x0010,
        BACK = 0x0020,
        LEFT_THUMB = 0x0040,
        RIGHT_THUMB = 0x0080,
        LEFT_SHOULDER = 0x0100,
        RIGHT_SHOULDER = 0x0200,
        A = 0x1000,
        B = 0x2000,
        X = 0x4000,
        Y = 0x8000,
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct XInputGamepad {
        [MarshalAs(UnmanagedType.I2)]
        [FieldOffset(0)]
        public short wButtons;

        [MarshalAs(UnmanagedType.I1)]
        [FieldOffset(2)]
        public byte bLeftTrigger;

        [MarshalAs(UnmanagedType.I1)]
        [FieldOffset(3)]
        public byte bRightTrigger;

        [MarshalAs(UnmanagedType.I2)]
        [FieldOffset(4)]
        public short sThumbLX;

        [MarshalAs(UnmanagedType.I2)]
        [FieldOffset(6)]
        public short sThumbLY;

        [MarshalAs(UnmanagedType.I2)]
        [FieldOffset(8)]
        public short sThumbRX;

        [MarshalAs(UnmanagedType.I2)]
        [FieldOffset(10)]
        public short sThumbRY;


        public bool IsButtonPressed(XInputButtons buttonFlags) {
            return (wButtons & (short)buttonFlags) != 0;
        }

        public bool IsButtonPresent(XInputButtons buttonFlags) {
            return (wButtons & (short)buttonFlags) != 0;
        }



        public void Copy(XInputGamepad source) {
            sThumbLX = source.sThumbLX;
            sThumbLY = source.sThumbLY;
            sThumbRX = source.sThumbRX;
            sThumbRY = source.sThumbRY;
            bLeftTrigger = source.bLeftTrigger;
            bRightTrigger = source.bRightTrigger;
            wButtons = source.wButtons;
        }

        public override bool Equals(object obj) {
            if (!(obj is XInputGamepad))
                return false;
            XInputGamepad source = (XInputGamepad)obj;
            return ((sThumbLX == source.sThumbLX)
            && (sThumbLY == source.sThumbLY)
            && (sThumbRX == source.sThumbRX)
            && (sThumbRY == source.sThumbRY)
            && (bLeftTrigger == source.bLeftTrigger)
            && (bRightTrigger == source.bRightTrigger)
            && (wButtons == source.wButtons));
        }
    }
}
