using UnityEngine;

public enum ChickenType
{
    Chicken,
    EvilChicken
}

public class ChickenFactory
{
    public static GameObject CreateChicken(ChickenType type)
    {
        GameObject chickenPrefab = null;

        switch (type)
        {
            case ChickenType.Chicken:
                chickenPrefab = Resources.Load<GameObject>("Prefabs/Chicken");
                break;
            case ChickenType.EvilChicken:
                chickenPrefab = Resources.Load<GameObject>("Prefabs/EvilChicken");
                break;
        }

        if (chickenPrefab != null)
        {
            return Object.Instantiate(chickenPrefab);
        }
        else
        {
            Debug.LogError("Chicken prefab not found for type: " + type);
            return null;
        }
    }
}