namespace Logger.Layouts
{
    public class SimpleLayout : ILayout
    {
        //format <date-time> - <report level> - <message>
        public string Format => "{0} - {1} - {2}";
    }
}
