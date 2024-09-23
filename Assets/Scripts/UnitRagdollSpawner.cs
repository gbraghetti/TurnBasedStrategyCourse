using System;
using UnityEngine;

public class UnitRagdollSpawner : MonoBehaviour {
    [SerializeField] private Transform ragdollPrefab;
    [SerializeField] private Transform originalRootBone;

    private HealthSystem healthSystem;

    private void Awake() {
        healthSystem = GetComponent<HealthSystem>();

        healthSystem.OnDead += healthSystem_OnDead;
    }


    private void Start() {

    }

    private void healthSystem_OnDead(object sender, EventArgs e) {
        Transform ragdollTransform = Instantiate(ragdollPrefab, transform.position, transform.rotation);
        UnitRagdoll unitRagdoll = ragdollTransform.GetComponent<UnitRagdoll>();
        unitRagdoll.Setup(originalRootBone);
    }

    

}
