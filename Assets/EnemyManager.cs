using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyManager : MonoBehaviour
{
    public GameObject[] enemy; 

    
    void Start()
    {
        
    }

    void Update()
    {
        
        if (AllEnemiesDestroyed())
        {
            SceneManager.LoadScene("WinScreen");
        }
    }

    bool AllEnemiesDestroyed()
    {
    
        for (int i = 0; i < enemy.Length; i++)
        {
            if (enemy[i] != null)
            {
               
                return false;
            }
        }

        return true;
    }
}

