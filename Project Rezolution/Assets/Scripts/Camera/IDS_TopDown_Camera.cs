using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IconicDesignStudios.Cameras
{
    public class IDS_TopDown_Camera : MonoBehaviour
    
    {

        public Transform cTarget;
        public float cHeight = 10f, cDistance = 20f, cAngle = 45f, cSmoothSpeed = 0.5f;
        private float yPosition = 0f;

        private Vector3 refVelocity;

    // Start is called before the first frame update
    void Start()
        {

            HandleCamera();
        }

        // Update is called once per frame
        void Update()
        {
            
            HandleCamera();
        }

        protected virtual void HandleCamera()
        {
            if (!cTarget)
            {
                return;
            }
            yPosition = cTarget.position.y;

            Vector3 worldPosition = (Vector3.forward * -cDistance) + (Vector3.up * (yPosition + cHeight));
            //Debug.DrawLine(cTarget.position, worldPosition, Color.red);

            //Build Rotated Vector
            Vector3 rotatedVector = Quaternion.AngleAxis(cAngle, Vector3.up) * worldPosition;
            //Debug.DrawLine(cTarget.position, worldPosition, Color.green);

            //Move Camera Position
            Vector3 flatTargetPosition = cTarget.position;
            flatTargetPosition.y = 0f;
            Vector3 finalPosition = flatTargetPosition + rotatedVector;
            //Debug.DrawLine(cTarget.position, finalPosition, Color.blue);

            transform.position = Vector3.SmoothDamp(transform.position, finalPosition, ref refVelocity, cSmoothSpeed);
            transform.LookAt(cTarget.position);
        }
    }
}





