using UnityEngine;
using System;
using System.Collections.Generic;
using UltimateGameTools.MeshSimplifier;

public class AutomaticLOD : MonoBehaviour
{
	[Serializable]
	public class LODLevelData
	{
		public float m_fScreenCoverage;
		public float m_fMaxCameraDistance;
		public float m_fMeshVerticesAmount;
		public int m_nColorEditorBarIndex;
		public Mesh m_mesh;
		public bool m_bUsesOriginalMesh;
		public GameObject m_gameObject;
	}

	public enum EvalMode
	{
		CameraDistance = 0,
		ScreenCoverage = 1,
	}

	public enum LevelsToGenerate
	{
		_1 = 1,
		_2 = 2,
		_3 = 3,
		_4 = 4,
		_5 = 5,
		_6 = 6,
	}

	public enum SwitchMode
	{
		SwitchMesh = 0,
		SwitchGameObject = 1,
		UnityLODGroup = 2,
	}

	public Mesh m_originalMesh;
	public EvalMode m_evalMode;
	public bool m_bEnablePrefabUsage;
	public string m_strAssetPath;
	public float m_fMaxCameraDistance;
	public int m_nColorEditorBarNewIndex;
	public List<AutomaticLOD.LODLevelData> m_listLODLevels;
	public AutomaticLOD m_LODObjectRoot;
	public List<AutomaticLOD> m_listDependentChildren;
	public bool m_bExpandRelevanceSpheres;
	public RelevanceSphere[] m_aRelevanceSpheres;
	[SerializeField]
	private Simplifier m_meshSimplifier;
	[SerializeField]
	private bool m_bGenerateIncludeChildren;
	[SerializeField]
	private LevelsToGenerate m_levelsToGenerate;
	[SerializeField]
	private SwitchMode m_switchMode;
	[SerializeField]
	private bool m_bOverrideRootSettings;
	[SerializeField]
	private bool m_bLODDataDirty;
	[SerializeField]
	private AutomaticLOD m_LODObjectRootPersist;
	[SerializeField]
	private LODGroup m_LODGroup;
}
