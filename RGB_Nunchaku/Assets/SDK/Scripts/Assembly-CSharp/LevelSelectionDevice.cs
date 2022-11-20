using UnityEngine;
using TMPro;
using System.Collections.Generic;

public class LevelSelectionDevice : MonoBehaviour
{
	public bool Activated;
	public float selection_t;
	public GameObject level_Prefab;
	public Transform[] transform_Points;
	public GameObject fx_ConfirmedSelection;
	public GameObject fx_DeniedSelection;
	public string[] strings_Scenes;
	public AudioSource src_Audio;
	public AudioClip clip_splash;
	public AudioClip[] clips_Selection;
	public AudioClip[] clips_SelectionConfirmed;
	public AudioClip[] clips_SelectionDenied;
	public bool held;
	public GameControl_HeightCheck gameControl;
	public GameObject fx_Lines;
	public GameObject fx_InvertedSphere;
	public ParticleSystem fx_PortalSplash;
	public TextMeshProUGUI text_BigTitle;
	public List<LevelObject> scenes_Unlocked;
}
