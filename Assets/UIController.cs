using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{

    private GameObject ScoreText; //スコア用変数
    private GameObject TimeText;//時間用変数
    private GameObject GameOverText;//ゲームオーバー表示用


    public float time = 60;
    public int score = 0; //スコア計算用変数

    GameObject refObj;
    GameObject refObj2;
    // ゲームオーバの判定
    private bool isGameOver = false;




    public void AddScore(int addScore)
    {
        //Debug.Log("Drag");
        this.score += addScore;
        this.ScoreText.GetComponent<Text>().text = "Score:" + score + "pt";

    }

    // Use this for initialization
    void Start()
    {

        this.TimeText = GameObject.Find("TimeText");
        this.ScoreText = GameObject.Find("ScoreText");
        this.GameOverText = GameObject.Find("GameOverText");


    }


    public void Update()
    {
        //時間のこと
        //１秒に１ずつへる
        time -= Time.deltaTime;
        this.TimeText.GetComponent<Text>().text = "Time" + time.ToString("f2");


        //マイナスは表示しない
        if (time < 0)
        {
            time = 0;
            this.TimeText.GetComponent<Text>().text = "Time" + time;

            // UIControllerのGameOver関数を呼び出して画面上に「GameOver」と表示する
            GameObject.Find("Canvas").GetComponent<UIController>().GameOver();


        }

        


    }

    public void GameOver()
    {
        // ゲームオーバになったときに、画面上にゲームオーバを表示する
        this.GameOverText.GetComponent<Text>().text = "GameOver";
        


    }
}