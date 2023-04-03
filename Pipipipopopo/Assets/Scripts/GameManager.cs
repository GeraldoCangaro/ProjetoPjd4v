using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //Simbolo, oq será usado para acessar o GameManager de qualquer local do código.
    public static GameManager Instance;
    
    //Execução que é executada no start.
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        DontDestroyOnLoad(transform);
        }
        else
            Destroy(gameObject);
    }

    private void Start()
    {
        LoadScene("MainMenu");
    } 

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
            
    
}
