using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class GameController : MonoBehaviour {
    public static int score = 0;
    public string scorePrefix = "Score: ";

    public Text scoreText = null;
    public Text gameOverText = null;

    public static GameController gameController = null;

    void Awake() {
        gameController = this;
    }
	// Use this for initialization
	void Start () {
        gameController.gameOverText.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    public static void UpdateTextScore() {
        if (gameController.scoreText != null)
        {
            gameController.scoreText.text = gameController.scorePrefix + score.ToString();
        }
    }

    public static void GameOver() {
        if (gameController.gameOverText != null) {
            gameController.gameOverText.gameObject.SetActive(true);
        }
    }
}
