using UnityEngine;
using System;

namespace StressLevelZero.VRMK
{
	public class BodyBuilder : MonoBehaviour
	{
		[Serializable]
		public class References
		{
			public Transform skull;
			public Transform c1Offset;
			public Transform c4Vertebra;
			public Transform t1Offset;
			public Transform t7Vertebra;
			public Transform l1Vertebra;
			public Transform l3Vertebra;
			public Transform sacrum;
			public Transform feetCenter;
			public Transform leftClavicle;
			public Transform rightClavicle;
			public Transform leftRifleTarget;
			public Transform rightRifleTarget;
			public Transform leftShoulder;
			public Transform rightShoulder;
			public Transform leftElbow;
			public Transform rightElbow;
			public Transform leftWrist;
			public Transform rightWrist;
			public Transform leftCarpal;
			public Transform rightCarpal;
			public Transform leftHand;
			public Transform rightHand;
			public Transform leftHip;
			public Transform rightHip;
			public Transform leftKnee;
			public Transform rightKnee;
			public Transform leftAnkle;
			public Transform rightAnkle;
			public Transform leftFootBall;
			public Transform rightFootBall;
		}

		[Serializable]
		public class Hardpoints
		{
			public Transform Head;
			public Transform Mouth;
			public Transform BackLf;
			public Transform BackRt;
			public Transform ChestLf;
			public Transform ChestRt;
			public Transform BackMid;
			public Transform SideLf;
			public Transform SideRt;
			public Transform BackLow;
			public Transform BeltFront;
			public Transform BeltLf1;
			public Transform BeltRt1;
			public Transform BeltLf2;
			public Transform BeltRt2;
			public Transform ArmUpLf;
			public Transform ArmUpRt;
			public Transform WristLf;
			public Transform WristRt;
			public Transform LegUpLf;
			public Transform LegUpRt;
			public Transform LegLowLf;
			public Transform LegLowRt;
		}

		public SLZ_Body body;
		public References references;
		public Hardpoints hardpoints;
	}
}
