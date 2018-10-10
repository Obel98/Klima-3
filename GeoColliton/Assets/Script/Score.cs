using UnityEngine;
using UnityEngine.UI;
using System;

public class Score : MonoBehaviour
{

    public Transform player;
    public Text scoreText;
    // Update is called once per frame
    void Update()
    {

        double time = Time.unscaledTime;
        double roundedTime = Math.Round(time, 3);
        string timeString = roundedTime.ToString();
        // Tjekker om roundedTime bliver afrundet til et heltal, hvis dette er tilfældet, tilføjer vi ".000" til timeString,
        // for at sørge for at timeString har de tre decimaler vi ønsker.
        if (roundedTime.ToString().Equals(Math.Round(time).ToString()))
        {
            String finalTimeString = timeString + ".000";
            scoreText.text = finalTimeString;
            Debug.Log(finalTimeString);
        }
        // Tjekker om roundedTime bliver afrundet til nærmeste tiendedel af et sekund(dette vil ske hvis tiden fx er 1,200023432), hvis dette er tilfældet,
        // tilføjer vi ".000" til timeString, for at sørge for at timeString har de tre decimaler vi ønsker.
        else if (roundedTime.ToString().Equals(Math.Round(time, 1).ToString()))
        {
            String finalTimeString = timeString + "00";
            scoreText.text = finalTimeString;
            Debug.Log(finalTimeString);
        }
        // Tjekker om roundedTime bliver afrundet til nærmeste hundrededel af et sekund(dette vil ske hvis tiden fx er 1,2700023432), hvis dette er tilfældet,
        // tilføjer vi ".000" til timeString, for at sørge for at timeString har de tre decimaler vi ønsker.
        else if (roundedTime.ToString().Equals(Math.Round(time, 2).ToString()))
        {
            String finalTimeString = timeString + "0";
            scoreText.text = finalTimeString;
            Debug.Log(finalTimeString);
        }
        else
        {
            scoreText.text = timeString;
        }
    }
}
