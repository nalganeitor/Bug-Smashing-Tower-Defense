using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridController : MonoBehaviour
{
    public GameObject gridHolder;
    public Collider2D currentGridSquare;
    public bool showGrid;

    LayerMask mask;

    private void Awake()
    {
        gridHolder.SetActive(true);
        mask = LayerMask.GetMask("Grid");
    }


    private void Update()
    {
        if (showGrid)
        {
            if(!gridHolder.activeInHierarchy)
                gridHolder.SetActive(true);
            
            MouseGridControl();
        }
        else
            if (gridHolder.activeInHierarchy)
        {
            currentGridSquare = null;
            gridHolder.SetActive(false);
        }
    }



    void MouseGridControl()
    {

        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition); //gets mouse position

        Collider2D gridSquare = Physics2D.OverlapPoint(mousePosition, mask); //Checks if mouse position overlaps with a collider


        if (gridSquare != null && gridSquare.tag == "Grid" || gridSquare != null && gridSquare.tag == "NonGrid") //Checks if there is a grid square detected
        {
            if (currentGridSquare != null && currentGridSquare != gridSquare)
            {
                currentGridSquare.GetComponent<SpriteRenderer>().enabled = false; //Disables sprite renderer of a formerly selected grid square
                currentGridSquare = gridSquare; //Selects the current grid square
            }

            gridSquare.GetComponent<SpriteRenderer>().enabled = true; //Enables sprite renderer of the selected grid square

            currentGridSquare = gridSquare;
        }
        else if(currentGridSquare != null)
        {
            currentGridSquare.GetComponent<SpriteRenderer>().enabled = false;
        }
    }
}
