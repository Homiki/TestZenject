using UnityEngine;
using Zenject;

public class DefaultInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<IFizzBuzz>().To<FizzBuzz>().AsSingle();
        Container.Bind<IGenerable>().To<RNG>().AsSingle();
    }
}