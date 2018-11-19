using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class PlayerQuest
    {
        public Quest QuestDetails { get; set; }
        public bool IsComplited { get; set; }

        public PlayerQuest(Quest questDetails, bool isComplited)
        {
            QuestDetails = questDetails;
            IsComplited = isComplited;
        }
    }
}