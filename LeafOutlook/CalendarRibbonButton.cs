using Microsoft.Office.Tools.Ribbon;

namespace LeafOutlook
{
    public partial class CalendarRibbonButton
    {
        private void CalendarRibbonButton_Load(object sender, RibbonUIEventArgs e)
        {
            setLanguage();
        }

        private void buttonNewJitsiMeeting_Click(object sender, RibbonControlEventArgs e)
        {
            new NewJitsiAppointment();
        }
    }
}
