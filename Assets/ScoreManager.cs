using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{


    public GameObject score_object = null;
    public static int score_num;//�X�R�A�ϐ�
    public static int score_count;
    bool isBonusFlag = false;
    void Start()
    {
        score_num = 0;
        score_count = 0;

    }


    void Update()
    {
        // �I�u�W�F�N�g����Text�R���|�[�l���g���擾
        Text score_text = score_object.GetComponent<Text>();
        // �e�L�X�g�̕\�������ւ���
        score_text.text = "Score" + score_num;
        //�X�R�A�̒l�𒲐�����
        if (score_count == 100 && isBonusFlag == false)
        {
            score_num += 5000;
            isBonusFlag = true;

        }
    }
}