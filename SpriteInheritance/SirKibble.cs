using System.Drawing;

namespace Eindopdracht
{
    class SirKibble : Sprite
    {

        public SirKibble(RectangleF screenPosition)
        {
            this.screenPosition = screenPosition;
            imageFrame = new Rectangle(95, 199, 16, 16);
        }
    }
}



