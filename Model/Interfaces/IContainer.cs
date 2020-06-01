using System;
using System.Collections.Generic;

namespace RogueLike.Model.Interfaces
{
	public interface IContainer
	{
		List<IUnique> Childrens {get; set;}
	}
}
