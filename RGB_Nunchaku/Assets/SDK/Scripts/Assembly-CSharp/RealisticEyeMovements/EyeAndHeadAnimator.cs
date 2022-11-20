using UnityEngine;

namespace RealisticEyeMovements
{
	public class EyeAndHeadAnimator : MonoBehaviour
	{
		public float headSpeedModifier;
		public float headWeight;
		public Transform headBoneNonMecanimXform;
		public bool useMicroSaccades;
		public bool useMacroSaccades;
		public bool useHeadJitter;
		public bool kDrawSightlinesInEditor;
		public bool areUpdatedControlledExternally;
		public ControlData controlData;
		public float kMinNextBlinkTime;
		public float kMaxNextBlinkTime;
		public float blinkSpeed;
		public bool eyelidsFollowEyesVertically;
		public float maxEyeHorizAngle;
		public float maxEyeHorizAngleTowardsNose;
		public float crossEyeCorrection;
		public float nervousness;
		public float limitHeadAngle;
	}
}
