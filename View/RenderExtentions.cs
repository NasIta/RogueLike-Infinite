using System;
using System.ComponentModel;
using System.Drawing;

using RogueLike.Model;
using RogueLike.Model.Interfaces;
using RogueLike.Model.Environments;

namespace RogueLike.View
{
	public static class RenderExtentions
	{
		const int modifier = 20;
		
		private static Bitmap _bmp {get; set;}
		private static Graphics _graph {get; set;}
		
		public static void Render(this Scene scene)
		{	
			if (_bmp == null || _bmp.Size != MainForm.instance.pictureBox.Size) 
			{
				_bmp = new Bitmap(scene.Size.X * modifier + modifier * 2, scene.Size.Y * modifier + modifier * 2);
				_graph = Graphics.FromImage(_bmp);
			}
			
			_graph.Clear(Color.Black);
			
			foreach (var gameObject in scene.Childrens) 
			{
				(gameObject as GameObject).Render();
			}
			
			MainForm.instance.pictureBox.Image = _bmp;
		}
		
		private static void Render(this GameObject gameObject)
		{		
			if (gameObject as IRenderizable != null)
			{
				var rect = new Rectangle()
				{
					X = gameObject.Position.X * modifier,
					Y = gameObject.Position.Y * modifier,
					Width = modifier,
					Height = modifier
				};
				
				if (gameObject is Wall) 
				{	
					_graph.FillRectangle(new SolidBrush(Color.Firebrick), rect);
				}
				
				if (gameObject is Player) 
				{
					_graph.FillEllipse(new SolidBrush(Color.White), rect);
				}
			}
		}
	}
}
