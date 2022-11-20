using UnityEngine;
using System.Collections.Generic;
using UltimateGameTools.MeshSimplifier;

public class MeshSimplify : MonoBehaviour
{
	public Mesh m_originalMesh;
	public Mesh m_simplifiedMesh;
	public bool m_bEnablePrefabUsage;
	public float m_fVertexAmount;
	public string m_strAssetPath;
	public MeshSimplify m_meshSimplifyRoot;
	public List<MeshSimplify> m_listDependentChildren;
	public bool m_bExpandRelevanceSpheres;
	public RelevanceSphere[] m_aRelevanceSpheres;
	[SerializeField]
	private Simplifier m_meshSimplifier;
	[SerializeField]
	private bool m_bGenerateIncludeChildren;
	[SerializeField]
	private bool m_bOverrideRootSettings;
	[SerializeField]
	private bool m_bUseEdgeLength;
	[SerializeField]
	private bool m_bUseCurvature;
	[SerializeField]
	private bool m_bProtectTexture;
	[SerializeField]
	private bool m_bLockBorder;
	[SerializeField]
	private bool m_bDataDirty;
	[SerializeField]
	private bool m_bExcludedFromTree;
}
