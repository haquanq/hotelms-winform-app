using System.Collections.Generic;
using System.Drawing;

namespace HotelMs
{
    public enum RoomStatus
    {
        VACANT_DIRTY,
        VACANT_CLEAN,
        READY,
        BOOKED,
        OCCUPIED,
    }

    public static class RoomStatusColor
    {
        private static Dictionary<RoomStatus, dynamic> colorDict = new Dictionary<RoomStatus, dynamic>(){
            {RoomStatus.VACANT_DIRTY, new StatusColor{
                Light = ColorTranslator.FromHtml( MyColor.Red._200),
                Dark = ColorTranslator.FromHtml(MyColor.Red._600)
            } },
            {RoomStatus.VACANT_CLEAN, new StatusColor{
                Light = ColorTranslator.FromHtml(MyColor.Orange._200),
                Dark = ColorTranslator.FromHtml(MyColor.Orange._600)
            } },
            {RoomStatus.READY, new StatusColor{
                Light = ColorTranslator.FromHtml(MyColor.Green._200),
                Dark = ColorTranslator.FromHtml(MyColor.Green._600)
            } },
            {RoomStatus.BOOKED, new StatusColor{
                Light = ColorTranslator.FromHtml(MyColor.Blue._200),
                Dark = ColorTranslator.FromHtml(MyColor.Blue._600)
            } },
            {RoomStatus.OCCUPIED, new StatusColor{
                Light = ColorTranslator.FromHtml(MyColor.Purple._200),
                Dark = ColorTranslator.FromHtml(MyColor.Purple._600)
            } },
        };

        public static StatusColor Get(RoomStatus status)
        {
            return colorDict[status];

        }
    }

}
