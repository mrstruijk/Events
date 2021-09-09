using UnityEngine.Events;


namespace _mrstruijk.Events
{
	[System.Serializable]
	public class UnityEventListResponseLatency
	{
		public float relativeLatency = 0f;
		public UnityEvent response;


		public UnityEventListResponseLatency(float relativeLatency, UnityEvent response)
		{
			this.relativeLatency = relativeLatency;
			this.response = response;
		}
	}
}
