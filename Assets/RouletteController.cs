using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0;

    private void Start()
    {
    }
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            this.rotSpeed = 10;
        }
        transform.Rotate(0,0,this.rotSpeed);

        this.rotSpeed *= 0.96f;
    }
}
