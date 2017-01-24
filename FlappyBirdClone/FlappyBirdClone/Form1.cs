using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace FlappyBirdClone {
    public partial class Form1 : Form {

        public static int GamingPanel_height;
        public static int GamingPanel_width;

        public int score = 0;

        const int num_pipe = 3;

        Bird bird;
        Pipe[] pipes = new Pipe[num_pipe];

        public Form1() {
            InitializeComponent();
            GamingPanel_height = GamingPanel.Height;
            GamingPanel_width = GamingPanel.Width;
            label1.Text = "0";
            KeyPreview = true;
            KeyDown += new KeyEventHandler(KeyDownHandler);
        }


        private void Form1_Load(object sender, EventArgs e) {
            bird = new Bird();
            for (int i = 0; i < pipes.Length; i++) {
                pipes[i] = new Pipe(num_pipe, i);
            }
            Timer.Enabled = true;
        }

        private void MainTimer_tick(object sender, EventArgs e) {
            bird.Fall();
            for (int i = 0; i < pipes.Length; i++) {
                pipes[i].Move();
            }
            if (bird.isCollideWith(pipes[Pipe.order]) || bird.ypos > GamingPanel_height + 100) {
                Timer.Stop();
            }else if(pipes[Pipe.order].xpos < -Pipe.width + 1) {
                Pipe.order = (Pipe.order == num_pipe - 1) ? 0 : Pipe.order + 1;
                score++;
                label1.Text = score.ToString();
            }

            GamingPanel.Refresh();
        }

        private void KeyDownHandler(object sender, KeyEventArgs e) {
            switch (e.KeyCode) {
                case Keys.Space:
                    Debug.WriteLine("Space");
                    ((Form1)sender).bird.Jump();
                    break;
            }
        }

        private void GamingPanel_Paint(object sender, PaintEventArgs e) {
            var p = sender as Panel;
            var g = e.Graphics;

            #region bird
            Point[] points_bird = new Point[4];

            points_bird[0] = new Point(0, bird.ypos);
            points_bird[1] = new Point(0, bird.ypos + Bird.height);
            points_bird[2] = new Point(Bird.width, bird.ypos + Bird.height);
            points_bird[3] = new Point(Bird.width, bird.ypos);

            Brush brush = new SolidBrush(Color.Red);

            g.FillPolygon(brush, points_bird);
            #endregion

            #region pipe
            foreach (Pipe pipe in pipes) {
                Point[] points_pipe_upper = new Point[4];
                Point[] points_pipe_lower = new Point[4];

                points_pipe_upper[0] = new Point(pipe.xpos, 0);
                points_pipe_upper[1] = new Point(pipe.xpos, pipe.upper_height);
                points_pipe_upper[2] = new Point(pipe.xpos + Pipe.width, pipe.upper_height);
                points_pipe_upper[3] = new Point(pipe.xpos + Pipe.width, 0);

                points_pipe_lower[0] = new Point(pipe.xpos, pipe.upper_height + Pipe.mid_space);
                points_pipe_lower[1] = new Point(pipe.xpos, GamingPanel_width);
                points_pipe_lower[2] = new Point(pipe.xpos + Pipe.width, GamingPanel_width);
                points_pipe_lower[3] = new Point(pipe.xpos + Pipe.width, pipe.upper_height + Pipe.mid_space);

                Brush brush_pipe = new SolidBrush(Color.Green);
                g.FillPolygon(brush_pipe, points_pipe_upper);
                g.FillPolygon(brush_pipe, points_pipe_lower);
            }
            #endregion

        }

    }
}
