using UnityEngine;

namespace Valve.VR
{
	public class SteamVR_Overlay : MonoBehaviour
	{
		public Texture texture;
		public bool curved;
		public bool antialias;
		public bool highquality;
		public float scale;
		public float distance;
		public float alpha;
		public Vector4 uvOffset;
		public Vector2 mouseScale;
		public Vector2 curvedRange;
		public VROverlayInputMethod inputMethod;
	}
}
