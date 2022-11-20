using UnityEngine;
using System;

namespace StressLevelZero.VRMK
{
	public class SLZ_BodyBlender : MonoBehaviour
	{
		[Serializable]
		public class Bones
		{
			public Transform playerRoot;
			public Transform head;
			public Transform neck;
			public Transform spineEnd;
			public Transform spineHi;
			public Transform spineMid;
			public Transform spineLow;
			public Transform hip;
			public Transform lfClav;
			public Transform lfScapula;
			public Transform lfUpperTwist;
			public Transform lfUpArm;
			public Transform lfElbow;
			public Transform lfTwist;
			public Transform lfWrist;
			public Transform lfCarpal;
			public Transform lfHand;
			public Transform rtClav;
			public Transform rtScapula;
			public Transform rtUpperTwist;
			public Transform rtUpArm;
			public Transform rtElbow;
			public Transform rtTwist;
			public Transform rtWrist;
			public Transform rtCarpal;
			public Transform rtHand;
			public Transform lfUpLeg;
			public Transform lfKnee;
			public Transform lfAnkle;
			public Transform lfBall;
			public Transform rtUpLeg;
			public Transform rtKnee;
			public Transform rtAnkle;
			public Transform rtBall;
			public Transform lfThumb1;
			public Transform lfIndex1;
			public Transform lfMiddle1;
			public Transform lfRing1;
			public Transform lfLittle1;
			public Transform rtThumb1;
			public Transform rtIndex1;
			public Transform rtMiddle1;
			public Transform rtRing1;
			public Transform rtLittle1;
		}

		[Serializable]
		public class MKBody
		{
			public Transform skull;
			public Transform c4Vert;
			public Transform t1Vert;
			public Transform t7Vert;
			public Transform l1Vert;
			public Transform l3Vert;
			public Transform sacrum;
			public Transform feetCenter;
			public Transform lfClav;
			public Transform lfScapula;
			public Transform lfShoulder;
			public Transform lfElbow;
			public Transform lfWrist;
			public Transform lfCarpal;
			public Transform lfHand;
			public Transform rtClav;
			public Transform rtScapula;
			public Transform rtShoulder;
			public Transform rtElbow;
			public Transform rtWrist;
			public Transform rtCarpal;
			public Transform rtHand;
			public Transform lfHip;
			public Transform lfKnee;
			public Transform lfAnkle;
			public Transform lfBall;
			public Transform rtHip;
			public Transform rtKnee;
			public Transform rtAnkle;
			public Transform rtBall;
		}

		[Serializable]
		public class PosOff
		{
			public Vector3 playerRoot;
			public Vector3 head;
			public Vector3 neck;
			public Vector3 spineEnd;
			public Vector3 spineHi;
			public Vector3 spineMid;
			public Vector3 spineLow;
			public Vector3 hip;
			public Vector3 lfClav;
			public Vector3 lfScapula;
			public Vector3 lfUpArm;
			public Vector3 lfElbow;
			public Vector3 lfWrist;
			public Vector3 lfCarpal;
			public Vector3 lfHand;
			public Vector3 rtClav;
			public Vector3 rtScapula;
			public Vector3 rtUpArm;
			public Vector3 rtElbow;
			public Vector3 rtWrist;
			public Vector3 rtCarpal;
			public Vector3 rtHand;
			public Vector3 lfUpLeg;
			public Vector3 lfKnee;
			public Vector3 lfAnkle;
			public Vector3 lfBall;
			public Vector3 rtUpLeg;
			public Vector3 rtKnee;
			public Vector3 rtAnkle;
			public Vector3 rtBall;
		}

		[Serializable]
		public class RotOff
		{
			public Vector3 playerRoot;
			public Vector3 head;
			public Vector3 neck;
			public Vector3 spineEnd;
			public Vector3 spineHi;
			public Vector3 spineMid;
			public Vector3 spineLow;
			public Vector3 hip;
			public Vector3 lfClav;
			public Vector3 lfScapula;
			public Vector3 lfUpArm;
			public Vector3 lfElbow;
			public Vector3 lfWrist;
			public Vector3 lfCarpal;
			public Vector3 lfHand;
			public Vector3 rtClav;
			public Vector3 rtScapula;
			public Vector3 rtUpArm;
			public Vector3 rtElbow;
			public Vector3 rtWrist;
			public Vector3 rtCarpal;
			public Vector3 rtHand;
			public Vector3 lfUpLeg;
			public Vector3 lfKnee;
			public Vector3 lfAnkle;
			public Vector3 lfBall;
			public Vector3 rtUpLeg;
			public Vector3 rtKnee;
			public Vector3 rtAnkle;
			public Vector3 rtBall;
		}

		public enum CharSpecific
		{
			Brett = 0,
			Jimmy = 1,
			Steve = 2,
			Skele = 3,
			StickBoy = 4,
		}

		public float elbowBlendShape;
		public float shoulderBlendShape;
		public float wristBlendShape;
		public SkinnedMeshRenderer bodyMesh01;
		public SkinnedMeshRenderer lfHandMesh;
		public SkinnedMeshRenderer rtHandMesh;
		public Transform leftKneePad;
		public Transform rightKneePad;
		public float twistPosWeight;
		public float twistRotWeight;
		public float twistUpperArmWeight;
		public CharSpecific charSpecific;
		public float characterHeight;
		public AnimationCurve FingerBlendCurve;
		public bool offsetsDirty;
		public Bones bones;
		public MKBody mkbody;
		public PosOff posOff;
		public RotOff rotOff;
		public SLZ_Body mkRefs;
	}
}
