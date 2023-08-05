using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class CharecterAnimation : MonoBehaviour
{
    private const string Grounded = "Grounded";
    private const string Speed = "Speed";

    [SerializeField] private CheckFly _checkFly;
    [SerializeField] private Animator _animator;
    [SerializeField] private Character _character;

    private void Update()
    {
        Vector3 localVelocity = _character.transform.InverseTransformVector(_character.velocity);
        float speed = localVelocity.magnitude / _character.speed;
        float sing = Mathf.Sign(localVelocity.z);

        _animator.SetFloat(Speed, speed * sing);
        _animator.SetBool(Grounded, _checkFly.IsFly == false);
    }
}
