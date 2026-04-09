using UnityEngine;

public class StudentCapacitorComponent : MonoBehaviour
{
    [SerializeField] private CapacitorDataSO capacitorData;

    public CapacitorDataSO CapacitorData => capacitorData;

    private void Awake()
    {
        ApplyData();
    }


    public void ApplyData()
    {
        if (capacitorData == null)
        {
            Debug.LogWarning($"{name} is missing CapacitorDataSO.");
            return;
        }

        transform.localPosition = capacitorData.defaultLocalPosition;
        transform.localRotation = Quaternion.Euler(capacitorData.defaultLocalRotation);
        transform.localScale = capacitorData.defaultLocalScale;
    }

    public string GetComponentName()
    {
        return capacitorData != null ? capacitorData.componentName : "Capacitor";
    }

    public string GetDescription()
    {
        return capacitorData != null ? capacitorData.description : "";
    }

    public float GetCapacitance()
    {
        return capacitorData != null ? capacitorData.capacitance : 0f;
    }

    public string GetCapacitanceUnit()
    {
        return capacitorData != null ? capacitorData.capacitanceUnit : "";
    }

    public float GetRatedVoltage()
    {
        return capacitorData != null ? capacitorData.ratedVoltage : 0f;
    }
}

