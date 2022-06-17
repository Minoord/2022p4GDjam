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
                case Characters.Mario:
                    return MarioDialogue();
                    break;
                default:
                    return BeginDialogue();
                    break;
            }
        }

        public DialogueSystem AddedToInventory(string itemName)
        {
            DialogueSystem dialogueSystem = new DialogueSystem();
            dialogueSystem.AddDialogue("Added " + itemName + " to inventory.", Characters.Narrator);
            return dialogueSystem;
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

        public DialogueSystem MarioDialogue()
        {
            DialogueSystem dialogueSystem = new DialogueSystem();
            dialogueSystem.AddDialogue("(Shroomlock examens Mario's body)", Characters.Narrator);
            dialogueSystem.AddDialogue("He has a deep wound precisely \nwhere the heart is", Characters.Shroomlock);
            dialogueSystem.AddDialogue("From the looks of it the murder \nmust have attacked from the front. ", Characters.Shroomlock);
            dialogueSystem.AddDialogue("He also doesnt have any bruises", Characters.Shroomlock);
            dialogueSystem.AddDialogue("That must mean that the wound by\nhis heart was the final blow", Characters.Shroomlock);
            dialogueSystem.AddDialogue("What could have caused this?", Characters.Shroomlock);

            return dialogueSystem;
        }
        public DialogueSystem LuigiDialogue()
        {
            DialogueSystem dialogueSystem = new DialogueSystem();
            dialogueSystem.AddDialogue("Goodday Luigi, Can I ask you a \nfew questions?", Characters.Shroomlock);
            dialogueSystem.AddDialogue("I didnt do it i swear!", Characters.Luigi);
            dialogueSystem.AddDialogue("I didn't accused you yet, \nwhy are you so nervous?", Characters.Shroomlock);
            dialogueSystem.AddDialogue("Well...When the lights went out, \nI panicked and bumped into Mario", Characters.Luigi);
            dialogueSystem.AddDialogue("I fell down on the floor, \nthen when i tried getting up, \nthe lights went on", Characters.Luigi);
            dialogueSystem.AddDialogue("and my brother was..was dead beside \nme. *Starts crying*", Characters.Luigi);
            dialogueSystem.AddDialogue("you were beside him before the \nlights went out right?", Characters.Shroomlock);
            dialogueSystem.AddDialogue("sniff..sniff..yes", Characters.Luigi);
            dialogueSystem.AddDialogue("(So my highness wasn't lying)", Characters.Shroomlock);
            dialogueSystem.AddDialogue("thank you for your time Luigi,", Characters.Shroomlock);
            dialogueSystem.AddDialogue("I will bring Mario's murder to \njustice", Characters.Shroomlock);
            dialogueSystem.AddDialogue("thank you...sniff.sniff", Characters.Luigi);
            return dialogueSystem;
        }

        public DialogueSystem DaisyDialogue()
        {
            DialogueSystem dialogueSystem = new DialogueSystem();
            dialogueSystem.AddDialogue("Goodday princess, Can I ask you a \nfew questions?", Characters.Shroomlock);
            dialogueSystem.AddDialogue("Yes you may", Characters.Daisy);
            dialogueSystem.AddDialogue("were you in the room when the murder\nhappend?", Characters.Shroomlock);
            dialogueSystem.AddDialogue("Yes and i already know who did it", Characters.Daisy);
            dialogueSystem.AddDialogue("If I may ask who did it then?", Characters.Shroomlock);
            dialogueSystem.AddDialogue("Well uhm...Bowser ofcourse!", Characters.Daisy);
            dialogueSystem.AddDialogue("He has always been the villian", Characters.Daisy);
            dialogueSystem.AddDialogue("So he could do it again", Characters.Daisy);
            dialogueSystem.AddDialogue("That doesnt mean he murdered Mario", Characters.Shroomlock);
            dialogueSystem.AddDialogue("Are you questioning me?", Characters.Daisy);
            dialogueSystem.AddDialogue("I'm sorry, princess, but can I ask\nyou another question?", Characters.Shroomlock);
            dialogueSystem.AddDialogue("Fine but then leave me alone i have\nbeter things to do, like mourning", Characters.Daisy);
            dialogueSystem.AddDialogue("Before the lights went out where \nwere you standing?", Characters.Shroomlock);
            dialogueSystem.AddDialogue("Behind Mario ofcourse,i didn't trust\nBowser the second i was in the room\nwith him.", Characters.Daisy);
            dialogueSystem.AddDialogue("Mario probably died to protect me\nfrom him. What a true hero!", Characters.Daisy);
            dialogueSystem.AddDialogue("Oke thank you, princess.\nThis really helped", Characters.Shroomlock);
            dialogueSystem.AddDialogue("(it really didn't)", Characters.Shroomlock);
            dialogueSystem.AddDialogue("yeah yeah now go I need to mourn", Characters.Daisy);
            return dialogueSystem;
        }        
        
        public DialogueSystem PeachDialogue()
        {
            DialogueSystem dialogueSystem = new DialogueSystem();
            dialogueSystem.AddDialogue("Sorry to bother you, your highness", Characters.Shroomlock);
            dialogueSystem.AddDialogue("But i have some questions for you.", Characters.Shroomlock);
            dialogueSystem.AddDialogue("sniff..sniff..Go ahead", Characters.Peach);
            dialogueSystem.AddDialogue("What happend when the lights went\nout?", Characters.Shroomlock);
            dialogueSystem.AddDialogue("I heard two thud sound next to me ", Characters.Peach);
            dialogueSystem.AddDialogue("and next thing i know the lights\nwent on", Characters.Peach);
            dialogueSystem.AddDialogue("and Mario was dead on the floor", Characters.Peach);
            dialogueSystem.AddDialogue("Your highness was standing besides \nhim,if I recall that correctly?", Characters.Shroomlock);
            dialogueSystem.AddDialogue("yes, yes i was", Characters.Peach);
            dialogueSystem.AddDialogue("Oke thank you for your time,\nyour highness", Characters.Shroomlock);
            return dialogueSystem;
        }       
        public DialogueSystem Hammer_BroDialogue()
        {
            DialogueSystem dialogueSystem = new DialogueSystem();
            dialogueSystem.AddDialogue("So Shroomlock have you found your \nevidence?", Characters.Hammer_Bro);
            dialogueSystem.AddDialogue("yes, lets proceed to the judging.", Characters.Shroomlock);
            dialogueSystem.AddDialogue("who is the murderer?", Characters.Shroomlock);
            dialogueSystem.AddDialogue("MENU1", Characters.Ba);
            dialogueSystem.AddDialogue("which weapon did he use?", Characters.Ba);
            dialogueSystem.AddDialogue("MENU2", Characters.Ba);
            dialogueSystem.AddDialogue("ENDDIA", Characters.Ba);

            return dialogueSystem;
        }        
        public DialogueSystem BowserDialogue()
        {
            DialogueSystem dialogueSystem = new DialogueSystem();
            dialogueSystem.AddDialogue("Bowser, Mario's biggest enemy", Characters.Shroomlock);
            dialogueSystem.AddDialogue("Scram off Toad", Characters.Bowser);
            dialogueSystem.AddDialogue("Did you just call me Toad?\nI have you know that my_", Characters.Shroomlock);
            dialogueSystem.AddDialogue("Yeah yeah, now buzz off,\nim busy trying to solve the murder", Characters.Bowser);
            dialogueSystem.AddDialogue("Why are you going to solve the\nmurder?", Characters.Shroomlock);
            dialogueSystem.AddDialogue("Because otherwise i would get the\nblame for it", Characters.Bowser);
            dialogueSystem.AddDialogue("Now i give you 5 seconds to go\nbother someone else", Characters.Bowser);
            dialogueSystem.AddDialogue("or there will be a second dead body\nin this room.", Characters.Bowser);
            dialogueSystem.AddDialogue("(I should leave him alone)", Characters.Shroomlock);
            return dialogueSystem;
        }        
        public DialogueSystem GoomDialogue()
        {
            DialogueSystem dialogueSystem = new DialogueSystem();
            dialogueSystem.AddDialogue("Hello, were you in the room when the\nmurder happend", Characters.Shroomlock);
            dialogueSystem.AddDialogue("Yes", Characters.Goom);
            dialogueSystem.AddDialogue("Could you describe what you\nwitnessed?", Characters.Shroomlock);
            dialogueSystem.AddDialogue("Were talking, lights went out,\nheard loud noise,", Characters.Goom);
            dialogueSystem.AddDialogue("lights went on, Mario dead", Characters.Goom);
            dialogueSystem.AddDialogue("What was the loud noise?", Characters.Shroomlock);
            dialogueSystem.AddDialogue("Sound like.... ", Characters.Goom);
            dialogueSystem.AddDialogue("Baa ba", Characters.Ba);
            dialogueSystem.AddDialogue("you right, Ba", Characters.Goom);
            dialogueSystem.AddDialogue("Sound like someone hit floor", Characters.Goom);
            dialogueSystem.AddDialogue("Where were you standing when lights\nwhen out?", Characters.Shroomlock);
            dialogueSystem.AddDialogue("standing in front, next to Boss?", Characters.Goom);
            dialogueSystem.AddDialogue("Thank you for your cooperation!", Characters.Shroomlock);
            dialogueSystem.AddDialogue("Problem no for me", Characters.Goom);
            return dialogueSystem;
        }        
        public DialogueSystem BaDialogue()
        {
            DialogueSystem dialogueSystem = new DialogueSystem();
            dialogueSystem.AddDialogue("Hello, were you in the room when the\nmurder happend", Characters.Shroomlock);
            dialogueSystem.AddDialogue("Ba", Characters.Ba);
            dialogueSystem.AddDialogue("(I am taking that as a yes)", Characters.Shroomlock);
            dialogueSystem.AddDialogue("Could you describe what you \nwitnessed?", Characters.Shroomlock);
            dialogueSystem.AddDialogue("Ba ba baaa, ba ba ba ba", Characters.Ba);
            dialogueSystem.AddDialogue("happend excatly", Characters.Goom);
            dialogueSystem.AddDialogue("beg my pardon, what did he just say?", Characters.Goom);
            dialogueSystem.AddDialogue("Ba ba baaaa, ba ba ba ba", Characters.Ba);
            dialogueSystem.AddDialogue("(I have no idea what he is saying,\nim gonna leave him alone)", Characters.Shroomlock);
            dialogueSystem.AddDialogue("Thank you for your cooperation.", Characters.Shroomlock);

            return dialogueSystem;
        }
        
        public DialogueSystem EndDialogue(List<string> answer, bool hasNote)
        {
            DialogueSystem dialogueSystem = new DialogueSystem();
            var item = answer[1];
            var chara = answer[0];
            hasSuicideNote = hasNote;

            dialogueSystem.AddDialogue("Mario has been murderd by  " +  chara, Characters.Shroomlock);
            dialogueSystem.AddDialogue("using a " + item, Characters.Shroomlock);
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
                    dialogueSystem.AddDialogue("The murderer couldn't have possibly \nhave used a lighter", Characters.Bowser);
                    dialogueSystem.AddDialogue("It would have lit up the room and \n everybody would have seen it!", Characters.Bowser);
                    DefeatDialogue(dialogueSystem);
                    break;
                case "Pan":
                    dialogueSystem.AddDialogue("OBJECTION", Characters.Bowser);
                    dialogueSystem.AddDialogue("The murderer couldn't have possibly \nhave used a pan", Characters.Bowser);
                    dialogueSystem.AddDialogue("Mario didn't have bruises or anything \nelse that could have implemented", Characters.Bowser);
                    dialogueSystem.AddDialogue("that he was hit with the pan!", Characters.Bowser);
                    DefeatDialogue(dialogueSystem);
                    break;
                case "Coin":
                    dialogueSystem.AddDialogue("OBJECTION", Characters.Bowser);
                    dialogueSystem.AddDialogue("The murderer couldn't have possibly \nhave used a coin", Characters.Bowser);
                    dialogueSystem.AddDialogue("Mario didn't have marks or anything \nelse that could have implemented", Characters.Bowser);
                    dialogueSystem.AddDialogue("that he was murderd with the coin", Characters.Bowser);
                    DefeatDialogue(dialogueSystem);
                    break;
                case "Gun":
                    dialogueSystem.AddDialogue("OBJECTION", Characters.Bowser);
                    dialogueSystem.AddDialogue("The murderer couldn't have possibly \nhave used a gun", Characters.Bowser);
                    dialogueSystem.AddDialogue("if the murdrer used the gun a bullet \nshould have been found", Characters.Bowser);
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
                    dialogueSystem.AddDialogue("Shroomlock how could you say that I \nmurderd him!", Characters.Peach);
                    dialogueSystem.AddDialogue("(She is right how could I say that, \nShe couldn't have stab him precisely \nin the heart)", Characters.Shroomlock);
                    dialogueSystem.AddDialogue("(Because it was to dark to see, \nwhere he was)", Characters.Shroomlock);
                    DefeatDialogue(dialogueSystem);
                    break;
                case "Daisy":
                    dialogueSystem.AddDialogue("WHAT! ME!?, I COULDN'T HAVE DONE IT \nI WAS BEHIND HIM!", Characters.Daisy);
                    dialogueSystem.AddDialogue("(She is right, but Mario could have \nturned around, still the stabwound \nwas to precisely in the heart)", Characters.Shroomlock);
                    dialogueSystem.AddDialogue("(The murderer knew excatly where \nthey were aiming)", Characters.Shroomlock);
                    DefeatDialogue(dialogueSystem);
                    break;
                case "Luigi":
                    dialogueSystem.AddDialogue("Me?, I killed my brother?, \nbut i only bumped into him", Characters.Luigi);
                    dialogueSystem.AddDialogue("(A bumped couldn't have killed Mario)", Characters.Shroomlock);
                    dialogueSystem.AddDialogue("(besides when the light went on \nLuigi was also on the floor)", Characters.Shroomlock);
                    dialogueSystem.AddDialogue("(If he did it he should have been \ncoverd in blood)", Characters.Shroomlock);
                    DefeatDialogue(dialogueSystem);
                    break;
                case "Bowser":
                    dialogueSystem.AddDialogue("ME!? HOW YOU DARE SAY ME.\nMABYE I AM THE VILLIAN ", Characters.Bowser);
                    dialogueSystem.AddDialogue("BUT I DIDN'T KILL HIM! \nI'LL TELL YOU WHY", Characters.Bowser);
                    dialogueSystem.AddDialogue("When the lights went out", Characters.Bowser);
                    dialogueSystem.AddDialogue("I was right infront of him. \nIn the dark ", Characters.Bowser);
                    dialogueSystem.AddDialogue("would have been hard to get to him \nand stab him in the heart", Characters.Bowser);
                    dialogueSystem.AddDialogue("(He is right)", Characters.Shroomlock);
                    DefeatDialogue(dialogueSystem);
                    break;
                case "Goom":
                    dialogueSystem.AddDialogue("Murderer is Goom?", Characters.Goom);
                    dialogueSystem.AddDialogue("Goom didn't murder him he was beside \nme the whole time", Characters.Bowser);
                    dialogueSystem.AddDialogue("besides he doesn't have hands so \nhe couldn't have", Characters.Bowser);
                    dialogueSystem.AddDialogue("stabbed him precisely in the heart", Characters.Bowser);
                    dialogueSystem.AddDialogue("He is right", Characters.Shroomlock);
                    DefeatDialogue(dialogueSystem);
                    break;
                case "Ba":
                    dialogueSystem.AddDialogue("Ba? BA? BAA?", Characters.Ba);
                    dialogueSystem.AddDialogue("*Ba Charges towards Shroomlock \nand starts attacking him*", Characters.Narrator);
                    dialogueSystem.AddDialogue("A second murder happend that day", Characters.Narrator);
                    dialogueSystem.AddDialogue("Who knew goombas can be so aggresive", Characters.Narrator);
                    dialogueSystem.AddDialogue("Anyway Ba was not the murderer, \npress enter to restart", Characters.Narrator);
                    dialogueSystem.AddDialogue("END", Characters.Narrator);
                    break;
            }
        }
        private void DefeatDialogue(DialogueSystem dialogueSystem)
        {
            dialogueSystem.AddDialogue("It seems I missed something, \nlet me relook the case ", Characters.Shroomlock);
            dialogueSystem.AddDialogue("You failed to catch the murderer, \npress enter to restart", Characters.Narrator);
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
                dialogueSystem.AddDialogue("The knife was the only weapon in \nroom", Characters.Shroomlock);
                dialogueSystem.AddDialogue("that could have done something like \nthat", Characters.Shroomlock);
                dialogueSystem.AddDialogue("It was too dark in the room for \nsomebody to see where he was", Characters.Shroomlock);
                dialogueSystem.AddDialogue("and even if someone knew it was too \ndark to see where his heart was", Characters.Shroomlock);
                dialogueSystem.AddDialogue("So it was suicide!", Characters.Shroomlock);
            }

            dialogueSystem.AddDialogue("I think we have our answer, ", Characters.Hammer_Bro);
            dialogueSystem.AddDialogue("I hereby declare that this murder \n suicide!", Characters.Hammer_Bro);
            dialogueSystem.AddDialogue("*Hammer bro slams his hammer*", Characters.Narrator);
            dialogueSystem.AddDialogue("The case is closed and \nyou solved the murderer", Characters.Narrator);
            dialogueSystem.AddDialogue("Good job! press enter to restart", Characters.Narrator);
            dialogueSystem.AddDialogue("END", Characters.Narrator);

        }
    }
}
