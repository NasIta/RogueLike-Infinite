﻿using System;
using System.Linq;
using System.Drawing;
using System.Collections.Generic;

using RogueLike.Model.Interfaces;
using RogueLike.Controllers;

namespace RogueLike.Model
{
	[Serializable]
	public class Scene: IPosed
	{
		public List<GameObject> Childrens {get; set;}
		public Point Position {get; set;}
		
		public Point Size {get; set;}
		
		public double GetDifficulty()
		{
			throw new NotImplementedException("Difficulty non implemented!");
		}
		
		public static Scene GetScene(int X, int Y)
		{
			return Game.instance.Scenes.FirstOrDefault(s => s.Position == new Point(X, Y));
		}
		
		public static void LoadOrCreate(int X, int Y)
		{
			var scene = GetScene(X, Y);
			
			if (scene != null)
			{
				Game.instance.ActiveScene = scene;
			}
			else
			{
				Game.instance.ActiveScene = Game.instance.Scenes.CreateRectangleScene(X, Y);
			}
			
			Player.instance = (Player)Game.instance.ActiveScene.Childrens.FirstOrDefault(u => u is Player);
		}
		
		public static void LoadOrCreateAt(int dx, int dy)
		{
			LoadOrCreate(Game.instance.ActiveScene.Position.X + dx, Game.instance.ActiveScene.Position.Y + dy);
		}
	}
}