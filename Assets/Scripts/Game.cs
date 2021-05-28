using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    [SerializeField] GameObject gamecanvas;

    private void Start()
    {
        Time.timeScale = 1;

    }
public void StartGame()
    {
        gamecanvas.SetActive(false);
        Time.timeScale = 0;
    }
    public void Replay()
    {
        SceneManager.LoadScene("Meat Grinder");
    }
}
