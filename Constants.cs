using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace SmartHome_v1
{
    class IRemoteConstants
    {
        public const uint TR_HOME = 0xf17e2757;
        public const uint TR_CALENDAR = 0x9ec7c88f;
        public const uint TR_POWER_OFF = 0xa7b76553;
        public const uint TR_STOP = 0x865adf1b;
        public const uint TR_PREV = 0xde260593;
        public const uint TR_NEXT = 0x37d35d97;
        public const uint TR_VOL_UP = 0x41285df7;
        public const uint TR_VOL_DOWN = 0x8bd34f2f;
        public const uint TR_OK = 0x473de9f3;
        public const uint TR_MODE = 0x7cb889b3;
        public const uint TR_EXIT = 0x1c47af6f;
        public const uint TR_ROTATE = 0xe77b05f3;
        public const uint TR_PHOTO = 0xf11a7ef3;
        public const uint TR_MUSIC = 0x4ac7d6f7;
        public const uint TR_SETTINGS = 0x204a3073;
        public const uint TR_PAUSE_PLAY = 0xda5ad0b3;
        public const uint TR_MUTE = 0x890e8e8f;
    }

    class SmartHomeDeviceConstants
    {
        public const byte REG_CMD_TIMER_RELOAD = 0x01;
        public const byte REG_CMD_GPIO_STATUS = 0x02;
        public const byte REG_CMD_ENC0_COUNTER = 0x03;
        public const byte REG_CMD_ENC1_COUNTER = 0x04;
        public const byte REG_CMD_SLEEP_MASK = 0x05;
        public const byte REG_CMD_HOT_BUTTON_MASK = 0x06;
        public const byte REG_CMD_SET_BITS_GPIO_STATUS = 0x07;
        public const byte REG_CMD_RESET_BITS_GPIO_STATUS = 0x08;
        public const byte REG_CMD_IR_DOOR_STATUS = 0x09;
        public const byte REG_CMD_SET_FLAGS = 0x0A;
        public const byte REG_CMD_GET_SENSORS = 0x0B;

        public const byte MONITOR_GPIO = 0x02;

        public const byte MENS_IN_ROOM_INDEX = 3;
        public const byte TIMEOUT_SLEEPMODE_INDEX = 1;
        public const byte IR_DOOR_SENSOR_INDEX = 6;
        public const byte ENCODER0_INDEX = 3;
        public const byte ENCODER1_INDEX = 7;
        public const byte TM1638_SLEEP_MASK = 4;
        public const byte TM1638_HOT_BUTTON_MASK = 5;
        public const byte TM1638_STATUS = 2;
    }

    class VlcConstants
    {
        public const int DEFAULT_VOLUME = 70;
        public const int VLC_LOCATION_X_SLAVE_MONITOR = 2000;
        public const int VLC_LOCATION_Y_SLAVE_MONITOR = 600;
        public const int VLC_LOCATION_X_MASTER_MONITOR = 800;
        public const int VLC_MONITOR_MASK = 0x08;

        public const string OBJECT_NAME_PLAYLIST = "listBoxVlcPlaylistTitles";
        public const string OBJECT_NAME_FAVORITES = "listBoxVlcFavoriteTitles";

        public const int CURRENT_ITEM = 0;
        public const int NEXT_ITEM = 1;
        public const int PREVIOUS_ITEM = -1;
        public const int ADD = 1;
        public const int DEC = -1;

        public const string ACTION_DELETE = "Удалить";
        public const string ACTION_SAVE = "Сохранить";
        public const string ACTION_ADD_FAV = "Добавить в избранные";

    }

    class RgbConstants
    {
        public const string RGB_NORMAL_STATE_STRING = "EFFECT_CONFIG:01.1.1.1.00.FF.20.15.00";
        public const string RGB_OFF_STRING = "EFFECT_CONFIG:01.1.1.1.00.00.00.15.00";
        public const string RGB_MORE_MENS_STRING = "EFFECT_CONFIG:01.1.1.1.FF.00.15.15.00";
        public const string RGB_SLEEP_MODE_STRING = "EFFECT_CONFIG:01.1.1.1.00.00.15.13.00";
        public const string RGB_VLC_VOLUME_CHANGE_STRING = "EFFECT_CONFIG:02.1.1.1.FF.00.00.00.20";
        public const string RGB_CHANNEL0_STRING = "0.1.111";
        public const string RGB_CHANNEL1_STRING = "1.1.111";
    }
    class MainConstants {
        public const byte ZERO = 0;
        public const int PAUSE_FOR_USB_TRANSFER = 25;

        public const int TAB_INDEX_VLC = 4;
        public const int TAB_INDEX_LOGGER = 5;

        public const byte DEV_SMART_HOME_ID = 1;
        public const byte DEV_RGB_TAPE_ID = 2;
        public const byte DEV_ID_WEIGHT = 3;

        //        const byte VLC_AUDIO_DEV_GPIO_BITS = 0x0C;
        public const int AMBILIGHT_X = 2200;
        public const int AMBILIGHT_Y = 600;
        //
        public const string SEND_STRING = " send:";
        public const string RECEIVE_STRING = " received:";
    }

    public struct SYSTEMTIME
    {
        public short wYear;
        public short wMonth;
        public short wDayOfWeek;
        public short wDay;
        public short wHour;
        public short wMinute;
        public short wSecond;
        public short wMilliseconds;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct POINT
    {
        public int X;
        public int Y;

        public POINT(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public static implicit operator System.Drawing.Point(POINT p)
        {
            return new System.Drawing.Point(p.X, p.Y);
        }

        public static implicit operator POINT(System.Drawing.Point p)
        {
            return new POINT(p.X, p.Y);
        }
    }
}
