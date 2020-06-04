using System;
using System.Drawing;

using RogueLike.Model;

namespace RogueLike.Model.Items
{
	public class Food: Item
	{
		public int HungerRecovery {get; set;}
		
		public override Image Image 
		{
			get
			{
				return Image.FromFile(@"Cake.jpg");
			}
		}
		
		public override void Use()
		{
			Player.instance.Hunger = (Player.instance.Hunger + HungerRecovery).Normalize(Player.instance.MaxHunger);
			Player.instance.Inventory.Remove(this);
			
			ScreenUpdater.OnHungerChanged();
			ScreenUpdater.OnInventoryChanged();
		}
	}
}
