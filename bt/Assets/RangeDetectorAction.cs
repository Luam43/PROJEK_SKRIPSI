using LlamAcademy.Sensors;
using System;
using Unity.Behavior;
using UnityEngine;
using Action = Unity.Behavior.Action;
using Unity.Properties;

[Serializable, GeneratePropertyBag]
[NodeDescription(name: "Range Detector", story: "Update Range [Detector] and assign [Target]", category: "Action", id: "f803a7b9983d5305283962af0f386e66")]
public partial class RangeDetectorAction : Action
{
    [SerializeReference] public BlackboardVariable<PlayerSensor> Detector;
    [SerializeReference] public BlackboardVariable<GameObject> Target;

    protected override Status OnStart()
    {
        return Status.Running;
    }

    protected override Status OnUpdate()
    {
        return Status.Success;
    }

    protected override void OnEnd()
    {
    }
}

