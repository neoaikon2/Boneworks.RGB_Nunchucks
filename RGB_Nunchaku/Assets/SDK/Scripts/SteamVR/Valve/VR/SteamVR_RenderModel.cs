using UnityEngine;

namespace Valve.VR
{
	public class SteamVR_RenderModel : MonoBehaviour
	{
		public SteamVR_TrackedObject.EIndex index;
		public string modelOverride;
		public Shader shader;
		public bool verbose;
		public bool createComponents;
		public bool updateDynamically;
	}
}
