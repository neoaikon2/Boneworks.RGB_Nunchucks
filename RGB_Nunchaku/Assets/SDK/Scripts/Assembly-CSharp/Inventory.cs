using UnityEngine;

public class Inventory : ScriptableObject
{
	[SerializeField]
	private float m_cellSize;
	[SerializeField]
	private int m_width;
	[SerializeField]
	private int m_height;
	[SerializeField]
	private bool m_isDebugging;
}
