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
        internal List<char> charList = new List<char>();

        public InteractiveSystem(RenderForm renderForm)
        {
            this.renderForm = renderForm;

            charList.Add('B');
            charList.Add('L');
            charList.Add('Y');
        }

        private bool isInRange;

        internal bool IsInRange(bool isInRange)
        {
            return this.isInRange = isInRange;
        }

        internal void Interact(char c)
        {
            if (!isInRange) return;
            Console.WriteLine(c);
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