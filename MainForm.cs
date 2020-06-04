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
		public static GameStates GameState;
		
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
			if (GameState == GameStates.Play) 
			{
				Player.SendKey(keyData);
			}
			else if (GameState == GameStates.Inventory) 
			{
				InventoryPanel.SendKey(keyData);
			}
			return true;
		}
	}
}
