using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
        private bool isDragging = false;
        private Vector3 offset;
        public Material normal;
        public Material selected;
        private MeshRenderer mRender;
        public float multiplier = 1.2f;

        private void Start()
        {
            mRender = gameObject.GetComponent<MeshRenderer>();
        }

        void OnMouseDown()
        {
            isDragging = true;
            offset = gameObject.transform.position - GetMouseWorldPos();
            mRender.material = selected;
        }

        void OnMouseUp()
        {
            isDragging = false;
            mRender.material = normal;
        }

        void Update()
        {
            if (isDragging)
            {
                Vector3 mousePos = GetMouseWorldPos() + offset;
                transform.position = new Vector3(mousePos.x, mousePos.y, transform.position.z);
            }
        }

        Vector3 GetMouseWorldPos()
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = Camera.main.nearClipPlane;
            return Camera.main.ScreenToWorldPoint(mousePos);
        }

}
