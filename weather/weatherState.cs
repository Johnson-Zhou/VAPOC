using Luis;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Graph;
using System;
using System.Collections.Generic;

namespace weather
{
    public class weatherState
    {
        public weatherState()
        {

        }

        public Skill LuisResult { get; set; }
    }
}
