using System;

using RogueLike.Model;
using RogueLike.Model.Interfaces;

namespace RogueLike.Model.Environments
{
	[Serializable]
	public class Chest: Environment, ISolid, IUsable
	{
		public Item Loot {get; set;}
		public string DescriptionOfUsing {get; set;}
		public bool Used {get; set;}
		
		public Chest()
		{
			Id = 3;
			Name = "Chest";
			
			DescriptionOfUsing = "Открыть - [Q]";
		}
		
		public void Use()
		{
			
		}
	}
}