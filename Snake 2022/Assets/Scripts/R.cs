using UnityEngine;

public class R : MonoBehaviour
{
    [Range(0, 10), SerializeField] private float _rotateSpeed;
    public void onClickR()
    {
        transform.rotation *= Quaternion.Euler(0f, 150f * Time.deltaTime, 0f);
    }

    bool Pressed = false;
    public void onDown()
    {
        Pressed = true;
    }

    public void onUp()
    {
        Pressed = false;
    }

    void Update()
    {
        if (Pressed) transform.rotation *= Quaternion.Euler(0f, 150f * Time.deltaTime, 0f);
    }
}
