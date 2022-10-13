using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    private PlayerControler pc;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        pc = collision.gameObject:GetComponent<PlayerControler>();
        pc.score += 1;
        Destroy(this.gameObject);
    }
}
