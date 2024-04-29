using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    public GameObject tankPrefab;

    public void Start()
    {
        Instantiate(tankPrefab, transform.position, Quaternion.identity);
    }
}
