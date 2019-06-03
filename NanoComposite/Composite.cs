using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NanoComposite
{
	public class Composite : IEnumerable
	{
		List<Material> _listMaterials = new List<Material>();

		public Composite()
		{
			Coeficents = new Coeficents();
		}
		public Composite(Composite composite)
		{
			Coeficents = new Coeficents();
			foreach ( Material material in composite )
				Add(material);
		}
		public Coeficents Coeficents { get; set; }
		public IEnumerator GetEnumerator()
		{
			return _listMaterials.GetEnumerator();
		}
		public string Name { get; set; }
		public int Count { get { return _listMaterials.Count; }	}
		public Material this[int index]
		{
			get { return _listMaterials[index]; }
			set { _listMaterials[index] = value; }
		}
		public Material this[bool isMatrixIndex]
		{
			get { return _listMaterials.Find(p => p.isMatrix == isMatrixIndex); }
		}
		public void Add()
		{
			_listMaterials.Add(new Material());
		}
		public void Add( Material material )
		{
			_listMaterials.Add(material);
		}
		public void RemoveNull()
		{
			_listMaterials.RemoveAll(p => p.Name == null);
		}
	
	}
	public class Coeficents
	{
		double _porosity, _cofelasticity, _cofhardness, _factorkogezia, _cofstrength, _coftranscalency;
		public Coeficents() { }
		public double Porosity
		{
			get
			{
				return _porosity;
			}
			set
			{
				if ( 0 > value && value > 100 ) _porosity = 0;
				else _porosity = value;
			}
		}
		public double Elasticity
		{
			get
			{
				return _cofelasticity;
			}
			set
			{
				if ( 2.50 > value && value > 5.40 ) _cofelasticity = 2.50;
				else _cofelasticity = value;
			}
		}
		public double Hardness
		{
			get
			{
				return _cofhardness;
			}
			set
			{
				if ( 4.10 > value && value > 5.80 ) _cofhardness = 4.10;
				else _cofhardness = value;
			}
		}
		public double FactorKogezia
		{
			get
			{
				return _factorkogezia;
			}
			set
			{
				if ( 0.20 > value && value > 1 ) _factorkogezia = 0.20;
				else _factorkogezia = value;
			}
		}
		public double Strength
		{
			get
			{
				return _cofstrength;
			}
			set
			{
				if ( 4 > value && value > 1000000 ) _cofstrength = 4;
				else _cofstrength = value;
			}
		}
		public double ThermalConduct
		{
			get
			{
				return _coftranscalency;
			}
			set
			{
				if ( 0 > value && value > 3 ) _coftranscalency = 0;
				else _coftranscalency = value;
			}
		}

	}
}
