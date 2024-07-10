using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // この2行を追加する.
using TMPro; // この2行を追加する.

public class time : MonoBehaviour
{
    // Textを外部に出力するための変数を定義する
    // [...]をつけることで,内部変数がインスペクターから操作できるようになる.
    // private を public にしても操作可能になる.
    [SerializeField] public TextMeshProUGUI TextTime;
    // 経過時間を格納する変数 ここに開始からの時間が格納される.
    private float elapsedTime;
    // Start is called before the first frame update
    void Start()
    {
        elapsedTime = 300.0F; // 時間を初期化する
    }
    // Update is called once per frame
    void Update()
    {
        //前のフレームからの経過時間(秒)を加算する
        elapsedTime -= Time.deltaTime;
        // 経過時間を表示するために,経過時間を秒にしたストリングを作成する.
        TextTime.text = string.Format("Time {0:f2} sec", elapsedTime);
    }
}
