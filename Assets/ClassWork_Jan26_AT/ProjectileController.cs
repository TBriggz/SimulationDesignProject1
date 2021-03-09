using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    public Vector3 P_init = Vector3.zero;
    public Vector3 V_init = Vector3.zero;
    public float t_init = 0;
    public Vector3 g = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        t_init = Time.time;
        g.y = -9.81f;// m/s^2   (a=dv/dt (m/s)/s=m/s^2,  v=dp/dt m/s)
    }

    // Update is called once per frame
    void Update()
    {
        UpdateCloseForm();
    }
    void UpdateCloseForm()
    {
        float t = Time.time;
        //float dt = t - t_init;
        Vector3 pos = Vector3.zero;
        pos = P_init + V_init * (t - t_init) + g / 2 * (t - t_init) * (t - t_init);
        //pos.z = 0;
        this.transform.position = pos;

    }
}
