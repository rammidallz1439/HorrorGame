using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private Button PlayButton;
    [SerializeField] private Button QuitButton;

    private void Start()
    {
        PlayButton.onClick.AddListener(() => { OnPlayButtonclicked();});
        QuitButton.onClick.AddListener(() => { onQuitButton(); });
    }
    public void OnPlayButtonclicked()
    {
        SceneManager.LoadScene("InitialScene");
    }
    public void onQuitButton()
    {
        Application.Quit();
    }

}
