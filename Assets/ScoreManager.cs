using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{


    public GameObject score_object = null;
    public static int score_num = 0;//�X�R�A�ϐ�

    void Start()
    {
    }


    void Update()
    {
        Debug.Log(score_num);
        // �I�u�W�F�N�g����Text�R���|�[�l���g���擾
        Text score_text = score_object.GetComponent<Text>();
        // �e�L�X�g�̕\�������ւ���
        score_text.text = "Score" + score_num;
    }
}