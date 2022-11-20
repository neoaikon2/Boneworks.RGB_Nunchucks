using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace StressLevelZero.UI
{
	public class Control_UI_InGameData : MonoBehaviour
	{
		//public Data_Manager dataManager;
		public Text txt_rh_cm;
		public Text txt_rh_ft;
		public Text txt_so_cm;
		public Text txt_so_ft;
		public Text txt_fo_cm;
		public Text txt_fo_ft;
		public TextMeshPro txt_Standing;
		public Image img_StandingSeated;
		public TextMeshPro txt_PleaseSave;
		public GameObject obj_PleaseSave;
		public Text txt_Playername;
		public Text txt_PlayerHeight;
		public Text txt_PlayerSittingOffset;
		public GameObject panel_Seated;
		public GameObject but_AutoSitOffset;
		public GameObject but_AutoFloorOffset;
		public Text txt_ControllerDirection;
		public Text txt_ControllerCurve;
		public Image img_ControllerCurve;
		public TextMeshPro txt_SnapTurnDegrees;
		public Text txt_SnapTurnRate;
		public TextMeshPro txt_virtualCrouching;
		public TextMeshPro txt_handRadius;
		public TextMeshPro txt_handedness;
		public TextMeshPro txt_beltSidedness;
		public TextMeshPro txt_hapticMod;
		public TextMeshPro txt_ambientOcclusion;
		public TextMeshPro txt_adaptiveResolution;
		public TextMeshPro txt_textureResolution;
		public TextMeshPro txt_antiAliasing;
		public TextMeshPro txt_shadowQuality;
		public TextMeshPro txt_AdditionalLighting;
		public TextMeshPro txt_physicsUpdate;
		public TextMeshPro txt_fishEyeButton;
		public TextMeshPro txt_fishEyeLocation;
		public TextMeshPro txt_MasterVolume;
		public TextMeshPro txt_MusicVolume;
		public TextMeshPro txt_SFXVolume;
		public Sprite[] sprite_StandingSeated;
		public Sprite[] sprite_CurveMap;
		public AudioClip[] clips_Confirm;
		public AudioClip[] clips_Deny;
		public AudioClip[] clips_Clicks;
		public AudioClip[] clips_Hover;
		public AudioClip[] clips_Activate;
		public AudioClip[] clips_Deactivate;
		public Haptor haptor;
		public AudioSource src_Audio;
	}
}
