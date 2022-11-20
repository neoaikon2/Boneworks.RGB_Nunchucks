using UnityEngine;
using System.Collections.Generic;

public class FlowmapGenerator : MonoBehaviour
{
	[SerializeField]
	private List<FlowSimulationField> fields;
	public bool gpuAcceleration;
	public bool autoAddChildFields;
	public int maxThreadCount;
	[SerializeField]
	private Vector2 dimensions;
	public int outputFileFormat;
}
