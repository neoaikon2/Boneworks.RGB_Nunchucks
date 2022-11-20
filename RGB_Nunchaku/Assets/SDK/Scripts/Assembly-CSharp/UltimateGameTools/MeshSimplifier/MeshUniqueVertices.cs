using System;
using System.Collections.Generic;
using UnityEngine;

namespace UltimateGameTools.MeshSimplifier
{
	[Serializable]
	public class MeshUniqueVertices
	{
		[Serializable]
		public class SerializableBoneWeight
		{
			public int _boneIndex0;
			public int _boneIndex1;
			public int _boneIndex2;
			public int _boneIndex3;
			public float _boneWeight0;
			public float _boneWeight1;
			public float _boneWeight2;
			public float _boneWeight3;
		}

		[Serializable]
		public class ListIndices
		{
			public List<int> m_listIndices;
		}

		[SerializeField]
		private List<Vector3> m_listVertices;
		[SerializeField]
		private List<Vector3> m_listVerticesWorld;
		[SerializeField]
		private List<MeshUniqueVertices.SerializableBoneWeight> m_listBoneWeights;
		[SerializeField]
		private ListIndices[] m_aFaceList;
	}
}
