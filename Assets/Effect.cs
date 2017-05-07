using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particle : MonoBehaviour {
    private ParticleSystem kirakira;

    // Use this for initialization
    void Start () {

        kirakira = this.GetComponent<ParticleSystem>();

        kirakira.Stop();

    }

    void OnTriggerEnter(Collider other)
    {

        //スコアが50こえたらきらめく
        if (GameObject.Find("Canvas").GetComponent<UIController>().score > 10)
        {

            //パーティクルを再生
            kirakira.Play();
          



        }
    }
            // Update is called once per frame
            void Update () {
		
	}
}
