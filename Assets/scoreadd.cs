using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class scoreadd : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        FindObjectOfType<score>().addCore();
    }
}
