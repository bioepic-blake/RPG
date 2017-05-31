using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Text;


namespace RPG3
{
	public abstract class enermy
	{
		public string _Name { get; set;}
		protected int _health = 0;
		protected int _speed = 0;
		protected int _weaponDamage = 0;

		public virtual int _DamageSet() { return _weaponDamage;}
		public virtual int _HealthSet() { return _health; }
		public virtual int _speedSet() { return _speed;}

		public enermy(string name)
		{
			_Name = name;
		}


		public override string ToString()
		{
			return $"[enermy: _Name={_Name}]";
		}
	}
}
