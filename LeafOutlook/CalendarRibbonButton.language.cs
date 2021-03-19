using System.Text.Json;

namespace LeafOutlook
{
    public partial class CalendarRibbonButton
    {
        private void setLanguage()
        {
            this.buttonNewLeafMeeting.Label = Globals.ThisAddIn.getElementTranslation("calendarRibbonButton", "buttonNewLeafMeeting");
        }
    }
}
