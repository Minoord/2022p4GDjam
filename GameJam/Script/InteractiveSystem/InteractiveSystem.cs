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

        public InteractiveSystem(RenderForm renderForm, Inventory inventory, World world)
        {
            this.renderForm = renderForm;
            this.inventory = inventory;
            this.world = world;
        }

        internal void Interact(char c)
        {
            var test = world.characters[c];

            // Call Dialogue System here

            // Mark Debug Begin
            Console.WriteLine(test);
            // Mark Debug End
        }

        internal void PickUp(char itemChar)
        {
            Item item = new Item("", "");
            world.worldItems.TryGetValue(itemChar, out item);
            inventory.AddItem(item);

            // Mark Debug Begin
            //Console.WriteLine(item.name);
            //Console.WriteLine(item.description);
            // Mark Debug End
        }
    }
}