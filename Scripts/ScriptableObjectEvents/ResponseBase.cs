using UnityEngine;


namespace _mrstruijk.Events
{
	/// <summary>
	/// Adapted from: https://github.com/roboryantron/Unite2017/blob/master/Assets/Code/Events/GameEventListener.cs
	/// By Maarten R. Struijk Wilbrink
	/// </summary>
	public abstract class ResponseBase : MonoBehaviour, IRespondToEventSO
	{
		public EventSO Event;


		private void Awake()
		{
			if (!Event)
			{
				Debug.LogErrorFormat("Event is missing on {0}", this.name);
			}
		}


		private void OnEnable()
		{
			if (!Event)
			{
				return;
			}

			Event.RegisterListener(this);
		}


		public virtual void OnEventRaised()
		{
			if (!Event)
			{
				return;
			}
		}


		public virtual void OnDisable()
		{
			if (!Event)
			{
				return;
			}

			Event.UnregisterListener(this);
		}
	}
}
