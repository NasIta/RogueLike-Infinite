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
		
		public static Scene CreateRectangleScene(this List<Scene> scenes, int X, int Y)
		{
			var scene = new Scene(){Childrens = new List<IUnique>(), Position = new Point(X, Y)};
			
			scene.AddWalls();
			scene.AddDoors();
			
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
				}
			}
		}
		
		private static void WallToDoor(Scene scene, Point place)
		{
			int index = scene.Childrens.IndexOf((IUnique)scene.Childrens.Select(u => (GameObject)u).First(o => o.Position == place));
			scene.Childrens[index] = new Door(){Position = (scene.Childrens[index] as GameObject).Position};
		}
		
		private static void AddDoors(this Scene scene)
		{
			var place = new Point(_rnd.Next(1, scene.Size.X + 1), 0);
			WallToDoor(scene, place);
			place = new Point(0, _rnd.Next(1, scene.Size.Y + 1));
			WallToDoor(scene, place);
			place = new Point(scene.Size.X + 1, _rnd.Next(1, scene.Size.Y + 1));
			WallToDoor(scene, place);
			place = new Point(_rnd.Next(1, scene.Size.X + 1), scene.Size.Y + 1);
			WallToDoor(scene, place);
		}
	}
}
