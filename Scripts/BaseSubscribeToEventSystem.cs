using UnityEngine;


namespace _mrstruijk.Events
{
	public abstract class BaseSubscribeToEventSystem : MonoBehaviour
	{
		public abstract void InvokeAction();
	}
}