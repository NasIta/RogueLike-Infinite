using System;
using System.Drawing;
using System.Windows.Forms;

using RogueLike.Model;

namespace RogueLike.View
{
	public class InventoryPanel : Panel
	{
		private static InventoryPanel _instance {get; set;}
		private static int _selectedItem {get; set;}
		
		public static bool IsShowed {get; set;}
		
		private InventoryPanel()
		{
			BackColor = Color.Black;
			Width = 460;
			Height = 300;
			Top = 100;
			Left = 200;
			
			if (Player.instance.Inventory.Count == 0) 
			{
				var emptyLabel = new Label()
				{
					Width = Height = 200,
					Text = "Инвентарь пуст",
					TextAlign = ContentAlignment.MiddleCenter,
					ForeColor = Color.Yellow,
					Font = new Font(new FontFamily("Arial"), 16, FontStyle.Regular)
				};
				this.Controls.Add(emptyLabel);
			}
			
			for (int y = 0; y < Player.instance.Inventory.Count / 10 + 1; y++) 
			{
				for (int x = 0; x < 10 && y * 10 + x < Player.instance.Inventory.Count; x++) 
				{
					this.Controls.Add(new ItemButton()
					{
						Item = Player.instance.Inventory[y * 10 + x],
						BackgroundImage = Player.instance.Inventory[y * 10 + x].Image,
						Left = 45 * (x % 10) + 5, 
						Top = 45 * y + 5});
				}
			}
			
			_selectedItem = 0;
		}
		
		public static void Create()
		{
			_instance = new InventoryPanel();
			MainForm.instance.pictureBox.Controls.Add(_instance);
			_instance.Show();
			IsShowed = true;
			
			MainForm.GameState = GameStates.Inventory;
			if (Player.instance.Inventory.Count > 0) 
			{
				(_instance.Controls[_selectedItem] as ItemButton).Select();
			}
			
			ScreenUpdater.OnUnselected();
		}
		
		public static void Close()
		{
			MainForm.instance.pictureBox.Controls.Remove(_instance);
			_instance.Dispose();
			_instance = null;
			IsShowed = false;
			
			MainForm.GameState = GameStates.Play;
			
			Player.CheckSelectableItems();
		}
		
		public static void SendKey(Keys key)
		{
			if (key == Keys.E) 
			{
				InventoryPanel.Close();
			}
			
			if (Player.instance.Inventory.Count > 0 && _instance != null)  
			{
				if (_instance.Controls != null) 
				{
					foreach (var btn in _instance.Controls) 
					{
						(btn as ItemButton).FlatAppearance.BorderSize = 0;
					}
				}
				
				if (key == Keys.Up) 
				{
					_selectedItem = (_selectedItem - 10).Normalize() % Player.instance.Inventory.Count;
					(_instance.Controls[_selectedItem] as ItemButton).Select();
				}
				if (key == Keys.Down) 
				{
					_selectedItem = (_selectedItem + 10).Normalize() % Player.instance.Inventory.Count;
					(_instance.Controls[_selectedItem] as ItemButton).Select();
				}
				if (key == Keys.Left) 
				{
					_selectedItem = (_selectedItem - 1).Normalize() % Player.instance.Inventory.Count;
					(_instance.Controls[_selectedItem] as ItemButton).Select();
				}
				if (key == Keys.Right) 
				{
					_selectedItem = (_selectedItem + 1).Normalize() % Player.instance.Inventory.Count;
					(_instance.Controls[_selectedItem] as ItemButton).Select();
				}
				
				if (key == Keys.Q) 
				{
					(_instance.Controls[_selectedItem] as ItemButton).Item.Use();
					
					Close();
				}
			}
		}
	}
}
