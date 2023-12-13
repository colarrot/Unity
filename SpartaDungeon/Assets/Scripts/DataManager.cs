using System.Collections;
using System.Collections.Generic;
using UnityEditor.U2D.Aseprite;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager instance;

    public PlayerStats playerStats;
    public GameData gameData;

    private void Awake()
    {
        instance = this;
    }
}
