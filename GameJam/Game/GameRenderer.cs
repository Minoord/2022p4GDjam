using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GameJam.Game
{
    public class GameRenderer : IDisposable
    {
        private readonly GameContext context;
        private float frametime;
        private readonly Image image;

        private Font font = new Font(FontFamily.GenericMonospace, 5); 
        private SolidBrush colourBrush = new SolidBrush(Color.White);

        public DialogueSystem dialogueSystem;
        public string dialogue;

        public bool isRenderingDialogue;
        public bool isRenderingMenu;

        public List<string> menuOptions;

        public GameRenderer(GameContext context)
        {
            this.context = context;

            image = Bitmap.FromFile("sprites.png");

        }
        private Graphics InitGraphics(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //make nice pixels
            g.SmoothingMode = SmoothingMode.None;
            g.InterpolationMode = InterpolationMode.NearestNeighbor;


            g.Transform = new Matrix();
            g.ScaleTransform(context.scaleunit, context.scaleunit);
            //there will be some tearing between tiles, a solution to that is to render to a bitmap then draw that bitmap, fun challenge?
            g.Clear(Color.Black);
            return g;
        }
        internal void Render(PaintEventArgs e, float frametime)
        {
            this.frametime = frametime;

            Graphics g = InitGraphics(e);
            RenderRoom(g);
            RenderObject(g, context.player);

            if (dialogue == null) isRenderingDialogue = false;
            if (!isRenderingDialogue) return;
            RenderObject(g, context.dialougue);
            RenderDialogue(g, dialogue);
            if (!isRenderingMenu) return;
            RenderObject(g, context.menu);
            RenderObject(g, context.dialougueArrow);
            RenderMenu(g, menuOptions);
        }

        private void RenderRoom(Graphics g)
        {
            foreach (Tile[] row in context.room.tiles)
            {
                foreach (Tile t in row)
                {
                    g.DrawImage(image, t.rectangle, t.sprite, GraphicsUnit.Pixel);
                }
            }
        }

        private void RenderObject(Graphics g, RenderObject renderObject)
        {
            g.DrawImage(image, renderObject.rectangle, renderObject.frames[(int)renderObject.frame], GraphicsUnit.Pixel);
            renderObject.MoveFrame(frametime);
        }

        private void RenderMenu(Graphics g, List<string> list)
        {
            if (list == null || list.Count <= 0)
            {
                isRenderingMenu = false;
                return;
            }
            var height = -15;
            var currentspace = height + 10;
            foreach (var strings in list)
            {
                currentspace += 10;

                g.DrawString(strings, font, colourBrush, new Point(127, currentspace));
            }
        }
        private void RenderDialogue(Graphics g, string dialogue)
        {
            g.DrawString(dialogue, font, colourBrush , new Point(15,90));
        }

        public void Dispose()
        {
            image.Dispose();
        }
    }

}


