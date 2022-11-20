using UnityEngine;
using StressLevelZero.Props.Weapons;

namespace StressLevelZero.Interaction
{
	public class GunOptionSelect : MonoBehaviour
	{
		public bool displayUI;
		public bool canChangeFiremode;
		public bool canEjectMag;
		public Color uiColor;
		public Color uiHighlightColor;
		public Grip grip;
		public Gun gun;
		public MagazineSocket reciever;
		public GameObject uiBorderObject;
		public GameObject uiCursorObject;
		public GameObject uiEjectText;
		public GameObject uiFireModeText;
	}
}
