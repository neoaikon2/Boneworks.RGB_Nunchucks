using UnityEngine;

namespace StressLevelZero.UI
{
	public class Control_UI_PopUpMenu : MonoBehaviour
	{
		public float offset_Pos;
		public Vector3 offset_Rot;
		public Transform parentTransfrom;
		public Transform spawnFromTransform;
		public GameObject ui_Core;
		public GameObject[] but_Compass;
		public AudioClip[] clips_Confirm;
		public AudioClip[] clips_Deny;
		public AudioClip[] clips_Clicks;
		public AudioClip[] clips_Hover;
		public AudioClip[] clips_Activate;
		public AudioClip[] clips_Deactivate;
	}
}
