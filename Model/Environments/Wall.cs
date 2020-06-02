using System;

using RogueLike.Model;
using RogueLike.Model.Interfaces;

namespace RogueLike.Model.Environments
{
	[Serializable]
	public class Wall: Environment, ISolid
	{
		public Wall()
		{
			Id = 1;
			Name = "Wall";
		}
	}
}
