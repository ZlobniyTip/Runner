using UnityEngine;

public class Healing : MonoBehaviour
{
    [SerializeField] private int _heal;
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.Translate(Vector3.left * _speed * Time.deltaTime);
    }

    public int Heal()
    {
        return _heal;
    }
}
