using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public int score1;
    public Text text;
    public void addCore()
    {
        score1++;
        text.text = score1.ToString();
    }
}
