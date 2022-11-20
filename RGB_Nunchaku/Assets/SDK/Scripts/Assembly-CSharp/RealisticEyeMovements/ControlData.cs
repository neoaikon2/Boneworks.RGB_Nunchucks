using System;
using UnityEngine;

namespace RealisticEyeMovements
{
	[Serializable]
	public class ControlData
	{
		[Serializable]
		public class EyelidPositionBlendshape
		{
			public SkinnedMeshRenderer skinnedMeshRenderer;
			public float defaultWeight;
			public float positionWeight;
			public int index;
			public string name;
			public bool isUsedInEalierConfig;
		}

		[Serializable]
		public class BlendshapesConfig
		{
			public SkinnedMeshRenderer skinnedMeshRenderer;
			public int blendShapeCount;
			public string[] blendshapeNames;
			public float[] blendshapeWeights;
		}

		public enum EyeControl
		{
			None = 0,
			MecanimEyeBones = 1,
			SelectedObjects = 2,
		}

		public enum EyelidControl
		{
			None = 0,
			Bones = 1,
			Blendshapes = 2,
			MCS_Blendshapes = 3,
		}

		public enum EyelidBoneMode
		{
			RotationAndPosition = 0,
			Rotation = 1,
			Position = 2,
		}

		public EyeControl eyeControl;
		public Transform leftEye;
		public Transform rightEye;
		public float maxEyeUpBoneAngle;
		public float maxEyeDownBoneAngle;
		public float maxEyeUpEyeballAngle;
		public float maxEyeDownEyeballAngle;
		public bool isEyeBallDefaultSet;
		public bool isEyeBoneDefaultSet;
		public bool isEyeBallLookUpSet;
		public bool isEyeBoneLookUpSet;
		public bool isEyeBallLookDownSet;
		public bool isEyeBoneLookDownSet;
		[SerializeField]
		private EyeRotationLimiter leftBoneEyeRotationLimiter;
		[SerializeField]
		private EyeRotationLimiter rightBoneEyeRotationLimiter;
		[SerializeField]
		private EyeRotationLimiter leftEyeballEyeRotationLimiter;
		[SerializeField]
		private EyeRotationLimiter rightEyeballEyeRotationLimiter;
		public EyelidControl eyelidControl;
		public EyelidBoneMode eyelidBoneMode;
		public bool eyelidsFollowEyesVertically;
		public Transform upperEyeLidLeft;
		public Transform upperEyeLidRight;
		public Transform lowerEyeLidLeft;
		public Transform lowerEyeLidRight;
		public bool isEyelidBonesDefaultSet;
		public bool isEyelidBonesClosedSet;
		public bool isEyelidBonesLookUpSet;
		public bool isEyelidBonesLookDownSet;
		[SerializeField]
		private EyelidRotationLimiter upperLeftLimiter;
		[SerializeField]
		private EyelidRotationLimiter upperRightLimiter;
		[SerializeField]
		private EyelidRotationLimiter lowerLeftLimiter;
		[SerializeField]
		private EyelidRotationLimiter lowerRightLimiter;
		public float eyeWidenOrSquint;
		[SerializeField]
		private EyelidPositionBlendshape[] blendshapesForBlinking;
		[SerializeField]
		private EyelidPositionBlendshape[] blendshapesForLookingUp;
		[SerializeField]
		private EyelidPositionBlendshape[] blendshapesForLookingDown;
		[SerializeField]
		private BlendshapesConfig[] blendshapesConfigs;
		public bool isEyelidBlendshapeDefaultSet;
		public bool isEyelidBlendshapeClosedSet;
		public bool isEyelidBlendshapeLookUpSet;
		public bool isEyelidBlendshapeLookDownSet;
	}
}
