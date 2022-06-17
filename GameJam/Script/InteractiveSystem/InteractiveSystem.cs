using GameJam.Game;
using GameJam.Tools;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace GameJam
{
    class InteractiveSystem
    {
        internal RenderForm renderForm;
        internal World world;
        internal Inventory inventory;
        public DialogueLibrary dialogueLibrary = new DialogueLibrary();

        public InteractiveSystem(RenderForm renderForm, Inventory inventory, World world)
        {
            this.renderForm = renderForm;
            this.inventory = inventory;
            this.world = world;
        }

        internal void Interact(char c)
        {
            Characters character = world.characters[c];

            // Call Dialogue System here
            renderForm.dialogueSystem = dialogueLibrary.WhichCharacterDialogue(character);
            renderForm.isSpeaking = true;
            renderForm.PlayDialogue();
            foreach(var item in inventory.inventory)
            {
                var isSecretItem = item.Key == "Suicide note";
                if (isSecretItem) continue;
                renderForm.menuDialogueItems.Add(item.Key);
            }
            foreach (var chara in world.characters)
            {
                var charName = chara.Value.ToString();
                bool isShroomlock = charName == "Shroomlock";
                bool isHammerBro = charName == "Hammer_Bro";
               if (!isShroomlock && !isHammerBro) renderForm.menuDialogueChar.Add(charName);
            }

            // Mark Debug Begin
            Console.WriteLine(character);
            // Mark Debug End
            renderForm.dialogueSystem = dialogueLibrary.WhichCharacterDialogue(character);
            renderForm.PlayDialogue();

        }

        internal void PickUp(char c)
        {
            string itemName = world.worldItems[c].name;

            inventory.AddItem(world.worldItems[c]);

            // Mark Debug Begin
            Console.WriteLine("Added " + itemName + " to inventory.");
            // Mark Debug End
        }
    }
}