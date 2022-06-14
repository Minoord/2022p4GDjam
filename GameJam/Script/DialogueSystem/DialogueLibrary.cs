using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameJam.Game
{
    public class DialogueLibrary
    {
      
        public DialogueSystem WhichCharacterDialogue(Characters chara)
        {
            switch (chara)
            {
                case Characters.Luigi:
                    return LuigiDialogue();
                    break; 
                case Characters.Daisy:
                    return DaisyDialogue();
                    break; 
                case Characters.Peach:
                    return PeachDialogue();
                    break; 
                case Characters.Hammer_Bro:
                    return Hammer_BroDialogue();
                    break;  
                case Characters.Bowser:
                    return BowserDialogue();
                    break;   
                case Characters.Goom:
                    return GoomDialogue();
                    break;  
                case Characters.Ba:
                    return BaDialogue();
                    break;
                default:
                    return BeginDialogue();
                    break;
            }
        }
        public DialogueSystem BeginDialogue()
        {
            DialogueSystem dialogueSystem = new DialogueSystem();
            dialogueSystem.AddDialogue("Dit is een test of het werk", Characters.Ba);
            dialogueSystem.AddDialogue("Enter Werkt ook", Characters.Ba);
            return dialogueSystem;
        }
        public DialogueSystem LuigiDialogue()
        {
            DialogueSystem dialogueSystem = new DialogueSystem();
            dialogueSystem.AddDialogue("Im Luigi", Characters.Ba);
            dialogueSystem.AddDialogue("Im his brother", Characters.Ba);
            return dialogueSystem;
        }

        public DialogueSystem DaisyDialogue()
        {
            DialogueSystem dialogueSystem = new DialogueSystem();
            dialogueSystem.AddDialogue("Im Daisy", Characters.Ba);
            dialogueSystem.AddDialogue("Im his friend", Characters.Ba);
            return dialogueSystem;
        }        
        
        public DialogueSystem PeachDialogue()
        {
            DialogueSystem dialogueSystem = new DialogueSystem();
            dialogueSystem.AddDialogue("Im Peach", Characters.Ba);
            dialogueSystem.AddDialogue("Im his girlfriend", Characters.Ba);
            return dialogueSystem;
        }       
        public DialogueSystem Hammer_BroDialogue()
        {
            DialogueSystem dialogueSystem = new DialogueSystem();
            dialogueSystem.AddDialogue("Im Hammer Bro", Characters.Ba);
            dialogueSystem.AddDialogue("Who is the murderer", Characters.Ba);
            dialogueSystem.AddDialogue("MENU1", Characters.Ba);
            dialogueSystem.AddDialogue("You?", Characters.Ba);
            dialogueSystem.AddDialogue("MENU2", Characters.Ba);
            dialogueSystem.AddDialogue("With this weapon?", Characters.Ba);
            dialogueSystem.AddDialogue("ENDDIA", Characters.Ba);

            return dialogueSystem;
        }        
        public DialogueSystem BowserDialogue()
        {
            DialogueSystem dialogueSystem = new DialogueSystem();
            dialogueSystem.AddDialogue("Im Bowser", Characters.Ba);
            dialogueSystem.AddDialogue("Im the villain", Characters.Ba);
            return dialogueSystem;
        }        
        public DialogueSystem GoomDialogue()
        {
            DialogueSystem dialogueSystem = new DialogueSystem();
            dialogueSystem.AddDialogue("Im Goom", Characters.Ba);
            dialogueSystem.AddDialogue("Im smart", Characters.Ba);
            return dialogueSystem;
        }        
        public DialogueSystem BaDialogue()
        {
            DialogueSystem dialogueSystem = new DialogueSystem();
            dialogueSystem.AddDialogue("Ba!!!", Characters.Ba);
            dialogueSystem.AddDialogue("Ba Ba Ba", Characters.Ba);
            return dialogueSystem;
        }
        
        public DialogueSystem EndDialogue()
        {
            DialogueSystem dialogueSystem = new DialogueSystem();
            dialogueSystem.AddDialogue("This is the end", Characters.Ba);
            dialogueSystem.AddDialogue("of everything...", Characters.Ba);
            dialogueSystem.AddDialogue("END", Characters.Ba);
            return dialogueSystem;
        }

    }
}
