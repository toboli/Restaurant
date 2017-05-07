using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//①アイテムを生成する
//②アイテムを生成したタイミングで、[次の生成タイミング]と[次の生成位置] を、例えばRandom.Range(10,20);のような形で変数に格納しておく
//③Updateで次の生成タイミングまで時間を計測する
//④次の生成タイミングになったら①に戻る

public class fukidashiGenerator : MonoBehaviour
{

    //吹き出しのprefab
    public GameObject[] fukidashiPrefabs;

    //ごはんのprefab
    public GameObject[] foodPrefabs;

    //ゲーム終了の判定
    private bool isEnd = false;


    // Use this for initialization
    void Start()
    {
       
    }



    //次に生成する時間 : 初期値1
    float nextGenerateTime = 3;

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Canvas").GetComponent<UIController>().time > 0)
        {

            //次に生成する時間をカウントダウンする
            nextGenerateTime -= Time.deltaTime;

            //次に生成する時間か判定する
            if (nextGenerateTime <= 0.5)
            {
                //0~配列の個数からランダムな数字を生成する
                int randomIndex = Random.Range(0, fukidashiPrefabs.Length);




                float x = Random.Range(5.5f, 7.0f);
                float y = Random.Range(-4.0f, 0.1f);



                //ランダムなインデックスに入っているプレファブを生成する
                Instantiate(fukidashiPrefabs[randomIndex], new Vector2(x, y), Quaternion.identity);

                //次に生成する時間をランダムに決める
                nextGenerateTime = Random.Range(1, 7);
            }
        }
        
        
    }

    public void FoodGenerate()
    {
        float x = Random.Range(-4.0f,4.0f);
        float y = Random.Range(1.6f,1.9f);

        //int randomIndex = Random.Range(0, foodPrefabs.Length);
        int randomIndex = Random.Range(0, fukidashiPrefabs.Length);
        Instantiate(foodPrefabs[randomIndex], new Vector2(x, y), Quaternion.identity);
    }

    public void Stop()
    {
        this.isEnd = true;
    }


}











