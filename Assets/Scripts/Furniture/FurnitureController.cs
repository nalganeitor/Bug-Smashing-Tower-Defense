using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FurnitureController : MonoBehaviour
{
    [SerializeField] private GameObject selectedObject, outline;
    bool isSelected;

    [SerializeField] GridController gridController;

    private void Update()
    {
        MouseFurnitureControl();
    }




    void MouseFurnitureControl()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition); //gets mouse position

            Collider2D targetObject = Physics2D.OverlapPoint(mousePosition); //checks if mouse position overlaps collider

            if (targetObject == GetComponent<Collider2D>())
            {
                //Activates outline and marks furniture as selected
                if (!isSelected)
                {
                    outline.SetActive(true);
                    isSelected = true;
                }
                else
                {
                    outline.SetActive(false);
                    isSelected = false;
                }
            }
        }


        if(isSelected)
        {
            if(Input.GetMouseButtonDown(0) && gridController.currentGridSquare != null)
            {
                transform.position = gridController.currentGridSquare.transform.position;
            }
        }
    }
}
