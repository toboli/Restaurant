using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class foodfukidashicontroller : MonoBehaviour
{

   

    public GameObject target;
   



    // Use this for initialization
    void Start()
    {
      
        GameObject chef = GameObject.Find("chef");
        GameObject table = GameObject.Find("table");

        if (this.tag == "fukidashi")
        {
            target = chef;
        }
        else if (this.tag == "food")
        {
            target = table;
        }

    }

    public void OnDragging()
    {
        if (GameObject.Find("Canvas").GetComponent<UIController>().time > 0)
        {
            //Debug.Log("Dragging");

            Vector3 screenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
            transform.position = Camera.main.ScreenToWorldPoint(screenPoint);


            

        }
  
                
    }



    //インスペクターでドラッグ先のオブジェクトを設定する


    public void OnDragUp()

    {
        if (GameObject.Find("Canvas").GetComponent<UIController>().time > 0)
        {//Debug.Log("Dragged");//動いてるかわかんなかったら、こういうの入れて確かめること



            //インスペクターで設定したターゲットとの距離を求める
            Vector3 TargetPos = this.target.transform.position;
            Vector3 thisPos = this.transform.position;
            float distance = Vector3.Distance(TargetPos, thisPos);
            Debug.Log(distance);

            //ターゲットとの距離が⼀定値未満であれば（近ければ）実⾏する
            if (distance < 0.5f)
            {
                Debug.Log("Drag");
                //ターゲットが厨房の場合、注⽂を実⾏する
                if (target.tag == "chef")
                {
                    //注⽂の処理
                    Destroy(this.gameObject);

                    //⽣成スクリプトに命令を送る
                    GameObject.Find("GameObject").GetComponent<fukidashiGenerator>().FoodGenerate();

                }
                //ターゲットが客席の場合、スコアを加算する
                if (target.tag == "table")
                {
                    //スコア加算の処理//ほかのスクリプト上のscoreにたしていく
                    GameObject.Find("Canvas").GetComponent<UIController>().AddScore(10);
                    Destroy(this.gameObject);




                }
            }
        }


    }



    // Update is called once per frame
    void Update()
    {
        



    }

}

       



    




