using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Shafir.Arkanoid.App
{
    public class LoadContentInstaller : LifetimeScope
    {
        [SerializeField] private LoadContentEntryPoint loadContentEntryPoint;

        protected override void Configure(IContainerBuilder builder) =>
            builder.RegisterComponent(loadContentEntryPoint);
    }
}