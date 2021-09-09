using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace _mrstruijk.Events
{
	/// <summary>
	/// Adapted from: https://github.com/roboryantron/Unite2017/blob/master/Assets/Code/Events/GameEventListener.cs
	/// By Maarten R. Struijk Wilbrink
	/// </summary>
	public class EventResponseList : ResponseBase
	{
		[Tooltip("The relative delay is always relative to the previous event")]
		public List<UnityEventListResponseLatency> responseList;


		public override void OnEventRaised()
		{
			base.OnEventRaised();

			StartCoroutine(DelayedResponseCR());
		}


		private IEnumerator DelayedResponseCR()
		{
			foreach (var response in responseList)
			{
				yield return new WaitForSeconds(response.relativeLatency);
				response.response?.Invoke();
			}
		}


		public override void OnDisable()
		{
			base.OnDisable();
			StopAllCoroutines();
		}
	}
}
