using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameoverScene : MonoBehaviour
{
    Vector3 Playerpos;
    int count;
    GameObject Fade;
    // Start is called before the first frame update
    void Start()
    {
        Fade = GameObject.Find("Panel");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Playerpos = this.transform.position;
        if(Playerpos.y < 5)
        {
            count++;
        }
        if(count > 50)
        {
            count = 0;
            Fade.SetActive(true);
            Fade.GetComponent<Feedin>().IsFadeOut();
            SceneManager.LoadScene("GameoverScene");
        }
    }
}
