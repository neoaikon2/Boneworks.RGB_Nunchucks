using UnityEngine;

public class TriggerSwitch : OnOffSwitch
{
	public bool momentary;
	public int layer;
	public Collider col_Pin;
	public float voltage;
	public GameObject[] send_Objects;
}
