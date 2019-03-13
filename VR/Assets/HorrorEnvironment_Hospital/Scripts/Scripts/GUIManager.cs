using UnityEngine;
using System.Collections;

public class GUIManager : MonoBehaviour {

	public static GUIManager instance;

	private int score;
	private static int hiScore;

	private int bullet;

	private Player player;




	// Use this for initialization
	void Start () {
		instance = this;

		player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
		if(player.IsDeath()){
			GUI.skin.label.alignment = TextAnchor.MiddleCenter;
			GUI.skin.label.fontSize = 40;
			GUI.Label(new Rect(0, 0, Screen.width, Screen.height), "Game Over");

			GUI.skin.label.fontSize = 30;
			if(GUI.Button(new Rect(Screen.width*0.5f - 150, Screen.height*0.75f, 300, 40), "Try again")){
				UnityEngine.SceneManagement.SceneManager.LoadScene("demo");
			}
		}
	}

}
