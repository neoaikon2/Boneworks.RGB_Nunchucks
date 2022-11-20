using UnityEngine;

namespace StressLevelZero.Combat
{
	public class ImpactPropertiesVariables : MonoBehaviour
	{
		public enum Material
		{
			Default = 0,
			Metal = 1,
			PureMetal = 2,
			Wood = 3,
			Dirt = 4,
			Cardboard = 5,
			Glass = 6,
			Blood = 7,
			Water = 8,
			Zapper = 9,
			Concrete = 10,
			Hydraulic = 11,
			Bioluminescent = 12,
		}

		public enum ModelType
		{
			Skinned = 0,
			Flat = 1,
			Model = 2,
			Ignore = 3,
			LightCone = 4,
		}

		public Material material;
		public ModelType modelType;
		public Color MainColor;
		public Color SecondaryColor;
		public float PenetrationResistance;
		public float megaPascalModifier;
		public bool Flammable;
		public float FireResistance;
	}
}
