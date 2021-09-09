using System;


namespace _mrstruijk.Events
{
	[System.Serializable] 
	public class ActionListResponseLatency
	{
		public float relativeLatency = 0f;
		public Action response;


		public ActionListResponseLatency(float relativeLatency, Action response)
		{
			this.relativeLatency = relativeLatency;
			this.response = response;
		}
	}
}