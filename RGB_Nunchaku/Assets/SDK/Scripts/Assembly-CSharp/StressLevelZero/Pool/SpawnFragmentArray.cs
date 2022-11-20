using UnityEngine;
using StressLevelZero;
using StressLevelZero.Data;

namespace StressLevelZero.Pool
{
	public class SpawnFragmentArray : MonoBehaviour
	{
		public float massPercentage;
		public int fragmentCount;
		public TextureArrayApplicator applicator;
		public int applicatorTextureIndex;
		public int applicatorTextureIndex2;
		public Color applicatorColor;
		public int fragmentSFXCount;
		public bool isRandom;
		public Transform[] fragmentSpawnPoints;
		public SpawnableObject spawnableFragmentObject;
	}
}
