using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class LevelLoader : MonoBehaviour
{
    [SerializeField] private Button playButton;

    public void Start()
    {
        playButton.onClick.AddListener(() => { StartGame(); });
    }

    public void StartGame()
    {
        SceneManager.LoadScene("initialScene");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
