using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerEnergyUIController : MonoBehaviour
{
   private Slider energySlider;

   private void OnEnable()
   {
      PlayerOBserver.OnEnergyChanged += EnergyUpdate;
   }

   private void OnDisable()
   {
      PlayerOBserver.OnEnergyChanged -= EnergyUpdate;
   }

   private void Awake()
   {
      energySlider = GetComponent<Slider>();
   }

   private void EnergyUpdate(int value)
   {
      energySlider.value = value;
   }
   
}
