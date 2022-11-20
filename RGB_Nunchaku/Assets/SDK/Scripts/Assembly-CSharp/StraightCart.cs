using UnityEngine;

public class StraightCart : MonoBehaviour
{
	public ConfigurableJoint jnt_cartTrack;
	public Vector3 loc_neg;
	public Vector3 loc_pos;
	public Transform[] wheels;
	public bool dir_Flip;
}
