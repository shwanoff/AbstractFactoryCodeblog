namespace AbstractFactoryCodeblog
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			this.baseCarStartButton = new System.Windows.Forms.Button();
			this.factoryCarButton = new System.Windows.Forms.Button();
			this.carRadioButton = new System.Windows.Forms.RadioButton();
			this.truckRadioButton = new System.Windows.Forms.RadioButton();
			this.speedTrackBar = new System.Windows.Forms.TrackBar();
			this.speedLabel = new System.Windows.Forms.Label();
			this.pathLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.speedTrackBar)).BeginInit();
			this.SuspendLayout();
			// 
			// baseCarStartButton
			// 
			this.baseCarStartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.baseCarStartButton.Location = new System.Drawing.Point(13, 195);
			this.baseCarStartButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.baseCarStartButton.Name = "baseCarStartButton";
			this.baseCarStartButton.Size = new System.Drawing.Size(112, 35);
			this.baseCarStartButton.TabIndex = 0;
			this.baseCarStartButton.Text = "Базовый";
			this.baseCarStartButton.UseVisualStyleBackColor = true;
			this.baseCarStartButton.Click += new System.EventHandler(this.BaseCarStartButtonClick);
			// 
			// factoryCarButton
			// 
			this.factoryCarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.factoryCarButton.Location = new System.Drawing.Point(1054, 195);
			this.factoryCarButton.Name = "factoryCarButton";
			this.factoryCarButton.Size = new System.Drawing.Size(112, 35);
			this.factoryCarButton.TabIndex = 1;
			this.factoryCarButton.Text = "Фабричный";
			this.factoryCarButton.UseVisualStyleBackColor = true;
			this.factoryCarButton.Click += new System.EventHandler(this.FactoryCarButtonClick);
			// 
			// carRadioButton
			// 
			this.carRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.carRadioButton.AutoSize = true;
			this.carRadioButton.Location = new System.Drawing.Point(1103, 134);
			this.carRadioButton.Name = "carRadioButton";
			this.carRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.carRadioButton.Size = new System.Drawing.Size(63, 24);
			this.carRadioButton.TabIndex = 2;
			this.carRadioButton.Text = "Ока";
			this.carRadioButton.UseVisualStyleBackColor = true;
			this.carRadioButton.CheckedChanged += new System.EventHandler(this.CarRadioButtonCheckedChanged);
			// 
			// truckRadioButton
			// 
			this.truckRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.truckRadioButton.AutoSize = true;
			this.truckRadioButton.Location = new System.Drawing.Point(1085, 164);
			this.truckRadioButton.Name = "truckRadioButton";
			this.truckRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.truckRadioButton.Size = new System.Drawing.Size(81, 24);
			this.truckRadioButton.TabIndex = 3;
			this.truckRadioButton.Text = "Камаз";
			this.truckRadioButton.UseVisualStyleBackColor = true;
			this.truckRadioButton.CheckedChanged += new System.EventHandler(this.TruckRadioButtonCheckedChanged);
			// 
			// speedTrackBar
			// 
			this.speedTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.speedTrackBar.LargeChange = 10;
			this.speedTrackBar.Location = new System.Drawing.Point(150, 161);
			this.speedTrackBar.Maximum = 120;
			this.speedTrackBar.Minimum = 1;
			this.speedTrackBar.Name = "speedTrackBar";
			this.speedTrackBar.Size = new System.Drawing.Size(870, 69);
			this.speedTrackBar.TabIndex = 4;
			this.speedTrackBar.Value = 50;
			this.speedTrackBar.Scroll += new System.EventHandler(this.SpeedTrackBarScroll);
			// 
			// speedLabel
			// 
			this.speedLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.speedLabel.AutoSize = true;
			this.speedLabel.Location = new System.Drawing.Point(546, 202);
			this.speedLabel.Name = "speedLabel";
			this.speedLabel.Size = new System.Drawing.Size(0, 20);
			this.speedLabel.TabIndex = 5;
			// 
			// pathLabel
			// 
			this.pathLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pathLabel.AutoSize = true;
			this.pathLabel.Location = new System.Drawing.Point(12, 117);
			this.pathLabel.Name = "pathLabel";
			this.pathLabel.Size = new System.Drawing.Size(90, 20);
			this.pathLabel.TabIndex = 6;
			this.pathLabel.Text = "Пройдено:";
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1178, 244);
			this.Controls.Add(this.pathLabel);
			this.Controls.Add(this.speedLabel);
			this.Controls.Add(this.speedTrackBar);
			this.Controls.Add(this.truckRadioButton);
			this.Controls.Add(this.carRadioButton);
			this.Controls.Add(this.factoryCarButton);
			this.Controls.Add(this.baseCarStartButton);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MinimumSize = new System.Drawing.Size(500, 300);
			this.Name = "Main";
			this.Text = "Моделирование автомобилей";
			((System.ComponentModel.ISupportInitialize)(this.speedTrackBar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button baseCarStartButton;
		private System.Windows.Forms.Button factoryCarButton;
		private System.Windows.Forms.RadioButton carRadioButton;
		private System.Windows.Forms.RadioButton truckRadioButton;
		private System.Windows.Forms.TrackBar speedTrackBar;
		private System.Windows.Forms.Label speedLabel;
		private System.Windows.Forms.Label pathLabel;
	}
}

