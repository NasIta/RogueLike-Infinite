using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

using RogueLike.Model.Interfaces;
using RogueLike.Model.Environments;

namespace RogueLike.Model
{
	[Serializable]
	public class Player: Mob, IContainer
	{
		public static Player instance {get; set;}
		public List<IUnique> Childrens {get; set;}
		
		public GameObject SelectedObject {get; set;}
		
		public static void Move(int dx, int dy)
		{
			var frontObject = instance.Position.LookAt(dx, dy);
			
			if (frontObject is Door) 
			{
				Door.SelectedDoor = (frontObject as Door).Direction;
				Scene.LoadOrCreateAt(dx, -dy);
				
				SetToDoor();
			}
			
			if (!(frontObject is ISolid))
			{
				Player.instance.Position = Player.instance.Position.Add(dx, dy);
				
				CheckSelectableItems();
			}
		}
		
		public static void SetToDoor()
		{
			var spawnPlace = ((IPosed)Game.instance.ActiveScene.Childrens
				.Where(u => u is Door)
				.First(u => (u as Door).Direction == (Door.SelectedDoor + 2) % 4)).Position;
			instance.Position = spawnPlace;
		}

		private static void CheckSelectableItems()
		{
			instance.SelectedObject = (GameObject)Game.instance.ActiveScene.Childrens
				.FirstOrDefault(
					u => 
						(u as GameObject).Position.Distance(instance.Position) < 1.5 
						&& u is IUsable 
						&& !(u as IUsable).Used
				);
		}
	}
}
