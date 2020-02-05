using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace IconicDesignStudios.Controller
{
    public class IDS_RBPlayer_Inputs : MonoBehaviour
    {
        #region Variables
        [Header("Input Properties")]
        public Camera camera;
        #endregion

        #region Properties
        private Vector3 reticalPosition;
        public Vector3 ReticalPosition
        {
            get { return reticalPosition; }
        }

        private Vector3 reticalNormal;
        public Vector3 ReticalNormal
        {
            get { return reticalNormal; }
        }

        private float forwardInput;
        public float ForwardInput
        {
            get { return forwardInput; }
        }

        private float rotationInput;
        public float RotationInput
        {
            get { return rotationInput; }
        }
        #endregion

        #region Builtin Methods
        void Update()
        {
            if (camera)
            {
                HandleInputs();
            }
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawSphere(reticalPosition, 0.5f);
        }
        #endregion

        #region Custom Methods
        protected virtual void HandleInputs()
        {
            Ray screenRay = camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(screenRay, out hit))
            {
                reticalPosition = hit.point;
                reticalNormal = hit.normal;
            }

            forwardInput = Input.GetAxis("Vertical");
            rotationInput = Input.GetAxis("Horizontal");
        }
        #endregion
    }
}
