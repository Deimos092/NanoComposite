using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NanoComposite.Properties;

namespace NanoComposite
{
	public partial class CreateMaterial_Form : Form
	{
		public CreateMaterial_Form( bool isChange , Composite mycomp )
		{
			IsChangeClick = isChange;
			MyComposite = mycomp;

			if ( !IsChangeClick )
				MyComposite.Add();

			InitializeComponent();
		}

		Hashtable HashTable_Active_Image, HashTable_Leave_Image;
		internal Composite MyComposite { get; set; }//Композит из нескольких материалов
		private int Mindex { get; set; }//Индекс материала в композите выбранный из таблицы
		public bool IsChangeClick { get; set; }
		private bool IsCoefficentClicked { get; set; }
		private List<NumericUpDown> _ListNumupForDataGrid { get; set; }
		private void CreateMaterial_Form_Load( object sender , EventArgs e )
		{
			HashTable_Active_Image = new Hashtable();
			HashTable_Leave_Image = new Hashtable();
			//-------------------------------Строго соблюдать порядок---------------------------------------
			string[] keys_active_image = { "Добавить" , "Отмена" , "Удалить" , "Изменить" , "Очистить" , "Сохранить" };
			//----------------------------------------------------------------------------------------------
			Bitmap[,] Images_ = {
				{   Resources.add_normal,Resources.Cancel_normal_32,Resources.delete_normal_32,
					Resources.edit_normal_32,Resources.refresh_normal_32,Resources.save_normal_32 },
				{   Resources.add_active,Resources.Cancel_active_32,Resources.delete_active_32,
					Resources.edit_active_32,Resources.refresh_active_32,Resources.save_active_32 } };
			//----------------------------------------------------------------------------------------------
			for ( int i = 0 ; i < keys_active_image.Length ; i++ )
			{
				HashTable_Active_Image.Add(keys_active_image[i] , Images_[1 , i]);
				HashTable_Leave_Image.Add(keys_active_image[i] , Images_[0 , i]);
			}
			Mindex = 0;//Индекс материала в композите
			IsCoefficentClicked = false;//флаг на проверку страницы с коэфицентами
			dgv_main.AllowUserToAddRows = false;//Убираем пустую строку у таблицы по дефолту
		}
		private void CreateMaterial_Form_Activated( object sender , EventArgs e )
		{
			if ( IsChangeClick )
			{
				for ( int i = 0, j = 1 ; i < MyComposite.Count - 1 ; i++, j = 1 )
				{
					dgv_main.Rows.Add();
					dgv_main.Rows[i].Cells[j++].Value = MyComposite[i].Name;            //Имя
					dgv_main.Rows[i].Cells[j++].Value = MyComposite[i].Percent;         //Доля
					dgv_main.Rows[i].Cells[j++].Value = MyComposite[i].Hardness;        //Твердость
					dgv_main.Rows[i].Cells[j++].Value = MyComposite[i].Elasticity;      //Модуль упругости
					dgv_main.Rows[i].Cells[j++].Value = MyComposite[i].StrengthBeyond;  //Предел прочности
					dgv_main.Rows[i].Cells[j++].Value = MyComposite[i].Density;         //Плотность
					dgv_main.Rows[i].Cells[j++].Value = MyComposite[i].HeatCapacity;    //Теплоемкость
					dgv_main.Rows[i].Cells[j++].Value = MyComposite[i].ThermalConduct;    //Теплопроводность
					dgv_main.Rows[i].Cells[j++].Value = MyComposite[i].ThermalExpansion;//Коэф.Терм.Расширения

				}
				IsChangeClick = false;
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
		//------------------------------------------------------------- Проверки и добавление в таблицу datagridview --------------------------------
		//Проверка всех NumericUpDown на 0 значения
		bool IsGoodToAddNew()
		{
			bool flag = false;
			GetNumericControls(MainGroupBox.Controls);//Добавляем все NumericUpDown в список

			foreach ( var item in _ListNumupForDataGrid )
			{
				if ( item.Value == 0 )
				{
					item.BackColor = Color.FromArgb(255 , 205 , 205);
					flag = true;
				}
			}
			if ( flag )
			{
				MessageBox.Show($"Проверьте значение ячеек");
				return false;
			}
			return true;
		}

		//Добавляем все NumericUpDown в список
		void GetNumericControls( Control.ControlCollection Rootcontrol )
		{
			_ListNumupForDataGrid = new List<NumericUpDown>();
			foreach ( var item in MainGroupBox.Controls )
				if ( item is NumericUpDown numericUp ) _ListNumupForDataGrid.Add(numericUp);
			_ListNumupForDataGrid = _ListNumupForDataGrid.OrderBy(x => x.TabIndex).ToList();
		}

		//Добавление ТОЛЬКО в таблицу значений из NumericUpDown
		private void btn_Add_Click( object sender , EventArgs e )
		{
			if ( rb_VolumePercent.Checked )//Если включен radioButton Обьемные проценты
			{
				if ( tb_NameMaterial.Text == "" )//Проверка на ввод имени
				{
					MessageBox.Show("Введите название материала");
					tb_NameMaterial.Select();
				}
				if ( IsGoodToAddNew() )//Проверка всех NumericUpDown на 0 значения
				{
					int index = dgv_main.Rows.Count;
					dgv_main.Rows.Add();

					dgv_main.Rows[index].Cells[1].Value = tb_NameMaterial.Text;//2 ячейка ввод названия материала
					int countColumns = dgv_main.Columns.GetColumnCount(DataGridViewElementStates.Visible);//Кол-во колонок

					for ( int i = 2, j = 0 ; i < countColumns ; i++ )
						dgv_main.Rows[index].Cells[i].Value = _ListNumupForDataGrid[j++].Value;//Заносим в ячейки значения
				}
			}

			if ( rb_MassivePercent.Checked )
			{
				bool flag = false;
				for ( int i = 0 ; i < dgv_main.Rows.Count ; i++ )
				{
					bool isMatrix = Convert.ToBoolean(dgv_main.Rows[i].Cells[0].Value);
					if ( isMatrix == true )
					{
						flag = true;
						if ( tb_NameMaterial.Text == "" )//Проверка на ввод имени
						{
							MessageBox.Show("Введите название материала");
							tb_NameMaterial.Select();
							break;
						}
						if ( IsGoodToAddNew() )//Проверка всех NumericUpDown на 0 значения
						{
							int index = dgv_main.Rows.Count;
							dgv_main.Rows.Add();

							dgv_main.Rows[index].Cells[1].Value = tb_NameMaterial.Text;//2 ячейка ввод названия материала
							int countColumns = dgv_main.Columns.GetColumnCount(DataGridViewElementStates.Visible);//Кол-во колонок

							for ( int x = 2, j = 0 ; x < countColumns ; x++ )
								dgv_main.Rows[index].Cells[x].Value = _ListNumupForDataGrid[j++].Value;//Заносим в ячейки значения
						}
						break;
					}
				}
				if ( !flag )
				{
					MessageBox.Show("Для работы с объемным содержанием армирующей фазы выберите матрицу!");
				}
			}
		}
		//-------------------------------------------------------------------------------------------------------------------------------------------

		//----------------------------------------------------------------- Кнопка СОХРАНИТЬ и все ее исходящие проверки ----------------------------
		//Проверка процентной доли всех материалов, они должны быть = 100%
		bool ChekCapacity()
		{
			double percent = 0;
			for ( int i = 0 ; i < dgv_main.Rows.Count ; i++ )
				percent += Convert.ToDouble(dgv_main["Volume" , i].Value);

			if ( percent != 100 )
				MessageBox.Show("Проверьте процентное соотношение доли! Оно не равно 100%");
			else
				return true;

			return false;
		}

		//Кнопка СОХРАНИТЬ
		private void btn_Save_Click( object sender , EventArgs e )
		{
			if ( IsCoefficentClicked & ChekCapacity() )
			{
				dgv_main_CellContentClick(sender , null);
				for ( int index = 0, j = 0 ; index < dgv_main.Rows.Count ; index++, j = 0, MyComposite.Add() )
				{
					MyComposite[index].isMatrix = Convert.ToBoolean(dgv_main[j++ , index].Value);         //Выбраная матрица
					MyComposite[index].Name = dgv_main[j++ , index].Value.ToString();                     //Имя
					MyComposite[index].Percent = Convert.ToDouble(dgv_main[j++ , index].Value);           //Доля
					MyComposite[index].Hardness = Convert.ToDouble(dgv_main[j++ , index].Value);          //Твердость
					MyComposite[index].Elasticity = Convert.ToDouble(dgv_main[j++ , index].Value);        //Модуль упругости
					MyComposite[index].StrengthBeyond = Convert.ToDouble(dgv_main[j++ , index].Value);    //Предел прочности
					MyComposite[index].Density = Convert.ToDouble(dgv_main[j++ , index].Value);           //Плотность
					MyComposite[index].HeatCapacity = Convert.ToDouble(dgv_main[j++ , index].Value);      //Теплоемкость
					MyComposite[index].ThermalConduct = Convert.ToDouble(dgv_main[j++ , index].Value);    //Теплопроводность
					MyComposite[index].ThermalExpansion = Convert.ToDouble(dgv_main[j , index].Value);    //Коэф.Терм.Расширения
				}
				MyComposite.RemoveNull();
				Mindex = dgv_main.CurrentRow.Index;//возращаем индекс выделеной строки материала

				//Еще раз пересчитываем Долю на всякий случай при сохранении
				ReCalc_Percent(( rb_MassivePercent.Checked ) ? rb_MassivePercent.Name : rb_VolumePercent.Name);

				//------------------------------------------------------------------------------------------------------------------
				// Сделано
				//------------------------------------------------------------------------------------------------------------------
				MyComposite.Name = string.Format($"{MyComposite[Mindex].Name} + ");
				for ( int i = 0 ; i < dgv_main.Rows.Count ; i++ )
					if ( i != Mindex )
						MyComposite.Name += string.Format($"{MyComposite[i].Name} {MyComposite[i].Percent:F1}% + ");
				MyComposite.Name = MyComposite.Name.Substring(0 , MyComposite.Name.LastIndexOf('+') - 1);
				//------------------------------------------------------------------------------------------------------------------
				//------------------------------------------------------------------------------------------------------------------
				
				this.Close();
			}
			else
			{
				MessageBox.Show("Проверьте коэфиценты");
				TabControl_AddMaterials.SelectTab(tabPage2);//Переходим на страницу коэфицентов
			}
		}

		//Заносим коэфиценты в наш обьект как только страница была открыта
		private void TabControl_AddMaterials_SelectedIndexChanged( object sender , EventArgs e )
		{
			if ( TabControl_AddMaterials.SelectedTab.Text == "Коэффиценты Материала" )
			{
				//--------------------------------- Заносим коэфиценты ----------------------------
				IsCoefficentClicked = true;//Булевское свойство "Флаг" на проверку этой страницы ставим на true

				MyComposite.Coeficents.Porosity = (double)NumUp_Porosity.Value;        //Пористость %
				MyComposite.Coeficents.Elasticity = (double)NumUp_Elasticity.Value;    //Коэфицент Упругости
				MyComposite.Coeficents.Hardness = (double)NumUp_Hardness.Value;        //Коэфицент Твердости
				MyComposite.Coeficents.FactorKogezia = (double)NumUp_Cogezy.Value;     //Фактор Когезии
				MyComposite.Coeficents.Strength = (double)NumUp_Strength.Value;        //Коэфицент Прочности
				MyComposite.Coeficents.ThermalConduct = (double)NumUp_Termal.Value;      //Коэфицент Теплопроводности
			}
		}
		//-------------------------------------------------------------------------------------------------------------------------------------------

		//Изменяем наименование Доли radiobutton
		private void rb_ChangeCapacity_CheckedChanged( object sender , EventArgs e )
		{
			RadioButton radioButton = sender as RadioButton;
			if ( radioButton.Name == "rb_VolumePercent" )
			{
				lb_Capacity.Text = "V - Обьемная доля, %";
				ReCalc_Percent(radioButton.Name);
			}
			else
			{
				lb_Capacity.Text = "X - массовая доля, %";
				ReCalc_Percent(radioButton.Name);
			}
		}

		//Пересчитываем долю процент у каждой матрицы или у 1ой
		private void ReCalc_Percent( string radiobutton )
		{
			if ( MyComposite[Mindex].Percent > 0 )
			{
				if ( dgv_main.Rows.Count < 2 )//Если всего 1 матрица
				{
					double value = MyComposite[Mindex].Percent / 100;
					MyComposite[Mindex].Percent = ( value / ( value + ( 1 - value ) ) ) * 100;
				}
				else
				{
					bool flag = false;
					double matrixDensity = -1;
					for ( int i = 0 ; i < dgv_main.Rows.Count ; i++ )//Находим матрицу которая выделена
					{
						bool isMatrix = (bool)dgv_main.Rows[i].Cells[0].Value;//Находим матрицу которая выделена в chekbox
						if ( isMatrix )
						{
							flag = true;
							matrixDensity = Convert.ToDouble(dgv_main.Rows[i].Cells[5].Value);
							double tempPercent = MyComposite[Mindex].Percent / 100;

							switch ( radiobutton )
							{
								case "rb_VolumePercent":
									tempPercent = ( tempPercent / ( tempPercent + ( 1 - tempPercent ) * matrixDensity / MyComposite[Mindex].Density ) ) * 100;
									break;
								case "rb_MassivePercent":
									tempPercent = ( tempPercent / ( tempPercent + ( 1 - tempPercent ) * MyComposite[Mindex].Density / matrixDensity ) ) * 100;
									break;
							}
							MyComposite[Mindex].Percent = tempPercent;
							break;
						}
					}
					if ( !flag )
					{
						MessageBox.Show("Для работы с объемным содержанием армирующей фазы выберите матрицу!");
						rb_MassivePercent.Checked = true;
					}
				}
			}
		}

		//-------------------------------------------------- Мелкие проверки и обновления данных -------------------------
		//Обновляем значения в обьекте если их изменил пользователь
		private void NumUp_ValueChanged( object sender , EventArgs e )
		{
			NumericUpDown numericUp = sender as NumericUpDown;
			switch ( numericUp.Tag )//Да по тегу нахожу, ничего лучше не придумал
			{
				case "Porosity":
					MyComposite.Coeficents.Porosity = (double)numericUp.Value;         //Пористость %
					break;
				case "CofElasticity":
					MyComposite.Coeficents.Elasticity = (double)numericUp.Value;    //Коэфицент Упругости
					break;
				case "CofHardness":
					MyComposite.Coeficents.Hardness = (double)numericUp.Value;      //Коэфицент Твердости
					break;
				case "FactorKogezia":
					MyComposite.Coeficents.FactorKogezia = (double)numericUp.Value;    //Фактор Когезии
					break;
				case "CofStrength":
					MyComposite.Coeficents.Strength = (double)numericUp.Value;      //Коэфицент Прочности
					break;
				case "CofTranscalency":
					MyComposite.Coeficents.ThermalConduct = (double)numericUp.Value;  //Коэфицент Теплопроводности
					break;
			}
		}

		private void btn_Cancel_Click( object sender , EventArgs e )
		{
			this.Close();
			this.Dispose(true);
		}
		private void btn_Delete_Click( object sender , EventArgs e )
		{
			try
			{
				if ( dgv_main.Rows.Count > 1 )
					dgv_main.Rows.RemoveAt(dgv_main.CurrentCell.RowIndex);
			}
			catch ( Exception ex )
			{
				MessageBox.Show("Ошибка при удалении строки!\n{0}" , ex.Message);
			}
		}

		//Красим обратно в белый если был закрашен в крассный из метода IsGoodToAddNew()
		private void NumUp_MouseClick( object sender , MouseEventArgs e )
		{
			NumericUpDown numeric = sender as NumericUpDown;
			numeric.BackColor = Color.White;
		}

		private void dgv_main_CellContentClick( object sender , DataGridViewCellEventArgs e )
		{
			Mindex = dgv_main.CurrentRow.Index;
			//Очистим все строчки
			foreach ( DataGridViewRow row in dgv_main.Rows )
				row.Cells["Matrix"].Value = false;

			//Выберем текущую
			dgv_main.CurrentRow.Cells["Matrix"].Value = true;

		}


	}
}
