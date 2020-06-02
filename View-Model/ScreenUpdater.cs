using System;

using RogueLike.Model;
using RogueLike.Model.Interfaces;

namespace RogueLike
{
	public delegate void GameObjectDelegate(GameObject gameObject);
	
	public static class ScreenUpdater
	{
		public static GameObjectDelegate OnSelected
		{
			get
			{
				return gameObject => 
				{
					MainForm.instance.DialogLabel.Text = (gameObject as IUsable).DescriptionOfUsing;
					MainForm.instance.DialogPanel.Visible = true;
				};
			}
		}
		
		public static Action OnUnselected
		{
			get
			{
				return () =>
				{
					MainForm.instance.DialogPanel.Visible = false;
				};
			}
		}
		
		public static Action OnHealthChanged
		{
			get
			{
				return () =>
				{
					MainForm.instance.HealhPointsLabel.Text = "HP - " + Player.instance.HealthPoints.Normalize() + " / " + Player.instance.MaxHealthPoints;
				};
			}
		}
		
		public static Action OnManaChanged
		{
			get
			{
				return () =>
				{
					MainForm.instance.ManaPointsLabel.Text = "MP - " + Player.instance.ManaPoints.Normalize() + " / " + Player.instance.MaxManaPoints;
				};
			}
		}
		
		public static Action OnHungerChanged
		{
			get
			{
				return () =>
				{
					MainForm.instance.HungerLabel.Text = "Сытость - " + Player.instance.Hunger.Normalize() + " / " + Player.instance.MaxHunger;
				};
			}
		}
		
		public static Action OnSpeedChanged
		{
			get
			{
				return () =>
				{
					MainForm.instance.SpeedLabel.Text = "Скорость - " + Player.instance.Speed.ToString("##.#");
				};
			}
		}
		
		public static Action OnStrengthChanged
		{
			get
			{
				return () =>
				{
					MainForm.instance.StrengthLabel.Text = "Сила - " + Player.instance.Strength.Normalize();
				};
			}
		}
		
		public static Action OnLevelExpChanged
		{
			get
			{
				return () =>
				{
					MainForm.instance.LevelLabel.Text = "LVL - " + Player.instance.Level + " / " + Player.instance.MaxLevel;
					MainForm.instance.ExperienceLabel.Text = "EXP - " + Player.instance.Expierence + " / " + Player.GetMaxExp();
				};
			}
		}
		
		public static Action OnInventoryChanged
		{
			get
			{
				return () =>
				{
					MainForm.instance.InventoryLabel.Text = "Инвентарь - " + Player.instance.Inventory.Count + " / " + Player.instance.MaxInventoryCount + "  -  [E]";
				};
			}
		}
		
		public static void UpdateAllStats()
		{
			OnHealthChanged();
			OnManaChanged();
			OnHungerChanged();
			OnSpeedChanged();
			OnStrengthChanged();
			OnLevelExpChanged();
			OnInventoryChanged();
		}
	}
}
