using UnityEngine;
using UnityEngine.Events;

public class GenericKeypressEvent : MonoBehaviour
{
	private enum KeyPressType
	{
		Key = 0,
		Down = 1,
		Up = 2,
	}

	[SerializeField]
	private KeyCode ActivationKey;
	[SerializeField]
	private KeyPressType KeyActivationType;
	[SerializeField]
	private UnityEvent EventToDo;
}
