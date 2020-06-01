using System;

using RogueLike.Model;

namespace RogueLike.Model.Environments
{
	[Serializable]
	public class Wall: Environment
	{
		public Wall()
		{
			Id = 1;
			Name = "Wall";
		}
	}
}
