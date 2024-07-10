using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;  // FPSを60に設定
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

        if(transform.position.y <= -10.0f){
            SceneManager.LoadScene("Game Over");
        }
    }
}

