using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using RogueLike.Model;
using RogueLike.Controllers;
using RogueLike.View;

namespace RogueLike
{
	public partial class MainForm : Form
	{
		public static MainForm instance {get; private set;}
		
		public MainForm()
		{
			InitializeComponent();
			instance = this;
		}
		
		private void Button1Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		private void Button2Click(object sender, EventArgs e)
		{
			((Button)sender).Hide();
			
			Start();
		}

		private void Start()
		{
			Game.StartNew();
			Scene.LoadOrCreate(0, 0);
			Game.instance.ActiveScene.Render();
		}
		int y = 0; 			// todo: delete this (>_< ) !!!
		private void MainFormKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.W) 
			{
				Scene.LoadOrCreate(0, ++y);
			}
			if (e.KeyCode == Keys.S) 
			{
				Scene.LoadOrCreate(0, --y);
			}
			Game.instance.ActiveScene.Render();
		}
	}
}
