using UnityEngine;
using System.Collections;

public class CollissionDamage : MonoBehaviour {

    public float damagePoints = 20.0f;

    void OnTriggerStay(Collider otherCollider) {
        Health health = otherCollider.gameObject.GetComponent<Health>();
        Debug.Log("Aqui2");
        if (health == null)
            return;
        Debug.Log("Aqui");
        health.healthPoints -= damagePoints * Time.deltaTime;
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
