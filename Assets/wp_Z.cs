using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wp_Z : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        // �i�l�����j�G�ꂽ�u�ԂɃ{�[���ɐV�����ʒu�����Z�b�g����B
        // �u0.5f�v�̂悤�Ɂu�����v���g�p����ꍇ�ɂ͕K���uf�v���������Ɓi�|�C���g�j
        // �uf�v�́ufloat�i���������_�j�v�̗�
        other.gameObject.transform.position = new Vector3(2.5f, 16.73f,16.6f );
    }
}
