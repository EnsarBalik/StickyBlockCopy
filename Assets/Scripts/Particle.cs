using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle : MonoBehaviour
{
    public GameObject DeathEffect;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Particlee();
        }
    }
    void Particlee()
    {
        Instantiate(DeathEffect, transform.position, Quaternion.identity);
    }
}
