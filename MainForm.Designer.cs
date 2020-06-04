/*
 * Created by SharpDevelop.
 * User: NasIta
 * Date: 01.06.2020
 * Time: 20:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace RogueLike
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel headerPanel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		public System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.Button button2;
		public System.Windows.Forms.Panel DialogPanel;
		public System.Windows.Forms.Label DialogLabel;
		public System.Windows.Forms.Panel StatsPanel;
		public System.Windows.Forms.Label HealhPointsLabel;
		public System.Windows.Forms.Label ManaPointsLabel;
		public System.Windows.Forms.Label HungerLabel;
		public System.Windows.Forms.Label ExperienceLabel;
		public System.Windows.Forms.Label LevelLabel;
		public System.Windows.Forms.Label StrengthLabel;
		public System.Windows.Forms.Label SpeedLabel;
		public System.Windows.Forms.Label InventoryLabel;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.headerPanel = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.button2 = new System.Windows.Forms.Button();
			this.DialogPanel = new System.Windows.Forms.Panel();
			this.DialogLabel = new System.Windows.Forms.Label();
			this.StatsPanel = new System.Windows.Forms.Panel();
			this.InventoryLabel = new System.Windows.Forms.Label();
			this.ExperienceLabel = new System.Windows.Forms.Label();
			this.LevelLabel = new System.Windows.Forms.Label();
			this.StrengthLabel = new System.Windows.Forms.Label();
			this.SpeedLabel = new System.Windows.Forms.Label();
			this.HungerLabel = new System.Windows.Forms.Label();
			this.ManaPointsLabel = new System.Windows.Forms.Label();
			this.HealhPointsLabel = new System.Windows.Forms.Label();
			this.headerPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.DialogPanel.SuspendLayout();
			this.StatsPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// headerPanel
			// 
			this.headerPanel.BackColor = System.Drawing.Color.Black;
			this.headerPanel.Controls.Add(this.label1);
			this.headerPanel.Controls.Add(this.button1);
			this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.headerPanel.Location = new System.Drawing.Point(0, 0);
			this.headerPanel.Margin = new System.Windows.Forms.Padding(0);
			this.headerPanel.Name = "headerPanel";
			this.headerPanel.Size = new System.Drawing.Size(818, 22);
			this.headerPanel.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.Color.Silver;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(150, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Roguelike";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(794, 0);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(24, 22);
			this.button1.TabIndex = 0;
			this.button1.Text = "X";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// pictureBox
			// 
			this.pictureBox.BackColor = System.Drawing.Color.Black;
			this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox.Location = new System.Drawing.Point(0, 22);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(818, 462);
			this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox.TabIndex = 2;
			this.pictureBox.TabStop = false;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Red;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Location = new System.Drawing.Point(357, 231);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(121, 39);
			this.button2.TabIndex = 3;
			this.button2.Text = "START";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// DialogPanel
			// 
			this.DialogPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.DialogPanel.BackColor = System.Drawing.Color.Black;
			this.DialogPanel.Controls.Add(this.DialogLabel);
			this.DialogPanel.Location = new System.Drawing.Point(261, 402);
			this.DialogPanel.Name = "DialogPanel";
			this.DialogPanel.Size = new System.Drawing.Size(317, 70);
			this.DialogPanel.TabIndex = 4;
			this.DialogPanel.Visible = false;
			// 
			// DialogLabel
			// 
			this.DialogLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.DialogLabel.Font = new System.Drawing.Font("Garamond", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.DialogLabel.ForeColor = System.Drawing.Color.Yellow;
			this.DialogLabel.Location = new System.Drawing.Point(3, 0);
			this.DialogLabel.Name = "DialogLabel";
			this.DialogLabel.Size = new System.Drawing.Size(311, 70);
			this.DialogLabel.TabIndex = 0;
			this.DialogLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// StatsPanel
			// 
			this.StatsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left)));
			this.StatsPanel.BackColor = System.Drawing.Color.Black;
			this.StatsPanel.Controls.Add(this.InventoryLabel);
			this.StatsPanel.Controls.Add(this.ExperienceLabel);
			this.StatsPanel.Controls.Add(this.LevelLabel);
			this.StatsPanel.Controls.Add(this.StrengthLabel);
			this.StatsPanel.Controls.Add(this.SpeedLabel);
			this.StatsPanel.Controls.Add(this.HungerLabel);
			this.StatsPanel.Controls.Add(this.ManaPointsLabel);
			this.StatsPanel.Controls.Add(this.HealhPointsLabel);
			this.StatsPanel.Location = new System.Drawing.Point(3, 27);
			this.StatsPanel.Name = "StatsPanel";
			this.StatsPanel.Size = new System.Drawing.Size(199, 445);
			this.StatsPanel.TabIndex = 5;
			// 
			// InventoryLabel
			// 
			this.InventoryLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.InventoryLabel.ForeColor = System.Drawing.Color.Yellow;
			this.InventoryLabel.Location = new System.Drawing.Point(3, 316);
			this.InventoryLabel.Name = "InventoryLabel";
			this.InventoryLabel.Size = new System.Drawing.Size(193, 28);
			this.InventoryLabel.TabIndex = 0;
			this.InventoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// ExperienceLabel
			// 
			this.ExperienceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ExperienceLabel.ForeColor = System.Drawing.Color.Yellow;
			this.ExperienceLabel.Location = new System.Drawing.Point(3, 254);
			this.ExperienceLabel.Name = "ExperienceLabel";
			this.ExperienceLabel.Size = new System.Drawing.Size(193, 28);
			this.ExperienceLabel.TabIndex = 0;
			this.ExperienceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// LevelLabel
			// 
			this.LevelLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.LevelLabel.ForeColor = System.Drawing.Color.Yellow;
			this.LevelLabel.Location = new System.Drawing.Point(3, 226);
			this.LevelLabel.Name = "LevelLabel";
			this.LevelLabel.Size = new System.Drawing.Size(193, 28);
			this.LevelLabel.TabIndex = 0;
			this.LevelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// StrengthLabel
			// 
			this.StrengthLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.StrengthLabel.ForeColor = System.Drawing.Color.Yellow;
			this.StrengthLabel.Location = new System.Drawing.Point(3, 169);
			this.StrengthLabel.Name = "StrengthLabel";
			this.StrengthLabel.Size = new System.Drawing.Size(193, 28);
			this.StrengthLabel.TabIndex = 0;
			this.StrengthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// SpeedLabel
			// 
			this.SpeedLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.SpeedLabel.ForeColor = System.Drawing.Color.Yellow;
			this.SpeedLabel.Location = new System.Drawing.Point(3, 141);
			this.SpeedLabel.Name = "SpeedLabel";
			this.SpeedLabel.Size = new System.Drawing.Size(193, 28);
			this.SpeedLabel.TabIndex = 0;
			this.SpeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// HungerLabel
			// 
			this.HungerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.HungerLabel.ForeColor = System.Drawing.Color.Yellow;
			this.HungerLabel.Location = new System.Drawing.Point(3, 84);
			this.HungerLabel.Name = "HungerLabel";
			this.HungerLabel.Size = new System.Drawing.Size(193, 28);
			this.HungerLabel.TabIndex = 0;
			this.HungerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// ManaPointsLabel
			// 
			this.ManaPointsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ManaPointsLabel.ForeColor = System.Drawing.Color.Yellow;
			this.ManaPointsLabel.Location = new System.Drawing.Point(3, 32);
			this.ManaPointsLabel.Name = "ManaPointsLabel";
			this.ManaPointsLabel.Size = new System.Drawing.Size(193, 28);
			this.ManaPointsLabel.TabIndex = 0;
			this.ManaPointsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// HealhPointsLabel
			// 
			this.HealhPointsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.HealhPointsLabel.ForeColor = System.Drawing.Color.Yellow;
			this.HealhPointsLabel.Location = new System.Drawing.Point(3, 4);
			this.HealhPointsLabel.Name = "HealhPointsLabel";
			this.HealhPointsLabel.Size = new System.Drawing.Size(193, 28);
			this.HealhPointsLabel.TabIndex = 0;
			this.HealhPointsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(818, 484);
			this.Controls.Add(this.StatsPanel);
			this.Controls.Add(this.DialogPanel);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.pictureBox);
			this.Controls.Add(this.headerPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.KeyPreview = true;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "RogueLike";
			this.headerPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.DialogPanel.ResumeLayout(false);
			this.StatsPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
