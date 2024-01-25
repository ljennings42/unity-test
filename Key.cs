using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    [SerializeField] private Transform location;
    private bool collected;

    public bool isCollected()
    {
        return collected;
    }

    public void collectKey()
    {
        collected = true;
    }


}
