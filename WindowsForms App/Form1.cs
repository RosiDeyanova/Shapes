using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsForms_App
{
    public partial class Form1 : Form
    {
        public Rectangle drawRectangle;
        public Square drawSquare;
        public Triangle drawTriangle;
        public List<Shape> Shapes { get; set; }

        public Form1()
        {
            InitializeComponent();
            Shapes = new List<Shape>();
        }

    }
}
