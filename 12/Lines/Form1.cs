﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoopyLandscape {
	public partial class Form1 : Form {
		Graphics graphics;
		public Form1() {
			InitializeComponent();
		}

		protected override void OnPaint(PaintEventArgs e) {
			graphics = e.Graphics;
			graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

			Pen pen = new Pen(Brushes.BlueViolet, 8);
            for(int n = 20; n <= 380; n = n + 60)
            {
                graphics.DrawLine(pen, n, 40, n + 60, 80);
            }
		}
	}
}
