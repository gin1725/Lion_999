using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Player : MonoBehaviour
{
    private int count_coin;//コイン枚数を数えるための変数
    private int goal_flag;//ゴールできる状態かどうかを判定
    [SerializeField] private TextMeshProUGUI TextCoin;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;  // FPSを60に設定
        count_coin = 0;
        goal_flag = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("up")) //↑なら前(Z方向)に0.1だけ進む
        {
            transform.position += transform.forward * 0.1f;
        }
        if(Input.GetKey("down")) // ↓なら-Z方向に0.1だけ進む
        {
            transform.position -= transform.forward * 0.1f;
        }
        if(Input.GetKey("right")) // →ならY軸に3度回転する
        {
            transform.Rotate(0f,3.0f,0f);
        }
        if(Input.GetKey("left")) // ←ならY軸に-3度回転する
        {
            transform.Rotate(0f,-3.0f,0f);
        }

        if (count_coin == 4)//コインを4枚集めたらプレイヤーをゴールできる状態にする
        {
            goal_flag = 1;
        }
        TextCoin.text = string.Format("COIN:{0}\nKEY:{0}", count_coin,goal_flag);
        
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "コイン")//オブジェクト名coinに当たったら取得とする
        {
            count_coin++;
        }
    }
}

