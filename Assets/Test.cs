using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;


public class Boss
{
    int mp = 53; // MP

    //魔法攻撃用の関数
    public void Magic()
    {
        if (mp >= 5) 
        {
            mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");
        }
        else
        {
                Debug.Log("MPが足りないため、魔法が使えない。");
        }
    }
      

}

public class Test : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        //要素数5の配列を初期化し、各要素に値を代入する
        int[] array = { 1, 2, 3, 4, 5 };

        //配列の要素数のぶんだけ昇順で処理を繰り返す
        for (int i = 0; i < array.Length; i++)
        {
            //配列の要素をすべて表示する
            Debug.Log(array[i]);
        }

        //配列の要素数のぶんだけ降順で処理を繰り返す
        for (int i = 4; i >= 0; i--)
        {
            //配列の要素をすべて表示する
            Debug.Log(array[i]);

        }

        // Bossクラス変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        //11回処理を繰り返す
        for(int a = 0; a < 11; a++)
        {
            //魔法攻撃用の関数を呼び出す
            lastboss.Magic();
        }





    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
