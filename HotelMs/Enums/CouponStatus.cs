using System.Collections.Generic;
using System.Drawing;

namespace HotelMs
{
    public enum CouponStatus
    {
        AVAILABLE,
        UNAVAILABLE,
        USED,
        EXPIRED,
    }

    public static class CouponStatusColor
    {
        private static Dictionary<CouponStatus, dynamic> colorDict = new Dictionary<CouponStatus, dynamic>(){
            {CouponStatus.AVAILABLE, new StatusColor{
                Light = ColorTranslator.FromHtml(MyColor.Green._200),
                Dark = ColorTranslator.FromHtml(MyColor.Green._600)
            } },
            {CouponStatus.UNAVAILABLE, new StatusColor{
                Light = ColorTranslator.FromHtml(MyColor.Red._200),
                Dark = ColorTranslator.FromHtml(MyColor.Red._600)
            } },
            {CouponStatus.USED, new StatusColor{
                Light = ColorTranslator.FromHtml(MyColor.Orange._200),
                Dark = ColorTranslator.FromHtml(MyColor.Orange._600)
            } },
            {CouponStatus.EXPIRED, new StatusColor{
                Light = ColorTranslator.FromHtml(MyColor.Purple._200),
                Dark = ColorTranslator.FromHtml(MyColor.Purple._600)
            } },
        };

        public static StatusColor Get(CouponStatus status)
        {
            return colorDict[status];
        }
    }

}
