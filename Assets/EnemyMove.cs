using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] Transform target;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        //transform.Translate(p);

        var heading = target.position - transform.position;
        var distance = heading.magnitude;
        if (distance < 5.0)
        {
            Quaternion lookRotation = Quaternion.LookRotation(target.transform.position - transform.position, Vector3.up);

            lookRotation.z = 0;
            lookRotation.x = 0;

            transform.rotation = Quaternion.Lerp(transform.rotation, lookRotation, 0.1f);

            Vector3 p = new Vector3(0f, 0f, 0.025f);
            transform.Translate(p);
        }

    }
}
