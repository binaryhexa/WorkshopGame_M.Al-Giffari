using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool isGameOver;

    public GameObject[] Burger;

    public int collectedBurger;

    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);
        isGameOver = false;
        collectedBurger = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (collectedBurger == Burger.Length)
        {
            GameOver();
        }
    }

    void GameOver()
    {
        isGameOver = true;
        panel.SetActive(true);
        foreach(var hamburger in Burger)
        {
            hamburger.SetActive(false);
        }
    }

    public void DisplayBurger()
    {
        for(int i = 0; i < collectedBurger; i++)
        {
            Burger[i].GetComponent<Image>().color = Color.white;
        }
    }
}
