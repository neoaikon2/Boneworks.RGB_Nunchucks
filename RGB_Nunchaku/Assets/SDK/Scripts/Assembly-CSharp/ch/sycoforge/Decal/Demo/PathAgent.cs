using UnityEngine;
using ch.sycoforge.Decal;

namespace ch.sycoforge.Decal.Demo
{
	public class PathAgent : MonoBehaviour
	{
		public float PathThickness;
		public float NormalPathOffset;
		public float Radius;
		public float AngleThreshold;
		public bool DrawGizmos;
		public EasyDecal TargetAimDecal;
		public GameObject TargetPointDecalPrefab;
	}
}
