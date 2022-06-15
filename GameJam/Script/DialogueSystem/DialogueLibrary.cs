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
        
        public DialogueSystem EndDialogue(List<string> answer)
        {
            DialogueSystem dialogueSystem = new DialogueSystem();
            var item = answer[1];
            var chara = answer[0];

            dialogueSystem.AddDialogue("Mario has been murderd by  " +  chara, Characters.Ba);
            dialogueSystem.AddDialogue("using a " + item, Characters.Ba);
            ItemCheckDialogue(dialogueSystem,item, chara);
         
            return dialogueSystem;
        }

        private void ItemCheckDialogue(DialogueSystem dialogueSystem, string item, string chara)
        {
            switch (item)
            {
                case "Knife":
                    CharCheckDialogue(dialogueSystem, chara);
                    break;
                case "Lighter":
                    dialogueSystem.AddDialogue("The murderer couldn't have possibly have used a lighter", Characters.Bowser);
                    dialogueSystem.AddDialogue("It would have lighten up the room and everybody would have seen it!", Characters.Bowser);
                    DefeatDialogue(dialogueSystem);
                    break;
                case "Pan":
                    dialogueSystem.AddDialogue("The murderer couldn't have possibly have used a pan", Characters.Bowser);
                    dialogueSystem.AddDialogue("Mario didn't have bruises or anything else that could have implemented", Characters.Bowser);
                    dialogueSystem.AddDialogue("that he was hit with the pan!", Characters.Bowser);
                    DefeatDialogue(dialogueSystem);
                    break;
                case "Coin":
                    dialogueSystem.AddDialogue("The murderer couldn't have possibly have used a coin", Characters.Bowser);
                    dialogueSystem.AddDialogue("Mario didn't have marks or anything else that could have implemented", Characters.Bowser);
                    dialogueSystem.AddDialogue("that he was murderd with the coin", Characters.Bowser);
                    DefeatDialogue(dialogueSystem);
                    break;
                case "Gun":
                    dialogueSystem.AddDialogue("The murderer couldn't have possibly have used a gun", Characters.Bowser);
                    dialogueSystem.AddDialogue("if the murdrer used the gun a bullet should have been found", Characters.Bowser);
                    DefeatDialogue(dialogueSystem);
                    break;
            }
        }

        private void CharCheckDialogue(DialogueSystem dialogueSystem, string chara)
        {
            switch (chara)
            {
                case "Mario":
                    WinDialogue(DialogueSystem);
                    break;
                case "Peach":
                    dialogueSystem.AddDialogue("Shroomlock how could you say that I murderd him!", Characters.Peach);
                    dialogueSystem.AddDialogue("(She is right how could I say that, She couldn't have stab him precisely in the heart)", Characters.Shroomlock);
                    dialogueSystem.AddDialogue("(Because it was to dark to see, where he was)", Characters.Shroomlock);
                    DefeatDialogue(dialogueSystem);
                    break;
                case "Daisy":
                    dialogueSystem.AddDialogue("WHAT! ME!?, I COULDN'T HAVE DONE IT I WAS BEHIND HIM!", Characters.Daisy);
                    dialogueSystem.AddDialogue("(She is right, Mario could have turned around, but the stabwound was to precisely in the heart)", Characters.Shroomlock);
                    dialogueSystem.AddDialogue("(The murderer knew excatly where they were aiming)", Characters.Shroomlock);
                    DefeatDialogue(dialogueSystem);
                    break;
                case "Luigi":
                    dialogueSystem.AddDialogue("Me?, I killed my brother?, but i only bumped into him", Characters.Luigi);
                    dialogueSystem.AddDialogue("(A bumped couldn't have killed Mario,)", Characters.Shroomlock);
                    dialogueSystem.AddDialogue("(besides when the light went on Luigi was also on the floor)", Characters.Shroomlock);
                    dialogueSystem.AddDialogue("(and should have been coverd in blood)", Characters.Shroomlock);
                    DefeatDialogue(dialogueSystem);
                    break;
                case "Bowser":
                    dialogueSystem.AddDialogue("ME!? HOW YOU DARE SAY ME. MABYE I AM THE VILLIAN ", Characters.Bowser);
                    dialogueSystem.AddDialogue("BUT I DIDN'T KILL HIM! I'LL TELL YOU WHY", Characters.Bowser);
                    dialogueSystem.AddDialogue(" First the lights went out", Characters.Bowser);
                    dialogueSystem.AddDialogue("I was right infront of him, but in the dark ", Characters.Bowser);
                    dialogueSystem.AddDialogue("would it be hard to get to him and stab him in the heart", Characters.Bowser);
                    DefeatDialogue(dialogueSystem);
                    break;
                case "Goom":
                    dialogueSystem.AddDialogue("The murderer couldn't have possibly have used a gun", Characters.Bowser);
                    dialogueSystem.AddDialogue("if the murdrer used the gun a bullet should have been found", Characters.Bowser);
                    DefeatDialogue(dialogueSystem);
                    break;
                case "Ba":
                    dialogueSystem.AddDialogue("The murderer couldn't have possibly have used a gun", Characters.Bowser);
                    dialogueSystem.AddDialogue("if the murdrer used the gun a bullet should have been found", Characters.Bowser);
                    DefeatDialogue(dialogueSystem);
                    break;
            }
        }
        private void DefeatDialogue(DialogueSystem dialogueSystem)
        {
            dialogueSystem.AddDialogue("It seems I missed something, let me relook the case ", Characters.Shroomlock);
            dialogueSystem.AddDialogue("You failed to catch the murderer, press enter to restart", Characters.Narrator);
            dialogueSystem.AddDialogue("END", Characters.Narrator);
            
        }

        private void WinDialogue(DialogueSystem dialogueSystem)
        {
            dialogueSystem.AddDialogue("You solved the murder!", Characters.Shroomlock);
            dialogueSystem.AddDialogue("press enter to restart", Characters.Narrator);
            dialogueSystem.AddDialogue("END", Characters.Narrator);

        }
    }
}
