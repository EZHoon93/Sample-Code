using UnityEngine;

public class NoHitSelfDamage : MonoBehaviour
{
    [SerializeField] PlayerRuntimeSet _playerRuntimeSet;
    [SerializeField] int _damage;

    MissileProjectile _projectile;
    private void Awake()
    {
        _projectile =  GetComponent<MissileProjectile>();
    }


    /// <summary>
    /// 아무도 못맞췃을때 대미지를 줌
    /// </summary>
    public void OnDamage(int count)
    {
        if (count != 0)
            return;

        //0 이면 던진플레이어에게 대미지.
        var playerViewID = _projectile.PlayerViewID;
        var playerController = _playerRuntimeSet.GetItem(playerViewID);
        if (playerController == null)
        {
            return;
        }
        if (playerController.TryGetComponent(out Damageable damageable))
        {
            damageable.ReceiveAnAttack(playerViewID, _damage, playerController.transform.position);
        }
    }
}
