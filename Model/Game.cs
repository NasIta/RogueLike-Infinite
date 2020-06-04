using System;
using System.Collections.Generic;

namespace RogueLike.Model
{
	[Serializable]
	public class Game
	{
		public static Game instance {get; private set;}
		
		public List<Scene> Scenes {get; set;}
		public Scene ActiveScene {get; set;}
		
		public static void StartNew()
		{
			instance = new Game();
		}
		
		private Game()
		{
			Scenes = new List<Scene>();
		}
	}
	
	public enum GameStates
	{
		Play,
		Inventory
	}
}
