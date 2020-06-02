using System;

namespace RogueLike.Model.Interfaces
{
	public interface IUsable
	{
		bool Used {get; set;}
		string DescriptionOfUsing {get; set;}
		void Use();
	}
}
