using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IconicDesignStudios.Cameras
{
    public class IDS_TopDown_Camera : MonoBehaviour
    
    {

        public Transform cTarget, Player, Target;
        public Transform Obstruction;
        public float cHeight = 10f, cDistance = 20f, cAngle = 45f, cSmoothSpeed = 0.5f, zoomSpeed = 2f;
        private float yPosition = 0f;

        private Vector3 refVelocity;

    // Start is called before the first frame update
    void Start()
        {
            Obstruction = Target;
            HandleCamera();
        }

        // Update is called once per frame
        void Update()
        {
            ViewObstructed();
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

        void ViewObstructed()
        {
            RaycastHit hit;

            if (Physics.Raycast(transform.position, Target.position - transform.position, out hit, 4.5f))
            {
                if (hit.collider.gameObject.tag != "Player")
                    Obstruction = hit.transform;
                    Obstruction.gameObject.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;

                if (Vector3.Distance(Obstruction.position, transform.position) >= 3f && Vector3.Distance(transform.position, Target.position) >= 1.5f)
                {
                    transform.Translate(Vector3.forward * zoomSpeed * Time.deltaTime);
                }
            }
            else
            {
                Obstruction.gameObject.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
                if (Vector3.Distance(transform.position, Target.position) < 4.5f)
                {
                    transform.Translate(Vector3.back * zoomSpeed * Time.deltaTime);
                }
            }
        }
    }
}





