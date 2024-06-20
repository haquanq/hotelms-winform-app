using System.Collections.Generic;
using System.Drawing;

namespace HotelMs
{
    public enum CustomerStatus
    {
        NEW,
        COMMON,
        VIP,
    }

    public static class CustomerStatusColor
    {
        private static Dictionary<CustomerStatus, dynamic> colorDict = new Dictionary<CustomerStatus, dynamic>(){
            {CustomerStatus.NEW, new StatusColor{
                Light = ColorTranslator.FromHtml(MyColor.Green._200),
                Dark = ColorTranslator.FromHtml(MyColor.Green._600)
            } },
            {CustomerStatus.COMMON, new StatusColor{
                Light = ColorTranslator.FromHtml(MyColor.Orange._200),
                Dark = ColorTranslator.FromHtml(MyColor.Orange._600)
            } },
            {CustomerStatus.VIP, new StatusColor{
                Light = ColorTranslator.FromHtml(MyColor.Purple._200),
                Dark = ColorTranslator.FromHtml(MyColor.Purple._600)
            } },
        };

        public static StatusColor Get(CustomerStatus status)
        {
            return colorDict[status];
        }
    }

}
