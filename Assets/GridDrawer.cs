using UnityEngine;

public class GridDrawer : MonoBehaviour
{
    public int gridSize = 100;
    public float cellSize = 1;

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.grey;
        for (int x = 0; x <= gridSize; x++)
        {
            Gizmos.DrawLine(new Vector3(x * cellSize, 0, 0), new Vector3(x * cellSize, gridSize * cellSize, 0));
        }
        for (int y = 0; y <= gridSize; y++)
        {
            Gizmos.DrawLine(new Vector3(0, y * cellSize, 0), new Vector3(gridSize * cellSize, y * cellSize, 0));
        }
    }
}
