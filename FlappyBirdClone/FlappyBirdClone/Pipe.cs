using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlappyBirdClone {
    class Pipe {
        static Random r = new Random();
        public static int order;

        public const int width = 30;
        public const int mid_space = 100;
        public int speed = 3;
        public int xpos = Form1.GamingPanel_width;
        public int upper_height = 100;

        public Pipe(int len, int order) {
            this.xpos += ((Form1.GamingPanel_width + width) / len) * order;
            upper_height = RandHeight();
        }

        public void Move() {
            xpos -= speed;
            if (xpos < -width) {
                Respawn();
            }
        }

        void Respawn() {
            upper_height = RandHeight();
            xpos = Form1.GamingPanel_width;
        }

        int RandHeight() {
            int max = Form1.GamingPanel_height - 175;
            int min = 25;
            return r.Next() % max + min;
        }
    }
}
