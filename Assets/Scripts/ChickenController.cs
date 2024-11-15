using System;
using UnityEngine;

public class ChickenController : Subject<int>
{
    public GameObject target;

    public int chickensAdded = 1;

    private void Awake()
    {
        target = GameObject.FindGameObjectWithTag("Target");
        
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position,
            Time.deltaTime * 5f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (CompareTag("Target"))
        {
            Debug.Log("bawk bawk in da barn");
            
            GameManager gameManager = FindObjectOfType<GameManager>();
            
            
            
            if (gameManager != null)
            {
                gameManager.AddChicken(chickensAdded);
            }
            else
            {
                Debug.LogError("GameManager not found");
            }
        
            Destroy(gameObject);
        }
    }
}
