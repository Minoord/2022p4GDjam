using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameJam.Game
{
    public class DialogueLibrary
    {
        private bool hasSuicideNote;
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
            dialogueSystem.AddDialogue("*Ding Dong*", Characters.Narrator);
            dialogueSystem.AddDialogue("Shroomlock, here. I heard a murder happend here.", Characters.Shroomlock);
            dialogueSystem.AddDialogue("*Door opens*", Characters.Narrator);
            dialogueSystem.AddDialogue("*in tears*Shroomlock, please help Mario has been murdered!", Characters.Peach);
            dialogueSystem.AddDialogue("Your highness, what happend?", Characters.Shroomlock);
            dialogueSystem.AddDialogue("We were having a meeting with Bowser and suddenly the lights went off. When they came back on Mario was dead.", Characters.Peach);
            dialogueSystem.AddDialogue("Who was standing next to Mario while the meeting was happening?", Characters.Shroomlock);
            dialogueSystem.AddDialogue("Me and Luigi..sniff...sniff", Characters.Peach);
            dialogueSystem.AddDialogue("Thank you your highness, you have done enough now. If i have more questions I will come back to you.", Characters.Shroomlock);
            dialogueSystem.AddDialogue("(I should talk to the suspects and look around for the murder weapon)", Characters.Shroomlock);
            dialogueSystem.AddDialogue("Talk to Hammer bro if you found out who did it. He will be the final judge", Characters.Narrator);
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
        
        public DialogueSystem EndDialogue(List<string> answer, bool hasNote)
        {
            DialogueSystem dialogueSystem = new DialogueSystem();
            var item = answer[1];
            var chara = answer[0];
            hasSuicideNote = hasNote;

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
                    dialogueSystem.AddDialogue("OBJECTION", Characters.Bowser);
                    dialogueSystem.AddDialogue("The murderer couldn't have possibly have used a lighter", Characters.Bowser);
                    dialogueSystem.AddDialogue("It would have lit up the room and everybody would have seen it!", Characters.Bowser);
                    DefeatDialogue(dialogueSystem);
                    break;
                case "Pan":
                    dialogueSystem.AddDialogue("OBJECTION", Characters.Bowser);
                    dialogueSystem.AddDialogue("The murderer couldn't have possibly have used a pan", Characters.Bowser);
                    dialogueSystem.AddDialogue("Mario didn't have bruises or anything else that could have implemented", Characters.Bowser);
                    dialogueSystem.AddDialogue("that he was hit with the pan!", Characters.Bowser);
                    DefeatDialogue(dialogueSystem);
                    break;
                case "Coin":
                    dialogueSystem.AddDialogue("OBJECTION", Characters.Bowser);
                    dialogueSystem.AddDialogue("The murderer couldn't have possibly have used a coin", Characters.Bowser);
                    dialogueSystem.AddDialogue("Mario didn't have marks or anything else that could have implemented", Characters.Bowser);
                    dialogueSystem.AddDialogue("that he was murderd with the coin", Characters.Bowser);
                    DefeatDialogue(dialogueSystem);
                    break;
                case "Gun":
                    dialogueSystem.AddDialogue("OBJECTION", Characters.Bowser);
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
                    WinDialogue(dialogueSystem);
                    break;
                case "Peach":
                    dialogueSystem.AddDialogue("Shroomlock how could you say that I murderd him!", Characters.Peach);
                    dialogueSystem.AddDialogue("(She is right how could I say that, She couldn't have stab him precisely in the heart)", Characters.Shroomlock);
                    dialogueSystem.AddDialogue("(Because it was to dark to see, where he was)", Characters.Shroomlock);
                    DefeatDialogue(dialogueSystem);
                    break;
                case "Daisy":
                    dialogueSystem.AddDialogue("WHAT! ME!?, I COULDN'T HAVE DONE IT I WAS BEHIND HIM!", Characters.Daisy);
                    dialogueSystem.AddDialogue("(She is right, but Mario could have turned around, still the stabwound was to precisely in the heart)", Characters.Shroomlock);
                    dialogueSystem.AddDialogue("(The murderer knew excatly where they were aiming)", Characters.Shroomlock);
                    DefeatDialogue(dialogueSystem);
                    break;
                case "Luigi":
                    dialogueSystem.AddDialogue("Me?, I killed my brother?, but i only bumped into him", Characters.Luigi);
                    dialogueSystem.AddDialogue("(A bumped couldn't have killed Mario,)", Characters.Shroomlock);
                    dialogueSystem.AddDialogue("(besides when the light went on Luigi was also on the floor)", Characters.Shroomlock);
                    dialogueSystem.AddDialogue("(If he did it he should have been coverd in blood)", Characters.Shroomlock);
                    DefeatDialogue(dialogueSystem);
                    break;
                case "Bowser":
                    dialogueSystem.AddDialogue("ME!? HOW YOU DARE SAY ME. MABYE I AM THE VILLIAN ", Characters.Bowser);
                    dialogueSystem.AddDialogue("BUT I DIDN'T KILL HIM! I'LL TELL YOU WHY", Characters.Bowser);
                    dialogueSystem.AddDialogue("When the lights went out", Characters.Bowser);
                    dialogueSystem.AddDialogue("I was right infront of him. In the dark ", Characters.Bowser);
                    dialogueSystem.AddDialogue("would have been hard to get to him and stab him in the heart", Characters.Bowser);
                    dialogueSystem.AddDialogue("He is right", Characters.Shroomlock);
                    DefeatDialogue(dialogueSystem);
                    break;
                case "Goom":
                    dialogueSystem.AddDialogue("Murderer is Goom?", Characters.Goom);
                    dialogueSystem.AddDialogue("Goom didn't murder him he was beside me the whole time", Characters.Bowser);
                    dialogueSystem.AddDialogue("besides he doesn't have hands so he couldn't have", Characters.Bowser);
                    dialogueSystem.AddDialogue("stabbed him precisely in the heart", Characters.Bowser);
                    dialogueSystem.AddDialogue("He is right", Characters.Shroomlock);
                    DefeatDialogue(dialogueSystem);
                    break;
                case "Ba":
                    dialogueSystem.AddDialogue("Ba? BA? BAA?", Characters.Ba);
                    dialogueSystem.AddDialogue("*Ba Charges towards Shroomlock and starts attacking him*", Characters.Narrator);
                    dialogueSystem.AddDialogue("A second murder happend that day", Characters.Narrator);
                    dialogueSystem.AddDialogue("Who knew goombas can be so aggresive", Characters.Narrator);
                    dialogueSystem.AddDialogue("Anyway Ba was not the murderer, press enter to restart", Characters.Narrator);
                    dialogueSystem.AddDialogue("END", Characters.Narrator);
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
            if (hasSuicideNote)
            {
                dialogueSystem.AddDialogue("*Everybody in the room went silent*", Characters.Narrator);
                dialogueSystem.AddDialogue("Dont believe me, thats fine but mabye this will change your mind", Characters.Shroomlock);
                dialogueSystem.AddDialogue("*Shroomlock shows the suicide note*", Characters.Narrator);
                dialogueSystem.AddDialogue("Mario committed suicide and someone tried covering it up", Characters.Shroomlock);
                dialogueSystem.AddDialogue("Who that person is I have no idea", Characters.Shroomlock);
                dialogueSystem.AddDialogue("But I'll leave that to the police", Characters.Shroomlock);

            }
            else
            {
                dialogueSystem.AddDialogue("*Everybody in the room went silent*", Characters.Narrator);
                dialogueSystem.AddDialogue("Mario had stab wound in his chest", Characters.Shroomlock);
                dialogueSystem.AddDialogue("The knife was the only weapon in room", Characters.Shroomlock);
                dialogueSystem.AddDialogue("that could have done something like that", Characters.Shroomlock);
                dialogueSystem.AddDialogue("It was too dark in the room for somebody to see where he was", Characters.Shroomlock);
                dialogueSystem.AddDialogue("and even if someone knew it was too dark to see where his heart was", Characters.Shroomlock);
                dialogueSystem.AddDialogue("So it was suicide!", Characters.Shroomlock);
            }

            dialogueSystem.AddDialogue("I think we have our answer, ", Characters.Hammer_Bro);
            dialogueSystem.AddDialogue("I hereby declare that this murder is suicide!", Characters.Hammer_Bro);
            dialogueSystem.AddDialogue("*Hammer bro slams his hammer*", Characters.Narrator);
            dialogueSystem.AddDialogue("The case is closed and you solved the murderer", Characters.Narrator);
            dialogueSystem.AddDialogue("Good job! press enter to restart", Characters.Narrator);
            dialogueSystem.AddDialogue("END", Characters.Narrator);

        }
    }
}
