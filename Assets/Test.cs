using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;


public class Boss
{
    int mp = 53; // MP

    //���@�U���p�̊֐�
    public void Magic()
    {
        if (mp >= 5) 
        {
            mp -= 5;
            Debug.Log("���@�U���������B�c��MP��" + this.mp + "�B");
        }
        else
        {
                Debug.Log("MP������Ȃ����߁A���@���g���Ȃ��B");
        }
    }
      

}

public class Test : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        //�v�f��5�̔z������������A�e�v�f�ɒl��������
        int[] array = { 1, 2, 3, 4, 5 };

        //�z��̗v�f���̂Ԃ񂾂������ŏ������J��Ԃ�
        for (int i = 0; i < array.Length; i++)
        {
            //�z��̗v�f�����ׂĕ\������
            Debug.Log(array[i]);
        }

        //�z��̗v�f���̂Ԃ񂾂��~���ŏ������J��Ԃ�
        for (int i = 4; i >= 0; i--)
        {
            //�z��̗v�f�����ׂĕ\������
            Debug.Log(array[i]);

        }

        // Boss�N���X�ϐ���錾���ăC���X�^���X����
        Boss lastboss = new Boss();

        //11�񏈗����J��Ԃ�
        for(int a = 0; a < 11; a++)
        {
            //���@�U���p�̊֐����Ăяo��
            lastboss.Magic();
        }





    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
