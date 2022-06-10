using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameJam
{
    class World
    {
        internal Dictionary<char, Item> worldItems = new Dictionary<char, Item>();
        internal Dictionary<char, Characters> characters = new Dictionary<char, Characters>();

        public World()
        {
            worldItems.Add('/', new Item("Knife", "A knife adorned in the dried blood. You remember the victim did have a stab wound in the chest."));
            worldItems.Add('0', new Item("Pan", "A large frying pan with a dent in the bottom. You remember the victim did have a fracture in the skull."));
            worldItems.Add('>', new Item("Gun", "A small pistol, recently fired. You remember the victim did have a bullet wound in the throat"));

            characters.Add('B', Characters.Bowser);
            characters.Add('L', Characters.Luigi);
            characters.Add('H', Characters.Hammer_Bro);
        }
    }
}