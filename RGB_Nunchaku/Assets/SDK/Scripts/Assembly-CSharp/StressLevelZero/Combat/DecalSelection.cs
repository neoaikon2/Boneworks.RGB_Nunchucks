using UnityEngine;
using ch.sycoforge.Decal;

namespace StressLevelZero.Combat
{
	public class DecalSelection : MonoBehaviour
	{
		[SerializeField]
		private EasyDecal decalSystem;
		public DecalMaterials decalMaterials;
		[SerializeField]
		private GameObject LightCone;
		public ImpactProperties SurfaceProperties;
	}
}
