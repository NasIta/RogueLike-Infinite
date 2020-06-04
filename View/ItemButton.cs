using System;
using System.Drawing;
using System.Windows.Forms;

using RogueLike.Model;

namespace RogueLike.View
{
	public class ItemButton: Button
	{
		private ItemButton _selected {get; set;}
		
		public Item Item {get; set;}
		
		public ItemButton()
		{
			FlatStyle = FlatStyle.Flat;
			TextAlign = ContentAlignment.BottomRight;
			FlatAppearance.BorderSize = 0;
			FlatAppearance.BorderColor = Color.Yellow;
			BackColor = Color.Black;
			ForeColor = Color.Red;
			Width = Height = 40;
		}
		
		new public void Select()
		{
			_selected = this;
			_selected.FlatAppearance.BorderSize = 3;
		}
	}
}
