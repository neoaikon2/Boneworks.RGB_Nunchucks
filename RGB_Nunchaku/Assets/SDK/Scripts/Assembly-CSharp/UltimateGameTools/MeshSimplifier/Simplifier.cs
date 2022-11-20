using UnityEngine;
using System.Collections.Generic;

namespace UltimateGameTools.MeshSimplifier
{
	public class Simplifier : MonoBehaviour
	{
		[SerializeField]
		private int m_nOriginalMeshVertexCount;
		[SerializeField]
		private float m_fOriginalMeshSize;
		[SerializeField]
		private List<int> m_listVertexMap;
		[SerializeField]
		private List<int> m_listVertexPermutationBack;
		[SerializeField]
		private MeshUniqueVertices m_meshUniqueVertices;
		[SerializeField]
		private Mesh m_meshOriginal;
		[SerializeField]
		private bool m_bUseEdgeLength;
		[SerializeField]
		private bool m_bUseCurvature;
		[SerializeField]
		private bool m_bProtectTexture;
		[SerializeField]
		private bool m_bLockBorder;
	}
}
