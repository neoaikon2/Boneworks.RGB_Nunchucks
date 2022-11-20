using UnityEngine;
using UnityEngine.UI;

namespace StressLevelZero.DuckSeason
{
	public class LightgunChannel : TelevisionChannel
	{
		public Canvas uiCanvas;
		public GameObject cursorObject;
		public Image flashImage;
		public AudioClip gunshotClip;
		public bool reducedState;
	}
}
