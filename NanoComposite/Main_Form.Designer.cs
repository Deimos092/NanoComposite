namespace NanoComposite
{
	partial class Main_Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
			this.MainTab = new System.Windows.Forms.TabControl();
			this.Tab_MaterialsList = new System.Windows.Forms.TabPage();
			this.Lb_MaterialsList = new System.Windows.Forms.ListBox();
			this.btn_ClearAll = new System.Windows.Forms.Button();
			this.btn_Delete = new System.Windows.Forms.Button();
			this.btn_Change = new System.Windows.Forms.Button();
			this.btn_Add = new System.Windows.Forms.Button();
			this.Tab_MaterialProperty = new System.Windows.Forms.TabPage();
			this.Split_Main = new System.Windows.Forms.SplitContainer();
			this.Split_Left_Top = new System.Windows.Forms.SplitContainer();
			this.Gb_Top_Left = new System.Windows.Forms.GroupBox();
			this.lb_Composites = new System.Windows.Forms.ListBox();
			this.Split_Left_Down = new System.Windows.Forms.SplitContainer();
			this.GB_Mid_Left = new System.Windows.Forms.GroupBox();
			this.lb_Armature = new System.Windows.Forms.ListBox();
			this.lb_alfa = new System.Windows.Forms.Label();
			this.lb_lambda = new System.Windows.Forms.Label();
			this.lb_Cp = new System.Windows.Forms.Label();
			this.lb_p = new System.Windows.Forms.Label();
			this.lb_sigma = new System.Windows.Forms.Label();
			this.lb_E = new System.Windows.Forms.Label();
			this.lb_Hb = new System.Windows.Forms.Label();
			this.tb_7_alfa = new System.Windows.Forms.TextBox();
			this.tb_6_lambda = new System.Windows.Forms.TextBox();
			this.tb_5_Cp = new System.Windows.Forms.TextBox();
			this.tb_4_p = new System.Windows.Forms.TextBox();
			this.tb_3_sigma = new System.Windows.Forms.TextBox();
			this.tb_2_E = new System.Windows.Forms.TextBox();
			this.Tb_1_Hb = new System.Windows.Forms.TextBox();
			this.NumUp_Porosity = new System.Windows.Forms.NumericUpDown();
			this.Track_Porosity = new System.Windows.Forms.TrackBar();
			this.lb_Percent = new System.Windows.Forms.Label();
			this.lb_Porsity = new System.Windows.Forms.Label();
			this.Split_Right_Top = new System.Windows.Forms.SplitContainer();
			this.Split_Top_1 = new System.Windows.Forms.SplitContainer();
			this.Split_Top_2 = new System.Windows.Forms.SplitContainer();
			this.Split_Right_Down = new System.Windows.Forms.SplitContainer();
			this.Split_Mid_1 = new System.Windows.Forms.SplitContainer();
			this.Split_Mid_2 = new System.Windows.Forms.SplitContainer();
			this.MyToolTip = new System.Windows.Forms.ToolTip(this.components);
			this.MainTab.SuspendLayout();
			this.Tab_MaterialsList.SuspendLayout();
			this.Tab_MaterialProperty.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Split_Main)).BeginInit();
			this.Split_Main.Panel1.SuspendLayout();
			this.Split_Main.Panel2.SuspendLayout();
			this.Split_Main.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Split_Left_Top)).BeginInit();
			this.Split_Left_Top.Panel1.SuspendLayout();
			this.Split_Left_Top.Panel2.SuspendLayout();
			this.Split_Left_Top.SuspendLayout();
			this.Gb_Top_Left.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Split_Left_Down)).BeginInit();
			this.Split_Left_Down.Panel1.SuspendLayout();
			this.Split_Left_Down.Panel2.SuspendLayout();
			this.Split_Left_Down.SuspendLayout();
			this.GB_Mid_Left.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.NumUp_Porosity)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Track_Porosity)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Split_Right_Top)).BeginInit();
			this.Split_Right_Top.Panel1.SuspendLayout();
			this.Split_Right_Top.Panel2.SuspendLayout();
			this.Split_Right_Top.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Split_Top_1)).BeginInit();
			this.Split_Top_1.Panel2.SuspendLayout();
			this.Split_Top_1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Split_Top_2)).BeginInit();
			this.Split_Top_2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Split_Right_Down)).BeginInit();
			this.Split_Right_Down.Panel1.SuspendLayout();
			this.Split_Right_Down.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Split_Mid_1)).BeginInit();
			this.Split_Mid_1.Panel2.SuspendLayout();
			this.Split_Mid_1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Split_Mid_2)).BeginInit();
			this.Split_Mid_2.SuspendLayout();
			this.SuspendLayout();
			// 
			// MainTab
			// 
			this.MainTab.Controls.Add(this.Tab_MaterialsList);
			this.MainTab.Controls.Add(this.Tab_MaterialProperty);
			this.MainTab.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MainTab.Location = new System.Drawing.Point(0, 0);
			this.MainTab.Name = "MainTab";
			this.MainTab.SelectedIndex = 0;
			this.MainTab.Size = new System.Drawing.Size(734, 561);
			this.MainTab.TabIndex = 0;
			this.MainTab.SelectedIndexChanged += new System.EventHandler(this.MainTab_SelectedIndexChanged);
			// 
			// Tab_MaterialsList
			// 
			this.Tab_MaterialsList.BackColor = System.Drawing.Color.Transparent;
			this.Tab_MaterialsList.Controls.Add(this.Lb_MaterialsList);
			this.Tab_MaterialsList.Controls.Add(this.btn_ClearAll);
			this.Tab_MaterialsList.Controls.Add(this.btn_Delete);
			this.Tab_MaterialsList.Controls.Add(this.btn_Change);
			this.Tab_MaterialsList.Controls.Add(this.btn_Add);
			this.Tab_MaterialsList.Location = new System.Drawing.Point(4, 22);
			this.Tab_MaterialsList.Name = "Tab_MaterialsList";
			this.Tab_MaterialsList.Padding = new System.Windows.Forms.Padding(3);
			this.Tab_MaterialsList.Size = new System.Drawing.Size(726, 535);
			this.Tab_MaterialsList.TabIndex = 0;
			this.Tab_MaterialsList.Text = "Список Материалов";
			// 
			// Lb_MaterialsList
			// 
			this.Lb_MaterialsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Lb_MaterialsList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Lb_MaterialsList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Lb_MaterialsList.FormattingEnabled = true;
			this.Lb_MaterialsList.ItemHeight = 21;
			this.Lb_MaterialsList.Location = new System.Drawing.Point(8, 19);
			this.Lb_MaterialsList.Name = "Lb_MaterialsList";
			this.Lb_MaterialsList.Size = new System.Drawing.Size(570, 506);
			this.Lb_MaterialsList.TabIndex = 4;
			this.Lb_MaterialsList.Tag = "Список материалов";
			this.MyToolTip.SetToolTip(this.Lb_MaterialsList, "Список материалов");
			// 
			// btn_ClearAll
			// 
			this.btn_ClearAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_ClearAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(243)))), ((int)(((byte)(214)))));
			this.btn_ClearAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(243)))), ((int)(((byte)(114)))));
			this.btn_ClearAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(243)))), ((int)(((byte)(114)))));
			this.btn_ClearAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(200)))), ((int)(((byte)(176)))));
			this.btn_ClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_ClearAll.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_ClearAll.Image = global::NanoComposite.Properties.Resources.refresh_normal_32;
			this.btn_ClearAll.Location = new System.Drawing.Point(583, 480);
			this.btn_ClearAll.Name = "btn_ClearAll";
			this.btn_ClearAll.Size = new System.Drawing.Size(135, 45);
			this.btn_ClearAll.TabIndex = 3;
			this.btn_ClearAll.Tag = "Очистить";
			this.btn_ClearAll.Text = "Очистить";
			this.btn_ClearAll.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.MyToolTip.SetToolTip(this.btn_ClearAll, "Очистить список");
			this.btn_ClearAll.UseVisualStyleBackColor = false;
			this.btn_ClearAll.Click += new System.EventHandler(this.btn_ClearAll_Click);
			this.btn_ClearAll.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_ClearAll.MouseHover += new System.EventHandler(this.btn_MouseHover);
			// 
			// btn_Delete
			// 
			this.btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
			this.btn_Delete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
			this.btn_Delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
			this.btn_Delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
			this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_Delete.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_Delete.Image = global::NanoComposite.Properties.Resources.delete_normal_32;
			this.btn_Delete.Location = new System.Drawing.Point(584, 121);
			this.btn_Delete.Name = "btn_Delete";
			this.btn_Delete.Size = new System.Drawing.Size(135, 45);
			this.btn_Delete.TabIndex = 2;
			this.btn_Delete.Tag = "Удалить";
			this.btn_Delete.Text = "Удалить";
			this.btn_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.MyToolTip.SetToolTip(this.btn_Delete, "Удалить выделенный материал");
			this.btn_Delete.UseVisualStyleBackColor = false;
			this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
			this.btn_Delete.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_Delete.MouseHover += new System.EventHandler(this.btn_MouseHover);
			// 
			// btn_Change
			// 
			this.btn_Change.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Change.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(255)))), ((int)(((byte)(215)))));
			this.btn_Change.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(212)))), ((int)(((byte)(150)))));
			this.btn_Change.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(212)))), ((int)(((byte)(150)))));
			this.btn_Change.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(200)))), ((int)(((byte)(169)))));
			this.btn_Change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_Change.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_Change.Image = global::NanoComposite.Properties.Resources.edit_normal_32;
			this.btn_Change.Location = new System.Drawing.Point(584, 70);
			this.btn_Change.Margin = new System.Windows.Forms.Padding(0);
			this.btn_Change.Name = "btn_Change";
			this.btn_Change.Size = new System.Drawing.Size(135, 45);
			this.btn_Change.TabIndex = 1;
			this.btn_Change.Tag = "Изменить";
			this.btn_Change.Text = "Изменить";
			this.btn_Change.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.MyToolTip.SetToolTip(this.btn_Change, "Изменить выделенный материал");
			this.btn_Change.UseVisualStyleBackColor = false;
			this.btn_Change.Click += new System.EventHandler(this.btn_Change_Click);
			this.btn_Change.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_Change.MouseHover += new System.EventHandler(this.btn_MouseHover);
			// 
			// btn_Add
			// 
			this.btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
			this.btn_Add.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(157)))), ((int)(((byte)(212)))));
			this.btn_Add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(157)))), ((int)(((byte)(212)))));
			this.btn_Add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(181)))), ((int)(((byte)(200)))));
			this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_Add.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_Add.Image = global::NanoComposite.Properties.Resources.add_normal;
			this.btn_Add.Location = new System.Drawing.Point(584, 19);
			this.btn_Add.Name = "btn_Add";
			this.btn_Add.Size = new System.Drawing.Size(135, 45);
			this.btn_Add.TabIndex = 0;
			this.btn_Add.Tag = "Добавить";
			this.btn_Add.Text = "Добавить";
			this.btn_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.MyToolTip.SetToolTip(this.btn_Add, "Добавить Материал");
			this.btn_Add.UseVisualStyleBackColor = false;
			this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
			this.btn_Add.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_Add.MouseHover += new System.EventHandler(this.btn_MouseHover);
			// 
			// Tab_MaterialProperty
			// 
			this.Tab_MaterialProperty.Controls.Add(this.Split_Main);
			this.Tab_MaterialProperty.Location = new System.Drawing.Point(4, 22);
			this.Tab_MaterialProperty.Name = "Tab_MaterialProperty";
			this.Tab_MaterialProperty.Padding = new System.Windows.Forms.Padding(3);
			this.Tab_MaterialProperty.Size = new System.Drawing.Size(726, 535);
			this.Tab_MaterialProperty.TabIndex = 1;
			this.Tab_MaterialProperty.Text = "Свойства Материала";
			this.Tab_MaterialProperty.UseVisualStyleBackColor = true;
			// 
			// Split_Main
			// 
			this.Split_Main.BackColor = System.Drawing.Color.Transparent;
			this.Split_Main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Split_Main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Split_Main.Location = new System.Drawing.Point(3, 3);
			this.Split_Main.Name = "Split_Main";
			// 
			// Split_Main.Panel1
			// 
			this.Split_Main.Panel1.Controls.Add(this.Split_Left_Top);
			this.Split_Main.Panel1MinSize = 265;
			// 
			// Split_Main.Panel2
			// 
			this.Split_Main.Panel2.Controls.Add(this.Split_Right_Top);
			this.Split_Main.Panel2MinSize = 200;
			this.Split_Main.Size = new System.Drawing.Size(720, 529);
			this.Split_Main.SplitterDistance = 265;
			this.Split_Main.TabIndex = 0;
			// 
			// Split_Left_Top
			// 
			this.Split_Left_Top.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Split_Left_Top.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Split_Left_Top.Location = new System.Drawing.Point(0, 0);
			this.Split_Left_Top.Name = "Split_Left_Top";
			this.Split_Left_Top.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// Split_Left_Top.Panel1
			// 
			this.Split_Left_Top.Panel1.Controls.Add(this.Gb_Top_Left);
			this.Split_Left_Top.Panel1MinSize = 100;
			// 
			// Split_Left_Top.Panel2
			// 
			this.Split_Left_Top.Panel2.Controls.Add(this.Split_Left_Down);
			this.Split_Left_Top.Panel2MinSize = 100;
			this.Split_Left_Top.Size = new System.Drawing.Size(265, 529);
			this.Split_Left_Top.SplitterDistance = 141;
			this.Split_Left_Top.TabIndex = 0;
			// 
			// Gb_Top_Left
			// 
			this.Gb_Top_Left.Controls.Add(this.lb_Composites);
			this.Gb_Top_Left.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Gb_Top_Left.Location = new System.Drawing.Point(0, 0);
			this.Gb_Top_Left.Name = "Gb_Top_Left";
			this.Gb_Top_Left.Size = new System.Drawing.Size(263, 139);
			this.Gb_Top_Left.TabIndex = 0;
			this.Gb_Top_Left.TabStop = false;
			this.Gb_Top_Left.Text = "Выбор Материала";
			// 
			// lb_Composites
			// 
			this.lb_Composites.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lb_Composites.FormattingEnabled = true;
			this.lb_Composites.Location = new System.Drawing.Point(3, 16);
			this.lb_Composites.Name = "lb_Composites";
			this.lb_Composites.Size = new System.Drawing.Size(257, 120);
			this.lb_Composites.TabIndex = 0;
			this.lb_Composites.SelectedIndexChanged += new System.EventHandler(this.Lb_MaterialsList_SelectedIndexChanged);
			// 
			// Split_Left_Down
			// 
			this.Split_Left_Down.BackColor = System.Drawing.Color.Transparent;
			this.Split_Left_Down.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Split_Left_Down.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Split_Left_Down.Location = new System.Drawing.Point(0, 0);
			this.Split_Left_Down.Name = "Split_Left_Down";
			this.Split_Left_Down.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// Split_Left_Down.Panel1
			// 
			this.Split_Left_Down.Panel1.Controls.Add(this.GB_Mid_Left);
			this.Split_Left_Down.Panel1MinSize = 100;
			// 
			// Split_Left_Down.Panel2
			// 
			this.Split_Left_Down.Panel2.Controls.Add(this.lb_alfa);
			this.Split_Left_Down.Panel2.Controls.Add(this.lb_lambda);
			this.Split_Left_Down.Panel2.Controls.Add(this.lb_Cp);
			this.Split_Left_Down.Panel2.Controls.Add(this.lb_p);
			this.Split_Left_Down.Panel2.Controls.Add(this.lb_sigma);
			this.Split_Left_Down.Panel2.Controls.Add(this.lb_E);
			this.Split_Left_Down.Panel2.Controls.Add(this.lb_Hb);
			this.Split_Left_Down.Panel2.Controls.Add(this.tb_7_alfa);
			this.Split_Left_Down.Panel2.Controls.Add(this.tb_6_lambda);
			this.Split_Left_Down.Panel2.Controls.Add(this.tb_5_Cp);
			this.Split_Left_Down.Panel2.Controls.Add(this.tb_4_p);
			this.Split_Left_Down.Panel2.Controls.Add(this.tb_3_sigma);
			this.Split_Left_Down.Panel2.Controls.Add(this.tb_2_E);
			this.Split_Left_Down.Panel2.Controls.Add(this.Tb_1_Hb);
			this.Split_Left_Down.Panel2.Controls.Add(this.NumUp_Porosity);
			this.Split_Left_Down.Panel2.Controls.Add(this.Track_Porosity);
			this.Split_Left_Down.Panel2.Controls.Add(this.lb_Percent);
			this.Split_Left_Down.Panel2.Controls.Add(this.lb_Porsity);
			this.Split_Left_Down.Panel2.Enabled = false;
			this.Split_Left_Down.Panel2MinSize = 100;
			this.Split_Left_Down.Size = new System.Drawing.Size(265, 384);
			this.Split_Left_Down.SplitterDistance = 154;
			this.Split_Left_Down.TabIndex = 0;
			// 
			// GB_Mid_Left
			// 
			this.GB_Mid_Left.Controls.Add(this.lb_Armature);
			this.GB_Mid_Left.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GB_Mid_Left.Location = new System.Drawing.Point(0, 0);
			this.GB_Mid_Left.Name = "GB_Mid_Left";
			this.GB_Mid_Left.Size = new System.Drawing.Size(263, 152);
			this.GB_Mid_Left.TabIndex = 0;
			this.GB_Mid_Left.TabStop = false;
			this.GB_Mid_Left.Text = "Выбор Арматуры";
			// 
			// lb_Armature
			// 
			this.lb_Armature.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lb_Armature.FormattingEnabled = true;
			this.lb_Armature.Location = new System.Drawing.Point(3, 16);
			this.lb_Armature.Name = "lb_Armature";
			this.lb_Armature.Size = new System.Drawing.Size(257, 133);
			this.lb_Armature.TabIndex = 0;
			// 
			// lb_alfa
			// 
			this.lb_alfa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.lb_alfa.AutoSize = true;
			this.lb_alfa.Location = new System.Drawing.Point(2, 207);
			this.lb_alfa.Name = "lb_alfa";
			this.lb_alfa.Size = new System.Drawing.Size(194, 13);
			this.lb_alfa.TabIndex = 4;
			this.lb_alfa.Text = " α - коэф.термического расширения ";
			// 
			// lb_lambda
			// 
			this.lb_lambda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.lb_lambda.AutoSize = true;
			this.lb_lambda.Location = new System.Drawing.Point(5, 181);
			this.lb_lambda.Name = "lb_lambda";
			this.lb_lambda.Size = new System.Drawing.Size(175, 13);
			this.lb_lambda.TabIndex = 4;
			this.lb_lambda.Text = "λ - Теплопроводность, Вт/м*град";
			// 
			// lb_Cp
			// 
			this.lb_Cp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.lb_Cp.AutoSize = true;
			this.lb_Cp.Location = new System.Drawing.Point(5, 155);
			this.lb_Cp.Name = "lb_Cp";
			this.lb_Cp.Size = new System.Drawing.Size(153, 13);
			this.lb_Cp.TabIndex = 4;
			this.lb_Cp.Text = "Cp - Теплоемкость, Дж/кг*К\r\n";
			// 
			// lb_p
			// 
			this.lb_p.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.lb_p.AutoSize = true;
			this.lb_p.Location = new System.Drawing.Point(5, 129);
			this.lb_p.Name = "lb_p";
			this.lb_p.Size = new System.Drawing.Size(118, 13);
			this.lb_p.TabIndex = 4;
			this.lb_p.Text = "p - Плотность, кг/м^3";
			// 
			// lb_sigma
			// 
			this.lb_sigma.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.lb_sigma.AutoSize = true;
			this.lb_sigma.Location = new System.Drawing.Point(5, 103);
			this.lb_sigma.Name = "lb_sigma";
			this.lb_sigma.Size = new System.Drawing.Size(157, 13);
			this.lb_sigma.TabIndex = 4;
			this.lb_sigma.Text = "σ^2 - Предел прочности, МПа\r\n";
			// 
			// lb_E
			// 
			this.lb_E.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.lb_E.AutoSize = true;
			this.lb_E.Location = new System.Drawing.Point(5, 77);
			this.lb_E.Name = "lb_E";
			this.lb_E.Size = new System.Drawing.Size(143, 13);
			this.lb_E.TabIndex = 4;
			this.lb_E.Text = "E - Модуль упругости, МПа";
			// 
			// lb_Hb
			// 
			this.lb_Hb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.lb_Hb.AutoSize = true;
			this.lb_Hb.Location = new System.Drawing.Point(5, 50);
			this.lb_Hb.Name = "lb_Hb";
			this.lb_Hb.Size = new System.Drawing.Size(114, 13);
			this.lb_Hb.TabIndex = 4;
			this.lb_Hb.Text = "HB - Твердость, МПа";
			// 
			// tb_7_alfa
			// 
			this.tb_7_alfa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_7_alfa.Location = new System.Drawing.Point(196, 203);
			this.tb_7_alfa.Name = "tb_7_alfa";
			this.tb_7_alfa.ReadOnly = true;
			this.tb_7_alfa.Size = new System.Drawing.Size(61, 20);
			this.tb_7_alfa.TabIndex = 3;
			this.MyToolTip.SetToolTip(this.tb_7_alfa, "Значение Коэффицента термического расширения");
			// 
			// tb_6_lambda
			// 
			this.tb_6_lambda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_6_lambda.Location = new System.Drawing.Point(196, 177);
			this.tb_6_lambda.Name = "tb_6_lambda";
			this.tb_6_lambda.ReadOnly = true;
			this.tb_6_lambda.Size = new System.Drawing.Size(61, 20);
			this.tb_6_lambda.TabIndex = 3;
			this.MyToolTip.SetToolTip(this.tb_6_lambda, "Значение Теплопроводности");
			// 
			// tb_5_Cp
			// 
			this.tb_5_Cp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_5_Cp.Location = new System.Drawing.Point(196, 151);
			this.tb_5_Cp.Name = "tb_5_Cp";
			this.tb_5_Cp.ReadOnly = true;
			this.tb_5_Cp.Size = new System.Drawing.Size(61, 20);
			this.tb_5_Cp.TabIndex = 3;
			this.MyToolTip.SetToolTip(this.tb_5_Cp, "Значение Теплоемкости");
			// 
			// tb_4_p
			// 
			this.tb_4_p.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_4_p.Location = new System.Drawing.Point(196, 125);
			this.tb_4_p.Name = "tb_4_p";
			this.tb_4_p.ReadOnly = true;
			this.tb_4_p.Size = new System.Drawing.Size(61, 20);
			this.tb_4_p.TabIndex = 3;
			this.MyToolTip.SetToolTip(this.tb_4_p, "Значение Плотности");
			// 
			// tb_3_sigma
			// 
			this.tb_3_sigma.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_3_sigma.Location = new System.Drawing.Point(196, 99);
			this.tb_3_sigma.Name = "tb_3_sigma";
			this.tb_3_sigma.ReadOnly = true;
			this.tb_3_sigma.Size = new System.Drawing.Size(61, 20);
			this.tb_3_sigma.TabIndex = 3;
			this.MyToolTip.SetToolTip(this.tb_3_sigma, "Значение Предела прочности");
			// 
			// tb_2_E
			// 
			this.tb_2_E.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_2_E.Location = new System.Drawing.Point(196, 73);
			this.tb_2_E.Name = "tb_2_E";
			this.tb_2_E.ReadOnly = true;
			this.tb_2_E.Size = new System.Drawing.Size(61, 20);
			this.tb_2_E.TabIndex = 3;
			this.MyToolTip.SetToolTip(this.tb_2_E, "Значение модуля Упругости Е");
			// 
			// Tb_1_Hb
			// 
			this.Tb_1_Hb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Tb_1_Hb.Location = new System.Drawing.Point(196, 47);
			this.Tb_1_Hb.Name = "Tb_1_Hb";
			this.Tb_1_Hb.ReadOnly = true;
			this.Tb_1_Hb.Size = new System.Drawing.Size(61, 20);
			this.Tb_1_Hb.TabIndex = 3;
			this.MyToolTip.SetToolTip(this.Tb_1_Hb, "Значение Твердости HВ");
			// 
			// NumUp_Porosity
			// 
			this.NumUp_Porosity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NumUp_Porosity.DecimalPlaces = 2;
			this.NumUp_Porosity.Location = new System.Drawing.Point(196, 6);
			this.NumUp_Porosity.Name = "NumUp_Porosity";
			this.NumUp_Porosity.Size = new System.Drawing.Size(61, 20);
			this.NumUp_Porosity.TabIndex = 2;
			this.NumUp_Porosity.ValueChanged += new System.EventHandler(this.NumUp_Porosity_ValueChanged);
			this.NumUp_Porosity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumUp_Porosity_KeyPress);
			// 
			// Track_Porosity
			// 
			this.Track_Porosity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Track_Porosity.AutoSize = false;
			this.Track_Porosity.LargeChange = 1;
			this.Track_Porosity.Location = new System.Drawing.Point(8, 24);
			this.Track_Porosity.Margin = new System.Windows.Forms.Padding(0);
			this.Track_Porosity.Maximum = 100;
			this.Track_Porosity.Name = "Track_Porosity";
			this.Track_Porosity.Size = new System.Drawing.Size(252, 20);
			this.Track_Porosity.TabIndex = 1;
			this.Track_Porosity.TickFrequency = 2;
			this.Track_Porosity.TickStyle = System.Windows.Forms.TickStyle.None;
			this.Track_Porosity.Scroll += new System.EventHandler(this.Track_Porosity_Scroll);
			this.Track_Porosity.ValueChanged += new System.EventHandler(this.Track_Porosity_ValueChanged);
			// 
			// lb_Percent
			// 
			this.lb_Percent.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lb_Percent.AutoSize = true;
			this.lb_Percent.Location = new System.Drawing.Point(86, 8);
			this.lb_Percent.Name = "lb_Percent";
			this.lb_Percent.Size = new System.Drawing.Size(0, 13);
			this.lb_Percent.TabIndex = 0;
			// 
			// lb_Porsity
			// 
			this.lb_Porsity.AutoSize = true;
			this.lb_Porsity.Location = new System.Drawing.Point(5, 8);
			this.lb_Porsity.Name = "lb_Porsity";
			this.lb_Porsity.Size = new System.Drawing.Size(67, 13);
			this.lb_Porsity.TabIndex = 0;
			this.lb_Porsity.Text = "Пористость";
			// 
			// Split_Right_Top
			// 
			this.Split_Right_Top.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Split_Right_Top.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Split_Right_Top.Location = new System.Drawing.Point(0, 0);
			this.Split_Right_Top.Name = "Split_Right_Top";
			this.Split_Right_Top.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// Split_Right_Top.Panel1
			// 
			this.Split_Right_Top.Panel1.Controls.Add(this.Split_Top_1);
			this.Split_Right_Top.Panel1MinSize = 100;
			// 
			// Split_Right_Top.Panel2
			// 
			this.Split_Right_Top.Panel2.Controls.Add(this.Split_Right_Down);
			this.Split_Right_Top.Panel2MinSize = 100;
			this.Split_Right_Top.Size = new System.Drawing.Size(451, 529);
			this.Split_Right_Top.SplitterDistance = 141;
			this.Split_Right_Top.TabIndex = 0;
			// 
			// Split_Top_1
			// 
			this.Split_Top_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Split_Top_1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Split_Top_1.Location = new System.Drawing.Point(0, 0);
			this.Split_Top_1.Name = "Split_Top_1";
			this.Split_Top_1.Panel1MinSize = 100;
			// 
			// Split_Top_1.Panel2
			// 
			this.Split_Top_1.Panel2.Controls.Add(this.Split_Top_2);
			this.Split_Top_1.Panel2MinSize = 100;
			this.Split_Top_1.Size = new System.Drawing.Size(451, 141);
			this.Split_Top_1.SplitterDistance = 135;
			this.Split_Top_1.TabIndex = 0;
			// 
			// Split_Top_2
			// 
			this.Split_Top_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Split_Top_2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Split_Top_2.Location = new System.Drawing.Point(0, 0);
			this.Split_Top_2.Name = "Split_Top_2";
			this.Split_Top_2.Panel1MinSize = 100;
			this.Split_Top_2.Panel2MinSize = 100;
			this.Split_Top_2.Size = new System.Drawing.Size(312, 141);
			this.Split_Top_2.SplitterDistance = 140;
			this.Split_Top_2.TabIndex = 0;
			// 
			// Split_Right_Down
			// 
			this.Split_Right_Down.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Split_Right_Down.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Split_Right_Down.Location = new System.Drawing.Point(0, 0);
			this.Split_Right_Down.Name = "Split_Right_Down";
			this.Split_Right_Down.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// Split_Right_Down.Panel1
			// 
			this.Split_Right_Down.Panel1.Controls.Add(this.Split_Mid_1);
			this.Split_Right_Down.Panel1MinSize = 100;
			this.Split_Right_Down.Panel2MinSize = 100;
			this.Split_Right_Down.Size = new System.Drawing.Size(451, 384);
			this.Split_Right_Down.SplitterDistance = 154;
			this.Split_Right_Down.TabIndex = 0;
			// 
			// Split_Mid_1
			// 
			this.Split_Mid_1.BackColor = System.Drawing.Color.Transparent;
			this.Split_Mid_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Split_Mid_1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Split_Mid_1.Location = new System.Drawing.Point(0, 0);
			this.Split_Mid_1.Name = "Split_Mid_1";
			this.Split_Mid_1.Panel1MinSize = 100;
			// 
			// Split_Mid_1.Panel2
			// 
			this.Split_Mid_1.Panel2.Controls.Add(this.Split_Mid_2);
			this.Split_Mid_1.Panel2MinSize = 100;
			this.Split_Mid_1.Size = new System.Drawing.Size(451, 154);
			this.Split_Mid_1.SplitterDistance = 135;
			this.Split_Mid_1.TabIndex = 0;
			// 
			// Split_Mid_2
			// 
			this.Split_Mid_2.BackColor = System.Drawing.Color.Transparent;
			this.Split_Mid_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Split_Mid_2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Split_Mid_2.Location = new System.Drawing.Point(0, 0);
			this.Split_Mid_2.Name = "Split_Mid_2";
			this.Split_Mid_2.Panel1MinSize = 100;
			this.Split_Mid_2.Panel2MinSize = 100;
			this.Split_Mid_2.Size = new System.Drawing.Size(312, 154);
			this.Split_Mid_2.SplitterDistance = 140;
			this.Split_Mid_2.TabIndex = 0;
			// 
			// Main_Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(734, 561);
			this.Controls.Add(this.MainTab);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(750, 600);
			this.Name = "Main_Form";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Tag = "Нанокомпозиты";
			this.Text = "Нанокомпозиты";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.MainTab.ResumeLayout(false);
			this.Tab_MaterialsList.ResumeLayout(false);
			this.Tab_MaterialProperty.ResumeLayout(false);
			this.Split_Main.Panel1.ResumeLayout(false);
			this.Split_Main.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Split_Main)).EndInit();
			this.Split_Main.ResumeLayout(false);
			this.Split_Left_Top.Panel1.ResumeLayout(false);
			this.Split_Left_Top.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Split_Left_Top)).EndInit();
			this.Split_Left_Top.ResumeLayout(false);
			this.Gb_Top_Left.ResumeLayout(false);
			this.Split_Left_Down.Panel1.ResumeLayout(false);
			this.Split_Left_Down.Panel2.ResumeLayout(false);
			this.Split_Left_Down.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.Split_Left_Down)).EndInit();
			this.Split_Left_Down.ResumeLayout(false);
			this.GB_Mid_Left.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.NumUp_Porosity)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Track_Porosity)).EndInit();
			this.Split_Right_Top.Panel1.ResumeLayout(false);
			this.Split_Right_Top.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Split_Right_Top)).EndInit();
			this.Split_Right_Top.ResumeLayout(false);
			this.Split_Top_1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Split_Top_1)).EndInit();
			this.Split_Top_1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Split_Top_2)).EndInit();
			this.Split_Top_2.ResumeLayout(false);
			this.Split_Right_Down.Panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Split_Right_Down)).EndInit();
			this.Split_Right_Down.ResumeLayout(false);
			this.Split_Mid_1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Split_Mid_1)).EndInit();
			this.Split_Mid_1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Split_Mid_2)).EndInit();
			this.Split_Mid_2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl MainTab;
		private System.Windows.Forms.TabPage Tab_MaterialsList;
		private System.Windows.Forms.ListBox Lb_MaterialsList;
		private System.Windows.Forms.Button btn_ClearAll;
		private System.Windows.Forms.Button btn_Delete;
		private System.Windows.Forms.Button btn_Change;
		private System.Windows.Forms.Button btn_Add;
		private System.Windows.Forms.TabPage Tab_MaterialProperty;
		private System.Windows.Forms.ToolTip MyToolTip;
		private System.Windows.Forms.SplitContainer Split_Main;
		private System.Windows.Forms.SplitContainer Split_Left_Top;
		private System.Windows.Forms.SplitContainer Split_Left_Down;
		private System.Windows.Forms.SplitContainer Split_Right_Top;
		private System.Windows.Forms.SplitContainer Split_Top_1;
		private System.Windows.Forms.SplitContainer Split_Top_2;
		private System.Windows.Forms.SplitContainer Split_Right_Down;
		private System.Windows.Forms.SplitContainer Split_Mid_1;
		private System.Windows.Forms.SplitContainer Split_Mid_2;
		private System.Windows.Forms.GroupBox Gb_Top_Left;
		private System.Windows.Forms.GroupBox GB_Mid_Left;
		private System.Windows.Forms.Label lb_Porsity;
		private System.Windows.Forms.TrackBar Track_Porosity;
		private System.Windows.Forms.Label lb_Percent;
		private System.Windows.Forms.NumericUpDown NumUp_Porosity;
		private System.Windows.Forms.ListBox lb_Composites;
		private System.Windows.Forms.ListBox lb_Armature;
		private System.Windows.Forms.TextBox Tb_1_Hb;
		private System.Windows.Forms.Label lb_alfa;
		private System.Windows.Forms.Label lb_lambda;
		private System.Windows.Forms.Label lb_Cp;
		private System.Windows.Forms.Label lb_p;
		private System.Windows.Forms.Label lb_sigma;
		private System.Windows.Forms.Label lb_E;
		private System.Windows.Forms.Label lb_Hb;
		private System.Windows.Forms.TextBox tb_7_alfa;
		private System.Windows.Forms.TextBox tb_6_lambda;
		private System.Windows.Forms.TextBox tb_5_Cp;
		private System.Windows.Forms.TextBox tb_4_p;
		private System.Windows.Forms.TextBox tb_3_sigma;
		private System.Windows.Forms.TextBox tb_2_E;
	}
}

