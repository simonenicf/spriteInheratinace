using System.Drawing;


namespace Eindopdracht
{
    class Sparky : Sprite
    {

        public Sparky (RectangleF screenPosition)
        {
            this.screenPosition = screenPosition;
            imageFrame = new Rectangle(95, 100, 16, 16);

        }


    }
}
