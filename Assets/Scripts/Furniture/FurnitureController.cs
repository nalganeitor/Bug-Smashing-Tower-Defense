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
                    gridController.showGrid = true;

                    //Activates grid colliders for mouse detection
                    for (int i = 0; i < gridController.gridSquares.Length; i++)
                    {
                        gridController.gridSquares[i].GetComponent<Collider2D>().enabled = true;
                    }

                    for (int i = 0; i < gridController.nonGridSquares.Length; i++)
                    {
                        gridController.nonGridSquares[i].GetComponent<Collider2D>().enabled = true;
                    }
                }
                else
                {
                    outline.SetActive(false);
                    isSelected = false;
                    gridController.showGrid = false;

                    //Dectivates grid colliders to stop mouse detection
                    for (int i = 0; i < gridController.gridSquares.Length; i++)
                    {
                        gridController.gridSquares[i].GetComponent<Collider2D>().enabled = false;
                    }

                    for (int i = 0; i < gridController.nonGridSquares.Length; i++)
                    {
                        gridController.nonGridSquares[i].GetComponent<Collider2D>().enabled = false;
                    }
                }
            }
        }


        if(isSelected)
        {
            if(Input.GetMouseButtonDown(0) && gridController.currentGridSquare != null && gridController.currentGridSquare.tag == "Grid")
            {
                transform.position = gridController.currentGridSquare.transform.position;
            }
        }
    }
}
