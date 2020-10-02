using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W5_Spawner : MonoBehaviour
{
    public GameObject zombie;

    private void Awake()
    {
        
    }

    private void Start()
    {
        W5_EventManager.instance.StartListening("Spawn", Spawn);
    }

    private void Update()
    {
        
    }

    private void FixedUpdate()
    {
        
    }

    private void LateUpdate()
    {
        
    }

    public void Spawn()
    {
        Instantiate(zombie, this.transform.position, this.transform.rotation);
    }
}
