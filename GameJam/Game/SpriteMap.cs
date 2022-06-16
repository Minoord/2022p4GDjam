using System;
using System.Collections.Generic;
using System.Drawing;

namespace GameJam.Game
{
    internal class SpriteMap
    {
        private readonly Dictionary<char, Rectangle> tileMap = new Dictionary<char, Rectangle>();
        private readonly Rectangle[] playerAnimation;
        private readonly Rectangle[] dialogue;

        internal SpriteMap()
        {
            tileMap.Add('#', new Rectangle(45, 75, 16, 16));
            tileMap.Add('.', new Rectangle(23, 75, 16, 16));
            tileMap.Add(']', new Rectangle(2, 75, 16, 16));
            tileMap.Add('!', new Rectangle(66, 75, 16, 16));

            // Items Begin
            tileMap.Add('/', new Rectangle(86, 75, 16, 16));
            tileMap.Add('0', new Rectangle(105, 75, 16, 16));
            tileMap.Add('>', new Rectangle(145, 75, 16, 16));
            tileMap.Add('^', new Rectangle(125, 75, 16, 16));
            tileMap.Add('$', new Rectangle(164, 75, 16, 16));
            tileMap.Add('*', new Rectangle(184, 75, 16, 16));
            // Items End

            // Characters Begin
            tileMap.Add('B', new Rectangle(7, 197, 61, 61));
            tileMap.Add('L', new Rectangle(123, 219, 39, 39));
            tileMap.Add('H', new Rectangle(77, 219, 39, 39));
            tileMap.Add('P', new Rectangle(170, 219, 39, 39));
            tileMap.Add('D', new Rectangle(216, 219, 40, 40));
            tileMap.Add('G', new Rectangle(315, 219, 40, 40));
            tileMap.Add('b', new Rectangle(265, 219, 40, 40));
            tileMap.Add('M', new Rectangle(359, 219, 40, 40));
            // Characters End

            playerAnimation = new Rectangle[]
                {
                    new Rectangle(1, 144, 39, 39)
                };

            dialogue = new Rectangle[]
            {
                new Rectangle(2, 99, 160, 40)
            };
        }

        internal Dictionary<char, Rectangle> GetMap()
        {
            return tileMap;
        }

        internal Rectangle[] GetPlayerFrames()
        {
            return playerAnimation;
        }

        internal Rectangle[] GetDialoguePosition()
        {
            return dialogue;
        }
    }

}


