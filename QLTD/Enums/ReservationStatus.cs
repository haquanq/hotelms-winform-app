using System.Collections.Generic;
using System.Drawing;

namespace HotelMs
{
    public enum ReservationStatus
    {
        PENDING,
        CHECKED_IN,
        CHECKED_OUT,
        CANCELLED,
    }

    public static class ReservationStatusColor
    {
        private static Dictionary<ReservationStatus, dynamic> colorDict = new Dictionary<ReservationStatus, dynamic>(){
            {ReservationStatus.PENDING, new StatusColor{
                Light = ColorTranslator.FromHtml(MyColor.Blue._200),
                Dark = ColorTranslator.FromHtml(MyColor.Blue._600)
            } },
            {ReservationStatus.CHECKED_IN, new StatusColor{
                Light = ColorTranslator.FromHtml(MyColor.Orange._200),
                Dark = ColorTranslator.FromHtml(MyColor.Orange._600)
            } },
            {ReservationStatus.CHECKED_OUT, new StatusColor{
                Light = ColorTranslator.FromHtml(MyColor.Green._200),
                Dark = ColorTranslator.FromHtml(MyColor.Green._600)
            } },
            {ReservationStatus.CANCELLED, new StatusColor{
                Light = ColorTranslator.FromHtml(MyColor.Red._200),
                Dark = ColorTranslator.FromHtml(MyColor.Red._600)
            } },
        };

        public static StatusColor Get(ReservationStatus status)
        {
            return colorDict[status];
        }
    }

}
