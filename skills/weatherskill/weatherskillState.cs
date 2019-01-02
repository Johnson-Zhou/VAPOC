using Luis;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Graph;
using System;
using System.Collections.Generic;

namespace weatherskill
{
    public class weatherskillState
    {
        public weatherskillState()
        {

        }

        public weather LuisResult { get; set; }
    }
}
