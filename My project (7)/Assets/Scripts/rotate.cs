using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    public int valrotate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float rotz = 0;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow)) {

            rotz = transform.rotation.eulerAngles.z;
            if ( transform.rotation.eulerAngles.z < 270 )
            {
                StartCoroutine(RotCoroutinue());
            }
            
        }
    }

    IEnumerator RotCoroutinue() {

        // 목표시간에 회전처리 안됨
        for (int i = 0; i < valrotate; i++) {
            transform.Rotate(0, 0, 1f);

            //float angle = transform.rotation.eulerAngles.z;
            //if (angle > 30 && angle < 29)
            //{
            //    yield break;
            //}

            yield return null;
        }


    }

}
