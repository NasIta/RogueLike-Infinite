using System;

namespace RogueLike.Model.Interfaces
{
	public interface IDestructible
	{
		int HealthPoints {get; set;}
		int MaxHealthPoints {get; set;}
	}
}
