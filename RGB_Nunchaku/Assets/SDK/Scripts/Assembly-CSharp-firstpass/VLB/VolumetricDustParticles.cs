using UnityEngine;

namespace VLB
{
	public class VolumetricDustParticles : MonoBehaviour
	{
		public enum Direction
		{
			Beam = 0,
			Random = 1,
		}

		public float alpha;
		public float size;
		public Direction direction;
		public float speed;
		public float density;
		public float spawnMaxDistance;
		public bool cullingEnabled;
		public float cullingMaxDistance;
	}
}
