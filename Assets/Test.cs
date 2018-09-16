using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boss
{
    int mp = 53;

    public void Magic ()
    {
        if(this.mp >= 5)
        {
            this.mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp);
        } else
        {
            Debug.Log("MPが足りないため魔法が使えない");
        }
        
    }
}

public class Test : MonoBehaviour {

    

    // Use this for initialization
    void Start () {

        Boss Magician = new Boss();

        for (int i = 0; i <= 10; i++)
        {
            Magician.Magic();
        }
        
        

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
