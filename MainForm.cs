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
		
		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			if (keyData == Keys.Up) 
			{
				Player.Move(0, -1);
			}
			if (keyData == Keys.Down) 
			{
				Player.Move(0, 1);
			}
			if (keyData == Keys.Left) 
			{
				Player.Move(-1, 0);
			}
			if (keyData == Keys.Right) 
			{
				Player.Move(1, 0);
			}
			Game.instance.ActiveScene.Render();
			return true;
		}
	}
}
