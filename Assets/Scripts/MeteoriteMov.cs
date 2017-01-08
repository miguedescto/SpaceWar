using UnityEngine;
using System.Collections;

public class MeteoriteMov : MonoBehaviour {

    private Transform theTransform = null;

    public float maxSpeed = 2.0f;
    void Awake()
    {
        theTransform = GetComponent<Transform>();
    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {       
        theTransform.position += theTransform.forward * maxSpeed * Time.deltaTime;
        theTransform.localRotation = Quaternion.LookRotation(new Vector3(0.0f,0.0f,-1.0f).normalized, Vector3.up);
        Debug.Log(theTransform.position);
        if (theTransform.position.z < -8) {
            Destroy(gameObject);
        }
    }
}
