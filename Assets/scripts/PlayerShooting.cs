using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] private GameObject _bulletPrephab;
    [SerializeField] private Transform _firePoint;
    [SerializeField] private float bulletSpeed = 20f;
    [SerializeField] public LayerMask groundLayer;
    private Camera mainCamera;

    private void Awake()
    {
        mainCamera = Camera.main;
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Проверка на нажатие левой кнопки мыши
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // Создаем луч от камеры через курсор мыши
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        // Если луч пересекает поверхность земли (или объект на groundLayer)
        if (Physics.Raycast(ray, out hit, Mathf.Infinity, groundLayer))
        {
            // Определяем направление стрельбы
            Vector3 targetPosition = hit.point;
            Vector3 direction = (targetPosition - _firePoint.position).normalized;

            // Создаем пулю в точке выстрела
            GameObject bullet = Instantiate(_bulletPrephab, _firePoint.position, Quaternion.identity);

            // Получаем Rigidbody пули и придаем ей начальную скорость
            Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
            bulletRb.velocity = direction * bulletSpeed;
        }
    }
}
