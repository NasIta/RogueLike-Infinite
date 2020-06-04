using System;
using System.Drawing;
using System.Windows.Forms;

using RogueLike.Model.Interfaces;

namespace RogueLike.Model
{
	[Serializable] 
	public class Item: IUnique, IUsable
	{
		public int Id {get; set;}
		public string Name {get; set;}

		public bool Used {get; set;}
		public string DescriptionOfUsing {get; set;}

		public virtual Image Image {get; set;}
		public virtual void Use(){}
	}
}
