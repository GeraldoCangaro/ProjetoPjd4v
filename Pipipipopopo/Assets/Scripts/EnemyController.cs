
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private int hp;

    [SerializeField] private Sprite mySprite;

    private SpriteRenderer myRenderer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Initialize(int hp, Sprite mesh)
    {
        this.hp = hp;
        mySprite = mesh;

        myRenderer = GetComponentInChildren<SpriteRenderer>();
        myRenderer.sprite = mySprite;
    }
}
