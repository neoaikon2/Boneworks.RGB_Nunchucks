using UnityEngine;
using System;
using StressLevelZero.Combat;

namespace StressLevelZero.Pool
{
	public class CasePool : MonoBehaviour
	{
		[Serializable]
		public struct CaseVariables
		{
			public Cart cartridgeType;
			public float CartridgeMass;
			public Renderer CaseMesh;
			public Renderer BulletMesh;
			public Collider CaseCollider;
		}

		public CaseVariables[] caseVariables;
	}
}
