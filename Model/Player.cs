using System;
using System.Collections.Generic;

using RogueLike.Model.Interfaces;

namespace RogueLike.Model
{
	[Serializable]
	public class Player: Mob, IContainer
	{
		public List<IUnique> Childrens {get; set;}
	}
}
