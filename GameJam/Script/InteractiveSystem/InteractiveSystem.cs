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

        public InteractiveSystem(RenderForm renderForm)
        {
            this.renderForm = renderForm;
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
            Console.WriteLine(item);
            // Add to Database inventory
        }
    }
}