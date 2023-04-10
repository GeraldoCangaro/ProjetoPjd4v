using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private PlayerInput _playerInput;
    private GameControls _controls;
    private Vector2 _moveInput;
    private bool _isShooting;

    //toda vez que o objeto é habilitado.
    private void OnEnable()
    {
        _playerInput.onActionTriggered += OnAction;
    }
    // toda vez que o objeto é desabilitado.
    private void OnDisable()
    {
        //onactionTriggered = quando a ação estiver acontececndo. (neste caso, negativo.)
        _playerInput.onActionTriggered -= OnAction;
    }

    // Start is called before the first frame update
    void Awake()
    {
        //Traduz o que o jogador fez no input.
        _controls = new GameControls();
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
    
    //Só funciona quando estiver alguma forma de ação no Input/Jogo.
    private void OnAction(InputAction.CallbackContext PlayerAct)
    {
        //Está chegando uma ação e if quer saber se a ação é igual ao nome da ação de atirar, e se for faz o jogador atirar.
        if (PlayerAct.action.name == _controls.Gameplay.Shoot.name)
        {
            // Fazer o player atirar!
            //PlayerAct.started == KeyDown (no momento que o jogador aperta a tecla)
            //playerAct.performed == Só executa quando o jogador aperta e solta
            //playerAct.canceled == KeyUp ( no momento que o jogador solta a tecla)
            
            // para atirar:
            // Forma 1: atira toda vez que o botão é pressionado
            // Forma 2: Atora ENQUANTO o botão estiver sendo pressionado
            
            //Forma usada: 2
            if (PlayerAct.started)
                _isShooting = true;
            else if (PlayerAct.canceled)
                _isShooting = false;
        }
        
        //Está chegando uma ação e if quer saber se a ação é igual ao nome da ação de mover, e se for faz o jogador se mover.
        if (PlayerAct.action.name == _controls.Gameplay.Movement.name)
        {
            _moveInput = PlayerAct.ReadValue<Vector2>();
        }
    }
    
}
