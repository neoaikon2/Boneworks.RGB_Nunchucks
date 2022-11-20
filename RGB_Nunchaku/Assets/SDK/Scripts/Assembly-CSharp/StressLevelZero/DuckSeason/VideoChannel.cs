using UnityEngine;
using UnityEngine.Video;

namespace StressLevelZero.DuckSeason
{
	public class VideoChannel : TelevisionChannel
	{
		public Renderer tvDisplayRenderer;
		public Renderer tvReflection;
		public Renderer tvReflection2;
		public RenderTexture tvRenderTexture;
		public Camera uiCamera;
		public bool isSkippable;
		public bool isLooping;
		public VideoClip currentMovieTexture;
		public VideoPlayer videoPlayer;
	}
}
