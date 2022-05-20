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
        internal bool isInRange;

        internal bool CanInteract
        {
            get => isInRange;
        }

        internal void Interact()
        {
            if (!CanInteract) return;
        }
    }
}
