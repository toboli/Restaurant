using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fukidashiDestroy : MonoBehaviour {

    private float sleeptime = 0f;
    private float deadlineTime = 5f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        sleeptime += Time.deltaTime;

        if (sleeptime > deadlineTime)
        {
            Destroy(this.gameObject);
        }

    }
}
