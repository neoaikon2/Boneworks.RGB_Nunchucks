using System.Collections.Generic;
using StressLevelZero.Player;
using UnityEngine;

namespace StressLevelZero.Rig
{
	public class ControllerRig : Rig
	{
		public enum TraversalState
		{
			Idle = 0,
			Walk = 1,
			Jog = 2,
			Run = 3,
			Jump = 4,
			Leap = 5,
			Airborne = 6,
			HandClimb = 7,
			QuadClimb = 8,
			FootClimb = 9,
		}

		public enum VertState
		{
			Stand = 0,
			Crouch = 1,
			Kneel = 2,
			Prone = 3,
			Supine = 4,
			SitChair = 5,
			SitFloor = 6,
		}

		public enum ButtonMap
		{
			aLf = 0,
			bLf = 1,
			stickLf = 2,
			touchLf = 3,
			aRt = 4,
			bRt = 5,
			stickRt = 6,
			touchRt = 7,
		}

		public enum VrVertState
		{
			Stand = 0,
			Crouch = 1,
			Sit = 2,
			Kneel = 3,
			Prone = 4,
		}

		public enum DirectionMode
		{
			Controller = 0,
			Head = 1,
			Custom = 2,
		}

		public enum CurveMode
		{
			Linear = 0,
			Poles = 1,
			GenesisDpad = 2,
			Dpad = 3,
			SmoothGenesis = 4,
			SmoothDpad = 5,
		}

		[SerializeField]
		public List<ControllerInfo> controllerInfos;
		public BaseController leftController;
		public BaseController rightController;
		public Transform vrRoot;
		public bool primaryEnabled;
		public bool locoEnabled;
		public bool turnEnabled;
		public bool crouchEnabled;
		public bool jumpEnabled;
		public bool quickmenuEnabled;
		public bool slowMoEnabled;
		public bool isRightHanded;
		public bool autoLiftLegs;
		public bool doubleJump;
		public float maxVelocity;
		public float maxAcceleration;
		public float maxJerk;
		public float maxJounce;
		public float dragPerSec;
		public float sharpness;
		public float brakingMult;
		public TraversalState travState;
		public VertState vertState;
		public float feetOffset;
		public AnimationCurve JumpCurve;
		public float holdTrackedGround;
		public float holdLocoGround;
		public float holdPhysGround;
		public float debtApplierMult;
		public float realDeltaTime;
		public ButtonMap jump;
		public ButtonMap menuLf;
		public ButtonMap menuRt;
		public ButtonMap sprint;
		public ButtonMap slowMo;
		public AnimationCurve curve_Linear;
		public AnimationCurve curve_Poles;
		public AnimationCurve curve_Genesis;
		public AnimationCurve curve_Dpad;
		public AnimationCurve curve_SmoothGenesis;
		public AnimationCurve curve_SmoothDpad;
		public float snapCool;
		public float degreesPerSnap;
		public int snapDegreesPerFrame;
		public VrVertState vrVertState;
		public DirectionMode directionMode;
		public CurveMode curveMode;
		public Transform CustomDirection;
		public float maxMillimeters;
		public float maxDegreesSwing;
		public Transform leftFilter;
		public Transform rightFilter;
		public GameObject menu_UI_Left;
		public GameObject menu_UI_Right;
	}
}
