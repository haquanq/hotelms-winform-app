using System.Collections.Generic;
using System.Drawing;

namespace HotelMs
{
    public enum RoomAmenityUsageStatus
    {
        USED,
        UNUSED,
        PENDING,
    }

    public static class RoomAmenityUsageStatusColor
    {
        private static Dictionary<RoomAmenityUsageStatus, dynamic> colorDict = new Dictionary<RoomAmenityUsageStatus, dynamic>(){
            {RoomAmenityUsageStatus.USED, new StatusColor{
                Light = ColorTranslator.FromHtml(MyColor.Green._200),
                Dark = ColorTranslator.FromHtml(MyColor.Green._600)
            } },
            {RoomAmenityUsageStatus.UNUSED, new StatusColor{
                Light = ColorTranslator.FromHtml(MyColor.Orange._200),
                Dark = ColorTranslator.FromHtml(MyColor.Orange._600)
            } },
            {RoomAmenityUsageStatus.PENDING, new StatusColor{
                Light = ColorTranslator.FromHtml(MyColor.Blue._200),
                Dark = ColorTranslator.FromHtml(MyColor.Blue._600)
            } },
        };

        public static StatusColor Get(RoomAmenityUsageStatus status)
        {
            return colorDict[status];
        }
    }
}
