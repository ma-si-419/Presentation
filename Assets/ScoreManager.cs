using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{


    public GameObject score_object = null;
    public static int score_num = 0;//スコア変数
    public static int score_count = 0;
    bool isBonusFlag = false;
    void Start()
    {

    }


    void Update()
    {
        // オブジェクトからTextコンポーネントを取得
        Text score_text = score_object.GetComponent<Text>();
        // テキストの表示を入れ替える
        score_text.text = "Score" + score_num;
        //スコアの値を調整する
        if(score_count == 100 && isBonusFlag == false)
        {
            score_num += 5000;
            isBonusFlag= true;
        
        }
    }
}