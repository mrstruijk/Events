using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Adapted from: https://github.com/roboryantron/Unite2017/blob/master/Assets/Code/Events/GameEvent.cs
/// By Maarten R. Struijk Wilbrink
/// </summary>
[CreateAssetMenu(fileName = "EventSO", menuName = "mrstruijk/Event")]
public class EventSO : ScriptableObject
{
	private List<SOEventListenerWithUnityEventResponse> listeners = new List<SOEventListenerWithUnityEventResponse>();


	/// <summary>
	/// Calls all UnityEvent listeners (SOEventListenerWithUnityEventResponse) to Invoke a UnityEvent
	/// Also calls local 'actionResponse' UnityAction, which allows this SO to function both as a sender and local receiver
	/// of calls.
	/// </summary>
	public void Raise()
	{
		if (listeners.Count != 0)
		{
			for (int i = listeners.Count - 1; i >= 0; i--)
			{
				listeners[i].OnEventRaised();
			}
		}
	}


	public void RegisterListener(SOEventListenerWithUnityEventResponse listener)
	{
		if (!listeners.Contains(listener))
			listeners.Add(listener);
	}


	public void UnregisterListener(SOEventListenerWithUnityEventResponse listener)
	{
		if (listeners.Contains(listener))
			listeners.Remove(listener);
	}
}

