using UnityEngine;

public class BakeryLightmapGroup : ScriptableObject
{
	public enum ftLMGroupMode
	{
		OriginalUV = 0,
		PackAtlas = 1,
		Vertex = 2,
	}

	public enum RenderMode
	{
		FullLighting = 0,
		Indirect = 1,
		Shadowmask = 2,
		Auto = 1000,
	}

	public enum RenderDirMode
	{
		None = 0,
		BakedNormalMaps = 1,
		DominantDirection = 2,
		RNM = 3,
		SH = 4,
		Auto = 1000,
	}

	[SerializeField]
	public int resolution;
	[SerializeField]
	public int bitmask;
	[SerializeField]
	public int id;
	[SerializeField]
	public bool isImplicit;
	[SerializeField]
	public float area;
	[SerializeField]
	public int totalVertexCount;
	[SerializeField]
	public int vertexCounter;
	[SerializeField]
	public int sceneLodLevel;
	[SerializeField]
	public string sceneName;
	[SerializeField]
	public ftLMGroupMode mode;
	[SerializeField]
	public RenderMode renderMode;
	[SerializeField]
	public RenderDirMode renderDirMode;
	[SerializeField]
	public bool computeSSS;
	[SerializeField]
	public int sssSamples;
	[SerializeField]
	public float sssDensity;
	[SerializeField]
	public Color sssColor;
}
