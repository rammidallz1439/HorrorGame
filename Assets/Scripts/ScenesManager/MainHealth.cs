using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainHealth : MonoBehaviour
{
    public static MainHealth _mg;
    public GameObject[] hearts;

    public int lives = 5;

    private void Awake()
    {
        if (!PlayerPrefs.HasKey("LivesCount"))
        {
            PlayerPrefs.SetInt("LivesCount", lives);
        }

    }
    private void Start()
    {
        SetLives(PlayerPrefs.GetInt("LivesCount"));
        _mg = this;

    }
    private void SetLives(int lifes)
    {
        Debug.Log(lifes);
        int length = hearts.Length;
        for (int i = length - 1; i >= 0; i--)
        {
            hearts[i].SetActive(i < lifes);
        }
    }

}
