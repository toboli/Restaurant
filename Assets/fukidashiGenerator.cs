using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//①アイテムを生成する
//②アイテムを生成したタイミングで、[次の生成タイミング]と[次の生成位置] を、例えばRandom.Range(10,20);のような形で変数に格納しておく
//③Updateで次の生成タイミングまで時間を計測する
//④次の生成タイミングになったら①に戻る

public class fukidashiGenerator : MonoBehaviour {

    //吹き出しのprefab
    public GameObject fukidashi1_p;
    public GameObject fukidashi2_p;
    public GameObject fukidashi3_p;
    public GameObject fukidashi4_p;
    public GameObject fukidashi5_p;
    public GameObject fukidashi6_p;
    public GameObject fukidashi7_p;
    public GameObject fukidashi8_p;
    public GameObject fukidashi9_p;
    public GameObject fukidashi10_p;
    public GameObject fukidashi11_p;
    public GameObject fukidashi12_p;




    // Use this for initialization
    void Start() {

    }

    //生成されたアイテムの座標を保持する変数
    float position = 0;
    //時間を入れておく箱
    float time = 5;



    // Update is called once per frame
    void Update() {

        time += Time.deltaTime;

        if (time >= Random.value)
        {

            if (Random.Range(0, 11) == 0)
            {
                Instantiate(fukidashi1_p, new Vector3(-5f, 0f, position + 250f), fukidashi1_p.transform.rotation);

            } else if (Random.Range(0, 11) == 1)
            {
                Instantiate(fukidashi2_p, new Vector3(-5f, 0f, position + 250f), fukidashi2_p.transform.rotation);

            }
            else if (Random.Range(0, 11) == 2)
            {
                Instantiate(fukidashi3_p, new Vector3(-5f, 0f, position + 250f), fukidashi3_p.transform.rotation);

            }
            else if (Random.Range(0, 11) == 3)
            {
                Instantiate(fukidashi4_p, new Vector3(-5f, 0f, position + 250f), fukidashi4_p.transform.rotation);

            }
        }

        else if (time <= Random.value) { 



            if (Random.Range(0, 11) == 4)
        {
            Instantiate(fukidashi5_p, new Vector3(-5f, 0f, position + 250f), fukidashi5_p.transform.rotation);

        }
        else if (Random.Range(0, 11) == 5)
        {
            Instantiate(fukidashi6_p, new Vector3(-5f, 0f, position + 250f), fukidashi6_p.transform.rotation);

        }
        else if (Random.Range(0, 11) == 6)
        {
            Instantiate(fukidashi7_p, new Vector3(-5f, 0f, position + 250f), fukidashi7_p.transform.rotation);

        }
        else if (Random.Range(0, 11) == 7)
        {
            Instantiate(fukidashi8_p, new Vector3(-5f, 0f, position + 250f), fukidashi8_p.transform.rotation);

        }
    }

            position += Random.value;
        }

        }

    
        

