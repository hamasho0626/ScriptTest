﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Test : MonoBehaviour {

    

    // Use this for initialization
    void Start () {


        int[] points = { 20, 30, 40, 50, 60 };

        for (int i = 0; i < points.Length; i++)
        {
            Debug.Log(points[i]);
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
