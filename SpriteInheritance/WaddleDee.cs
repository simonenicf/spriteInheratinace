using System.Drawing;

namespace Eindopdracht
{
    class WaddleDee : Sprite
    {
        
        public WaddleDee(RectangleF screenPosition)
        {
            this.screenPosition = screenPosition;
            imageFrame = new Rectangle(95, 457, 16, 16);
        }
    }
}