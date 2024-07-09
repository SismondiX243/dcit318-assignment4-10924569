using System;
using System.Drawing;
using System.Windows.Forms;

namespace CanvasSketch
{
    public partial class Form1 : Form
    {
        bool shouldPaint = false;
        Point previousPoint; // Keep track of the previous point

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            shouldPaint = true;
            previousPoint = e.Location; // Set the previous point to the current location
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            shouldPaint = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (shouldPaint)
            {
                using (Graphics graphics = CreateGraphics())
                {
                    Color drawColor = Color.Black; // Default color if no radio button is checked

                    if (radioButton1.Checked)
                        drawColor = Color.Red;
                    else if (radioButton2.Checked)
                        drawColor = Color.Green;
                    else if (radioButton4.Checked)
                        drawColor = Color.Black;
                    else if (radioButton5.Checked)
                        drawColor = Color.Blue;
                    else if (radioButton6.Checked)
                        drawColor = Color.Purple;

                    // Draw a line from the previous point to the current point
                    graphics.DrawLine(new Pen(drawColor), previousPoint, e.Location);
                    previousPoint = e.Location; // Update the previous point
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Any additional initialization code
        }
    }
}
