using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class foodfukidashicontroller : MonoBehaviour {

    private GameObject scoreText;
    private int score=0;

    // Use this for initialization
    void Start() {
        //シーン中のscoreTextオブジェクトを取得
        this.scoreText = GameObject.Find("Score");

    }

    public void OnDragging()
    {
        Debug.Log("Dragging");

        Vector3 screenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y,10);
        transform.position = Camera.main.ScreenToWorldPoint(screenPoint);
    }



    //インスペクターでドラッグ先のオブジェクトを設定する
    public GameObject target;
    public void OnDragUp()
    {
        //インスペクターで設定したターゲットとの距離を求める
        float distance = this.target.transform.position.z- this.transform.position.z;

        //ターゲットとの距離が⼀定値未満であれば（近ければ）実⾏する
        if (distance < 0.5f)
        {
            //ターゲットが厨房の場合、注⽂を実⾏する
            if (target.tag=="chef")
            {
                //注⽂の処理
                Destroy(this);
                //⽣成スクリプトに命令を送る(?)

            }
            //ターゲットが客席の場合、スコアを加算する
            if (target.tag=="table")
            {
                //スコア加算の処理
                this.score += 10;

                //UIに命令を送る
                this.scoreText.GetComponent < Text >().text= "Score" + this.score + "pt";

                
            }
        }
    }



    // Update is called once per frame
    void Update () {

        }
    }

