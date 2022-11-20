using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class AtmosphericManager : MonoBehaviour
{
	[SerializeField]
	private PostProcessProfile GlobalPostProfile;
	[SerializeField]
	private GameObject FogCatcher;
	[SerializeField]
	private ValveFog Vfog;
}
