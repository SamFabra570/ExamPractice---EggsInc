using System;
using UnityEngine;

public class GameManager : Subject<int>
{
    public static GameManager Instance { get; private set; }
    
    //public ScoreSubject scoreSubject;
    public ScoreUI scoreUI;

    private int chickens;
    
    private void Start()
    {
        //scoreSubject = FindObjectsByType<ScoreSubject>();
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }
        
        //scoreSubject.AddObserver(scoreUI);
    }

    private void Update()
    {
        
    }

    public void AddChicken(int value)
    {
        chickens += value;
        NotifyObservers(chickens);
    }

    public int GetChickens()
    {
        return chickens;
    }
}