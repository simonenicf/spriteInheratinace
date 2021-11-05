using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace Eindopdracht
{
    public partial class RenderForm : Form
    {
        private const int tileSize = 16;

        private readonly Image spriteSheetImage;

        private readonly List<Sprite> spritesToDraw = new();


        public RenderForm()
        {
            InitializeComponent();
            spriteSheetImage = Bitmap.FromFile("sprites.png");


           

            DoubleBuffered = true;
            ResizeRedraw = true;

            FormClosing += Form1_FormClosing;
            Load += RenderForm_Load;
        }

        private void RenderForm_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            for (int i = 0; i < 12; i++)
            {

                Rectangle screenPosition = new Rectangle(
                    random.Next(0, Width - tileSize),
                    random.Next(0, Height - tileSize),
                    tileSize,
                    tileSize);
                
                if (i % 3 == 0)
                {
                    spritesToDraw.Add(new SirKibble(screenPosition));
                    continue;
                }
                if(i % 3 == 1)
                {
                    spritesToDraw.Add(new Sparky(screenPosition));
                }
                else
                {
                    spritesToDraw.Add(new WaddleDee(screenPosition));
                }
                
            }
            //doe eens wat andere sprites erbij!
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            spriteSheetImage.Dispose();
        }




        private Graphics InitGraphics(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.None;
            g.InterpolationMode = InterpolationMode.NearestNeighbor;

            g.Clear(Color.Black);
            return g;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = InitGraphics(e);

            foreach (Sprite item in spritesToDraw)
            {
                g.DrawImage(spriteSheetImage, item.screenPosition, item.imageFrame, GraphicsUnit.Pixel);
            }
        }


    }

}


