using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;
using NanoComposite.Properties;

namespace NanoComposite
{
	public partial class Main_Form : Form
	{
		public Main_Form()
		{
			InitializeComponent();
		}
		//создаем глобальные переменные
		Dictionary<string , double> CalcResult;
		Dictionary<string , Chart> Graphs;
		Hashtable HashTable_Active_Image, HashTable_Leave_Image;
		//Свойства
		List<Composite> _ListComposites { get; set; }
		Composite TmpComposite { get; set; }
		String[] NamesValue { get; set; }
		Bitmap[] IconsNormal { get; set; }
		Bitmap[] IconsActive { get; set; }

		private void Form1_Load( object sender , EventArgs e )
		{
			HashTable_Active_Image = new Hashtable();
			HashTable_Leave_Image = new Hashtable();
			//-------------------------------Строго соблюдать порядок---------------------------------------
			string[] keys_active_image = { "Добавить", "Отмена", "Удалить" , "Изменить" ,"Очистить","Сохранить"};
			//----------------------------------------------------------------------------------------------
			Bitmap[,] Images_ = {
				{	Resources.add_normal,Resources.Cancel_normal_32,Resources.delete_normal_32,
					Resources.edit_normal_32,Resources.refresh_normal_32,Resources.save_normal_32 },
				{	Resources.add_active,Resources.Cancel_active_32,Resources.delete_active_32,
					Resources.edit_active_32,Resources.refresh_active_32,Resources.save_active_32 } };
			//----------------------------------------------------------------------------------------------
			for ( int i = 0 ; i < keys_active_image.Length ; i++ )
			{
				HashTable_Active_Image.Add(keys_active_image[i] , Images_[1 , i]);
				HashTable_Leave_Image.Add(keys_active_image[i] , Images_[0 , i]);
			}

			CalcResult = new Dictionary<string , double>();
			Graphs = new Dictionary<string , Chart>();
			_ListComposites = new List<Composite>();
			NamesValue = new string[] { "Hardness" , "Elasticity" , "StrengthBeyond" , "Density" , "HeatCapacity" , "ThermalConduct" , "ThermalExpansion" };
			Label[] TitlesGraph = { lb_Hb , lb_E , lb_sigma , lb_p , lb_Cp , lb_lambda , lb_alfa };
			SplitterPanel[] panels = { Split_Top_1.Panel1, Split_Top_2.Panel1, Split_Top_2.Panel2,
			  Split_Mid_1.Panel1, Split_Mid_2.Panel1, Split_Mid_2.Panel2,
			Split_Right_Down.Panel2};

			int count = 0;
			foreach ( var item in NamesValue )
			{
				Graphs.Add(item , new Chart());
				//кладем его на форму и растягиваем на все окно.
				Graphs[item].Parent = panels[count];
				Graphs[item].Dock = DockStyle.Fill;
				//добавляем в Chart область для рисования графиков, их может быть
				//много, поэтому даем ей имя.
				Graphs[item].ChartAreas.Add(new ChartArea("Nano Composite Graph"));
				//Создаем и настраиваем набор точек для рисования графика, в том
				//не забыв указать имя области на которой хотим отобразить этот
				//набор точек.
				Graphs[item].Titles.Add(TitlesGraph[count++].Text);
			}

		}

		private void NumUp_Porosity_ValueChanged( object sender , EventArgs e )
		{
			if ( lb_Composites.SelectedItem != null )
			{
				Track_Porosity.Value = (int)NumUp_Porosity.Value;
				lb_Percent.Text = Track_Porosity.Value.ToString() + " %";
			}
			else
			{
				Track_Porosity.Value = 0;
				NumUp_Porosity.Value = Track_Porosity.Value;
				MessageBox.Show("Выберите Композит из списка.");
			}
		}
		private void Track_Porosity_Scroll( object sender , EventArgs e )
		{
			if ( lb_Composites.SelectedItem != null )
			{
				lb_Percent.Text = Track_Porosity.Value.ToString() + " %";
				NumUp_Porosity.Value = Track_Porosity.Value;
			}
			else
			{
				Track_Porosity.Value = 0;
				NumUp_Porosity.Value = Track_Porosity.Value;
				MessageBox.Show("Выберите Композит из списка.");
			}
		}
		private void btn_Add_Click( object sender , EventArgs e )
		{
			try
			{
				CreateMaterial_Form createMaterial_Form = new CreateMaterial_Form(false , new Composite());
				this.Hide();
				createMaterial_Form.ShowDialog();
				if ( createMaterial_Form.MyComposite.Name != null )
				{
					_ListComposites.Add(createMaterial_Form.MyComposite);
					Lb_MaterialsList.Items.Add(createMaterial_Form.MyComposite.Name);
				}
				createMaterial_Form.Dispose();
				this.Show();
			}
			catch ( Exception ex )
			{
				MessageBox.Show($"Ошибка : {ex.Message}");
			}

		}
		private void btn_Change_Click( object sender , EventArgs e )
		{
			if ( Lb_MaterialsList.SelectedItem != null )
			{
				CreateMaterial_Form createMaterial_Form = new CreateMaterial_Form(true , _ListComposites[Lb_MaterialsList.SelectedIndex]);
				this.Hide();
				createMaterial_Form.ShowDialog();
				if ( createMaterial_Form.MyComposite.Name != null )
				{
					_ListComposites[Lb_MaterialsList.SelectedIndex] = createMaterial_Form.MyComposite;
					Lb_MaterialsList.Items[Lb_MaterialsList.SelectedIndex] = createMaterial_Form.MyComposite.Name;
				}
				createMaterial_Form.Dispose();
				Lb_MaterialsList.Update();
				Lb_MaterialsList.Hide();
				Lb_MaterialsList.Show();
				this.Show();
			}
		}
		private void MainTab_SelectedIndexChanged( object sender , EventArgs e )
		{
			lb_Composites.Items.Clear();
			if ( MainTab.SelectedTab.Text == "Свойства Материала" )
				lb_Composites.Items.AddRange(Lb_MaterialsList.Items);
		}
		private void btn_Delete_Click( object sender , EventArgs e )
		{
			if ( Lb_MaterialsList.SelectedItem != null )
			{
				_ListComposites.Remove(_ListComposites[Lb_MaterialsList.SelectedIndex]);
				Lb_MaterialsList.Items.Remove(Lb_MaterialsList.SelectedItem);
				Lb_MaterialsList.Update();
			}
		}
		private void btn_ClearAll_Click( object sender , EventArgs e )
		{
			if ( Lb_MaterialsList.Items.Count > 0 )
			{
				_ListComposites.Clear();
				Lb_MaterialsList.Items.Clear();
				Lb_MaterialsList.Update();
			}
		}
		private void btn_MouseHover( object sender , EventArgs e )
		{
			// add cancel delete edit refresh save
			Button button = sender as Button;
			button.Image = new Bitmap((Image)HashTable_Active_Image[button.Tag]);
		}
		private void btn_MouseLeave( object sender , EventArgs e )
		{
			// add cancel delete edit refresh save
			Button button = sender as Button;
			button.Image = new Bitmap((Image)HashTable_Leave_Image[button.Tag]);
		}
		//--------------------------- 2 вкладка Свойства Материала -------------------------------
		/// <summary>
		/// Выбор композита из списка, загрузка его во временную переменную TmpComposite
		/// Создание всех графиков этого композита и высчитывание всех начальных значений Calculate_allData
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Lb_MaterialsList_SelectedIndexChanged( object sender , EventArgs e )
		{
			if ( lb_Composites.SelectedItem != null )
			{
				Split_Left_Down.Panel2.Enabled = true;
				TmpComposite = new Composite();
				TmpComposite = _ListComposites[lb_Composites.SelectedIndex];
				foreach ( var item in NamesValue )
					GetNewGraph(item);
				Calculate_allData();
			}
		}
		/// <summary>
		/// Вычисление значений при перемешении TrackBar
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Track_Porosity_ValueChanged( object sender , EventArgs e )
		{
			Calculate_allData();
		}
		private void Calculate_allData()
		{
			ReLoadCalcResult();
			double porosity = (double)NumUp_Porosity.Value * 0.01;	//Пористость
			Tb_1_Hb.Text = string.Format($"{CalculateParamsForData("Hardness" , porosity):F6}");            //Твердость
			tb_2_E.Text = string.Format($"{CalculateParamsForData("Elasticity" , porosity):F6}");           //Модуль упругости
			tb_3_sigma.Text = string.Format($"{CalculateParamsForData("StrengthBeyond" , porosity):F6}");   //Предел прочности
			tb_5_Cp.Text = string.Format($"{CalculateParamsForData("HeatCapacity" , porosity):F6}");        //Теплоемкость
			tb_4_p.Text = string.Format($"{CalculateParamsForData("Density" , porosity):F6}");              //Плотность
			tb_6_lambda.Text = string.Format($"{CalculateParamsForData("ThermalConduct" , porosity):F6}");  //Теплопроводность
			tb_7_alfa.Text = string.Format($"{CalculateParamsForData("ThermalExpansion" , porosity):E6}");  //Коэф.Терм.Расширения
		}
		private void GetNewGraph( string key , double value = 1 )//Пористость х(value)
		{
			Graphs[key].Series.Clear();
			ReLoadCalcResult();
			Series mySeriesOfPoint = new Series("Functions");
			mySeriesOfPoint.ChartType = SeriesChartType.FastLine;
			mySeriesOfPoint.ChartArea = "Nano Composite Graph";

			for ( double x = 0 ; x <= 100 ; x++ )
				mySeriesOfPoint.Points.AddXY(x , CalculateParamsForData(key , x * 0.01));//Вызов метода CalculateParamsForGraph("материал","процент пористости");

			//Добавляем созданный набор точек в Chart для построения графика
			Graphs[key].Series.Add(mySeriesOfPoint);
		}
		/// <summary>
		/// Возвращает значение поля KeyNames с вычисление его пористости porosity
		/// </summary>
		/// <param name="KeyNames">Название материала</param>
		/// <param name="porosity">Процент пористости</param>
		/// <returns></returns>
		private double CalculateParamsForData( string KeyNames , double porosity )
		{
			switch ( KeyNames )
			{
				case "Elasticity":
					foreach ( Material material in TmpComposite )
						CalcResult[KeyNames] = CalcPercent(material.Percent * 0.01 , KeyNames , material.Elasticity);
					return CalcResult[KeyNames] * Math.Exp(-TmpComposite.Coeficents.Elasticity * porosity);
				case "ThermalExpansion":
					double tempDivision = 0;
					foreach ( Material material in TmpComposite )
					{
						CalcResult[KeyNames] = CalcPercent(material.Percent * 0.01 , KeyNames , material.ThermalExpansion , material.ThermalConduct);
						tempDivision += material.Percent * material.ThermalConduct;
					}
					CalcResult[KeyNames] /= tempDivision;
					return CalcResult[KeyNames] * Math.Pow(1.0 - porosity , 1.0 / 3.0) * 10;
				case "Hardness":
					foreach ( Material material in TmpComposite )
						CalcResult[KeyNames] = CalcPercent(material.Percent * 0.01 , KeyNames , material.Hardness);
					return CalcResult[KeyNames] * Math.Exp(-TmpComposite.Coeficents.Hardness * porosity);
				case "StrengthBeyond":
					foreach ( Material material in TmpComposite )
						CalcResult[KeyNames] = CalcPercent(material.Percent * 0.01 , KeyNames , material.StrengthBeyond);
					if ( TmpComposite.Count == 4 )
						CalcResult[KeyNames] = TmpComposite[true].StrengthBeyond *
												( 1.0 - 1.21 * Math.Pow(1.0 - TmpComposite[true].Percent / 100.0 , 1.0 / 3.0) )
												* TmpComposite.Coeficents.FactorKogezia;
					return CalcResult[KeyNames] * Math.Exp(-TmpComposite.Coeficents.Strength * porosity);
				case "Density":
					foreach ( Material material in TmpComposite )
						CalcResult[KeyNames] = CalcPercent(material.Percent * 0.01 , KeyNames , material.Density);
					return CalcResult[KeyNames] * ( 1 - porosity );
				case "HeatCapacity":
					double tempForthermalCapacity = 1;
					foreach ( Material material in TmpComposite )
					{
						CalcResult[KeyNames] = CalcPercent(material.Percent * 0.01 , KeyNames , material.HeatCapacity);
						if ( material.isMatrix ) tempForthermalCapacity *= 0.2 * material.Percent * 0.01;
						else tempForthermalCapacity *= material.Percent * 0.01;
					}
					return CalcResult[KeyNames] *= ( 1.0 + tempForthermalCapacity );
				case "ThermalConduct":
					foreach ( Material material in TmpComposite )
						CalcResult[KeyNames] = CalcPercent(material.Percent * 0.01 , KeyNames , material.ThermalConduct);
					return CalcResult[KeyNames] * Math.Exp(-TmpComposite.Coeficents.ThermalConduct * porosity)*10;
				default:
					break;
			}
			return 0.0;
		}
		private double CalcPercent( double percent , string KeyNames , params double[] property )
		{
			if ( KeyNames == "ThermalExpansion" )
				return CalcResult[KeyNames] + property[0] * percent * property[1];//Для него немного по другому считается поэтому условие
			else
				return CalcResult[KeyNames] + property[0] * percent;
		}		
		private void NumUp_Porosity_KeyPress( object sender , KeyPressEventArgs e )
		{
			if ( e.KeyChar == (char)Keys.Enter )
			{
				NumUp_Porosity_ValueChanged(sender , null);
				Track_Porosity_ValueChanged(sender , null);
			}
		}
		/// <summary>
		/// Сброс значений для словаря CalcResult чере который осуществляется основные вычисления 
		/// </summary>
		private void ReLoadCalcResult()
		{
			CalcResult.Clear();
			foreach ( var item in NamesValue )
				CalcResult.Add(item , 0.0);
		}

		
	}
}
