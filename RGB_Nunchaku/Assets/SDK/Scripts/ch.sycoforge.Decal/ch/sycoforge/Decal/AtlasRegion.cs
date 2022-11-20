using System;
using UnityEngine;

namespace ch.sycoforge.Decal
{
	[Serializable]
	public class AtlasRegion
	{
		[SerializeField]
		private string name;
		[SerializeField]
		private Rect region;
	}
}
