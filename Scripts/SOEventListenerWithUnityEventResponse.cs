using UnityEngine;
using UnityEngine.Events;


/// <summary>
/// From: https://github.com/roboryantron/Unite2017/blob/master/Assets/Code/Events/GameEventListener.cs
/// By Maarten R. Struijk Wilbrink
/// </summary>
public class SOEventListenerWithUnityEventResponse : MonoBehaviour
{
	public EventSO Event;
	public UnityEvent Response;


	private void OnEnable()
	{
		Event.RegisterListener(this);
	}


	private void OnDisable()
	{
		Event.UnregisterListener(this);
	}


	public virtual void OnEventRaised()
	{
		Response.Invoke();
	}

}
