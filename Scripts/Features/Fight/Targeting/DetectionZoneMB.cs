using System.Collections;
using System.Collections.Generic;
using Leopotam.EcsLite;
using Leopotam.EcsLite.Di;
using UnityEngine;

namespace Client
{
    public class DetectionZoneMB : MonoBehaviour
    {
        [SerializeField] private GameObject _mainGameObject;
        [SerializeField] private EcsInfoMB _ecsInfoMB;

        private EcsWorldInject _world;

        private EcsPool<Targetable> _targetablePool;
        private EcsPool<DeadTag> _deadPool;

        private string _enemyTag = "Enemy";
        private string _friendlyTag = "Friendly";
        private string _targetTag;

        public void Start()
        {
            if (_mainGameObject == null) _mainGameObject = transform.parent.gameObject;
            if (_ecsInfoMB == null) _ecsInfoMB = GetComponentInParent<EcsInfoMB>();

            if (_mainGameObject.CompareTag(_enemyTag))
            {
                _targetTag = _friendlyTag;
            }
            else
            {
                _targetTag = _enemyTag;
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.isTrigger)
            {
                return;
            }

            if (!other.gameObject.CompareTag(_targetTag))
            {
                return;
            }

            if (_ecsInfoMB.GetWorld().Value.GetPool<DeadTag>().Has(other.GetComponent<EcsInfoMB>().GetEntity()))
            {
                return;
            }

            _world = _ecsInfoMB.GetWorld();
            _targetablePool = _world.Value.GetPool<Targetable>();
            ref var targetableComponent = ref _targetablePool.Get(_ecsInfoMB.GetEntity());
            targetableComponent.EntitysInDetectionZone.Add(other.GetComponent<EcsInfoMB>().GetEntity());
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.isTrigger)
            {
                return;
            }

            if (!other.gameObject.CompareTag(_targetTag))
            {
                return;
            }

            _world = _ecsInfoMB.GetWorld();
            _targetablePool = _world.Value.GetPool<Targetable>();
            ref var targetableComponent = ref _targetablePool.Get(_ecsInfoMB.GetEntity());
            targetableComponent.EntitysInDetectionZone.Remove(other.GetComponent<EcsInfoMB>().GetEntity());
        }
    }
}
