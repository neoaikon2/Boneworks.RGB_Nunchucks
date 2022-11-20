using UnityEngine;
using UnityEngine.Audio;

public class SceneLoader : MonoBehaviour
{
	public AudioClip clip;
	public AudioMixer mixer;
	public string destSceneName;
	public string internalProcessPath;
	public string internalProcessArgs;
	public bool loadAdditive;
	public bool loadAsync;
	public Texture loadingScreen;
	public Texture progressBarEmpty;
	public Texture progressBarFull;
	public float loadingScreenWidthInMeters;
	public float progressBarWidthInMeters;
	public float loadingScreenDistance;
	public Transform loadingScreenTransform;
	public Transform progressBarTransform;
	public GameObject load_package;
	public LoadingScreenPackage loadingScreenPackage;
	public Texture front;
	public Texture back;
	public Texture left;
	public Texture right;
	public Texture top;
	public Texture bottom;
	public Color backgroundColor;
	public bool showGrid;
	public float fadeOutTime;
	public float fadeInTime;
	public float postLoadSettleTime;
	public float loadingScreenFadeInTime;
	public float loadingScreenFadeOutTime;
	public bool autoTriggerOnEnable;
}
