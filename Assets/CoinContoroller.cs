using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinContoroller : MonoBehaviour
{
    int count;
    public AudioClip se;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(count > 99)
        {
            ScoreManager.score_num += 1000;
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        //プレイヤーに触れたらコインが消えるように処理する
        if (collision.gameObject.CompareTag("Player"))
        {
            count++;
            ScoreManager.score_num += 10;
            AudioSource.PlayClipAtPoint(se,transform.position);
            Destroy(this.gameObject);
        }
    }
}
