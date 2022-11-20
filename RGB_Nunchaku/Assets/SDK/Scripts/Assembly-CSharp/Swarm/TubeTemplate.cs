using UnityEngine;

namespace Swarm
{
	public class TubeTemplate : ScriptableObject
	{
		[SerializeField]
		private int _divisions;
		[SerializeField]
		private int _segments;
		[SerializeField]
		private Mesh _mesh;
	}
}
