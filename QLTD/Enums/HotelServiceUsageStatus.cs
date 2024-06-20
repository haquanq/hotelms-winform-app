using System.Collections.Generic;
using System.Drawing;

namespace HotelMs
{
    public enum HotelServiceUsageStatus
    {
        PENDING,
        COMPLETED,
        CANCELLED,
    }

    public static class HotelServiceUsageStatusColor
    {
        private static Dictionary<HotelServiceUsageStatus, dynamic> colorDict = new Dictionary<HotelServiceUsageStatus, dynamic>(){
            {HotelServiceUsageStatus.PENDING, new StatusColor{
                Light = ColorTranslator.FromHtml(MyColor.Blue._200),
                Dark = ColorTranslator.FromHtml(MyColor.Blue._600)
            } },
            {HotelServiceUsageStatus.COMPLETED, new StatusColor{
                Light = ColorTranslator.FromHtml(MyColor.Green._200),
                Dark = ColorTranslator.FromHtml(MyColor.Green._600)
            } },
            {HotelServiceUsageStatus.CANCELLED, new StatusColor{
                Light = ColorTranslator.FromHtml(MyColor.Red._200),
                Dark = ColorTranslator.FromHtml(MyColor.Red._600)
            } },
        };

        public static StatusColor Get(HotelServiceUsageStatus status)
        {
            return colorDict[status];
        }
    }

}
