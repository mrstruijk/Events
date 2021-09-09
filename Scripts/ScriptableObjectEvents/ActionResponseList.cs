using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace _mrstruijk.Events
{
	/// <summary>
	/// By Maarten R. Struijk Wilbrink
	/// </summary>
	public class ActionResponseList : ResponseBase
	{
		public List<ActionListResponseLatency> responseList;


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