using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdjustScript : MonoBehaviour
{
    // Adds buttons to adjust player stats on screen
    private void OnGUI()
    {
        if (GUI.Button(new Rect(200, 10, 150, 30), "Health Up"))
        {
            GameManager.manager.health += 10;
        }
        if (GUI.Button(new Rect(200, 40, 150, 30), "Health Down"))
        {
            GameManager.manager.health -= 10;
        }
        if (GUI.Button(new Rect(200, 70, 150, 30), "Experience Up"))
        {
            GameManager.manager.experience += 10;
        }
        if (GUI.Button(new Rect(200, 100, 150, 30), "Experience Down"))
        {
            GameManager.manager.experience -= 10;
        }
        if (GUI.Button(new Rect(200, 130, 150, 30), "Level Up"))
        {
            GameManager.manager.level += 1;
        }
        if (GUI.Button(new Rect(200, 160, 150, 30), "Level Down"))
        {
            GameManager.manager.level -= 1;
        }
        if (GUI.Button(new Rect(200, 190, 150, 30), "Gold Up"))
        {
            GameManager.manager.gold += 10;
        }
        if (GUI.Button(new Rect(200, 220, 150, 30), "Gold Down"))
        {
            GameManager.manager.gold -= 10;
        }
        if (GUI.Button(new Rect(200, 250, 150, 30), "Score Up"))
        {
            GameManager.manager.score += 10;
        }
        if (GUI.Button(new Rect(200, 280, 150, 30), "Score Down"))
        {
            GameManager.manager.score -= 10;
        }
        if (GUI.Button(new Rect(200, 310, 150, 30), "Lives Up"))
        {
            GameManager.manager.lives += 1;
        }
        if (GUI.Button(new Rect(200, 340, 150, 30), "Lives Down"))
        {
            GameManager.manager.lives -= 1;
        }

        if (GUI.Button(new Rect(550, 400, 150, 30), "Save"))
        {
            GameManager.manager.Save();
        }
        if (GUI.Button(new Rect(550, 430, 150, 30), "Load"))
        {
            GameManager.manager.Load();
        }
    }
}
