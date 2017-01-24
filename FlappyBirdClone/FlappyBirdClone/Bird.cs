using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlappyBirdClone {
    class Bird {
        public const int width = 10;
        public const int height = 10;

        public const int gravity = 1;
        public const int jumpdist = 12;
        public int velocity = 0;
        public int ypos = 0;

        public Bird() {

        }

        public void Fall() {
            velocity += gravity;
            ypos += velocity;
        }

        public void Jump() {
            velocity = 0;
            velocity -= jumpdist;
        }

        public bool isCollideWith(Pipe p) {
            return ((p.xpos >= -Pipe.width && p.xpos <= 10)      // Inside detect
                        && (ypos < p.upper_height || ypos + height > p.upper_height + Pipe.mid_space)); // Collided;
        }
    }
}
