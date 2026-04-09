using UnityEngine;

[CreateAssetMenu(fileName = "NewCapacitorData", menuName = "DahVarsity/Components/Capacitor Data")]
public class CapacitorDataSO : ScriptableObject
{
    [Header("Basic Info")]
    public string componentName = "Capacitor";
    [TextArea] public string description = "Stores electrical energy in an electric field.";

    [Header("Capacitor Specs")]
    public float capacitance = 100f;
    public string capacitanceUnit = "uF";
    public float ratedVoltage = 16f;

    [Header("Placement")]
    public Vector3 defaultLocalPosition = Vector3.zero;
    public Vector3 defaultLocalRotation = Vector3.zero;
    public Vector3 defaultLocalScale = Vector3.one;
}