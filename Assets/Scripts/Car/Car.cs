using UnityEngine;
using System.Collections;

public class Car : MonoBehaviour {
	float CarAngle = 0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.localRotation = Quaternion.AngleAxis(Input.GetAxis("Horizontal")*(Input.GetButton("Boost")?10f:(Mathf.Lerp(30f,90f,Input.GetAxis("Break")))),Vector3.up);
	}
}
