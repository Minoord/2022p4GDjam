﻿using System;
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
            tileMap.Add('D', new Rectangle(2, 75, 16, 16));
            tileMap.Add('!', new Rectangle(66, 75, 16, 16));

            // Items Begin
            tileMap.Add('/', new Rectangle(86, 75, 16, 16));
            tileMap.Add('0', new Rectangle(86, 75, 16, 16));
            tileMap.Add('>', new Rectangle(86, 75, 16, 16));
            // Items End

            // Characters Begin
            tileMap.Add('B', new Rectangle(7, 197, 61, 61));
            tileMap.Add('L', new Rectangle(123, 219, 39, 39));
            tileMap.Add('H', new Rectangle(77, 219, 39, 39));
            tileMap.Add('P', new Rectangle(170, 219, 39, 39));
            // Characters End

            playerAnimation = new Rectangle[]
                {
                    new Rectangle(43, 9, 16, 16),
                    new Rectangle(60, 9, 16, 16),
                    new Rectangle(77, 9, 16, 16)
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


