using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectedObjController : MonoBehaviour
{
    PlayerManager playerManager;
    [SerializeField] Transform sphere;
    void Start()
    {
        playerManager = GameObject.FindGameObjectWithTag("PlayerManager").GetComponent<PlayerManager>();

        sphere = transform.GetChild(0);

        if (GetComponent<Rigidbody>() == null)
        {
            gameObject.AddComponent<Rigidbody>();

            Rigidbody rb = GetComponent<Rigidbody>();

            rb.useGravity = false;
            rb.constraints = RigidbodyConstraints.FreezeAll;

            GetComponent<Renderer>().material = playerManager.CollectedMaterial;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("collectibleObj"))
        {
            if (!playerManager.collidedList.Contains(collision.gameObject))
            {
                collision.gameObject.tag = "CollectedObj";
                collision.transform.parent = playerManager.collectedPooolTransform;
                playerManager.collidedList.Add(collision.gameObject);
                collision.gameObject.AddComponent<CollectedObjController>();
            }
        }
        if (collision.gameObject.CompareTag("Enemy"))
        {
            DestroyTheObject();
        }
    }

    void DestroyTheObject()
    {
        Destroy(gameObject);
    }
}
