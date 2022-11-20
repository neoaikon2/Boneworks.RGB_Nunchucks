using UnityEngine;

namespace DFVolume
{
	public class VolumeVisualizer : MonoBehaviour
	{
		private enum Mode
		{
			Distance = 0,
			Gradient = 1,
		}

		[SerializeField]
		private VolumeData _data;
		[SerializeField]
		private Mode _mode;
		[SerializeField]
		private float _depth;
		[SerializeField]
		private Mesh _quadMesh;
		[SerializeField]
		private Shader _shader;
	}
}
