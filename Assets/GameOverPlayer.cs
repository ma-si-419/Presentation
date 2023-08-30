using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverPlayer : MonoBehaviour
{
    Vector3 Playerpos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Playerpos = this.transform.position;
        if(Playerpos.y < -5 )
        {
            Playerpos.y = 10;
        }
    }
}
