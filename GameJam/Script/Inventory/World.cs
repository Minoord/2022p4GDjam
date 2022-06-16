using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameJam.Game
{
    class World
    {
        internal Dictionary<char, Item> worldItems = new Dictionary<char, Item>();
        internal Dictionary<char, Characters> characters = new Dictionary<char, Characters>();

        public World(GameContext gc)
        {
            worldItems.Add('/', new Item("Knife", "A knife adorned in the dried blood. You remember the victim did have a stab wound in the chest."));
            worldItems.Add('0', new Item("Pan", "A large frying pan with a dent in the bottom. You remember the victim did have a fracture in the skull."));
            worldItems.Add('>', new Item("Gun", "A small pistol, recently fired. You remember the victim did have a bullet wound in the throat."));
            worldItems.Add('^', new Item("Lighter", "A cigarette lighter, empty. You remember the victim having small burn wounds near the neck."));
            worldItems.Add('$', new Item("Coin", "Big Moneys."));
            worldItems.Add('*', new Item("Suicide note", "Suicide is badass."));

            characters.Add('B', Characters.Bowser);
            characters.Add('L', Characters.Luigi);
            characters.Add('H', Characters.Hammer_Bro);
            characters.Add('P', Characters.Peach);
            characters.Add('D', Characters.Daisy);
            characters.Add('G', Characters.Goom);
            characters.Add('b', Characters.Ba);
            characters.Add('M', Characters.Mario);
        }
    }
}