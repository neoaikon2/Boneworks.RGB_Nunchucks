using UnityEngine;
using System.Collections.Generic;

namespace ch.sycoforge.Decal
{
	public class CombinedDecalsGroup : MonoBehaviour
	{
		[SerializeField]
		private DecalTextureAtlas atlas;
		[SerializeField]
		private List<EasyDecal> references;
	}
}
