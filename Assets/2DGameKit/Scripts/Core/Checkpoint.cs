using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gamekit2D
{
    [RequireComponent(typeof(BoxCollider2D))]
    public class Checkpoint : MonoBehaviour
    {
        public GameObject player;
        public bool respawnFacingLeft;

        private void Reset()
        {
            GetComponent<BoxCollider2D>().isTrigger = true; 
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            PlayerCharacter c = collision.GetComponent<PlayerCharacter>();
            if(c != null)
            {
                c.SetChekpoint(this);
                if (player.GetComponent<AcidScheduler>() != null)
                {
                    foreach (GrowingArea acid in player.GetComponent<AcidScheduler>().current)
                    {
                        if (acid != null)
                            acid.SetCheckpoint();
                    }
                }
            }
        }
    }
}