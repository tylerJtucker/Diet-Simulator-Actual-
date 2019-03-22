using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Diet_Simulator
{
    class food
    {
        public int x, y, size, image;

        public food(int _x, int _y, int _size, int _image)
        {
            x = _x;
            y = _y;
            size = _size;
            image = _image;
        }

        public void Move(int speed)
        {
            y += speed;
        }

        public static bool Collision(food f)
        {
            Rectangle rec1 = new Rectangle(f.x, f.y, f.size, f.size);
            Rectangle rec2 = new Rectangle(gameScreen.mouthX, gameScreen.mouthY, gameScreen.mouthSize, gameScreen.mouthSize);

            if (rec1.IntersectsWith(rec2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
