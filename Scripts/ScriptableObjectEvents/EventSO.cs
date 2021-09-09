using System;
using System.Collections.Generic;
using UnityEngine;


namespace _mrstruijk.Events
{
	/// <summary>
	/// Adapted from: https://github.com/roboryantron/Unite2017/blob/master/Assets/Code/Events/GameEvent.cs
	/// By Maarten R. Struijk Wilbrink
	/// </summary>
	[CreateAssetMenu(fileName = "EventSO", menuName = "mrstruijk/Event")]
	public class EventSO : ScriptableObject
	{
		private readonly List<IRespondToEventSO> listeners = new List<IRespondToEventSO>();

		/// <summary>
		/// Calls all UnityEvent listeners to Invoke a UnityEvent
		/// </summary>
		public void Raise()
		{
			if (listeners.Count != 0)
			{
				for (int i = listeners.Count - 1; i >= 0; i--) // Iterate backwards in case of 'Remove From List'
				{
					listeners[i].OnEventRaised();
				}
			}
		}


		public void RegisterListener(ResponseBase listener)
		{
			if (!listeners.Contains(listener))
			{
				listeners.Add(listener);
			}
		}


		public void UnregisterListener(ResponseBase listener)
		{
			if (listeners.Contains(listener))
			{
				listeners.Remove(listener);
			}
		}
	}
}
