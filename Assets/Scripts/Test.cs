using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        this.GetComponent<Transform>().Rotate(new Vector3(1.0f,0.0f,0.0f),.5f);
	}
    
}
