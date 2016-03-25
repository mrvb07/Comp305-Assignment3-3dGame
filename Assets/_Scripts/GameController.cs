using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
    //PRIVATE INSTANCE VARIABLES
    private int _scoreValues;
    private int _livesValues;

    //PUBLIC INSTANCE VARIABLES
    public Text ScoreLabel;
    public Text LivesLabel;
    public Text TimeLeftLabel;
    public Text GameOverLabel;
    public Text VictoryLabel;
    public Text YourScoreLabel;

    public Button RestartButton;
    public Button QuitButton;
    public CarObject carObject;
    public Camera cam;
    public float timeLeft = 5.0f;
    public bool stop = true;

    public int ScoreValues
    {
        get
        {
            return this._scoreValues;
        }
        set
        {
            this._scoreValues = value;
            this.ScoreLabel.text = "Score: " + this._scoreValues / 20;
        }
    }
    public int LivesValues
    {
        get
        {
            return this._livesValues;
        }

        set
        {
            this._livesValues = value;
            if (this._livesValues <= 0)
            {
               this._endGame();
                
            }
            else
            {
                this.LivesLabel.text = "Lives: " + this._livesValues;
            }

        }
    }

    // Use this for initialization
    void Start()
    {
        this._init();
    }

    // Update is called once per frame
    void Update()
    {
        this.ScoreValues += 1;
        timeLeft -= Time.deltaTime;
        TimeLeftLabel.text = "Time Left:" + Mathf.Round(timeLeft);
        if (timeLeft <= 0)
        {
            
            this._endGame();
        }
       
        //this.TimeLeftValues -= 1;
    }

    private void _init()
    {
        this.cam.enabled = false;
        this.ScoreValues = 0;
        this.LivesValues = 10;
        
        this.GameOverLabel.enabled = false;
        this.VictoryLabel.enabled = false;
        this.RestartButton.gameObject.SetActive(false);
        this.QuitButton.gameObject.SetActive(false);
        this.LivesLabel.enabled = true;
        this.ScoreLabel.enabled = true;
        this.YourScoreLabel.enabled = false;

    }


    private void _endGame()
    {
        
        this.cam.enabled = true;
        
        this.LivesLabel.enabled = false;
        this.ScoreLabel.enabled = false;
        this.GameOverLabel.enabled = true;
        this.VictoryLabel.enabled = false;
        this.RestartButton.gameObject.SetActive(true);
        this.QuitButton.gameObject.SetActive(true);
        this.TimeLeftLabel.enabled = false;
        this.YourScoreLabel.enabled = true;
        this.YourScoreLabel.text = "High Score: " + this._scoreValues / 20;
        this.carObject.gameObject.SetActive(false);
    }
    public void restartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void quitButton()
    {
        Application.Quit();
    }

    public void finishRace()
    {
        this.cam.enabled = true;
        this.LivesLabel.enabled = false;
        this.ScoreLabel.enabled = false;
        this.VictoryLabel.enabled = true;
        this.GameOverLabel.enabled = false;
        this.RestartButton.gameObject.SetActive(true);
        this.QuitButton.gameObject.SetActive(true);
        this.TimeLeftLabel.enabled = false;
        this.YourScoreLabel.enabled = true;
        this.YourScoreLabel.text = "High Score: " + this._scoreValues / 20;
        this.carObject.gameObject.SetActive(false);
        
    }

}
