using UnityEngine;
using UnityEngine.Profiling;


public class NeedsProfiling : MonoBehaviour {
    void Update() {
       Profiler.BeginSample("LlamAcademy.FSM");
        Debug.Log("This code is being profiled");
       Profiler.EndSample();
    }
}
