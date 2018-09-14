using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

    

	// Use this for initialization
	void Start () {
        int money = 600;

        if(money <= 50)
        {
            Debug.Log("武器を売る");
        } else if(money >= 200)
        {
            Debug.Log("武器を買う");
        } else
        {
            Debug.Log("ポーションを買う");
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
