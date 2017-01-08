using UnityEngine;
using System.Collections;

public class ScorePointOnDestroy : MonoBehaviour {
    public int scorePoints = 200;

    void OnDestroy() {
        GameController.score += scorePoints;
        GameController.UpdateTextScore();
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
