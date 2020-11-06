using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W5_StatusSystem : MonoBehaviour
{
    [Range(0, 200)] public float hp = 100.0f;
    //[Range(0, 200)] public float playerHP = 100.0f;

    public delegate void DelegateHandleTakeDamage(GameObject damageFrom, float inDamge);
    public delegate void DelegateHandleDead();

    public event DelegateHandleTakeDamage OnTakeDamage;
    public event DelegateHandleDead OnDead;

    public void TakeDamage(GameObject damageFrom, float inDamage)
    {
        if(hp > 0)
        {
            hp -= inDamage;

            if(OnTakeDamage != null)
            {
                OnTakeDamage(damageFrom, inDamage);
            }

            if(hp <= 0)
            {
                if(OnDead != null)
                {
                    OnDead();
                }
            }
        }
    }

    public bool IsAlive()
    {
        return hp > 0;
    }
}
