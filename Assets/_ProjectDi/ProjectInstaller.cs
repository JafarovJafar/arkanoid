using Shafir.Arkanoid;
using Shafir.Arkanoid.App;
using Shafir.Arkanoid.SceneManagement;
using UnityEngine;
using VContainer;
using VContainer.Unity;

public class ProjectInstaller : LifetimeScope
{
    [SerializeField] private MonoBehaviourHolder monoBehaviourHolderPrefab;

    protected override void Configure(IContainerBuilder builder)
    {
        builder.RegisterComponentInNewPrefab(monoBehaviourHolderPrefab, Lifetime.Singleton);
        builder.Register<SceneLoader>(Lifetime.Singleton);
        builder.RegisterEntryPoint<AppInitializationEntryPoint>();
    }
}