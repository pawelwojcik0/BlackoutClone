using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePlayManager : Singleton<GamePlayManager>
{
    [SerializeField] private GameObject GameOver;

    private Target target;
    private HUD HUD;
    private int points;

    public int Points
    {
        get { return points; }
        set
        {
            points = value;
            HUD.UpdatePoints(points);
        }
    }

    private void Start()
    {
        target = FindObjectOfType<Target>();
        HUD = FindObjectOfType<HUD>();
        Points = 0;
    }

    private void Update()
    {
        if (GameOver.activeInHierarchy == true && Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
        }
    }
}
