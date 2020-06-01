using System;

using RogueLike.Model;

namespace RogueLike.Model.Environments
{
	[Serializable]
	public class Door: Environment
	{
		public Door()
		{
			Id = 2;
			Name = "Door";
		}
	}
}
