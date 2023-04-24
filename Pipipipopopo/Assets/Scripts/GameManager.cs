using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //Simbolo, oq será usado para acessar o GameManager de qualquer local do código.
    public static GameManager Instance;
    
 //Deixa editar a variavél do Controller do Unity
 
    [SerializeField] private GameObject enemyControllerPrefab;
    
// Lista identificando os tipos de inimigo
    [SerializeField] private List<EnemySO> enemyTypes;

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

    public void LoadLevel(string levelname)
    {
        SceneManager.LoadScene(levelname);
        SceneManager.LoadScene("GUI", LoadSceneMode.Additive);
    }

    private void Update()
    {
        if (Keyboard.current.digit1Key.wasPressedThisFrame)
        {
            SpawnEnemy(0);
        }
        if (Keyboard.current.digit1Key.wasPressedThisFrame)
        {
            SpawnEnemy(1);
        }
        if (Keyboard.current.digit1Key.wasPressedThisFrame)
        {
            SpawnEnemy(2);
        }
    }

    public void SpawnEnemy(int enemyType)
    {
        //Pode deixa inicialmente sem nada, ou instanciar em algum local (X, Y)
        GameObject enemy = Instantiate(enemyControllerPrefab); 
        
        int hp = enemyTypes[enemyType].hp;
        Sprite sprite = enemyTypes[enemyType].sprite;

        enemy.GetComponent<EnemyController>().Initialize(hp,sprite);
    }
    
}
