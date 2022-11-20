using UnityEngine;
using System.Collections.Generic;

public class DynamicBone : MonoBehaviour
{
	public enum UpdateMode
	{
		Normal = 0,
		AnimatePhysics = 1,
		UnscaledTime = 2,
	}

	public enum FreezeAxis
	{
		None = 0,
		X = 1,
		Y = 2,
		Z = 3,
	}

	public Transform m_Root;
	public float m_UpdateRate;
	public UpdateMode m_UpdateMode;
	public float m_Damping;
	public AnimationCurve m_DampingDistrib;
	public float m_Elasticity;
	public AnimationCurve m_ElasticityDistrib;
	public float m_Stiffness;
	public AnimationCurve m_StiffnessDistrib;
	public float m_Inert;
	public AnimationCurve m_InertDistrib;
	public float m_Friction;
	public AnimationCurve m_FrictionDistrib;
	public float m_Radius;
	public AnimationCurve m_RadiusDistrib;
	public float m_EndLength;
	public Vector3 m_EndOffset;
	public Vector3 m_Gravity;
	public Vector3 m_Force;
	public List<DynamicBoneColliderBase> m_Colliders;
	public List<Transform> m_Exclusions;
	public FreezeAxis m_FreezeAxis;
	public bool m_DistantDisable;
	public Transform m_ReferenceObject;
	public float m_DistanceToObject;
}
