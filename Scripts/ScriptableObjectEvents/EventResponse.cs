using UnityEngine.Events;


namespace _mrstruijk.Events
{
	/// <summary>
	/// Adapted from: https://github.com/roboryantron/Unite2017/blob/master/Assets/Code/Events/GameEventListener.cs
	/// By Maarten R. Struijk Wilbrink
	/// </summary>
	public class EventResponse : ResponseBase
	{
		public UnityEvent response;


		public override void OnEventRaised()
		{
			base.OnEventRaised();

			response?.Invoke();
		}
	}
}
