namespace NanoComposite
{
	partial class CreateMaterial_Form
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && ( components != null ) )
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.TabControl_AddMaterials = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.MainGroupBox = new System.Windows.Forms.GroupBox();
			this.btn_Delete = new System.Windows.Forms.Button();
			this.btn_Add = new System.Windows.Forms.Button();
			this.lb_Capacity = new System.Windows.Forms.Label();
			this.lb_alfa = new System.Windows.Forms.Label();
			this.lb_lambda = new System.Windows.Forms.Label();
			this.lb_Cp = new System.Windows.Forms.Label();
			this.lb_p = new System.Windows.Forms.Label();
			this.lb_sigma = new System.Windows.Forms.Label();
			this.lb_E = new System.Windows.Forms.Label();
			this.lb_Hb = new System.Windows.Forms.Label();
			this.NumUp_8_Capacity = new System.Windows.Forms.NumericUpDown();
			this.NumUp_7_ThermalExpansion = new System.Windows.Forms.NumericUpDown();
			this.NumUp_6_Transcalency = new System.Windows.Forms.NumericUpDown();
			this.NumUp_5_HeatCapacity = new System.Windows.Forms.NumericUpDown();
			this.NumUp_4_Density = new System.Windows.Forms.NumericUpDown();
			this.NumUp_3_StrengthBeyond = new System.Windows.Forms.NumericUpDown();
			this.NumUp_2_Elasticity = new System.Windows.Forms.NumericUpDown();
			this.NumUp_1_Hardness = new System.Windows.Forms.NumericUpDown();
			this.rb_MassivePercent = new System.Windows.Forms.RadioButton();
			this.rb_VolumePercent = new System.Windows.Forms.RadioButton();
			this.GroupBoxName = new System.Windows.Forms.GroupBox();
			this.tb_NameMaterial = new System.Windows.Forms.TextBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.NumUp_Termal = new System.Windows.Forms.NumericUpDown();
			this.NumUp_Strength = new System.Windows.Forms.NumericUpDown();
			this.NumUp_Cogezy = new System.Windows.Forms.NumericUpDown();
			this.NumUp_Hardness = new System.Windows.Forms.NumericUpDown();
			this.NumUp_Elasticity = new System.Windows.Forms.NumericUpDown();
			this.NumUp_Porosity = new System.Windows.Forms.NumericUpDown();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.btn_Cancel = new System.Windows.Forms.Button();
			this.btn_Save = new System.Windows.Forms.Button();
			this.dgv_main = new System.Windows.Forms.DataGridView();
			this.Matrix = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.Material = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Volume = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Hardness = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Elaticity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DurabilityBeyond = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Density = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TermalCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Termal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TermalExpansionFactor = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TabControl_AddMaterials.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.MainGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.NumUp_8_Capacity)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NumUp_7_ThermalExpansion)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NumUp_6_Transcalency)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NumUp_5_HeatCapacity)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NumUp_4_Density)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NumUp_3_StrengthBeyond)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NumUp_2_Elasticity)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NumUp_1_Hardness)).BeginInit();
			this.GroupBoxName.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.NumUp_Termal)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NumUp_Strength)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NumUp_Cogezy)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NumUp_Hardness)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NumUp_Elasticity)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NumUp_Porosity)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_main)).BeginInit();
			this.SuspendLayout();
			// 
			// TabControl_AddMaterials
			// 
			this.TabControl_AddMaterials.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.TabControl_AddMaterials.Controls.Add(this.tabPage1);
			this.TabControl_AddMaterials.Controls.Add(this.tabPage2);
			this.TabControl_AddMaterials.Location = new System.Drawing.Point(12, 12);
			this.TabControl_AddMaterials.Name = "TabControl_AddMaterials";
			this.TabControl_AddMaterials.SelectedIndex = 0;
			this.TabControl_AddMaterials.Size = new System.Drawing.Size(400, 437);
			this.TabControl_AddMaterials.TabIndex = 15;
			this.TabControl_AddMaterials.SelectedIndexChanged += new System.EventHandler(this.TabControl_AddMaterials_SelectedIndexChanged);
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.MainGroupBox);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(392, 411);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Добавление Вещества";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// MainGroupBox
			// 
			this.MainGroupBox.Controls.Add(this.btn_Delete);
			this.MainGroupBox.Controls.Add(this.btn_Add);
			this.MainGroupBox.Controls.Add(this.lb_Capacity);
			this.MainGroupBox.Controls.Add(this.lb_alfa);
			this.MainGroupBox.Controls.Add(this.lb_lambda);
			this.MainGroupBox.Controls.Add(this.lb_Cp);
			this.MainGroupBox.Controls.Add(this.lb_p);
			this.MainGroupBox.Controls.Add(this.lb_sigma);
			this.MainGroupBox.Controls.Add(this.lb_E);
			this.MainGroupBox.Controls.Add(this.lb_Hb);
			this.MainGroupBox.Controls.Add(this.NumUp_8_Capacity);
			this.MainGroupBox.Controls.Add(this.NumUp_7_ThermalExpansion);
			this.MainGroupBox.Controls.Add(this.NumUp_6_Transcalency);
			this.MainGroupBox.Controls.Add(this.NumUp_5_HeatCapacity);
			this.MainGroupBox.Controls.Add(this.NumUp_4_Density);
			this.MainGroupBox.Controls.Add(this.NumUp_3_StrengthBeyond);
			this.MainGroupBox.Controls.Add(this.NumUp_2_Elasticity);
			this.MainGroupBox.Controls.Add(this.NumUp_1_Hardness);
			this.MainGroupBox.Controls.Add(this.rb_MassivePercent);
			this.MainGroupBox.Controls.Add(this.rb_VolumePercent);
			this.MainGroupBox.Controls.Add(this.GroupBoxName);
			this.MainGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MainGroupBox.Location = new System.Drawing.Point(3, 3);
			this.MainGroupBox.Name = "MainGroupBox";
			this.MainGroupBox.Size = new System.Drawing.Size(386, 405);
			this.MainGroupBox.TabIndex = 0;
			this.MainGroupBox.TabStop = false;
			this.MainGroupBox.Text = "Базовые Свойства";
			// 
			// btn_Delete
			// 
			this.btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
			this.btn_Delete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
			this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_Delete.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_Delete.Image = global::NanoComposite.Properties.Resources.delete_normal_32;
			this.btn_Delete.Location = new System.Drawing.Point(224, 357);
			this.btn_Delete.Name = "btn_Delete";
			this.btn_Delete.Size = new System.Drawing.Size(150, 45);
			this.btn_Delete.TabIndex = 11;
			this.btn_Delete.Tag = "Удалить";
			this.btn_Delete.Text = "Удалить";
			this.btn_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.toolTip1.SetToolTip(this.btn_Delete, "Удалить из таблицы выбранный элемент");
			this.btn_Delete.UseVisualStyleBackColor = false;
			this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
			this.btn_Delete.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_Delete.MouseHover += new System.EventHandler(this.btn_MouseHover);
			// 
			// btn_Add
			// 
			this.btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
			this.btn_Add.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(157)))), ((int)(((byte)(212)))));
			this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_Add.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_Add.Image = global::NanoComposite.Properties.Resources.add_normal;
			this.btn_Add.Location = new System.Drawing.Point(10, 357);
			this.btn_Add.Name = "btn_Add";
			this.btn_Add.Size = new System.Drawing.Size(150, 45);
			this.btn_Add.TabIndex = 10;
			this.btn_Add.Tag = "Добавить";
			this.btn_Add.Text = "Добавить";
			this.btn_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.toolTip1.SetToolTip(this.btn_Add, "Добавить в Таблицу");
			this.btn_Add.UseVisualStyleBackColor = false;
			this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
			this.btn_Add.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_Add.MouseHover += new System.EventHandler(this.btn_MouseHover);
			// 
			// lb_Capacity
			// 
			this.lb_Capacity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.lb_Capacity.AutoSize = true;
			this.lb_Capacity.Location = new System.Drawing.Point(10, 332);
			this.lb_Capacity.Name = "lb_Capacity";
			this.lb_Capacity.Size = new System.Drawing.Size(116, 13);
			this.lb_Capacity.TabIndex = 5;
			this.lb_Capacity.Text = "V - Обьемная доля, %";
			// 
			// lb_alfa
			// 
			this.lb_alfa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.lb_alfa.AutoSize = true;
			this.lb_alfa.Location = new System.Drawing.Point(10, 306);
			this.lb_alfa.Name = "lb_alfa";
			this.lb_alfa.Size = new System.Drawing.Size(194, 13);
			this.lb_alfa.TabIndex = 5;
			this.lb_alfa.Text = " α - коэф.термического расширения ";
			// 
			// lb_lambda
			// 
			this.lb_lambda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.lb_lambda.AutoSize = true;
			this.lb_lambda.Location = new System.Drawing.Point(10, 281);
			this.lb_lambda.Name = "lb_lambda";
			this.lb_lambda.Size = new System.Drawing.Size(175, 13);
			this.lb_lambda.TabIndex = 6;
			this.lb_lambda.Text = "λ - Теплопроводность, Вт/м*град";
			// 
			// lb_Cp
			// 
			this.lb_Cp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.lb_Cp.AutoSize = true;
			this.lb_Cp.Location = new System.Drawing.Point(10, 255);
			this.lb_Cp.Name = "lb_Cp";
			this.lb_Cp.Size = new System.Drawing.Size(153, 13);
			this.lb_Cp.TabIndex = 7;
			this.lb_Cp.Text = "Cp - Теплоемкость, Дж/кг*К\r\n";
			// 
			// lb_p
			// 
			this.lb_p.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.lb_p.AutoSize = true;
			this.lb_p.Location = new System.Drawing.Point(10, 229);
			this.lb_p.Name = "lb_p";
			this.lb_p.Size = new System.Drawing.Size(118, 13);
			this.lb_p.TabIndex = 8;
			this.lb_p.Text = "p - Плотность, кг/м^3";
			// 
			// lb_sigma
			// 
			this.lb_sigma.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.lb_sigma.AutoSize = true;
			this.lb_sigma.Location = new System.Drawing.Point(10, 203);
			this.lb_sigma.Name = "lb_sigma";
			this.lb_sigma.Size = new System.Drawing.Size(157, 13);
			this.lb_sigma.TabIndex = 9;
			this.lb_sigma.Text = "σ^2 - Предел прочности, МПа";
			// 
			// lb_E
			// 
			this.lb_E.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.lb_E.AutoSize = true;
			this.lb_E.Location = new System.Drawing.Point(10, 177);
			this.lb_E.Name = "lb_E";
			this.lb_E.Size = new System.Drawing.Size(143, 13);
			this.lb_E.TabIndex = 10;
			this.lb_E.Text = "E - Модуль упругости, МПа";
			// 
			// lb_Hb
			// 
			this.lb_Hb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.lb_Hb.AutoSize = true;
			this.lb_Hb.Location = new System.Drawing.Point(10, 150);
			this.lb_Hb.Name = "lb_Hb";
			this.lb_Hb.Size = new System.Drawing.Size(114, 13);
			this.lb_Hb.TabIndex = 11;
			this.lb_Hb.Text = "HB - Твердость, МПа";
			// 
			// NumUp_8_Capacity
			// 
			this.NumUp_8_Capacity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NumUp_8_Capacity.Location = new System.Drawing.Point(294, 330);
			this.NumUp_8_Capacity.Name = "NumUp_8_Capacity";
			this.NumUp_8_Capacity.Size = new System.Drawing.Size(80, 20);
			this.NumUp_8_Capacity.TabIndex = 1;
			this.NumUp_8_Capacity.Tag = "% Доля";
			this.toolTip1.SetToolTip(this.NumUp_8_Capacity, "% Доля");
			this.NumUp_8_Capacity.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NumUp_MouseClick);
			// 
			// NumUp_7_ThermalExpansion
			// 
			this.NumUp_7_ThermalExpansion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NumUp_7_ThermalExpansion.DecimalPlaces = 2;
			this.NumUp_7_ThermalExpansion.Location = new System.Drawing.Point(294, 304);
			this.NumUp_7_ThermalExpansion.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.NumUp_7_ThermalExpansion.Name = "NumUp_7_ThermalExpansion";
			this.NumUp_7_ThermalExpansion.Size = new System.Drawing.Size(80, 20);
			this.NumUp_7_ThermalExpansion.TabIndex = 8;
			this.NumUp_7_ThermalExpansion.Tag = "Коэфицент термического расширения";
			this.toolTip1.SetToolTip(this.NumUp_7_ThermalExpansion, "Коэфицент термического расширения");
			this.NumUp_7_ThermalExpansion.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NumUp_MouseClick);
			// 
			// NumUp_6_Transcalency
			// 
			this.NumUp_6_Transcalency.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NumUp_6_Transcalency.DecimalPlaces = 2;
			this.NumUp_6_Transcalency.Location = new System.Drawing.Point(294, 278);
			this.NumUp_6_Transcalency.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.NumUp_6_Transcalency.Name = "NumUp_6_Transcalency";
			this.NumUp_6_Transcalency.Size = new System.Drawing.Size(80, 20);
			this.NumUp_6_Transcalency.TabIndex = 7;
			this.NumUp_6_Transcalency.Tag = "Теплопроводность";
			this.toolTip1.SetToolTip(this.NumUp_6_Transcalency, "Теплопроводность");
			this.NumUp_6_Transcalency.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NumUp_MouseClick);
			// 
			// NumUp_5_HeatCapacity
			// 
			this.NumUp_5_HeatCapacity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NumUp_5_HeatCapacity.DecimalPlaces = 2;
			this.NumUp_5_HeatCapacity.Location = new System.Drawing.Point(294, 252);
			this.NumUp_5_HeatCapacity.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.NumUp_5_HeatCapacity.Name = "NumUp_5_HeatCapacity";
			this.NumUp_5_HeatCapacity.Size = new System.Drawing.Size(80, 20);
			this.NumUp_5_HeatCapacity.TabIndex = 6;
			this.NumUp_5_HeatCapacity.Tag = "Теплоемкость";
			this.toolTip1.SetToolTip(this.NumUp_5_HeatCapacity, "Теплоемкость");
			this.NumUp_5_HeatCapacity.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NumUp_MouseClick);
			// 
			// NumUp_4_Density
			// 
			this.NumUp_4_Density.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NumUp_4_Density.DecimalPlaces = 2;
			this.NumUp_4_Density.Location = new System.Drawing.Point(294, 226);
			this.NumUp_4_Density.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.NumUp_4_Density.Name = "NumUp_4_Density";
			this.NumUp_4_Density.Size = new System.Drawing.Size(80, 20);
			this.NumUp_4_Density.TabIndex = 5;
			this.NumUp_4_Density.Tag = "Плотность";
			this.toolTip1.SetToolTip(this.NumUp_4_Density, "Плотность");
			this.NumUp_4_Density.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NumUp_MouseClick);
			// 
			// NumUp_3_StrengthBeyond
			// 
			this.NumUp_3_StrengthBeyond.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NumUp_3_StrengthBeyond.DecimalPlaces = 2;
			this.NumUp_3_StrengthBeyond.Location = new System.Drawing.Point(294, 200);
			this.NumUp_3_StrengthBeyond.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.NumUp_3_StrengthBeyond.Name = "NumUp_3_StrengthBeyond";
			this.NumUp_3_StrengthBeyond.Size = new System.Drawing.Size(80, 20);
			this.NumUp_3_StrengthBeyond.TabIndex = 4;
			this.NumUp_3_StrengthBeyond.Tag = "Предел прочности";
			this.toolTip1.SetToolTip(this.NumUp_3_StrengthBeyond, "Предел прочности");
			this.NumUp_3_StrengthBeyond.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NumUp_MouseClick);
			// 
			// NumUp_2_Elasticity
			// 
			this.NumUp_2_Elasticity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NumUp_2_Elasticity.DecimalPlaces = 2;
			this.NumUp_2_Elasticity.Location = new System.Drawing.Point(294, 174);
			this.NumUp_2_Elasticity.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.NumUp_2_Elasticity.Name = "NumUp_2_Elasticity";
			this.NumUp_2_Elasticity.Size = new System.Drawing.Size(80, 20);
			this.NumUp_2_Elasticity.TabIndex = 3;
			this.NumUp_2_Elasticity.Tag = "Модуль упругости";
			this.toolTip1.SetToolTip(this.NumUp_2_Elasticity, "Модуль упругости");
			this.NumUp_2_Elasticity.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NumUp_MouseClick);
			// 
			// NumUp_1_Hardness
			// 
			this.NumUp_1_Hardness.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NumUp_1_Hardness.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.NumUp_1_Hardness.DecimalPlaces = 2;
			this.NumUp_1_Hardness.Location = new System.Drawing.Point(294, 148);
			this.NumUp_1_Hardness.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.NumUp_1_Hardness.Name = "NumUp_1_Hardness";
			this.NumUp_1_Hardness.Size = new System.Drawing.Size(80, 20);
			this.NumUp_1_Hardness.TabIndex = 2;
			this.NumUp_1_Hardness.Tag = "Твердость материала";
			this.toolTip1.SetToolTip(this.NumUp_1_Hardness, "Твердость материала");
			this.NumUp_1_Hardness.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NumUp_MouseClick);
			// 
			// rb_MassivePercent
			// 
			this.rb_MassivePercent.AutoSize = true;
			this.rb_MassivePercent.Location = new System.Drawing.Point(202, 104);
			this.rb_MassivePercent.Name = "rb_MassivePercent";
			this.rb_MassivePercent.Size = new System.Drawing.Size(130, 17);
			this.rb_MassivePercent.TabIndex = 1;
			this.rb_MassivePercent.TabStop = true;
			this.rb_MassivePercent.Text = "Массовые проценты";
			this.rb_MassivePercent.UseVisualStyleBackColor = true;
			this.rb_MassivePercent.CheckedChanged += new System.EventHandler(this.rb_ChangeCapacity_CheckedChanged);
			// 
			// rb_VolumePercent
			// 
			this.rb_VolumePercent.AutoSize = true;
			this.rb_VolumePercent.Location = new System.Drawing.Point(12, 104);
			this.rb_VolumePercent.Name = "rb_VolumePercent";
			this.rb_VolumePercent.Size = new System.Drawing.Size(131, 17);
			this.rb_VolumePercent.TabIndex = 1;
			this.rb_VolumePercent.TabStop = true;
			this.rb_VolumePercent.Text = "Обьемные проценты";
			this.rb_VolumePercent.UseVisualStyleBackColor = true;
			this.rb_VolumePercent.CheckedChanged += new System.EventHandler(this.rb_ChangeCapacity_CheckedChanged);
			// 
			// GroupBoxName
			// 
			this.GroupBoxName.Controls.Add(this.tb_NameMaterial);
			this.GroupBoxName.Location = new System.Drawing.Point(6, 19);
			this.GroupBoxName.Name = "GroupBoxName";
			this.GroupBoxName.Size = new System.Drawing.Size(374, 52);
			this.GroupBoxName.TabIndex = 0;
			this.GroupBoxName.TabStop = false;
			this.GroupBoxName.Text = "Название вещества";
			// 
			// tb_NameMaterial
			// 
			this.tb_NameMaterial.Location = new System.Drawing.Point(6, 19);
			this.tb_NameMaterial.Name = "tb_NameMaterial";
			this.tb_NameMaterial.Size = new System.Drawing.Size(362, 20);
			this.tb_NameMaterial.TabIndex = 0;
			this.toolTip1.SetToolTip(this.tb_NameMaterial, "Названия материала");
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.label7);
			this.tabPage2.Controls.Add(this.label6);
			this.tabPage2.Controls.Add(this.label5);
			this.tabPage2.Controls.Add(this.label4);
			this.tabPage2.Controls.Add(this.label3);
			this.tabPage2.Controls.Add(this.label2);
			this.tabPage2.Controls.Add(this.NumUp_Termal);
			this.tabPage2.Controls.Add(this.NumUp_Strength);
			this.tabPage2.Controls.Add(this.NumUp_Cogezy);
			this.tabPage2.Controls.Add(this.NumUp_Hardness);
			this.tabPage2.Controls.Add(this.NumUp_Elasticity);
			this.tabPage2.Controls.Add(this.NumUp_Porosity);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(392, 411);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Коэффиценты Материала";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(22, 186);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(162, 13);
			this.label7.TabIndex = 1;
			this.label7.Text = "Коэфицент Теплопроводности";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(22, 160);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(120, 13);
			this.label6.TabIndex = 1;
			this.label6.Text = "Коэфицент Прочности";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(22, 134);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(92, 13);
			this.label5.TabIndex = 1;
			this.label5.Text = "Фактор Когезии";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(22, 108);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(120, 13);
			this.label4.TabIndex = 1;
			this.label4.Text = "Коэфицент Твердости";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(22, 82);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(119, 13);
			this.label3.TabIndex = 1;
			this.label3.Text = "Коэфицент Упругости";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(22, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Пористость %";
			// 
			// NumUp_Termal
			// 
			this.NumUp_Termal.DecimalPlaces = 2;
			this.NumUp_Termal.Location = new System.Drawing.Point(190, 184);
			this.NumUp_Termal.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
			this.NumUp_Termal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.NumUp_Termal.Name = "NumUp_Termal";
			this.NumUp_Termal.Size = new System.Drawing.Size(177, 20);
			this.NumUp_Termal.TabIndex = 0;
			this.NumUp_Termal.Tag = "CofTranscalency";
			this.NumUp_Termal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.NumUp_Termal.ValueChanged += new System.EventHandler(this.NumUp_ValueChanged);
			// 
			// NumUp_Strength
			// 
			this.NumUp_Strength.DecimalPlaces = 2;
			this.NumUp_Strength.Location = new System.Drawing.Point(190, 158);
			this.NumUp_Strength.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.NumUp_Strength.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
			this.NumUp_Strength.Name = "NumUp_Strength";
			this.NumUp_Strength.Size = new System.Drawing.Size(177, 20);
			this.NumUp_Strength.TabIndex = 0;
			this.NumUp_Strength.Tag = "CofStrength";
			this.NumUp_Strength.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
			this.NumUp_Strength.ValueChanged += new System.EventHandler(this.NumUp_ValueChanged);
			// 
			// NumUp_Cogezy
			// 
			this.NumUp_Cogezy.DecimalPlaces = 2;
			this.NumUp_Cogezy.Location = new System.Drawing.Point(190, 132);
			this.NumUp_Cogezy.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.NumUp_Cogezy.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            131072});
			this.NumUp_Cogezy.Name = "NumUp_Cogezy";
			this.NumUp_Cogezy.Size = new System.Drawing.Size(177, 20);
			this.NumUp_Cogezy.TabIndex = 0;
			this.NumUp_Cogezy.Tag = "FactorKogezia";
			this.NumUp_Cogezy.Value = new decimal(new int[] {
            20,
            0,
            0,
            131072});
			this.NumUp_Cogezy.ValueChanged += new System.EventHandler(this.NumUp_ValueChanged);
			// 
			// NumUp_Hardness
			// 
			this.NumUp_Hardness.DecimalPlaces = 2;
			this.NumUp_Hardness.Location = new System.Drawing.Point(190, 106);
			this.NumUp_Hardness.Maximum = new decimal(new int[] {
            580,
            0,
            0,
            131072});
			this.NumUp_Hardness.Minimum = new decimal(new int[] {
            410,
            0,
            0,
            131072});
			this.NumUp_Hardness.Name = "NumUp_Hardness";
			this.NumUp_Hardness.Size = new System.Drawing.Size(177, 20);
			this.NumUp_Hardness.TabIndex = 0;
			this.NumUp_Hardness.Tag = "CofHardness";
			this.NumUp_Hardness.Value = new decimal(new int[] {
            410,
            0,
            0,
            131072});
			this.NumUp_Hardness.ValueChanged += new System.EventHandler(this.NumUp_ValueChanged);
			// 
			// NumUp_Elasticity
			// 
			this.NumUp_Elasticity.DecimalPlaces = 2;
			this.NumUp_Elasticity.Location = new System.Drawing.Point(190, 80);
			this.NumUp_Elasticity.Maximum = new decimal(new int[] {
            540,
            0,
            0,
            131072});
			this.NumUp_Elasticity.Minimum = new decimal(new int[] {
            250,
            0,
            0,
            131072});
			this.NumUp_Elasticity.Name = "NumUp_Elasticity";
			this.NumUp_Elasticity.Size = new System.Drawing.Size(177, 20);
			this.NumUp_Elasticity.TabIndex = 0;
			this.NumUp_Elasticity.Tag = "CofElasticity";
			this.NumUp_Elasticity.Value = new decimal(new int[] {
            250,
            0,
            0,
            131072});
			this.NumUp_Elasticity.ValueChanged += new System.EventHandler(this.NumUp_ValueChanged);
			// 
			// NumUp_Porosity
			// 
			this.NumUp_Porosity.Location = new System.Drawing.Point(190, 54);
			this.NumUp_Porosity.Name = "NumUp_Porosity";
			this.NumUp_Porosity.Size = new System.Drawing.Size(177, 20);
			this.NumUp_Porosity.TabIndex = 0;
			this.NumUp_Porosity.Tag = "Porosity";
			this.NumUp_Porosity.ValueChanged += new System.EventHandler(this.NumUp_ValueChanged);
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
			this.btn_Cancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
			this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_Cancel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_Cancel.Image = global::NanoComposite.Properties.Resources.Cancel_normal_32;
			this.btn_Cancel.Location = new System.Drawing.Point(672, 394);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(200, 45);
			this.btn_Cancel.TabIndex = 13;
			this.btn_Cancel.Tag = "Отмена";
			this.btn_Cancel.Text = "Отменить";
			this.btn_Cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.toolTip1.SetToolTip(this.btn_Cancel, "Отменить все действия");
			this.btn_Cancel.UseVisualStyleBackColor = false;
			this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
			this.btn_Cancel.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_Cancel.MouseHover += new System.EventHandler(this.btn_MouseHover);
			// 
			// btn_Save
			// 
			this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(255)))), ((int)(((byte)(215)))));
			this.btn_Save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(212)))), ((int)(((byte)(150)))));
			this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_Save.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_Save.Image = global::NanoComposite.Properties.Resources.save_normal_32;
			this.btn_Save.Location = new System.Drawing.Point(418, 394);
			this.btn_Save.Name = "btn_Save";
			this.btn_Save.Size = new System.Drawing.Size(200, 45);
			this.btn_Save.TabIndex = 12;
			this.btn_Save.Tag = "Сохранить";
			this.btn_Save.Text = "Сохранить";
			this.btn_Save.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.toolTip1.SetToolTip(this.btn_Save, "Сохранить текущую таблицу");
			this.btn_Save.UseVisualStyleBackColor = false;
			this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
			this.btn_Save.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_Save.MouseHover += new System.EventHandler(this.btn_MouseHover);
			// 
			// dgv_main
			// 
			this.dgv_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgv_main.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgv_main.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
			this.dgv_main.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
			this.dgv_main.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgv_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_main.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Matrix,
            this.Material,
            this.Volume,
            this.Hardness,
            this.Elaticity,
            this.DurabilityBeyond,
            this.Density,
            this.TermalCapacity,
            this.Termal,
            this.TermalExpansionFactor});
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgv_main.DefaultCellStyle = dataGridViewCellStyle1;
			this.dgv_main.Location = new System.Drawing.Point(418, 12);
			this.dgv_main.MultiSelect = false;
			this.dgv_main.Name = "dgv_main";
			this.dgv_main.Size = new System.Drawing.Size(454, 370);
			this.dgv_main.TabIndex = 14;
			this.dgv_main.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_main_CellContentClick);
			// 
			// Matrix
			// 
			this.Matrix.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Matrix.HeaderText = "Матрица";
			this.Matrix.Name = "Matrix";
			this.Matrix.Width = 57;
			// 
			// Material
			// 
			this.Material.HeaderText = "Вещество";
			this.Material.Name = "Material";
			// 
			// Volume
			// 
			this.Volume.HeaderText = "Доля";
			this.Volume.Name = "Volume";
			// 
			// Hardness
			// 
			this.Hardness.HeaderText = "Твердость";
			this.Hardness.Name = "Hardness";
			// 
			// Elaticity
			// 
			this.Elaticity.HeaderText = "Модуль упругости";
			this.Elaticity.Name = "Elaticity";
			// 
			// DurabilityBeyond
			// 
			this.DurabilityBeyond.HeaderText = "Предел прочности";
			this.DurabilityBeyond.Name = "DurabilityBeyond";
			// 
			// Density
			// 
			this.Density.HeaderText = "Плотность";
			this.Density.Name = "Density";
			// 
			// TermalCapacity
			// 
			this.TermalCapacity.HeaderText = "Теплоемкость";
			this.TermalCapacity.Name = "TermalCapacity";
			// 
			// Termal
			// 
			this.Termal.HeaderText = "Теплопроводность";
			this.Termal.Name = "Termal";
			// 
			// TermalExpansionFactor
			// 
			this.TermalExpansionFactor.HeaderText = "ф.Термического расширения";
			this.TermalExpansionFactor.Name = "TermalExpansionFactor";
			// 
			// CreateMaterial_Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 461);
			this.Controls.Add(this.dgv_main);
			this.Controls.Add(this.btn_Cancel);
			this.Controls.Add(this.btn_Save);
			this.Controls.Add(this.TabControl_AddMaterials);
			this.MinimumSize = new System.Drawing.Size(900, 500);
			this.Name = "CreateMaterial_Form";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Добавление Материала";
			this.Activated += new System.EventHandler(this.CreateMaterial_Form_Activated);
			this.Load += new System.EventHandler(this.CreateMaterial_Form_Load);
			this.MouseHover += new System.EventHandler(this.CreateMaterial_Form_Load);
			this.TabControl_AddMaterials.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.MainGroupBox.ResumeLayout(false);
			this.MainGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.NumUp_8_Capacity)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NumUp_7_ThermalExpansion)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NumUp_6_Transcalency)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NumUp_5_HeatCapacity)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NumUp_4_Density)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NumUp_3_StrengthBeyond)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NumUp_2_Elasticity)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NumUp_1_Hardness)).EndInit();
			this.GroupBoxName.ResumeLayout(false);
			this.GroupBoxName.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.NumUp_Termal)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NumUp_Strength)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NumUp_Cogezy)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NumUp_Hardness)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NumUp_Elasticity)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NumUp_Porosity)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_main)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl TabControl_AddMaterials;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.GroupBox MainGroupBox;
		private System.Windows.Forms.NumericUpDown NumUp_1_Hardness;
		private System.Windows.Forms.RadioButton rb_MassivePercent;
		private System.Windows.Forms.RadioButton rb_VolumePercent;
		private System.Windows.Forms.GroupBox GroupBoxName;
		private System.Windows.Forms.TextBox tb_NameMaterial;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.NumericUpDown NumUp_8_Capacity;
		private System.Windows.Forms.NumericUpDown NumUp_7_ThermalExpansion;
		private System.Windows.Forms.NumericUpDown NumUp_6_Transcalency;
		private System.Windows.Forms.NumericUpDown NumUp_5_HeatCapacity;
		private System.Windows.Forms.NumericUpDown NumUp_4_Density;
		private System.Windows.Forms.NumericUpDown NumUp_3_StrengthBeyond;
		private System.Windows.Forms.NumericUpDown NumUp_2_Elasticity;
		private System.Windows.Forms.Label lb_alfa;
		private System.Windows.Forms.Label lb_lambda;
		private System.Windows.Forms.Label lb_Cp;
		private System.Windows.Forms.Label lb_p;
		private System.Windows.Forms.Label lb_sigma;
		private System.Windows.Forms.Label lb_E;
		private System.Windows.Forms.Label lb_Hb;
		private System.Windows.Forms.Label lb_Capacity;
		private System.Windows.Forms.Button btn_Delete;
		private System.Windows.Forms.Button btn_Add;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.NumericUpDown NumUp_Termal;
		private System.Windows.Forms.NumericUpDown NumUp_Strength;
		private System.Windows.Forms.NumericUpDown NumUp_Cogezy;
		private System.Windows.Forms.NumericUpDown NumUp_Hardness;
		private System.Windows.Forms.NumericUpDown NumUp_Elasticity;
		private System.Windows.Forms.NumericUpDown NumUp_Porosity;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dgv_main;
		private System.Windows.Forms.Button btn_Save;
		private System.Windows.Forms.Button btn_Cancel;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Matrix;
		private System.Windows.Forms.DataGridViewTextBoxColumn Material;
		private System.Windows.Forms.DataGridViewTextBoxColumn Volume;
		private System.Windows.Forms.DataGridViewTextBoxColumn Hardness;
		private System.Windows.Forms.DataGridViewTextBoxColumn Elaticity;
		private System.Windows.Forms.DataGridViewTextBoxColumn DurabilityBeyond;
		private System.Windows.Forms.DataGridViewTextBoxColumn Density;
		private System.Windows.Forms.DataGridViewTextBoxColumn TermalCapacity;
		private System.Windows.Forms.DataGridViewTextBoxColumn Termal;
		private System.Windows.Forms.DataGridViewTextBoxColumn TermalExpansionFactor;
	}
}