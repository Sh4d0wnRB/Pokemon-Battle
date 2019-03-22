using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrMaintwo : MonoBehaviour {

    public int n = 0;
    float d;
	// Use this for initialization
	void Start () {
        d = n % 2;
        if (d == 0)
        {
            if(n > 2 && n < 5)
            {
                Debug.Log("não estranho");
            }
            else
            {
                if (n > 6 && n < 20)
                {
                    Debug.Log("Estranho");
                }
                else
                {
                    if (n>20)
                    {
                        Debug.Log("não estranho");
                    }
                    else
                    {
                        Debug.Log("Estranho");
                    }

                }
            }
        }
        else
        {
            Debug.Log("Estranho");
        }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
