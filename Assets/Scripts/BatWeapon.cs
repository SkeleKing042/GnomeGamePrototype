//Created by Jackson Lucas
//Last edited by Jackson Lucas

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatWeapon : MonoBehaviour
{
    public ParticleSystem HitEffects;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy")
        {
            float hpLeft = other.gameObject.GetComponent<EnemyGnomeAI>().ReciveDamage(1);
            if (hpLeft > 0)
            {
                GameObject go = Instantiate(HitEffects, transform.position, Quaternion.identity).transform.gameObject;
                Destroy(go, 3);
            }
            
        }
    }
}
