using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameoverScene : MonoBehaviour
{
    GameObject Player;
    Vector3 Playerpos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Playerpos = this.transform.position;
        if(Playerpos.y < 5)
        {
            SceneManager.LoadScene("GameoverScene");
        }
    }
}
