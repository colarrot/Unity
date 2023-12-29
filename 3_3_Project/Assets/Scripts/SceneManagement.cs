using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class SceneManagement : MonoBehaviour
{  
    public void ChangeScene()
    {
        SceneManager.LoadScene("MainScene");
    }

    
}
