using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Player
{
    public class PlayerMov : MonoBehaviour
    {
        [SerializeField] float speed = 0.1f;

        float cameraRotateSpeed = 5.0f;

        float fixedZAxis = 0.0f;

        Animator animator;

        void Awake()
        {
            animator = GetComponent<Animator>();
        }

        void Update()
        {
            playerAction();
            CameraAction();
        }

        void playerAction()
        {
            Vector3 playerVector = Vector3.zero;
            if (Input.GetKey(KeyCode.W))
            {
                playerVector.z = speed;
            }
            if (Input.GetKey(KeyCode.A))
            {
                playerVector.x = - speed;
            }
            if (Input.GetKey(KeyCode.S))
            {
                playerVector.z = - speed;
            }
            if (Input.GetKey(KeyCode.D))
            {
                playerVector.x = speed;
            }
            if (playerVector.x != 0 || playerVector.z != 0)
            {
                transform.position += transform.rotation * playerVector;
                animator.SetBool("onWalk", true);
            }
            else
            {
                animator.SetBool("onWalk", false);
            }

        }

        void CameraAction()
        {
            if (Input.GetMouseButton(0))
            {
                float rotateX = Input.GetAxis("Mouse X") * cameraRotateSpeed;
                float rotateY = Input.GetAxis("Mouse Y") * cameraRotateSpeed;
                this.gameObject.transform.Rotate(rotateY, rotateX, 0.0f);

            }

            Vector3 currentRotation = this.gameObject.transform.rotation.eulerAngles;
            currentRotation.z = fixedZAxis;
            this.gameObject.transform.rotation = Quaternion.Euler(currentRotation);

        }
    }
}

