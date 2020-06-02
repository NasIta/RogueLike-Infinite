using System;
using System.Linq;
using System.Collections.Generic;
using System.Drawing;

using RogueLike.Model;
using RogueLike.Model.Interfaces;
using RogueLike.Model.Environments;

namespace RogueLike.Controllers
{
	public static class RoomRobot
	{
		private static Random _rnd = new Random();
		private static int _doorId {get; set;}
		
		public static Scene CreateRectangleScene(this List<Scene> scenes, int X, int Y)
		{
			var scene = new Scene(){Childrens = new List<GameObject>(), Position = new Point(X, Y)};
			
			scene.AddWalls();
			scene.AddDoors();
			scene.AddPlayer();
			
			scenes.Add(scene);
			
			return scene;
		}
		
		private static void AddWalls(this Scene scene)
		{
			scene.Size = new Point(_rnd.Next(5, 12), _rnd.Next(4, 9));
			
			for (int y = 0; y <= scene.Size.Y + 1; y++) 
			{
				for (int x = 0; x <= scene.Size.X + 1; x++) 
				{
					if (x == scene.Size.X + 1 || x == 0 || y == scene.Size.Y + 1 || y == 0) 
					{
						scene.Childrens.Add(new Wall(){Position = new Point(x, y)});
					}
					else
					{
						if (scene.Position == new Point(0, 0))
						{
							continue;
						}
						
						var content = GetRandomContent();
						
						if (content != null) 
						{
							content.Position = new Point(x, y);
							scene.Childrens.Add(content);
						}
					}
				}
			}
		}
		
		private static void WallToDoor(Scene scene, Point place)
		{
			int index = scene.Childrens.IndexOf(scene.Childrens.Select(u => (GameObject)u).First(o => o.Position == place));
			scene.Childrens.RemoveAt(index);
		}
		
		private static void AddDoors(this Scene scene)
		{
			var place = new Point(scene.Size.X + 1, _rnd.Next(1, scene.Size.Y + 1));
			WallToDoor(scene, place);
			scene.Childrens.Add(new Door(){Position = place.Add(1, 0), Direction = 0});
			place = new Point(_rnd.Next(1, scene.Size.X + 1), scene.Size.Y + 1);
			WallToDoor(scene, place);
			scene.Childrens.Add(new Door(){Position = place.Add(0, 1), Direction = 1});
			place = new Point(0, _rnd.Next(1, scene.Size.Y + 1));
			WallToDoor(scene, place);
			scene.Childrens.Add(new Door(){Position = place.Add(-1, 0), Direction = 2});
			place = new Point(_rnd.Next(1, scene.Size.X + 1), 0);
			WallToDoor(scene, place);
			scene.Childrens.Add(new Door(){Position = place.Add(0, -1), Direction = 3});
		}
		
		private static void AddPlayer(this Scene scene)
		{
			if (Door.SelectedDoor == -1) 
			{
				Player.instance = new Player(){Position = new Point(scene.Size.X / 2 + 1, scene.Size.Y / 2 + 1)};
				
				scene.Childrens.Add(Player.instance);
				
				ScreenUpdater.UpdateAllStats();
			}
			else
			{
				if (!scene.Childrens.Contains(Player.instance))
				{
					scene.Childrens.Add(Player.instance);
				}
				
				Player.SetToDoor();
			}
		}
		
		
		private static GameObject GetRandomContent()
		{
			if (_rnd.NextDouble() < 0.01)
			{
				return new Chest();
			}
			return null;
		}
	}
}
