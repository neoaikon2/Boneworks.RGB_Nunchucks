using UnityEngine;

public class Enemy_Barricade : MonoBehaviour
{
	public bool open;
	public float open_targetPos;
	public float close_targetPos;
	public bool openOnImpact;
	public float thr_Impact;
	public bool useBorkyImpact;
	public ConfigurableJoint jnt_panel;
}
