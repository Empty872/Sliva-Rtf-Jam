using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private int value;

    public int PickUp()
    {
        Destroy(gameObject);
        return value;
    }
}