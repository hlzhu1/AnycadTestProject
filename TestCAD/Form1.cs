﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnyCAD.Platform;

namespace TestCAD
{
    public partial class Form1 : Form
    {
        private AnyCAD.Presentation.RenderWindow3d renderView;
        public Form1()
        {
            InitializeComponent();
            this.renderView = new AnyCAD.Presentation.RenderWindow3d();

            //this.renderView.Location = new System.Drawing.Point(0, 27);
            System.Drawing.Size size = this.panel1.ClientSize;
            this.renderView.Size = size;

            this.renderView.TabIndex = 1;
            this.panel1.Controls.Add(this.renderView);
        }
    }
}