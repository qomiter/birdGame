using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    
    [SerializeField] string _nextLevelName;

    Monster[] _monsters;
    
    void OnEnable()
    {
        _monsters = FindObjectsOfType<Monster>();
    }

    void Update()
    {
        if (MonstersAreAllDead())
            GoToNextLevel();
    }

    void GoToNextLevel()
    {
        Debug.Log("Go to Next Level " + _nextLevelName);
    }

    bool MonstersAreAllDead()
    {
        foreach (var monster in _monsters)
        {
            if(monster.gameObject.activeSelf)
                return false;
        }
        return true;
    }
}
