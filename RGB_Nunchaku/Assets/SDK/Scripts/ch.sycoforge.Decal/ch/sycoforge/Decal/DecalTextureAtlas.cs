using UnityEngine;
using System.Collections.Generic;

namespace ch.sycoforge.Decal
{
	public class DecalTextureAtlas : ScriptableObject
	{
		[SerializeField]
		private Material material;
		[SerializeField]
		private List<AtlasRegion> regions;
	}
}
