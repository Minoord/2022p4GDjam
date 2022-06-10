using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameJam.Game
{
    public class DialogueLibrary
    {
        public DialogueSystem BeginDialogue()
        {
            DialogueSystem dialogueSystem = new DialogueSystem();
            dialogueSystem.AddDialogue("Dit is een test of het werk", Characters.Ba);
            dialogueSystem.AddDialogue("Enter Werkt ook", Characters.Ba);
            return dialogueSystem;
        } 
    }
}
