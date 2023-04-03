using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadSceneButton : MonoBehaviour
{
   public string SceneName;

   public void LoadScene()
   {
      GameManager.Instance.LoadScene(SceneName);
   }
}
