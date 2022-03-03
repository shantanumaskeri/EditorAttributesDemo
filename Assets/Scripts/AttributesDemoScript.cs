using System;
using UnityEngine;
using Random = UnityEngine.Random;

[HelpURL("<https://www.youtube.com/channel/UCGjv_3tbzJ8yKuvacoqmO-Q>")]
[RequireComponent(typeof(Rigidbody))]
[SelectionBase]
[AddComponentMenu("My Menu/New Component")]
[ExecuteInEditMode]
public class AttributesDemoScript : MonoBehaviour
{
    [Header("Sphere variable")] public GameObject ball;
    
    [Space(50)]
    [Header("======Capsule variable======")]
    [Space(50)]
    
    public GameObject capsule;
    
    [Tooltip("This variable represent 3 dimension position values of Capsule")] public Vector3 capsulePosition;

    [Range(0f, 25f)] public float capsuleScale;

    public string aboutSphere;
    [TextArea] public string aboutCapsule;

    [Multiline] public string location;

    [Header("This is a private variable that will be made available in the editor")] [SerializeField] private int objectNumber;

    [HideInInspector] public bool isEnd;

    [Header("Right click this variable name!")]
    [SerializeField]
    [ContextMenuItem("Get a random scale", nameof(RandomScale))]
    private float randomScale;

    [ContextMenu("isEnd is true")]
    private void ChangeBool()
    {
        isEnd = true;
    }
    
    private void RandomScale()
    {
        randomScale = Random.Range(0f, 5f);
    }

    private void Start()
    {
        GetComponent<Transform>().localScale = new Vector3(2, 2, 2);
    }
}
