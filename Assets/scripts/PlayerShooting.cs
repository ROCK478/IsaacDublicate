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
        if (Input.GetMouseButtonDown(0)) // �������� �� ������� ����� ������ ����
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // ������� ��� �� ������ ����� ������ ����
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        // ���� ��� ���������� ����������� ����� (��� ������ �� groundLayer)
        if (Physics.Raycast(ray, out hit, Mathf.Infinity, groundLayer))
        {
            // ���������� ����������� ��������
            Vector3 targetPosition = hit.point;
            Vector3 direction = (targetPosition - _firePoint.position).normalized;

            // ������� ���� � ����� ��������
            GameObject bullet = Instantiate(_bulletPrephab, _firePoint.position, Quaternion.identity);

            // �������� Rigidbody ���� � ������� �� ��������� ��������
            Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
            bulletRb.velocity = direction * bulletSpeed;
        }
    }
}
