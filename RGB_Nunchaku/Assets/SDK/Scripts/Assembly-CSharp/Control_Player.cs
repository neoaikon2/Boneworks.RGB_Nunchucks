using UnityEngine;
using StressLevelZero.VRMK;
using StressLevelZero;

public class Control_Player : MonoBehaviour
{
	//public Data_Player player_data;
	//public Data_Manager manager;
	public BodyVitals body_vitals;
	public bool canPull;
	public float stored_offset_Sitting;
	public RigScreenOptions rigScreen;
	public GameObject obj_Ammo;
	public Transform target_leftAmmo;
	public Transform target_rightAmmo;
	public GameObject obj_UIAmmo;
	public Transform target_leftUI;
	public Transform target_rightUI;
}
