﻿using System;
using System.Linq;
using System.Drawing;
using System.Collections.Generic;

using RogueLike.View;
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
		
		public static double Distance(this Point p1, Point p2)
		{
			return Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
		}
		
		public static int Normalize(this int x)
		{
			return x < 0 ? 0 : x;
		}
		
		public static int Normalize(this int x, int max)
		{
			x = x.Normalize();
			
			return x > max ? max : x;
		}
		
		public static Rectangle GetRectangle(this IPosed obj)
		{
			return new Rectangle()
			{
				X = obj.Position.X * RenderExtentions.modifier,
				Y = obj.Position.Y * RenderExtentions.modifier,
				Width = RenderExtentions.modifier,
				Height = RenderExtentions.modifier
			};
		}
	}
}
