using UnityEngine;
using StressLevelZero.Rig;

namespace StressLevelZero.VRMK
{
	public class BodyVitals : MonoBehaviour
	{
		public enum ScaleMode
		{
			RealWorld = 0,
			CharacterRp = 1,
		}

		public float realWorldHeight;
		public float sittingOffset;
		public float playerHeight;
		public float floorOffset;
		public int loco_CurveMode;
		public int loco_Direction;
		public float loco_DegreesPerSnap;
		public int loco_SnapDegreesPerFrame;
		public float mod_globalHaptic;
		public float character_Height;
		public float character_Weight;
		public float cur_Strength;
		public float crouch_Speed;
		public float reverse_Speed;
		public float walk_Speed;
		public float jog_Speed;
		public float run_Speed;
		public float sprint_Speed;
		public float mod_Jump;
		public float blood_BPM;
		public float blood_Oxygen;
		public float use_Arm_L;
		public float use_Arm_R;
		public float use_Legs;
		public float cur_Speed;
		public float accumulated_Legs;
		public float accumulated_Arms;
		public float force_Jump;
		public bool locoEnabled;
		public bool turnEnabled;
		public bool crouchEnabled;
		public bool jumpEnabled;
		public bool quickmenuEnabled;
		public bool slowTimeEnabled;
		public bool isRightHanded;
		public Vector3 checkpointPosition;
		public Vector3 checkpointFwd;
		public bool fwdOnPort;
		public RigManager mngr_Rig;
		public float counterScaleCam;
		public ScaleMode scaleMode;
	}
}
