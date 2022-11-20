using UnityEngine;

namespace StressLevelZero
{
	public class InteractableIconObject : SingletonScriptableObject<InteractableIconObject>
	{
		public Material material;
		public Texture2DArray IconTextureArray;
		public float GeneralScale;
		public float AnimationDuration;
	}
}
