using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effect: MonoBehaviour {
    private ParticleSystem particle;

    // Use this for initialization
    void Start () {

        particle = this.GetComponent<ParticleSystem>();

        particle.Stop();

    }

    void OnTriggerEnter2D(Collider2D other)
    {

        //スコアが50こえたらきらめく
        if (GameObject.Find("Canvas").GetComponent<UIController>().score > 50)
        {

            //パーティクルを再生
            particle.Play();
          



        }
    }
            // Update is called once per frame
            void Update () {
		
	}
}
