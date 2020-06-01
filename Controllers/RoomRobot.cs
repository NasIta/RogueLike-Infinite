using System;
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
		
		public static Scene CreateRectangleScene(this List<Scene> scenes)
		{
			var scene = new Scene(){Childrens = new List<IUnique>()};
			
			scene.AddWalls();
			
			scenes.Add(scene);
			
			return scene;
		}
		
		private static void AddWalls(this Scene scene)
		{
			scene.Size = new Point(_rnd.Next(3, 9), _rnd.Next(2, 6));
			
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
	}
}
