using UnityEngine;
using TMPro;

namespace StressLevelZero.SFX
{
	public class JukeBoxMachine : MonoBehaviour
	{
		public AmbientSFX sfx_headphones;
		public AmbientSFX sfx_speakers;
		public AudioClip[] clip_track;
		public string[] name_track;
		public TextMeshPro txt_songName;
		public bool random;
		public TextMeshPro txt_randomToggle;
	}
}
