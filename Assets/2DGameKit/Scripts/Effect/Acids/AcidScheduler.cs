using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gamekit2D
{
    public class AcidScheduler : MonoBehaviour
    {
        public GrowingArea[] current = new GrowingArea[2];
        public GrowingArea phase1;
        public GrowingArea phase2Left;
        public GrowingArea phase2Right;
        public GrowingArea phase3Left;
        public GrowingArea phase3Right;

        // Update is called once per frame
        void Update()
        {
            if(gameObject.transform.position.y <= 20)
            {
                current[0] = phase1;
            }
            else if(gameObject.transform.position.y <= 40)
            {
                current[0] = phase2Left;
                current[1] = phase2Right;
            }
            else
            {
                current[0] = phase3Left;
                current[1] = phase3Right;
            }
        }
    }
}

