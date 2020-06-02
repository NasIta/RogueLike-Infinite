using System;

using RogueLike.Model;
using RogueLike.Model.Interfaces;

namespace RogueLike.Model.Environments
{
	[Serializable]
	public class Door: Environment
	{
		public static int SelectedDoor {get; set;}
		public int Direction {get; set;}
		
		static Door()
		{
			SelectedDoor = -1;
		}
		
		public Door()
		{
			Id = 2;
			Name = "Door";
		}
	}
}
