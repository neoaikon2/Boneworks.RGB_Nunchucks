using UnityEngine;

namespace StressLevelZero
{
	public class TextureArrayApplicator : MonoBehaviour
	{
		[SerializeField]
		public Texture2DArray textureArray;
		public int m_selection;
		public int m_2nd_selection;
		public Color m_color;
		[SerializeField]
		private Renderer matrenderer;
	}
}
