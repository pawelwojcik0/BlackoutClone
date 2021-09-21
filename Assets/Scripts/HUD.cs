using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUD : MonoBehaviour
{
    [SerializeField] private TMPro.TextMeshProUGUI Points;
    [SerializeField] private GameObject GameOver;

    private void Start()
    {
        GameOver.SetActive(false);
    }

    public void UpdatePoints(int points)
    {
        Points.text = "" + points;
    }    


}
