using System;
using System.Collections.Generic;
using CoreGraphics;
using UIKit;

namespace RPG3
{
	public class fieldVC : UIViewController
	{



		oldHouseVC OHvc;
		boatHouseVC BHvc;
		mineVC Mvc;
		forestVC FOrestvc;
		fieldVC Fvc;
		lakeVC Lvc;

		private UITextField _PlayerHealth;
		private UITextField _PlayerDamage;
		private UITextField _PlayerSpeed;

		private UITextField _EnermyHealth;
		private UITextField _Enermydamage;
		private UITextField _EnermySpeed;

		private UITextField _TfArea;
		private UITextField _tfAreaString;

		private UILabel _LblNarraterText;

		private UIButton _subButton;
		private UIButton _AddButton;
		private UIButton _travelBTN;

		public string Player_Health;
		public string Player_Damage;
		public string Player_Speed;


public string HealthPotsString;
		private string[] array1;
		private int movementNumber = 0;
		private string areaString;

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			NavigationItem.Title = "Field";
			View.BackgroundColor = UIColor.White;

		
			PHealth();
			PDamage();
			PSpeed();
			EHealth();
			EDamage();
			ESpeed();
			LblNt();
			TFareaNum();
			_tfAreaM();
			btnADDM();
			btnSub();
			TravelBTN();
			arrayArea();
			enermyIN();
			startAreaString();
                playerStatsM();

			_travelBTN.TouchUpInside += BtnTravelC;
			_subButton.TouchUpInside += BtnSubC;
			_AddButton.TouchUpInside += BtnAddC;
		}

		public void enermyIN()
		{
			enermy zombie = new zombie("crying zombie", "broken shild");

			List<enermy> enermys = new List<enermy>()
			{
				zombie
			};
			foreach (var i in enermys)
			{
				_EnermySpeed.Text = i._speedSet().ToString();
				_EnermyHealth.Text = i._HealthSet().ToString();
				_Enermydamage.Text = i._DamageSet().ToString();

			}


		}
//===================== bring in values from the player stat textfields
public void playerStatsM()
{


_PlayerHealth.Text = Player_Health;
_PlayerSpeed.Text = Player_Speed;
_PlayerDamage.Text = Player_Damage;
}


//================================= button controles 
private void BtnTravelC(object sender, EventArgs e)
{



	if (movementNumber == 0)
	{
		OHvc = new oldHouseVC();
		this.NavigationController.PushViewController(OHvc, true);

		OHvc.Player_Health = _PlayerHealth.Text;
		OHvc.Player_Speed = _PlayerSpeed.Text;
		OHvc.Player_Damage = _PlayerDamage.Text;


	}
	else if (movementNumber == 1)
	{
		BHvc = new boatHouseVC();
		this.NavigationController.PushViewController(BHvc, true);

		BHvc.Player_Health = _PlayerHealth.Text;
		BHvc.Player_Speed = _PlayerSpeed.Text;
		BHvc.Player_Damage = _PlayerDamage.Text;
	}
	else if (movementNumber == 2)
	{
		Mvc = new mineVC();
		this.NavigationController.PushViewController(Mvc, true);

		Mvc.Player_Health = _PlayerHealth.Text;
		Mvc.Player_Speed = _PlayerSpeed.Text;
		Mvc.Player_Damage = _PlayerDamage.Text;

	}
	else if (movementNumber == 3)
	{
		FOrestvc = new forestVC();
		this.NavigationController.PushViewController(FOrestvc, true);

		FOrestvc.Player_Health = _PlayerHealth.Text;
		FOrestvc.Player_Speed = _PlayerSpeed.Text;
		FOrestvc.Player_Damage = _PlayerDamage.Text;
	}
	else if (movementNumber == 4)
	{
		Fvc = new fieldVC();
		this.NavigationController.PushViewController(Fvc, true);

		Fvc.Player_Health = _PlayerHealth.Text;
		Fvc.Player_Speed = _PlayerSpeed.Text;
		Fvc.Player_Damage = _PlayerDamage.Text;
	}
	else if (movementNumber == 5)
	{
		Lvc = new lakeVC();
		this.NavigationController.PushViewController(Lvc, true);

		Lvc.Player_Health = _PlayerHealth.Text;
		Lvc.Player_Speed = _PlayerSpeed.Text;
		Lvc.Player_Damage = _PlayerDamage.Text;

		}


		}


		private void BtnSubC(object sender, EventArgs e)
		{

			if (movementNumber <= 0)
			{
				movementNumber = 0;
				_TfArea.Text = movementNumber.ToString();
			}
			else
			{
				movementNumber--;
				_TfArea.Text = movementNumber.ToString();
			}


			if (movementNumber == 0)
			{
				areaString = array1[0];
				_tfAreaString.Text = areaString;
			}
			else if (movementNumber == 1)
			{
				areaString = array1[1];
				_tfAreaString.Text = areaString;
			}
			else if (movementNumber == 2)
			{
				areaString = array1[2];
				_tfAreaString.Text = areaString;
			}
			else if (movementNumber == 3)
			{
				areaString = array1[3];
				_tfAreaString.Text = areaString;
			}
			else if (movementNumber == 4)
			{
				areaString = array1[4];
				_tfAreaString.Text = areaString;
			}
			else if (movementNumber == 5)
			{
				areaString = array1[5];
				_tfAreaString.Text = areaString;
			}

		}


		private void BtnAddC(object sender, EventArgs e)
		{

			if (movementNumber >= 5)
			{
				movementNumber = 5;
				_TfArea.Text = movementNumber.ToString();
			}
			else
			{
				movementNumber++;
				_TfArea.Text = movementNumber.ToString();
			}
			if (movementNumber == 0)
			{
				areaString = array1[0];
				_tfAreaString.Text = areaString;
			}
			else if (movementNumber == 1)
			{
				areaString = array1[1];
				_tfAreaString.Text = areaString;
			}
			else if (movementNumber == 2)
			{
				areaString = array1[2];
				_tfAreaString.Text = areaString;
			}
			else if (movementNumber == 3)
			{
				areaString = array1[3];
				_tfAreaString.Text = areaString;
			}
			else if (movementNumber == 4)
			{
				areaString = array1[4];
				_tfAreaString.Text = areaString;
			}
			else if (movementNumber == 5)
			{
				areaString = array1[5];
				_tfAreaString.Text = areaString;
			}
		}
//=========================== // fill in the travel textfild's at start of runtime
private void startAreaString()
{
	if (movementNumber == 0)
	{
		areaString = array1[4];
		_tfAreaString.Text = areaString;
		movementNumber = 4;
		_TfArea.Text = movementNumber.ToString();
	}	}

		//================================ page UI eliments 
		private void TravelBTN()
		{
			var rect = new CGRect(135, 555, 150, 50);
			_travelBTN = new UIButton(rect);
			_travelBTN.Layer.BorderWidth = 3f;
			_travelBTN.Layer.BorderColor = UIColor.Blue.CGColor;
			_travelBTN.Layer.CornerRadius = 15f;
			_travelBTN.BackgroundColor = UIColor.LightGray;
			_travelBTN.SetTitle("travel", UIControlState.Normal);
			View.Add(_travelBTN);
		}
		private void btnSub()
		{
			var rect = new CGRect(80, 555, 50, 50);
			_subButton = new UIButton(rect);
			_subButton.Layer.BorderWidth = 3f;
			_subButton.Layer.BorderColor = UIColor.Blue.CGColor;
			_subButton.Layer.CornerRadius = 15f;
			_subButton.BackgroundColor = UIColor.LightGray;
			_subButton.SetTitle("_", UIControlState.Normal);
			View.Add(_subButton);
		}
		private void btnADDM()
		{
			var rect = new CGRect(25, 555, 50, 50);
			_AddButton = new UIButton(rect);
			_AddButton.Layer.BorderWidth = 3f;
			_AddButton.Layer.BorderColor = UIColor.Blue.CGColor;
			_AddButton.Layer.CornerRadius = 15f;
			_AddButton.BackgroundColor = UIColor.LightGray;
			_AddButton.SetTitle("+", UIControlState.Normal);
			View.Add(_AddButton);
		}

		private void _tfAreaM()
		{
			var rect = new CGRect(80, 500, 150, 50);
			_tfAreaString = new UITextField(rect);
			_tfAreaString.Layer.BorderWidth = 3f;
			_tfAreaString.Layer.BorderColor = UIColor.Black.CGColor;
			_tfAreaString.Layer.CornerRadius = 5f;
			//_tfAreaString.Text = "field";
			_tfAreaString.TextAlignment = UITextAlignment.Center;

			View.Add(_tfAreaString);
		}
		private void TFareaNum()
		{
			var rect = new CGRect(25, 500, 50, 50);
			_TfArea = new UITextField(rect);
			_TfArea.Layer.BorderColor = UIColor.Black.CGColor;
			_TfArea.Layer.BorderWidth = 3f;
			_TfArea.Layer.CornerRadius = 5f;
			//_TfArea.Text = "0";
			_TfArea.TextAlignment = UITextAlignment.Center;
			View.Add(_TfArea);
		}
		//===================================== player stats
		private void LblNt()
		{
			var rect = new CGRect(25, 40, 300, 130);
			_LblNarraterText = new UILabel(rect);
			UILineBreakMode NSLineBreakByWordWrapping = default(UILineBreakMode);
			_LblNarraterText.LineBreakMode = NSLineBreakByWordWrapping;
			_LblNarraterText.Lines = 10;
			//_LblNarraterText.Layer.BorderWidth = 1f;
			//_LblNarraterText.Layer.BorderColor = UIColor.Black.CGColor;
			_LblNarraterText.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.";
			View.Add(_LblNarraterText);
		}

		//======================= player stats text fields
		public void PHealth()
		{
			var rect = new CGRect(25, 175, 100, 40);
			_PlayerHealth = new UITextField(rect);
			_PlayerHealth.Layer.BorderWidth = 3f;
			_PlayerHealth.Layer.BorderColor = UIColor.Green.CGColor;
			_PlayerHealth.TextAlignment = UITextAlignment.Center;
			_PlayerHealth.Text = $"{Player_Health}";
			View.Add(_PlayerHealth);
		}
		public void PDamage()
		{
			var rect = new CGRect(25, 230, 100, 40);
			_PlayerDamage = new UITextField(rect);
			_PlayerDamage.Layer.BorderColor = UIColor.Green.CGColor;
			_PlayerDamage.Layer.BorderWidth = 3f;
			_PlayerDamage.TextAlignment = UITextAlignment.Center;
			_PlayerDamage.Text = $"{Player_Damage}";
			View.Add(_PlayerDamage);

		}
		public void PSpeed()
		{
			var rect = new CGRect(25, 285, 100, 40);
			_PlayerSpeed = new UITextField(rect);
			_PlayerSpeed.Layer.BorderWidth = 3f;
			_PlayerSpeed.Layer.BorderColor = UIColor.Green.CGColor;
			_PlayerSpeed.TextAlignment = UITextAlignment.Center;
			_PlayerSpeed.Text = $"{Player_Speed}";
			View.Add(_PlayerSpeed);
		}
		//============================================== enermy stats
		public void EHealth()
		{
			var rect = new CGRect(225, 175, 100, 40);
			_EnermyHealth = new UITextField(rect);
			_EnermyHealth.Layer.BorderWidth = 3f;
			_EnermyHealth.Layer.BorderColor = UIColor.Red.CGColor;
			_EnermyHealth.TextAlignment = UITextAlignment.Center;
			//	_EnermyHealth.Text = "100";
			View.Add(_EnermyHealth);
		}
		public void EDamage()
		{
			var rect = new CGRect(225, 230, 100, 40);
			_Enermydamage = new UITextField(rect);
			_Enermydamage.Layer.BorderColor = UIColor.Red.CGColor;
			_Enermydamage.Layer.BorderWidth = 3f;
			_Enermydamage.TextAlignment = UITextAlignment.Center;
			//	_Enermydamage.Text = "10";
			View.Add(_Enermydamage);

		}
		public void ESpeed()
		{
			var rect = new CGRect(225, 285, 100, 40);
			_EnermySpeed = new UITextField(rect);
			_EnermySpeed.Layer.BorderWidth = 3f;
			_EnermySpeed.Layer.BorderColor = UIColor.Red.CGColor;
			_EnermySpeed.TextAlignment = UITextAlignment.Center;
			//_EnermySpeed.Text = "5";
			View.Add(_EnermySpeed);
		}
		private void arrayArea()
		{
			array1 = new string[6];
			array1[0] = "old house";
			array1[1] = "boat house";
			array1[2] = "mine";
			array1[3] = "forest";
			array1[4] = "field";
			array1[5] = "lake";
		}


		public fieldVC()
		{
		}
	}
}
