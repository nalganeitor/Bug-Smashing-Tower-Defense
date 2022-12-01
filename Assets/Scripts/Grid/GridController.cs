using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridController : MonoBehaviour
{
    public GameObject[] gridSquares, nonGridSquares;
    public Collider2D currentGridSquare;
    public bool showGrid;

    private void Awake()
    {
        gridSquares = GameObject.FindGameObjectsWithTag("Grid");
        nonGridSquares = GameObject.FindGameObjectsWithTag("NonGrid");

        for (int i = 0; i < gridSquares.Length; i++)
        {
            gridSquares[i].GetComponent<SpriteRenderer>().enabled = false; //Hides the grid squares
            gridSquares[i].GetComponent<Collider2D>().enabled = false;
        }

        for (int i = 0; i < nonGridSquares.Length; i++)
        {
            nonGridSquares[i].GetComponent<SpriteRenderer>().enabled = false; //Hides the grid squares
            nonGridSquares[i].GetComponent<Collider2D>().enabled = false;
        }
    }


    private void Update()
    {
        if(showGrid)
            MouseGridControl();
    }



    void MouseGridControl()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition); //gets mouse position

        Collider2D gridSquare = Physics2D.OverlapPoint(mousePosition); //Checks if mouse position overlaps with a collider


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
