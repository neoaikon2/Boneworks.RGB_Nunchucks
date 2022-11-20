using System.Collections.Generic;
using UnityEngine;

public class SO_Languages : SingletonScriptableObject<SO_Languages>
{
	[SerializeField]
	private List<string> Language;
	public bool isDebugging;
}
