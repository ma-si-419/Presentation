using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleButton : MonoBehaviour
{

    GameObject Fade;
    bool isFlag;
    int count;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        Fade = GameObject.Find("Panel");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isFlag)
        {
            count++;
        }
        if (count > 50)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
    public void ClickStartButton()
    {
        Fade.SetActive(true);
        Fade.GetComponent<Feedin>().IsFadeOut();
        isFlag = true;
    }
}
