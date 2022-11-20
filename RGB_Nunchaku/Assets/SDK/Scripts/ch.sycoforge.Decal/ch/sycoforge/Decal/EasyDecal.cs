using System;
using UnityEngine;

namespace ch.sycoforge.Decal
{
	[Serializable]
	public class EasyDecal : DecalBase
	{
		public LayerMask Mask;
		[SerializeField]
		private ProjectionMode mode;
		[SerializeField]
		private SourceMode source;
		[SerializeField]
		private AspectMode aspectCorrectionMode;
		[SerializeField]
		private LookupMode recursiveMode;
		[SerializeField]
		private SkinQuality skinningQuality;
		[SerializeField]
		internal Material material;
		[SerializeField]
		private DecalTextureAtlas atlas;
		[SerializeField]
		private int atlasRegionIndex;
		[SerializeField]
		private float maxDistance;
		[SerializeField]
		private float projectionDistance;
		[SerializeField]
		private bool smoothNormals;
		[SerializeField]
		private float normalSmoothFactor;
		[SerializeField]
		private float normalSmoothThreshold;
		[SerializeField]
		internal int resolution;
		[SerializeField]
		private bool multiMeshEnabled;
		[SerializeField]
		private bool cullInvisible;
		[SerializeField]
		private bool cullUnreachable;
		[SerializeField]
		private bool showVertices;
		[SerializeField]
		private bool showDir;
		[SerializeField]
		private bool showNormals;
		[SerializeField]
		private bool enableVertexColorFade;
		[SerializeField]
		private bool onlyColliders;
		[SerializeField]
		private bool tangents;
		[SerializeField]
		private bool calculateNormals;
		[SerializeField]
		private MeshChannelMode normalChannelMode;
		[SerializeField]
		private MeshChannelMode tangentChannelMode;
		[SerializeField]
		private bool recursiceLookup;
		[SerializeField]
		private bool randomIndexEnabled;
		[SerializeField]
		private int recursiceLookupSteps;
		[SerializeField]
		private bool autoDestroy;
		[SerializeField]
		private OpacityMode opacityMode;
		[SerializeField]
		private bool fadeOnly;
		[SerializeField]
		private bool useLightProbes;
		[SerializeField]
		private float lifetime;
		[SerializeField]
		private float fadeoutTime;
		[SerializeField]
		private AnimationCurve fadeoutCurve;
		[SerializeField]
		private float surfaceRotation;
		[SerializeField]
		private int quality;
		[SerializeField]
		private Mesh sharedMesh;
		[SerializeField]
		private int instanceID;
	}
}
