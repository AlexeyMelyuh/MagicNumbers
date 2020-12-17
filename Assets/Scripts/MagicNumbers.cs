using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicNumbers : MonoBehaviour
{
    // Start is called before the first frame update
    int min = 1, max = 1000;
    int guess;
    bool gameOver = true;
    private void Start()
    {
        print("Загадайте число от "+ min + " до " + max);
        guess = (max + min) / 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                guess = (max + min) / 2;
                print("Это число " + guess + " ,верно?");
            }
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                max = guess;
                SizeGame();
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                min = guess;
                SizeGame();
            }
            if (Input.GetKeyDown(KeyCode.Return))
            {
                print("Всё верно!");
                gameOver = false;
            }
        }

    }

    void SizeGame()
    {
        guess = (max + min) / 2;
        print("Это число " + guess + " ,верно?");
    }


}
