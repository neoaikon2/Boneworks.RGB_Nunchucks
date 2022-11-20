using UnityEngine.Video;
using UnityEngine;

namespace StressLevelZero.DuckSeason
{
	public class TelevisionBasic : TelevisionBase
	{
		public VideoClip[] clipPlaylist;
		public VideoClip[] oculusClipPlaylist;
		public bool isPlaylistLoop;
		public bool isOculus;
		public VideoPlayer videoPlayer;
		public AudioSource videoAudioSource;
		public VHSPlayer vhsPlayer;
		public Renderer[] TV_Renderers;
		public RenderTexture tvRenderTexture;
		public bool playOnStart;
	}
}
