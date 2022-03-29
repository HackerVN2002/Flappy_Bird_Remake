using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bird : MonoBehaviour
{
    public Rigidbody2D rg;

    public GameObject gameOverobj;

    public float speed;

    public void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            rg.AddForce(Vector2.up * speed);
        }
    }

    public void resetGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    void GameOver()
    {
        gameOverobj.SetActive(true);
        Time.timeScale = 0;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameOver();
    }
}
