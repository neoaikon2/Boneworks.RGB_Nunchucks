using UnityEngine;
using System;
using System.Collections.Generic;

public class UltimateRope : MonoBehaviour
{
	[Serializable]
	public class RopeNode
	{
		public GameObject goNode;
		public float fLength;
		public float fTotalLength;
		public int nNumLinks;
		public int nTotalLinks;
		public UltimateRope.EColliderType eColliderType;
		public int nColliderSkip;
		public bool bFold;
		public bool bIsCoil;
		public bool bInitialOrientationInitialized;
		public Vector3 v3InitialLocalPos;
		public Quaternion qInitialLocalRot;
		public Vector3 v3InitialLocalScale;
		public bool m_bExtensionInitialized;
		public int m_nExtensionLinkIn;
		public int m_nExtensionLinkOut;
		public float m_fExtensionRemainingLength;
		public float m_fExtensionRemainderIn;
		public float m_fExtensionRemainderOut;
		public Vector3 m_v3LocalDirectionForward;
		public Vector3 m_v3LocalDirectionUp;
		public GameObject[] segmentLinks;
		public ConfigurableJoint[] linkJoints;
		public bool[] linkJointBreaksProcessed;
		public bool bSegmentBroken;
	}

	[Serializable]
	public class RopeBone
	{
		public GameObject goBone;
		public Transform tfParent;
		public Transform tfNonBoneParent;
		public bool bCreatedCollider;
		public bool bIsStatic;
		public float fLength;
		public bool bCreatedRigidbody;
		public int nOriginalLayer;
		public Vector3 v3OriginalLocalScale;
		public Vector3 v3OriginalLocalPos;
		public Quaternion qOriginalLocalRot;
	}

	public enum ERopeType
	{
		Procedural = 0,
		LinkedObjects = 1,
		ImportBones = 2,
	}

	public enum EColliderType
	{
		None = 0,
		Capsule = 1,
		Box = 2,
	}

	public enum EAxis
	{
		MinusX = 0,
		MinusY = 1,
		MinusZ = 2,
		X = 3,
		Y = 4,
		Z = 5,
	}

	public ERopeType RopeType;
	public GameObject RopeStart;
	public List<UltimateRope.RopeNode> RopeNodes;
	public int RopeLayer;
	public PhysicMaterial RopePhysicsMaterial;
	public float RopeDiameter;
	public float RopeDiameterScaleX;
	public float RopeDiameterScaleY;
	public int RopeSegmentSides;
	public Material RopeMaterial;
	public float RopeTextureTileMeters;
	public Material RopeSectionMaterial;
	public float RopeTextureSectionTileMeters;
	public bool IsExtensible;
	public float ExtensibleLength;
	public bool HasACoil;
	public GameObject CoilObject;
	public EAxis CoilAxisRight;
	public EAxis CoilAxisUp;
	public float CoilWidth;
	public float CoilDiameter;
	public int CoilNumBones;
	public GameObject LinkObject;
	public EAxis LinkAxis;
	public float LinkOffsetObject;
	public float LinkTwistAngleStart;
	public float LinkTwistAngleIncrement;
	public GameObject BoneFirst;
	public GameObject BoneLast;
	public string BoneListNamesStatic;
	public string BoneListNamesNoColliders;
	public EAxis BoneAxis;
	public EColliderType BoneColliderType;
	public float BoneColliderDiameter;
	public int BoneColliderSkip;
	public float BoneColliderLength;
	public float BoneColliderOffset;
	public float LinkMass;
	public int LinkSolverIterationCount;
	public float LinkJointAngularXLimit;
	public float LinkJointAngularYLimit;
	public float LinkJointAngularZLimit;
	public float LinkJointSpringValue;
	public float LinkJointDamperValue;
	public float LinkJointMaxForceValue;
	public float LinkJointBreakForce;
	public float LinkJointBreakTorque;
	public bool LockStartEndInZAxis;
	public bool SendEvents;
	public GameObject EventsObjectReceiver;
	public string OnBreakMethodName;
	public bool PersistAfterPlayMode;
	public bool EnablePrefabUsage;
	public bool AutoRegenerate;
	public bool Deleted;
	public float[] LinkLengths;
	public int TotalLinks;
	public float TotalRopeLength;
	public bool m_bRopeStartInitialOrientationInitialized;
	public Vector3 m_v3InitialRopeStartLocalPos;
	public Quaternion m_qInitialRopeStartLocalRot;
	public Vector3 m_v3InitialRopeStartLocalScale;
	public int m_nFirstNonCoilNode;
	public float[] m_afCoilBoneRadiuses;
	public float[] m_afCoilBoneAngles;
	public float[] m_afCoilBoneX;
	public float m_fCurrentCoilRopeRadius;
	public float m_fCurrentCoilTurnsLeft;
	public float m_fCurrentCoilLength;
	public float m_fCurrentExtension;
	public float m_fCurrentExtensionInput;
	public RopeBone[] ImportedBones;
	public bool m_bBonesAreImported;
	public string m_strStatus;
	public bool m_bLastStatusIsError;
	public string m_strAssetFile;
}
