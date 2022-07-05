using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] private string _label;
    [SerializeField] private int _price;
    [SerializeField] private Sprite _icon;
    [SerializeField] private bool IsBuyed = false;

    [SerializeField] protected Bullet Bullet;

    public abstract void Shoot(Transform shootPoint);

}
