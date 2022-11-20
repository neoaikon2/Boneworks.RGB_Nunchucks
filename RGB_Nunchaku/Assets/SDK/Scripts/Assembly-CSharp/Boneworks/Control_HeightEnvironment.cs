using UnityEngine;
using UnityEngine.UI;

namespace Boneworks
{
	public class Control_HeightEnvironment : MonoBehaviour
	{
		public GameObject object_Door;
		public Material mat_WhiteDoor;
		public Material mat_locomoteDoor;
		public Material mat_knockFirstDoor;
		public Material mat_KeepOutDoor;
		public AudioSource source_Door;
		public AudioClip clip_DoorOpen;
		public AudioClip clip_DoorClose;
		public AudioClip clip_DoorUnlock;
		public AudioClip clip_DoorLock;
		public GameObject object_doorKnob;
		public Transform thePlayerLocomotor;
		public GameObject object_BoneWorks;
		public Animator animator_BoneworksTitle;
		public bool canEndAnim;
		public GameObject object_HeightCheckTable;
		public GameObject object_LilSteve;
		public GameObject object_BigSteve;
		public GameObject object_OriginalPresentTable;
		public RectTransform object_HeightUIPanel;
		public GameObject object_Present;
		public GameObject button_WearIt;
		public GameObject button_LetsGo;
		public GameObject object_LaserCursor;
		public GameObject object_UIOutlineViveWand;
		public Image image_MenuHighlight;
		public Color32 color_MenuHighlight;
		public Color32 color_MenuDarklight;
		public RectTransform rect_MeasureHeight;
		public Text text_MeasureHeight;
		public Transform hmdLocalPos;
		public Text text_MeasureCharacterHeight;
		public RectTransform rect_MeasureCharacterHeight;
		public GameObject geo_Hands;
		public GameObject geo_FullBody;
		public GameObject particles_confettiBig;
		public Control_TestEnvironment control_environment;
	}
}
