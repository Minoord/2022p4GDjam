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

            renderForm.dialogueSystem = dialogueLibrary.WhichCharacterDialogue(character);
            renderForm.PlayDialogue(); 
        }

        internal void PickUp(char c)
        {
            inventory.AddItem(world.worldItems[c]);

            // Mark Debug Begin
            Console.WriteLine("Added " + c + " to inventory.");
            // Mark Debug End
        }
    }
}