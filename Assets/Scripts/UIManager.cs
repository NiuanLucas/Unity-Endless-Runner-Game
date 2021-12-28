using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Image[] lifeHearts;
    public GameObject gameOverPanel;
    public Text textPoints;


    public void Update() {
       
    }

    public void UpdateLives(int lives){
        for (int i = 0; i < lifeHearts.Length; i++)
        {
            if(lives > i){
                lifeHearts[i].color = Color.white;
            } else {
                lifeHearts[i].color = Color.black;
            }
        }
    }


}
