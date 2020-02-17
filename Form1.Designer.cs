namespace pokemon
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnLegendary = new System.Windows.Forms.Button();
            this.lstpokemon = new System.Windows.Forms.ListView();
            this.DexNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PokeName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Attack = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Defense = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SpAtk = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SpDef = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Spd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Generation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Legendary = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnName = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnGen = new System.Windows.Forms.Button();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnGalar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLegendary
            // 
            this.btnLegendary.Location = new System.Drawing.Point(82, 1073);
            this.btnLegendary.Margin = new System.Windows.Forms.Padding(6);
            this.btnLegendary.Name = "btnLegendary";
            this.btnLegendary.Size = new System.Drawing.Size(232, 103);
            this.btnLegendary.TabIndex = 1;
            this.btnLegendary.Text = "Legenday";
            this.btnLegendary.UseVisualStyleBackColor = true;
            this.btnLegendary.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lstpokemon
            // 
            this.lstpokemon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DexNumber,
            this.PokeName,
            this.Type1,
            this.Type2,
            this.Total,
            this.HP,
            this.Attack,
            this.Defense,
            this.SpAtk,
            this.SpDef,
            this.Spd,
            this.Generation,
            this.Legendary});
            this.lstpokemon.HideSelection = false;
            this.lstpokemon.Location = new System.Drawing.Point(82, 23);
            this.lstpokemon.Margin = new System.Windows.Forms.Padding(6);
            this.lstpokemon.Name = "lstpokemon";
            this.lstpokemon.Size = new System.Drawing.Size(2220, 955);
            this.lstpokemon.TabIndex = 6;
            this.lstpokemon.UseCompatibleStateImageBehavior = false;
            this.lstpokemon.SelectedIndexChanged += new System.EventHandler(this.lstpokemon_SelectedIndexChanged);
            // 
            // DexNumber
            // 
            this.DexNumber.Text = "#";
            // 
            // PokeName
            // 
            this.PokeName.Text = "Name";
            this.PokeName.Width = 90;
            // 
            // Type1
            // 
            this.Type1.Text = "Type 1";
            // 
            // Type2
            // 
            this.Type2.Text = "Type 2";
            // 
            // Total
            // 
            this.Total.Text = "Total";
            // 
            // HP
            // 
            this.HP.Text = "HP";
            // 
            // Attack
            // 
            this.Attack.Text = "ATK";
            // 
            // Defense
            // 
            this.Defense.Text = "DEF";
            // 
            // SpAtk
            // 
            this.SpAtk.Text = "SpAtk";
            // 
            // SpDef
            // 
            this.SpDef.Text = "SpDef";
            // 
            // Spd
            // 
            this.Spd.Text = "Spd";
            // 
            // Generation
            // 
            this.Generation.Text = "Generation";
            // 
            // Legendary
            // 
            this.Legendary.Text = "Legendary";
            // 
            // btnName
            // 
            this.btnName.Location = new System.Drawing.Point(422, 1073);
            this.btnName.Margin = new System.Windows.Forms.Padding(6);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(220, 103);
            this.btnName.TabIndex = 7;
            this.btnName.Text = "Name";
            this.btnName.UseVisualStyleBackColor = true;
            this.btnName.Click += new System.EventHandler(this.btnName_Click);
            // 
            // btnAll
            // 
            this.btnAll.Enabled = false;
            this.btnAll.Location = new System.Drawing.Point(770, 1073);
            this.btnAll.Margin = new System.Windows.Forms.Padding(6);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(216, 103);
            this.btnAll.TabIndex = 8;
            this.btnAll.Text = "All";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnGen
            // 
            this.btnGen.Location = new System.Drawing.Point(1104, 1073);
            this.btnGen.Margin = new System.Windows.Forms.Padding(6);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(228, 103);
            this.btnGen.TabIndex = 9;
            this.btnGen.Text = "Generation";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Water",
            "Fire",
            "Grass",
            "Flying",
            "Normal",
            "Fighting",
            "Ice",
            "Psychic",
            "Ghost",
            "Dark",
            "Fairy",
            "Dragon",
            "Steel",
            "Ground",
            "Rock",
            "Electric",
            "Bug",
            "Poison"});
            this.cmbType.Location = new System.Drawing.Point(1382, 1102);
            this.cmbType.Margin = new System.Windows.Forms.Padding(6);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(238, 39);
            this.cmbType.TabIndex = 11;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // btnEnter
            // 
            this.btnEnter.Enabled = false;
            this.btnEnter.Location = new System.Drawing.Point(2000, 1072);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(215, 96);
            this.btnEnter.TabIndex = 12;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1713, 1069);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(203, 102);
            this.button2.TabIndex = 13;
            this.button2.Text = "specific stat value";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnGalar
            // 
            this.btnGalar.Location = new System.Drawing.Point(2299, 1072);
            this.btnGalar.Name = "btnGalar";
            this.btnGalar.Size = new System.Drawing.Size(214, 96);
            this.btnGalar.TabIndex = 14;
            this.btnGalar.Text = "Galar";
            this.btnGalar.UseVisualStyleBackColor = true;
            this.btnGalar.Click += new System.EventHandler(this.btnGalar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2659, 1345);
            this.Controls.Add(this.btnGalar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnName);
            this.Controls.Add(this.lstpokemon);
            this.Controls.Add(this.btnLegendary);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

		}

		#endregion
        private System.Windows.Forms.Button btnLegendary;
        private System.Windows.Forms.ListView lstpokemon;
        private System.Windows.Forms.ColumnHeader DexNumber;
        private System.Windows.Forms.ColumnHeader PokeName;
        private System.Windows.Forms.ColumnHeader Type1;
        private System.Windows.Forms.ColumnHeader Type2;
        private System.Windows.Forms.ColumnHeader Total;
        private System.Windows.Forms.ColumnHeader HP;
        private System.Windows.Forms.ColumnHeader Attack;
        private System.Windows.Forms.ColumnHeader Defense;
        private System.Windows.Forms.ColumnHeader SpAtk;
        private System.Windows.Forms.ColumnHeader SpDef;
        private System.Windows.Forms.ColumnHeader Spd;
        private System.Windows.Forms.ColumnHeader Generation;
        private System.Windows.Forms.ColumnHeader Legendary;
        private System.Windows.Forms.Button btnName;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnGalar;
    }
}

