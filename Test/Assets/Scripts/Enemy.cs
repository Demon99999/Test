using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int _count;
    private void OnTriggerEnter(Collider col)
    {
        if (col.TryGetComponent(out Player player)) // Проверка на взаимодействие с "Player" по компоненту 
        {
            player.ApplySpheres(_count);
            Die();
        }
        
    }

    //Пройедура уничтожения обьекта "Enemy"
    private void Die()
    {
        Destroy(gameObject);
    }
}
