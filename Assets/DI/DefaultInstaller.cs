using UnityEngine;
using Zenject;

public class DefaultInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<IGenerable>().To<FizzBuzz>().AsSingle();
        //Container.Bind<IGenerable>().To<RNG>().AsSingle();
    }
}