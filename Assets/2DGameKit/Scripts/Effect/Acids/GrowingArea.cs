using System.Collections;
using System.Collections.Generic;
using Gamekit2D;
using UnityEngine;

namespace Gamekit2D
{
    public class GrowingArea : MonoBehaviour
    {
        public bool IsRising = false;
        public float UpperBoundScale = 40f;
        private const float LowerBoundScale = 1f;

        private const float RisingSpeed = 0.05f;
        private const float FallingSpeed = 0.07f;

        protected Vector3 LastScale;
        protected bool LastRising;

        // Start is called before the first frame update
        void Start()
        {
            LastScale = gameObject.GetComponent<Transform>().localScale;
            LastRising = IsRising;
        }

        // Update is called once per frame
        void Update()
        {
            if (IsRising)
                Rise();
            else
                Fall();
        }

        // Calculate Rising and Falling
        void Rise()
        {
            if (gameObject.transform.localScale.y < UpperBoundScale)
            {
                gameObject.transform.localScale += new Vector3(0, RisingSpeed, 0);
            }
        }

        void Fall()
        {
            if (gameObject.transform.localScale.y > LowerBoundScale)
            {
                gameObject.transform.localScale -= new Vector3(0, FallingSpeed, 0);
            }
        }

        // Receive message from Switch
        public void ReceiveMeesage()
        {
            IsRising = !IsRising;
        }

        public void SetCheckpoint()
        {
            LastScale = gameObject.GetComponent<Transform>().localScale;
            LastRising = IsRising;
        }

        public void SetToCheckpoint()
        {
            gameObject.GetComponent<Transform>().localScale = LastScale;
            IsRising = LastRising;
        }
    }

}
