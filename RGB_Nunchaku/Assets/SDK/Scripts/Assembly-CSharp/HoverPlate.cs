using UnityEngine;

public class HoverPlate : MonoBehaviour
{
	public float hoverDistance;
	public float hoverForce;
	public Rigidbody rb_this;
	public float stability;
	public float stabilitySpeed;
	public GameObject Handle;
	public PowerSocket powerSocket;
	public float draw_Power;
	public bool energized;
}
