using System.Collections.Generic;
using System.Drawing;

namespace HotelMs
{
    public enum StaffStatus
    {
        ACTIVATED,
        DEACTIVATED,
    }

    public static class StaffStatusColor
    {
        private static Dictionary<StaffStatus, dynamic> colorDict = new Dictionary<StaffStatus, dynamic>(){
            {StaffStatus.ACTIVATED, new StatusColor{
                Light = ColorTranslator.FromHtml(MyColor.Green._200),
                Dark = ColorTranslator.FromHtml(MyColor.Green._600)
            } },
            {StaffStatus.DEACTIVATED, new StatusColor{
                Light = ColorTranslator.FromHtml(MyColor.Red._200),
                Dark = ColorTranslator.FromHtml(MyColor.Red._600)
            } },
        };

        public static StatusColor Get(StaffStatus status)
        {
            return colorDict[status];
        }
    }

}
