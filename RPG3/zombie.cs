﻿using System;
namespace RPG3
{
	public class zombie : enermy
	{
		public string weaponName { get; set; }

		public zombie(string name, string WeaponS)
			: base(name, WeaponS)
		{
			weaponName = WeaponS;

		}
		public override int _DamageSet()
		{
			_weaponDamage += 5;
			return _weaponDamage;
		}
		public override int _HealthSet()
		{
			_health += 80;
			return _health;
		}
		public override int _speedSet()
		{
			_speed += 2;
			return _health;
		}
		public override string ToString()
		{
			return $"enermy name = {_Name} {Environment.NewLine} health = {_health} {Environment.NewLine} speed = {_speed} {Environment.NewLine} weapon = {weaponName} {Environment.NewLine} weapon damage = {_weaponDamage}";
		}
	}
}
