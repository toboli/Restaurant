using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{

    private GameObject ScoreText; //スコア用変数
    private GameObject TimeText;//時間用変数


    private float time = 60;
    private int score = 0; //スコア計算用変数

    // Use this for initialization
    void Start()
    {

        this.TimeText = GameObject.Find("TimeText");
        this.ScoreText = GameObject.Find("ScoreText");

       
    }



    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "fukidashi")
        {
            score += 10;
            this.ScoreText.GetComponent<Text>().text = "Score:" + score + "pt";

        }
        else if (collision.gameObject.tag == "food")
        {
            score += 20;
            this.ScoreText.GetComponent<Text>().text = "Score:" + score + "pt";

        }

       


    }

   

    void Update()
    {
        //時間のこと
        //１秒に１ずつへる
        time -= Time.deltaTime;
        this.TimeText.GetComponent<Text>().text = "Time" + time;


        //マイナスは表示しない
        if (time < 0)
        {
            time = 0;
            this.TimeText.GetComponent<Text>().text = "Time" + time;
        }

        

    }


}