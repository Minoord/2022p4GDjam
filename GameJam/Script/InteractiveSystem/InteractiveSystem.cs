using GameJam.Game;
using GameJam.Tools;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GameJam
{
    class InteractiveSystem
    {
        internal RenderForm renderForm;
        internal Inventory inventory;

        public InteractiveSystem(RenderForm renderForm, Inventory inventory)
        {
            this.renderForm = renderForm;
            this.inventory = inventory;
        }

        internal bool isInRange = true;

        internal bool canInteract = true;

        internal void Interact()
        {
            if (!canInteract) return;
            Console.WriteLine(renderForm.GetPlayerLocation());
            Console.WriteLine(renderForm.GetRoom().roomx);
            Console.WriteLine(renderForm.GetRoom().roomy);
        }

        internal void PickUp(string item)
        {
            //inventory.AddItem(item);
            Console.WriteLine(item);
        }
    }
}