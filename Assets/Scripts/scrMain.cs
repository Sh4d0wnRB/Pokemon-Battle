using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrMain : MonoBehaviour {

    public KeyCode tecla;
    bool critical;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(tecla))
        {
          var dmg = dano(63, 50, 20);
          if (critical)
          {
              dmg = dmg * 2;
          }
          Debug.Log(dmg);
        }
	}
    void modificador()
    {

    }

    float dano(int lvl, int atk, int poder, float mod = 1)
    {
        return (((((2 * lvl) / 5) + 2 * poder * atk) / 50) + 2) * mod;
    }
}
