using System;

using RogueLike.Model.Interfaces;

namespace RogueLike.Model
{
	public class Mob: GameObject, IDestructible, ISolid
	{
		public int HealthPoints {get; set;}
		public int MaxHealthPoints {get; set;}
		
		public double Speed {get; set;}
		public int Strength {get; set;}
	}
}
