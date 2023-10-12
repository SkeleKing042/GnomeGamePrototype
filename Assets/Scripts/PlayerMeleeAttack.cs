using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMeleeAttack : MonoBehaviour
{
    public Collider HitBox;
    public Animator Animator;
    public void CastAttack()
    {
        Animator.SetTrigger("CastAttack");
    }
}
