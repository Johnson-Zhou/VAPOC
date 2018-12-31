using Microsoft.Bot.Solutions.Dialogs;
using Microsoft.Bot.Solutions.Dialogs.BotResponseFormatters;

namespace weather
{
    public class weatherResponseBuilder : BotResponseBuilder
    {
        public weatherResponseBuilder()
           : base()
        {
            AddFormatter(new TextBotResponseFormatter());
        }
    }
}
