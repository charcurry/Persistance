using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdjustScript : MonoBehaviour
{
    private void OnGUI()
    {
        if (GUI.Button(new Rect(10, 10, 100, 30), "Adjust Health"))
        {
            GameManager.manager.health += 10;
        }
        if (GUI.Button(new Rect(10, 40, 100, 30), "Adjust Experience"))
        {
            GameManager.manager.experience += 10;
        }
        if (GUI.Button(new Rect(10, 70, 100, 30), "Adjust Level"))
        {
            GameManager.manager.level += 1;
        }
        if (GUI.Button(new Rect(10, 100, 100, 30), "Adjust Gold"))
        {
            GameManager.manager.gold += 10;
        }
        if (GUI.Button(new Rect(10, 130, 100, 30), "Adjust Score"))
        {
            GameManager.manager.score += 10;
        }
        if (GUI.Button(new Rect(10, 160, 100, 30), "Adjust Lives"))
        {
            GameManager.manager.lives += 1;
        }
    }
}
