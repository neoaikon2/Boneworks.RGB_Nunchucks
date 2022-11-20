using UnityEngine;
using StressLevelZero.VRMK;

public class SkinnedBoneRebind : MonoBehaviour
{
	public Transform[] bones;
	public bool[] rebindBone;
	public SkinnedMeshRenderer skinnedMeshRenderer;
	public Mesh meshToRead;
	public Mesh meshToWrite;
	public SLZ_BodyBlender slzBlender;
}
