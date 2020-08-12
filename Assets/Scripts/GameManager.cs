using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public GameObject paddlePrefab;
	GameObject paddleClone;
	public GameObject brickPrefab;
	public GameObject deathParticles;
	public GameObject youWon;
	public GameObject gameOver;
	public static GameManager instance = null;

	public int lives = 3;
	public int noOfBricks = 16;
	public float resetDelay = 1.0f;
	public Text LivesText;
	Vector3 brickPos = new Vector3(1.808954f,0.1540221f,3.745659f);
	// Use this for initialization
	void Awake () {
		if (instance == null) {
			instance = this;
		} else if (instance != this) {
			Destroy(gameObject);
		}

		Setup ();
	}

	void Setup(){
		paddleClone = Instantiate (paddlePrefab, transform.position, Quaternion.identity) as GameObject;
		Instantiate (brickPrefab, brickPos, Quaternion.identity);
	}

	void GameOver(){
		if (noOfBricks < 1) {
			youWon.SetActive (true);
			Time.timeScale = 0.25f;
			Invoke ("Reset", resetDelay);
		} else if(lives < 1) {
			gameOver.SetActive (true);
			Time.timeScale = 0.25f;
			Invoke ("Reset", resetDelay);
		}
	}

	void  Reset(){
		Time.timeScale = 1.0f;
		Application.LoadLevel (Application.loadedLevel);
	}

	public void LostLife(){
		lives--;
		LivesText.text = "Lives : " + lives;
		Instantiate (deathParticles, paddleClone.transform.position, Quaternion.identity);
		Destroy (paddleClone);
		GameOver ();
		Invoke ("SetupPaddle", resetDelay);
	}

	void SetupPaddle(){
		paddleClone = Instantiate (paddlePrefab, transform.position, Quaternion.identity) as GameObject;
	}

	public void DestroyBrick(){
		noOfBricks--;
		GameOver ();
	}
	// Update is called once per frame
	void Update () {
	
	}
}
