using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pointsManager : MonoBehaviour
{
    public cubePointsCollision notificador;
    public int points = 0;
    public Text pointText;
    public Text victoryText;
    
    // Start is called before the first frame update
    void Start()
    {
        notificador.fivePoints += addFive;
        notificador.tenPoints += addTen;
    }

    // Update is called once per frame
    void Update()
    {
        pointText.text = points.ToString();
        if(points == 100) victoryText.text = "Victory";
    }

    void addFive() {
        points += 5;
        Debug.Log("Current points = " + points);
    }

    void addTen() {
        points += 10;
        Debug.Log("Current points = " + points);
    }
}
