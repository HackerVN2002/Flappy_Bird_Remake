using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject pipe;  
    public float maxTime;
    float timer;
    public float height;

    private void Update()
    {
        if (timer > maxTime)
        {
            GameObject tmp = Instantiate(pipe,new Vector3(transform.position.x,transform.position.y + Random.Range(-height,height),transform.position.z), Quaternion.identity);
            tmp.layer = pipe.layer;
            Destroy(tmp, 10f);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
