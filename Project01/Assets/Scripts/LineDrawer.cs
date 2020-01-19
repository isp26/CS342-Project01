using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineDrawer : MonoBehaviour
{

    LineRenderer line;

    public Transform Cube1;
    public Transform Cube2;

    // Start is called before the first frame update
    void Start()
    {
        line = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        line.SetPosition(0, Cube1.position);
        line.SetPosition(1, Cube2.position);

        if (Physics.Linecast(Cube1.position, Cube2.position, 1 << 9))
        {
            GameManager.gameManager.GameOver();
        }
    }
}
