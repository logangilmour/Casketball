using UnityEngine;
using System.Collections;

public class Car : MonoBehaviour {
	// Use this for initialization
	Animator animator;
	static int smoothing = 10;
	float[] average = new float[smoothing];
	
	void Start () {
		animator = this.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		float angle = (Input.GetAxis("Horizontal")*(Input.GetButton("Boost")?0.04f:(Mathf.Lerp(0.1f,0.25f,Input.GetAxis("Break")))));
		float avg = 0f;
		
		for(int i=1; i<smoothing;i++){
			average[i-1]=average[i];
			avg+=average[i];
			
		}
		avg+=angle;
		average[smoothing-1]=angle;
		avg/=smoothing;
        animator.SetFloat("Angle",(avg%1+1)%1);
        
	}
}
