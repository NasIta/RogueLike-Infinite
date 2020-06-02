using System;
using System.Linq;
using System.Drawing;

using RogueLike.Model;
using RogueLike.Model.Interfaces;

namespace RogueLike
{
	public static class Extentions
	{
		public static Point Add(this Point point, int X, int Y)
		{
			return new Point(point.X + X, point.Y + Y);
		}
		
		public static GameObject LookAt(this Point point, int X, int Y)
		{
			return Game.instance.ActiveScene.Childrens
				.Select(u => u as GameObject)
				.FirstOrDefault(p => p.Position.X == point.X + X && p.Position.Y == point.Y + Y);
		}
	}
}
