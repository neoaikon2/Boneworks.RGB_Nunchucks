using System;
using UnityEngine;

[Serializable]
public class Item
{
	[SerializeField]
	private bool m_isStackable;
	[SerializeField]
	private int m_itemAmt;
	public Color d_slotColor;
}
