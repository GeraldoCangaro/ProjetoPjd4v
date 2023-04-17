using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerPointsUIController : MonoBehaviour
{
    private TMP_Text pointsText;
    private void OnEnable()
    {
        PlayerOBserver.OnPointsChanged += UpdatePoints;
    }
    
    private void OnDisable()
    {
        PlayerOBserver.OnPointsChanged -= UpdatePoints;
    }

    private void Awake()
    {
        pointsText = GetComponent<TMP_Text>();
    }

    private void UpdatePoints(int value)
    {
        pointsText.text = value.ToString();
    }

}
