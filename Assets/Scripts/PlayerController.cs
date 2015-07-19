using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float maxVelocity = 10.0f;

	private float velocity = 0.0f;
	private float distance = 0.0f;
	
	private TrackManager tm;
	
	// Use this for initialization
	void Start () {
		tm = FindObjectOfType(typeof(TrackManager)) as TrackManager;
	}
	
	// Update is called once per frame
	void Update () {
		float h = Input.GetAxis ("Vertical");
		//Debug.Log (h);
		if(Input.GetKey("up"))
		{
			velocity = (Time.deltaTime + velocity) % velocity;
			Debug.Log (velocity);
		}
		
		distance += Time.deltaTime * velocity;
		
		SplineInterpolator.TransformRotation tr = tm.si.GetTransformRotationAtLen(distance);
		
		if(tr == null)
		{
			distance = 0;
		}
		else
		{
			this.gameObject.transform.position = tr.pos;
			this.gameObject.transform.rotation = tr.rot;
		}
	}
}
