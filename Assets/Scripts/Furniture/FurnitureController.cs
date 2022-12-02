using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FurnitureController : MonoBehaviour
{
    [SerializeField] private GameObject selectedObject, outline;
    [SerializeField] bool isSelected;
    [SerializeField] Collider2D targetObject;

    [SerializeField] GridController gridController;

    LayerMask mask;

    private void Awake()
    {
        mask = LayerMask.GetMask("Item");
    }

    private void Update()
    {
        MouseFurnitureControl();
    }




    void MouseFurnitureControl()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition); //gets mouse position

            targetObject = Physics2D.OverlapPoint(mousePosition, mask) ; //checks if mouse position overlaps collider

            if (targetObject == GetComponent<Collider2D>())
            {

                //Activates outline and marks furniture as selected
                if (!isSelected)
                {
                    outline.SetActive(true);
                    isSelected = true;
                    gridController.showGrid = true;
                }
                else
                {
                    DeselectFurniture();
                }
            }

            //Deselects furniture if placed in a new grid square
            if (isSelected)
            {
                print("Marco");
                if (gridController.currentGridSquare != null && gridController.currentGridSquare.tag == "Grid")
                {
                    transform.position = gridController.currentGridSquare.transform.position;
                    DeselectFurniture();
                }
            }

        }
    }

    private void DeselectFurniture()
    {
        outline.SetActive(false);
        isSelected = false;
        gridController.showGrid = false;
    }
}
