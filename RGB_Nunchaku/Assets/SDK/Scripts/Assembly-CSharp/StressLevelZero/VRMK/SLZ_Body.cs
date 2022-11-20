using UnityEngine;
using System;
using StressLevelZero.SFX;

namespace StressLevelZero.VRMK
{
	public class SLZ_Body : MonoBehaviour
	{
		[Serializable]
		public class Spine
		{
			public bool computeVelocity;
			public bool thoracicLumbarSpine;
			public bool feetCenter;
			public Vector4 cervicalRom;
			public Vector4 thoracicRom;
			public Vector4 lumbarRom;
			public float trackedPelvisWeight;
			public bool noSlerp;
			public float accelLeanWeight;
			public float dragWeight;
			public float pACdProduct;
			public float accelDragTan;
			public float dragTan;
			public Vector3 dragUpDir;
			public Vector3 centerOfMassW;
			public float angularVelocity;
			public Vector3 velocitySanGrav;
			public Vector3 accelerationSanGrav;
			public Vector3 velocitySanGravNormal;
			public Vector3 accelerationSanGravNormal;
			public float velocitySanGravMag;
			public AnimationCurve UpOffsetCurve;
			public AnimationCurve sacrumUpOffsetCurve;
			public AnimationCurve NeckTiltCurve;
			public AnimationCurve thoracicTwistCurve;
			public AnimationCurve AngleCurve;
			public AnimationCurve T1DirectionCurve;
			public AnimationCurve T1TiltZCurve;
			public AnimationCurve T1TiltXCurve;
			public float spineCrouchOffset;
		}

		[Serializable]
		public class Clavicles
		{
			public float clavicalLengthFactor;
			public AnimationCurve ClavicleReachCurve;
			public AnimationCurve ClavZCurve;
			public AnimationCurve ClavYCurve;
		}

		[Serializable]
		public class Arms
		{
			public bool solveArms;
			public bool limitHandPosition;
			public float armLengthFactor;
			public bool armStretching;
			public float maxStretchFactor;
			public float stretchThreshold;
			public float stretchRatio;
			public bool wristRelax;
			public bool computeIk;
			public Vector3 leftHandVector3;
			public Vector3 rightHandVector3;
			public float armMagLf;
			public float armMagRt;
			public AnimationCurve ArmStretchCurve;
			public AnimationCurve WristPositionOverrideCurve;
			public AnimationCurve WristTwistRelaxCurve;
			public AnimationCurve WristElbowIsNotCurve;
			public AnimationCurve WristTwistRelax180Curve;
			public AnimationCurve ElbowLimitCurve;
			public float oldMaxStretchFactor;
			public float oldStretchThreshold;
			public float oldStretchRatio;
			public float leftHandTwist;
			public float rightHandTwist;
			public float leftHandDevia;
			public float rightHandDevia;
			public float leftWristRelaxLerp;
			public float rightWristRelaxLerp;
			public bool forearmLfColliding;
			public Vector3 forearmLfCollisionPoint;
			public Vector3 forearmLfCollisionNorm;
			public float collisionLfInfluence;
		}

		[Serializable]
		public class Legs
		{
			public bool solveLegs;
		}

		[Serializable]
		public class Gear
		{
			public float upshiftVel;
			public float downshiftVel;
			public AnimationCurve stepHeight;
			public AnimationCurve heelHeight;
			public AnimationCurve stepHeightBackwards;
			public AnimationCurve heelHeightBackwards;
			public AnimationCurve StepProgressThreshVCurve;
			public AnimationCurve StepSpeedVCurve;
			public AnimationCurve StepLandingZoneVCurve;
			public AnimationCurve StepZInterpolationVCurve;
		}

		[Serializable]
		public class Grounder
		{
			public enum Quality
			{
				ToeRay = 0,
				ToeHeelRay = 1,
			}

			public bool useGrounder;
			public LayerMask layers;
			public Quality quality;
			public float maxStep;
			public float maxFootRotationAngle;
			public float footSpeed;
			public float footRotationSpeed;
		}

		[Serializable]
		public class Locomotion
		{
			public float stepThreshold;
			public float stepProgressThreshold;
			public float angleThreshold;
			public float stepLZ;
			public float stepSpeed;
			public AnimationCurve FootDistanceVCurve;
			public AnimationCurve StepThresholdVCurve;
			public float relaxLegTwistMinAngle;
			public float animCycle;
			public int gear;
			public SLZ_Body.Gear[] gears;
			public SLZ_Body.Grounder grounder;
			public AnimationCurve stepHeight;
			public AnimationCurve heelHeight;
			public AnimationCurve stepHeightBackwards;
			public AnimationCurve heelHeightBackwards;
			public AnimationCurve StepProgressThreshVCurve;
			public AnimationCurve StepSpeedVCurve;
			public AnimationCurve StepLandingZoneVCurve;
			public AnimationCurve StepZInterpolationVCurve;
			public FootstepSFX leftStepSfx;
			public FootstepSFX rightStepSfx;
		}

		[Serializable]
		public class FollowObjects
		{
			public Transform head;
			public Transform chest;
			public Transform leftHand;
			public Transform rightHand;
			public Transform pelvis;
			public Transform lfFoot;
			public Transform rtFoot;
			public Transform playerRoot;
		}

		[Serializable]
		public class References
		{
			public Transform skull;
			public Transform c4Vertebra;
			public Transform t1Offset;
			public Transform t7Vertebra;
			public Transform l1Vertebra;
			public Transform l3Vertebra;
			public Transform sacrum;
			public Transform feetCenter;
			public Transform leftClavicle;
			public Transform rightClavicle;
			public Transform lfScapula;
			public Transform rtScapula;
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
			public Transform SideLf;
			public Transform SideRt;
			public Transform BeltFront;
			public Transform BeltLf1;
			public Transform BeltRt1;
		}

		public float playerHeight;
		public bool timeSolve;
		public Spine spine;
		public Clavicles clavicles;
		public Arms arms;
		public Legs legs;
		public Locomotion locomotion;
		public float armLength;
		public float upperArmLength;
		public float forearmLength;
		public float clavicleLength;
		public float upperLegLength;
		public float lowerLegLength;
		public float footLength;
		public float carpalLength;
		public FollowObjects followObjects;
		public SLZ_BodyBlender ArtToBlender;
		public References references;
		public Hardpoints hardpoints;
	}
}
