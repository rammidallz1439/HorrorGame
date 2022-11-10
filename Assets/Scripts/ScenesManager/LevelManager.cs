using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private Button PlayButton;

    private void Start()
    {
        PlayButton.onClick.AddListener(() => { OnPlayButtonclicked();});
    }
    public void OnPlayButtonclicked()
    {
        SceneManager.LoadScene("InitialScene");
    }
}
