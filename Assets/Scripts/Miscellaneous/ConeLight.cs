using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameJam;

namespace GameJam.Light {
    public class ConeLight : BaseLight {
        private void Awake () {
            m_angle = GetComponent<Light>().spotAngle;
            m_range = GetComponent<Light>().range;
            m_dir = transform.forward;
        }
    }
}