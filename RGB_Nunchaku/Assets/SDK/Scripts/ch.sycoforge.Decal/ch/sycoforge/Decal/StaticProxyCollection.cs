using UnityEngine;
using System.Collections.Generic;

namespace ch.sycoforge.Decal
{
	public class StaticProxyCollection : MonoBehaviour
	{
		public List<GameObject> Proxies;
		[SerializeField]
		public List<ProxyMesh> MeshProxies;
	}
}
