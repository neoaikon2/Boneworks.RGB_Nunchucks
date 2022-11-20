using UnityEngine;
using StressLevelZero.UI.Radial;
using StressLevelZero.Rig;

namespace StressLevelZero.UI
{
	public class PageView : MonoBehaviour
	{
		public AudioSource audioSource;
		public AudioClip clip_hover;
		public AudioClip clip_select;
		public AudioClip clip_closeDown;
		public AudioClip clip_summon;
		public PageItemView[] buttons;
		public PageElementView cancelButton;
		public GameObject TextCanvas;
		public BaseController controller;
		public Color color1;
		public Color color2;
	}
}
