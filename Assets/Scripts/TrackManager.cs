using UnityEngine;
using System.Collections;

public class TrackManager : MonoBehaviour {
	public static TrackManager instance;
	
	public SplineController sc;
	public SplineInterpolator si;
	
	void Start()
	{
		if(sc == null)
		{
			sc = this.GetComponent<SplineController>() as SplineController;
		}
		
		if(si == null)
		{
			si = this.GetComponent<SplineInterpolator>() as SplineInterpolator;
		}
	}
}
