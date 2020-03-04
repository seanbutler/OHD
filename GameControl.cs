using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    public static GameControl instance;         //A reference to our game control script so we can access it statically.
    public Text scoreText;                      //A reference to the UI text component that displays the player's score.
    public Text gameOverText;                       //A reference to the UI text component that displays the player's score.

    public int playerScore = 0;
    public int playerLives = 1;

    void Awake()
    {
        //If we don't currently have a game control...
        if (instance == null)
            //...set this one to be it...
            instance = this;
        //...otherwise...
        else if (instance != this)
            //...destroy this one because it is a duplicate.
            Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start() {
        gameOverText.enabled = false;
        playerScore = 0;
        scoreText.text = "Score: " + playerScore.ToString();
    }

    public void IncreaseScore()
    {
        playerScore += 1;
        scoreText.text = "Score: " + playerScore.ToString();
    }

    public void HurtPlayer()
    {
        playerLives -= 1;
        gameOverText.enabled = true;
    }


}
