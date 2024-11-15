using UnityEngine;

public class ChickenSpawner : MonoBehaviour
{
    public ChickenType chickenType;
    
    float randValue = Random.value;
    
    void Update()
    {
        
        if (Input.anyKeyDown)
        {
            //GameObject chicken;
            
            GameObject chicken = ChickenFactory.CreateChicken(chickenType);
            
            /*if (randValue < 0.9f)
            {
                chicken = ChickenFactory.CreateChicken(chickenType.Chicken);
            }
            else
            {
                chicken = ChickenFactory.CreateChicken(chickenType.EvilChicken);
            }*/
            
            if (chicken != null)
            {
                //set position of spawned chicken
                chicken.transform.position = transform.position;
            }
            
        }
        
    }
}