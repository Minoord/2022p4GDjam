using GameJam.Game;
using GameJam.Tools;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GameJam
{

    public partial class RenderForm : Form
    {

        private InteractiveSystem interactiveSystem;
        private World world;
        private Inventory inventory;
        private LevelLoader levelLoader;
        private float frametime;
        public bool isSpeaking;
        private bool isInMenu { get; set; }
        private bool itemIsCorrectly;
        private bool charIsCorrectly;

        public DialogueLibrary dialogueLibrary = new DialogueLibrary();
        public DialogueSystem dialogueSystem;
        private GameRenderer renderer;
        private readonly GameContext gc = new GameContext();

        public List<string> menuDialogueItems = new List<string>();
        public List<string> menuDialogueChar = new List<string>();
        private List<string> playersChoices = new List<string>();

        private int playerChoiceNumber = 0;

        public RenderForm()
        {
            InitializeComponent();

            DoubleBuffered = true;
            ResizeRedraw = true;

            KeyDown += RenderForm_KeyDown;
            FormClosing += Form1_FormClosing;
            Load += RenderForm_Load;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            renderer.Dispose();
        }
        private void RenderForm_Load(object sender, EventArgs e)
        {
            inventory = new Inventory();
            world = new World(gc);
            interactiveSystem = new InteractiveSystem(this, inventory, world);

            levelLoader = new LevelLoader(gc.tileSize, new FileLevelDataSource());
            levelLoader.LoadRooms(gc.spriteMap.GetMap());

            renderer = new GameRenderer(gc);

            gc.room = levelLoader.GetRoom(0, 0);

            gc.player = new RenderObject() // MARK HIER WORD PLAYER GERENDERED
            {
                frames = gc.spriteMap.GetPlayerFrames(),
                rectangle = new Rectangle(2 * gc.tileSize, 2 * gc.tileSize, gc.tileSize, gc.tileSize),
            };


            ClientSize =
             new Size(

                (gc.tileSize * gc.room.tiles[0].Length) * gc.scaleunit,
                (gc.tileSize * gc.room.tiles.Length) * gc.scaleunit
                );

            gc.dialougue = new RenderObject()
            {
                frames = gc.spriteMap.GetDialoguePosition(),
                rectangle = new Rectangle(0, 80, 160, 40),
            };
            
            gc.Menu = new RenderObject()
            {
                frames = gc.spriteMap.GetDialoguePosition(),
                rectangle = new Rectangle(112, 40, 50, 40),
            };



        }

        private void RenderForm_KeyDown(object sender, KeyEventArgs e)
        {
         
            
                if (e.KeyCode == Keys.W)
                {
                    MovePlayer(0, -1);
                }
                else if (e.KeyCode == Keys.S)
                {
                    MovePlayer(0, 1);
                }
                else if (e.KeyCode == Keys.A)
                {
                    MovePlayer(-1, 0);
                }
                else if (e.KeyCode == Keys.D)
                {
                    MovePlayer(1, 0);
                }
                else if (e.KeyCode == Keys.E)
                {
                    inventory.PrintAllItems();
                    CheckTiles();
               }
            
                if (e.KeyCode == Keys.Return && !isInMenu)
                {
                    PlayDialogue();
                }
                else if (isInMenu)
                {
                    inMenu(e);
                }
            

        }

        public void inMenu(KeyEventArgs e)
        {
            Console.WriteLine(renderer.menuOptions.Count +":"+  playerChoiceNumber);
            if (e.KeyCode == Keys.Return)
            {
                playersChoices.Add(renderer.menuOptions[playerChoiceNumber]);
                PlayDialogue();
                isInMenu = false;
            }
            else if (e.KeyCode == Keys.Up)
            {
                playerChoiceNumber -= 1;
                if (playerChoiceNumber < 0) playerChoiceNumber = renderer.menuOptions.Count - 1;
            }
            else if (e.KeyCode == Keys.Down)
            {
                playerChoiceNumber += 1;
                if (playerChoiceNumber >= renderer.menuOptions.Count) playerChoiceNumber = 0;
            }
        }

        public void PlayDialogue()
        {
            if (dialogueSystem == null) return;
            renderer.isRenderingDialogue = true;
            var dialogue = dialogueSystem.NextDialogue();
            if (dialogue == null)
            {
                isInMenu = false;
                menuDialogueItems.Clear();
                menuDialogueChar.Clear();

            }
            if (dialogue == "MENU1")
            {
                renderer.menuOptions = menuDialogueChar;
                renderer.dialogue = dialogueSystem.MenuDialogue();
                renderer.isRenderingMenu = true;
                isInMenu = true;
                playerChoiceNumber = 0;
            }
            else if(dialogue == "MENU2")
            {
                renderer.menuOptions = menuDialogueItems;
                renderer.dialogue = dialogueSystem.MenuDialogue();
                renderer.isRenderingMenu = true;
                isInMenu = true;
                playerChoiceNumber = 0;
            }
            else if( dialogue == "ENDDIA")
            {
                dialogueSystem = dialogueLibrary.EndDialogue(playersChoices, false);
            }
            else if (dialogue == "END")
            {
                Application.Restart();
            }
            else
            {
                isInMenu = false;
                renderer.dialogue = dialogue;
                renderer.isRenderingMenu = false;
            }

        }

        internal RectangleF GetPlayerLocation()
        {
            return gc.player.rectangle;
        }

        internal Room GetRoom()
        {
            return gc.room;
        }

        private void CheckTiles()
        {
            RenderObject player = gc.player;
            float newRight = player.rectangle.X + gc.tileSize;
            float newLeft = player.rectangle.X - gc.tileSize;
            float newTop = player.rectangle.Y - gc.tileSize;
            float newBottom = player.rectangle.Y + gc.tileSize;

            Tile next = gc.room.tiles.SelectMany(ty => ty.Where(tx =>
            (tx.rectangle.Contains((int)newRight, (int)player.rectangle.Y) ||
            tx.rectangle.Contains((int)newLeft, (int)player.rectangle.Y) ||
            tx.rectangle.Contains((int)player.rectangle.X, (int)newTop) ||
            tx.rectangle.Contains((int)player.rectangle.X, (int)newBottom))
            &&
            world.characters.ContainsKey(tx.graphic)
            )).FirstOrDefault();

            if (next == null) return;
            interactiveSystem.Interact(next.graphic);
        }

        private void MovePlayer(int x, int y)
        {
            if (renderer.isRenderingDialogue) return;
            RenderObject player = gc.player;
            float newx = player.rectangle.X + (x * gc.tileSize);
            float newy = player.rectangle.Y + (y * gc.tileSize);

            Tile next = gc.room.tiles.SelectMany(ty => ty.Where(tx => tx.rectangle.Contains((int)newx, (int)newy))).FirstOrDefault();

            if (next != null)
            {
                bool isChar = world.characters.ContainsKey(next.graphic);
                bool isItem = world.worldItems.ContainsKey(next.graphic);
                if (next.graphic == ']')
                {
                    EnterRoom(x, y, player);
                }

                else if (next.graphic != '#' && !isChar)
                {
                    MoveSprite(newx, newy, player);
                    if (isItem)
                    {
                        interactiveSystem.PickUp(next.graphic);

                        Dictionary<char, Rectangle> map = gc.spriteMap.GetMap();
                        next.graphic = '.';
                        next.sprite = map[next.graphic];
                    }
                }
            }
        }

        internal void EnterRoom(int x, int y, RenderObject player)
        {
            gc.room = levelLoader.GetRoom(gc.room.roomx + x, gc.room.roomy + y);

            if (y != 0)
            {
                player.rectangle.Y += -y * ((gc.room.tiles.Length - 2) * gc.tileSize);
            }
            else
            {
                player.rectangle.X += -x * ((gc.room.tiles[0].Length - 2) * gc.tileSize);
            }
        }

        internal void MoveSprite(float newx, float newy, RenderObject player)
        {
            player.rectangle.X = newx;
            player.rectangle.Y = newy;
        }

        public void Logic(float frametime)
        {
            this.frametime = frametime;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            renderer.Render(e, frametime);
        }

        private void RenderForm_Load_1(object sender, EventArgs e)
        {

        }
    }

}


