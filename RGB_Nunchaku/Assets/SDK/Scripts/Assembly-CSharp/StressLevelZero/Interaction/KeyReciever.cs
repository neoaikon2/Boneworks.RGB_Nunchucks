using StressLevelZero;
using UnityEngine;
using UnityEngine.Events;

namespace StressLevelZero.Interaction
{
	public class KeyReciever : InteractionReciever
	{
		public enum Code
		{
			CODE_A = 1,
			CODE_B = 2,
			CODE_C = 4,
			CODE_D = 8,
			CODE_E = 16,
			CODE_F = 32,
			CODE_G = 64,
			CODE_H = 128,
			CODE_I = 256,
			CODE_J = 512,
			CODE_K = 1024,
		}

		public SaveItem saveItem;
		public Transform startInsertTarget;
		public Transform endInsertTarget;
		public AudioClip[] insertClips;
		public AudioClip[] ejectClips;
		public Code code;
		public bool isKeyConsumed;
		public UnityEvent onUnlock;
		public UnityEvent onLock;
	}
}
